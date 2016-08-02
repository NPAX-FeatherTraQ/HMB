﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.237
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Duplicati.Library.Modules.Builtin.Strings {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class HttpOptions {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal HttpOptions() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Duplicati.Library.Modules.Builtin.Strings.HttpOptions", typeof(HttpOptions).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This module exposes a number of properties that can be used to change the way http requests are issued.
        /// </summary>
        internal static string Description {
            get {
                return ResourceManager.GetString("Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use this option to accept any server certificate, regardless of what errors it may have. Please use --accept-specified-ssl-hash instead, whenever possible..
        /// </summary>
        internal static string DescriptionAcceptAnyCertificateLong {
            get {
                return ResourceManager.GetString("DescriptionAcceptAnyCertificateLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Accept any server certificate.
        /// </summary>
        internal static string DescriptionAcceptAnyCertificateShort {
            get {
                return ResourceManager.GetString("DescriptionAcceptAnyCertificateShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If your server certificate is reported as invalid (eg. with self-signed certificates), you can supply the certificate hash to approve it anyway. The hash value must be entered in hex format without spaces..
        /// </summary>
        internal static string DescriptionAcceptHashLong {
            get {
                return ResourceManager.GetString("DescriptionAcceptHashLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optionally accept a known SSL certificate.
        /// </summary>
        internal static string DescriptionAcceptHashShort {
            get {
                return ResourceManager.GetString("DescriptionAcceptHashShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The default HTTP request has the header &quot;Expect: 100-Continue&quot; attached, which allows some optimizations when authenticating, but also breaks some web servers, causing them to report &quot;417 - Expectation failed&quot;.
        /// </summary>
        internal static string DisableExpect100Long {
            get {
                return ResourceManager.GetString("DisableExpect100Long", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disable the expect header.
        /// </summary>
        internal static string DisableExpect100Short {
            get {
                return ResourceManager.GetString("DisableExpect100Short", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to By default the http requests use the RFC 896 nagling algorithm to support transfer of small packages more effeciently..
        /// </summary>
        internal static string DisableNagleLong {
            get {
                return ResourceManager.GetString("DisableNagleLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disable nagling.
        /// </summary>
        internal static string DisableNagleShort {
            get {
                return ResourceManager.GetString("DisableNagleShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configure http requests.
        /// </summary>
        internal static string DisplayName {
            get {
                return ResourceManager.GetString("DisplayName", resourceCulture);
            }
        }
    }
}
