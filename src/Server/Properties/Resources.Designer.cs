﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hermes.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Hermes.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The client {0} is not connected and cannot receive messages.
        /// </summary>
        internal static string ConnectionProvider_ClientIdNotFound {
            get {
                return ResourceManager.GetString("ConnectionProvider_ClientIdNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The first packet sent by a Client must be a Connect. The connection will be closed..
        /// </summary>
        internal static string ServerPacketChannelAdapter_FirstPacketMustBeConnect {
            get {
                return ResourceManager.GetString("ServerPacketChannelAdapter_FirstPacketMustBeConnect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The keep alive time of {0} seconds has been exceeded and no packet has been received. The connection will be closed..
        /// </summary>
        internal static string ServerPacketChannelAdapter_KeepAliveTimeExceeded {
            get {
                return ResourceManager.GetString("ServerPacketChannelAdapter_KeepAliveTimeExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No connect packet has been received since the network connection was established. The connection will be closed..
        /// </summary>
        internal static string ServerPacketChannelAdapter_NoConnectReceived {
            get {
                return ResourceManager.GetString("ServerPacketChannelAdapter_NoConnectReceived", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only one Connect packet is allowed. The connection will be closed..
        /// </summary>
        internal static string ServerPacketChannelAdapter_SecondConnectNotAllowed {
            get {
                return ResourceManager.GetString("ServerPacketChannelAdapter_SecondConnectNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client must be connected.
        /// </summary>
        internal static string TcpChannel_ClientMustBeConnected {
            get {
                return ResourceManager.GetString("TcpChannel_ClientMustBeConnected", resourceCulture);
            }
        }
    }
}
