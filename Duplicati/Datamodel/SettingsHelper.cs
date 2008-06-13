using System;
using System.Collections.Generic;
using System.Text;
using System.Data.LightDatamodel;
using System.Reflection;

namespace Duplicati.Datamodel
{
    public class SettingsHelper<TBase, TKey, TValue> 
        : IDictionary<TKey, TValue>
        where TBase : IDataClass
    {
        private Dictionary<TKey, TBase> m_settings;
        private IList<TBase> m_col;
        private IDataFetcher m_parent;

        private PropertyInfo m_keyfield;
        private PropertyInfo m_valuefield;
        private TranslatoryEnumerator m_enum;

        public SettingsHelper(IDataFetcher parent, IList<TBase> col, string keyfield, string valuefield)
            : this(parent, col, typeof(TBase).GetProperty(keyfield), typeof(TBase).GetProperty(valuefield))

        {
        }

        public SettingsHelper(IDataFetcher parent, IList<TBase> col, PropertyInfo keyfield, PropertyInfo valuefield)
        {
            m_parent = parent;
            m_col = col;
            m_keyfield = keyfield;
            m_valuefield = valuefield;

            if (m_parent == null)
                throw new ArgumentNullException("parent");
            if (m_col == null)
                throw new ArgumentNullException("col");
            if (m_keyfield == null)
                throw new ArgumentNullException("keyfield");
            if (m_valuefield == null)
                throw new ArgumentNullException("valuefield");

            m_settings = new Dictionary<TKey, TBase>();
            m_enum = new TranslatoryEnumerator(this, m_settings.GetEnumerator());

            foreach (TBase item in m_col)
                m_settings.Add((TKey)m_keyfield.GetValue(item, null), item);
        }

        public PropertyInfo KeyField { get { return m_keyfield; } }
        public PropertyInfo ValueField { get { return m_valuefield; } }

        #region IDictionary<TKey, TValue> Members

        public void Add(TKey key, TValue value)
        {
            TBase item = Activator.CreateInstance<TBase>();
            m_keyfield.SetValue(item, key, null);
            m_valuefield.SetValue(item, value, null);

            m_settings.Add(key, item);
            m_parent.Add(item);
            m_col.Add(item);
        }

        public bool ContainsKey(TKey key)
        {
            return m_settings.ContainsKey(key);
        }

        public ICollection<TKey> Keys
        {
            get { return m_settings.Keys; }
        }

        public bool Remove(TKey key)
        {
            if (m_settings.ContainsKey(key))
            {
                m_col.Remove(m_settings[key]);
                m_parent.DeleteObject<TBase>(m_settings[key]);
            }

            return m_settings.Remove(key);
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            TBase item;
            if (m_settings.TryGetValue(key, out item))
            {
                value = (TValue)m_valuefield.GetValue(item, null);
                return true;
            }
            else
            {
                value = default(TValue);
                return false;
            }

        }

        public ICollection<TValue> Values
        {
            get
            {
                List<TValue> lst = new List<TValue>();
                foreach (TBase item in m_settings.Values)
                    lst.Add((TValue)m_valuefield.GetValue(item, null));
                return lst;
            }
        }

        public TValue this[TKey key]
        {
            get
            {
                if (m_settings.ContainsKey(key))
                    return (TValue)m_valuefield.GetValue(m_settings[key], null);
                else
                    return default(TValue);
            }
            set
            {
                if (value == null && m_settings.ContainsKey(key))
                {
                    //Remove
                    this.Remove(key);
                }
                else if (value != null && !m_settings.ContainsKey(key))
                {
                    //Add
                    this.Add(key, value);
                }
                else if (value != null && m_settings.ContainsKey(key))
                {
                    //Update
                    m_valuefield.SetValue(m_settings[key], value, null);
                }
                //else: It should be removed, but does not exist

            }
        }

        #endregion

        #region ICollection<KeyValuePair<TKey,TValue>> Members

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void Clear()
        {
            while (m_col.Count > 0)
            {
                TBase item = m_col[0];
                m_col.Remove(item);
                m_parent.DeleteObject<TBase>(item);
            }

            m_settings.Clear();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            ((ICollection<KeyValuePair<TKey, TValue>>)(m_settings)).CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return m_settings.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #region IEnumerable<KeyValuePair<string,string>> Members

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return m_enum;
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((System.Collections.IEnumerable)m_settings).GetEnumerator();
        }

        #endregion


        private class TranslatoryEnumerator : IEnumerator<KeyValuePair<TKey, TValue>>
        {
            private SettingsHelper<TBase, TKey, TValue> m_parent;
            private IEnumerator<KeyValuePair<TKey, TBase>> m_base;

            public TranslatoryEnumerator(SettingsHelper<TBase, TKey, TValue> parent, IEnumerator<KeyValuePair<TKey, TBase>> en)
            {
                m_parent = parent;
                m_base = en;
            }

            #region IEnumerator<KeyValuePair<TKey,TValue>> Members

            public KeyValuePair<TKey, TValue> Current
            {
                get 
                {
                    return new KeyValuePair<TKey, TValue>(m_base.Current.Key, (TValue)m_parent.KeyField.GetValue(m_base.Current.Value, null));
                }
            }

            #endregion

            #region IDisposable Members

            public void Dispose()
            {
                m_parent = null;
                m_base = null;
            }

            #endregion

            #region IEnumerator Members

            object System.Collections.IEnumerator.Current
            {
                get { return new System.Collections.DictionaryEntry(m_base.Current.Key, (TValue)m_parent.KeyField.GetValue(m_base.Current.Value, null)); }
            }

            public bool MoveNext()
            {
                return m_base.MoveNext();
            }

            public void Reset()
            {
                m_base.Reset();
            }

            #endregion
        }
    }
}