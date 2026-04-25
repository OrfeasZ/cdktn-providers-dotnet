using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiInterface(nativeType: typeof(IZeroTrustAccessApplicationPoliciesConnectionRulesRdp), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesConnectionRulesRdp")]
    public interface IZeroTrustAccessApplicationPoliciesConnectionRulesRdp
    {
        /// <summary>Clipboard formats allowed when copying from local machine to remote RDP session.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#allowed_clipboard_local_to_remote_formats ZeroTrustAccessApplication#allowed_clipboard_local_to_remote_formats}
        /// </remarks>
        [JsiiProperty(name: "allowedClipboardLocalToRemoteFormats", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedClipboardLocalToRemoteFormats
        {
            get
            {
                return null;
            }
        }

        /// <summary>Clipboard formats allowed when copying from remote RDP session to local machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#allowed_clipboard_remote_to_local_formats ZeroTrustAccessApplication#allowed_clipboard_remote_to_local_formats}
        /// </remarks>
        [JsiiProperty(name: "allowedClipboardRemoteToLocalFormats", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedClipboardRemoteToLocalFormats
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustAccessApplicationPoliciesConnectionRulesRdp), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesConnectionRulesRdp")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesConnectionRulesRdp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Clipboard formats allowed when copying from local machine to remote RDP session.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#allowed_clipboard_local_to_remote_formats ZeroTrustAccessApplication#allowed_clipboard_local_to_remote_formats}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedClipboardLocalToRemoteFormats", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedClipboardLocalToRemoteFormats
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Clipboard formats allowed when copying from remote RDP session to local machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#allowed_clipboard_remote_to_local_formats ZeroTrustAccessApplication#allowed_clipboard_remote_to_local_formats}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedClipboardRemoteToLocalFormats", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedClipboardRemoteToLocalFormats
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
