using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Share
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.share.ShareResources")]
    public class ShareResources : cloudflare.Share.IShareResources
    {
        /// <summary>Resource Metadata.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/share#meta Share#meta}
        /// </remarks>
        [JsiiProperty(name: "meta", typeJson: "{\"primitive\":\"string\"}")]
        public string Meta
        {
            get;
            set;
        }

        /// <summary>Account identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/share#resource_account_id Share#resource_account_id}
        /// </remarks>
        [JsiiProperty(name: "resourceAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceAccountId
        {
            get;
            set;
        }

        /// <summary>Share Resource identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/share#resource_id Share#resource_id}
        /// </remarks>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceId
        {
            get;
            set;
        }

        /// <summary>Resource Type. Available values: "custom-ruleset", "gateway-policy", "gateway-destination-ip", "gateway-block-page-settings", "gateway-extended-email-matching", "idp-federation-grant".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/share#resource_type Share#resource_type}
        /// </remarks>
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceType
        {
            get;
            set;
        }
    }
}
