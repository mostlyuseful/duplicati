﻿// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Duplicati.Library.Compression.Strings {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SevenZipCompression {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SevenZipCompression() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("Duplicati.Library.Compression.Strings.SevenZipCompression", typeof(SevenZipCompression).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string FileNotFoundError {
            get {
                return ResourceManager.GetString("FileNotFoundError", resourceCulture);
            }
        }
        
        internal static string Description {
            get {
                return ResourceManager.GetString("Description", resourceCulture);
            }
        }
        
        internal static string NoReaderError {
            get {
                return ResourceManager.GetString("NoReaderError", resourceCulture);
            }
        }
        
        internal static string ThreadcountLong {
            get {
                return ResourceManager.GetString("ThreadcountLong", resourceCulture);
            }
        }
        
        internal static string DisplayName {
            get {
                return ResourceManager.GetString("DisplayName", resourceCulture);
            }
        }
        
        internal static string ThreadcountShort {
            get {
                return ResourceManager.GetString("ThreadcountShort", resourceCulture);
            }
        }
        
        internal static string NoWriterError {
            get {
                return ResourceManager.GetString("NoWriterError", resourceCulture);
            }
        }

        internal static string CompressionLevelShort {
            get {
                return ResourceManager.GetString("CompressionLevelShort", resourceCulture);
            }
        }

        internal static string CompressionLevelLong {
            get {
                return ResourceManager.GetString("CompressionLevelLong", resourceCulture);
            }
        }
    }
}
