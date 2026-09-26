using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbWebhook
{
    [JsiiInterface(nativeType: typeof(IZeroTrustCasbWebhookHeaders), fullyQualifiedName: "cloudflare.zeroTrustCasbWebhook.ZeroTrustCasbWebhookHeaders")]
    public interface IZeroTrustCasbWebhookHeaders
    {
        /// <summary>Header key name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_casb_webhook#key ZeroTrustCasbWebhook#key}
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Header value. Required on Create and Evaluate. On Update, omit or set to null to keep existing value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_casb_webhook#value ZeroTrustCasbWebhook#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustCasbWebhookHeaders), fullyQualifiedName: "cloudflare.zeroTrustCasbWebhook.ZeroTrustCasbWebhookHeaders")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustCasbWebhook.IZeroTrustCasbWebhookHeaders
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Header key name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_casb_webhook#key ZeroTrustCasbWebhook#key}
            /// </remarks>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Header value. Required on Create and Evaluate. On Update, omit or set to null to keep existing value.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_casb_webhook#value ZeroTrustCasbWebhook#value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
