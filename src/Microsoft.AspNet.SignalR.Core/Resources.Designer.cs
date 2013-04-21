﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AspNet.SignalR {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.AspNet.SignalR.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to             /// &lt;summary&gt;Calls the {0} method on the server-side {1} hub.&amp;#10;Returns a jQuery.Deferred() promise.&lt;/summary&gt;.
        /// </summary>
        internal static string DynamicComment_CallsMethodOnServerSideDeferredPromise {
            get {
                return ResourceManager.GetString("DynamicComment_CallsMethodOnServerSideDeferredPromise", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to             /// &lt;param name=\&quot;{0}\&quot; type=\&quot;{1}\&quot;&gt;Server side type is {2}&lt;/param&gt;.
        /// </summary>
        internal static string DynamicComment_ServerSideTypeIs {
            get {
                return ResourceManager.GetString("DynamicComment_ServerSideTypeIs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument cannot be null or empty.
        /// </summary>
        internal static string Error_ArgumentNullOrEmpty {
            get {
                return ResourceManager.GetString("Error_ArgumentNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The buffer size &apos;{0}&apos; is out of range..
        /// </summary>
        internal static string Error_BufferSizeOutOfRange {
            get {
                return ResourceManager.GetString("Error_BufferSizeOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Caller is not authorized to invoke the {0} method on {1}..
        /// </summary>
        internal static string Error_CallerNotAuthorizedToInvokeMethodOn {
            get {
                return ResourceManager.GetString("Error_CallerNotAuthorizedToInvokeMethodOn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The connection id is in the incorrect format..
        /// </summary>
        internal static string Error_ConnectionIdIncorrectFormat {
            get {
                return ResourceManager.GetString("Error_ConnectionIdIncorrectFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The PersistentConnection is not initialized..
        /// </summary>
        internal static string Error_ConnectionNotInitialized {
            get {
                return ResourceManager.GetString("Error_ConnectionNotInitialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DisconnectTimeout cannot be configured after the KeepAlive..
        /// </summary>
        internal static string Error_DisconnectTimeoutCannotBeConfiguredAfterKeepAlive {
            get {
                return ResourceManager.GetString("Error_DisconnectTimeoutCannotBeConfiguredAfterKeepAlive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DisconnectTimeout must be at least six seconds..
        /// </summary>
        internal static string Error_DisconnectTimeoutMustBeAtLeastSixSeconds {
            get {
                return ResourceManager.GetString("Error_DisconnectTimeoutMustBeAtLeastSixSeconds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not read RequireOutgoing. Use protected _requireOutgoing instead..
        /// </summary>
        internal static string Error_DoNotReadRequireOutgoing {
            get {
                return ResourceManager.GetString("Error_DoNotReadRequireOutgoing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicate hub names found..
        /// </summary>
        internal static string Error_DuplicateHubs {
            get {
                return ResourceManager.GetString("Error_DuplicateHubs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicate payload id detected for stream &apos;{0}&apos;..
        /// </summary>
        internal static string Error_DuplicatePayloadsForStream {
            get {
                return ResourceManager.GetString("Error_DuplicatePayloadsForStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error creating Hub {0}. .
        /// </summary>
        internal static string Error_ErrorCreatingHub {
            get {
                return ResourceManager.GetString("Error_ErrorCreatingHub", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; Hub could not be resolved..
        /// </summary>
        internal static string Error_HubCouldNotBeResolved {
            get {
                return ResourceManager.GetString("Error_HubCouldNotBeResolved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an error invoking Hub method &apos;{0}.{1}&apos;..
        /// </summary>
        internal static string Error_HubInvocationFailed {
            get {
                return ResourceManager.GetString("Error_HubInvocationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid cursor..
        /// </summary>
        internal static string Error_InvalidCursorFormat {
            get {
                return ResourceManager.GetString("Error_InvalidCursorFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The supplied frameId is in the incorrect format..
        /// </summary>
        internal static string Error_InvalidForeverFrameId {
            get {
                return ResourceManager.GetString("Error_InvalidForeverFrameId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a {1}..
        /// </summary>
        internal static string Error_IsNotA {
            get {
                return ResourceManager.GetString("Error_IsNotA", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SignalR: JavaScript Hub proxy generation has been disabled..
        /// </summary>
        internal static string Error_JavaScriptProxyDisabled {
            get {
                return ResourceManager.GetString("Error_JavaScriptProxyDisabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Keep Alive value must be greater than two seconds..
        /// </summary>
        internal static string Error_KeepAliveMustBeGreaterThanTwoSeconds {
            get {
                return ResourceManager.GetString("Error_KeepAliveMustBeGreaterThanTwoSeconds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Keep Alive value must be no more than a third of the DisconnectTimeout..
        /// </summary>
        internal static string Error_KeepAliveMustBeNoMoreThanAThirdOfTheDisconnectTimeout {
            get {
                return ResourceManager.GetString("Error_KeepAliveMustBeNoMoreThanAThirdOfTheDisconnectTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; method could not be resolved..
        /// </summary>
        internal static string Error_MethodCouldNotBeResolved {
            get {
                return ResourceManager.GetString("Error_MethodCouldNotBeResolved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Outgoing authorization can only be required for an entire Hub, not a specific method..
        /// </summary>
        internal static string Error_MethodLevelOutgoingAuthorization {
            get {
                return ResourceManager.GetString("Error_MethodLevelOutgoingAuthorization", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple activators for type {0} are registered. Please call GetServices instead..
        /// </summary>
        internal static string Error_MultipleActivatorsAreaRegisteredCallGetServices {
            get {
                return ResourceManager.GetString("Error_MultipleActivatorsAreaRegisteredCallGetServices", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A configuration object must be specified..
        /// </summary>
        internal static string Error_NoConfiguration {
            get {
                return ResourceManager.GetString("Error_NoConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A dependency resolver must be specified..
        /// </summary>
        internal static string Error_NoDepenendeyResolver {
            get {
                return ResourceManager.GetString("Error_NoDepenendeyResolver", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not a valid web socket request..
        /// </summary>
        internal static string Error_NotWebSocketRequest {
            get {
                return ResourceManager.GetString("Error_NotWebSocketRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected end when reading object..
        /// </summary>
        internal static string Error_ParseObjectFailed {
            get {
                return ResourceManager.GetString("Error_ParseObjectFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Protocol error: Missing connection token..
        /// </summary>
        internal static string Error_ProtocolErrorMissingConnectionToken {
            get {
                return ResourceManager.GetString("Error_ProtocolErrorMissingConnectionToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Protocol error: Unknown transport..
        /// </summary>
        internal static string Error_ProtocolErrorUnknownTransport {
            get {
                return ResourceManager.GetString("Error_ProtocolErrorUnknownTransport", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The queue has been closed..
        /// </summary>
        internal static string Error_QueueClosed {
            get {
                return ResourceManager.GetString("Error_QueueClosed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The queue is not open..
        /// </summary>
        internal static string Error_QueueNotOpen {
            get {
                return ResourceManager.GetString("Error_QueueNotOpen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to State has exceeded the maximum length of 4096 bytes..
        /// </summary>
        internal static string Error_StateExceededMaximumLength {
            get {
                return ResourceManager.GetString("Error_StateExceededMaximumLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The queue is full..
        /// </summary>
        internal static string Error_TaskQueueFull {
            get {
                return ResourceManager.GetString("Error_TaskQueueFull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to add module. The HubPipeline has already been invoked..
        /// </summary>
        internal static string Error_UnableToAddModulePiplineAlreadyInvoked {
            get {
                return ResourceManager.GetString("Error_UnableToAddModulePiplineAlreadyInvoked", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unrecognized user identity.  The user identity cannot change during an active SignalR connection..
        /// </summary>
        internal static string Error_UnrecognizedUserIdentity {
            get {
                return ResourceManager.GetString("Error_UnrecognizedUserIdentity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using a Hub instance not created by the HubPipeline is unsupported..
        /// </summary>
        internal static string Error_UsingHubInstanceNotCreatedUnsupported {
            get {
                return ResourceManager.GetString("Error_UsingHubInstanceNotCreatedUnsupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WebSockets is not supported..
        /// </summary>
        internal static string Error_WebSocketsNotSupported {
            get {
                return ResourceManager.GetString("Error_WebSocketsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Forbidden: SignalR cross domain is disabled..
        /// </summary>
        internal static string Forbidden_CrossDomainIsDisabled {
            get {
                return ResourceManager.GetString("Forbidden_CrossDomainIsDisabled", resourceCulture);
            }
        }
    }
}
