using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustCasbPolicy.ZeroTrustCasbPolicyActionsWebhookConfigs")]
    public class ZeroTrustCasbPolicyActionsWebhookConfigs : cloudflare.ZeroTrustCasbPolicy.IZeroTrustCasbPolicyActionsWebhookConfigs
    {
        /// <summary>The ID of the webhook configuration to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_casb_policy#webhook_config_id ZeroTrustCasbPolicy#webhook_config_id}
        /// </remarks>
        [JsiiProperty(name: "webhookConfigId", typeJson: "{\"primitive\":\"string\"}")]
        public string WebhookConfigId
        {
            get;
            set;
        }
    }
}
