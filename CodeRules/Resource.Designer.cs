﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ODataValidator.Rule {
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
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ODataValidator.Rule.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to Expecting a 4xx error, but got other status code..
        /// </summary>
        internal static string ExpectingError4xx {
            get {
                return ResourceManager.GetString("ExpectingError4xx", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expecting an empty feed, but got some entries..
        /// </summary>
        internal static string NotEmptyFeed {
            get {
                return ResourceManager.GetString("NotEmptyFeed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to payload type is not supported..
        /// </summary>
        internal static string NotSupportedPayloadType {
            get {
                return ResourceManager.GetString("NotSupportedPayloadType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Payload is partial collection, but next link is not found..
        /// </summary>
        internal static string PayloadExpectingNextLink {
            get {
                return ResourceManager.GetString("PayloadExpectingNextLink", resourceCulture);
            }
        }
    }
}