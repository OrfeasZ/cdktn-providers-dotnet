using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbPolicy
{
    [JsiiInterface(nativeType: typeof(IZeroTrustCasbPolicyActionsWebhookConfigs), fullyQualifiedName: "cloudflare.zeroTrustCasbPolicy.ZeroTrustCasbPolicyActionsWebhookConfigs")]
    public interface IZeroTrustCasbPolicyActionsWebhookConfigs
    {
        /// <summary>The ID of the webhook configuration to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_casb_policy#webhook_config_id ZeroTrustCasbPolicy#webhook_config_id}
        /// </remarks>
        [JsiiProperty(name: "webhookConfigId", typeJson: "{\"primitive\":\"string\"}")]
        string WebhookConfigId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustCasbPolicyActionsWebhookConfigs), fullyQualifiedName: "cloudflare.zeroTrustCasbPolicy.ZeroTrustCasbPolicyActionsWebhookConfigs")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustCasbPolicy.IZeroTrustCasbPolicyActionsWebhookConfigs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the webhook configuration to use.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_casb_policy#webhook_config_id ZeroTrustCasbPolicy#webhook_config_id}
            /// </remarks>
            [JsiiProperty(name: "webhookConfigId", typeJson: "{\"primitive\":\"string\"}")]
            public string WebhookConfigId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
