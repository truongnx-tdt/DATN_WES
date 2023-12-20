﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudySystem.Infrastructure.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Message {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Message() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("StudySystem.Infrastructure.Resources.Message", typeof(Message).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bad Request.
        /// </summary>
        public static string _400 {
            get {
                return ResourceManager.GetString("400", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access denied. You don&apos;t have the necessary permissions..
        /// </summary>
        public static string _403 {
            get {
                return ResourceManager.GetString("403", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not Found.
        /// </summary>
        public static string _404 {
            get {
                return ResourceManager.GetString("404", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method Not Allowed.
        /// </summary>
        public static string _405 {
            get {
                return ResourceManager.GetString("405", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Internal Server Error.
        /// </summary>
        public static string _500 {
            get {
                return ResourceManager.GetString("500", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurs while save.
        /// </summary>
        public static string ErrorCreateProduct {
            get {
                return ResourceManager.GetString("ErrorCreateProduct", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UserID or Password is incorrect.
        /// </summary>
        public static string InValidAccount {
            get {
                return ResourceManager.GetString("InValidAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have been logging out of the system.
        /// </summary>
        public static string Logout {
            get {
                return ResourceManager.GetString("Logout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unauthorized.
        /// </summary>
        public static string Unauthorize {
            get {
                return ResourceManager.GetString("Unauthorize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurs while save.
        /// </summary>
        public static string UpdateError {
            get {
                return ResourceManager.GetString("UpdateError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User was sign in.
        /// </summary>
        public static string UserLogined {
            get {
                return ResourceManager.GetString("UserLogined", resourceCulture);
            }
        }
    }
}