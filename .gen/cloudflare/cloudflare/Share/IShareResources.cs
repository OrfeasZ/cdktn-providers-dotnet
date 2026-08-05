using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Share
{
    [JsiiInterface(nativeType: typeof(IShareResources), fullyQualifiedName: "cloudflare.share.ShareResources")]
    public interface IShareResources
    {
        /// <summary>Resource Metadata.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/share#meta Share#meta}
        /// </remarks>
        [JsiiProperty(name: "meta", typeJson: "{\"primitive\":\"string\"}")]
        string Meta
        {
            get;
        }

        /// <summary>Account identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/share#resource_account_id Share#resource_account_id}
        /// </remarks>
        [JsiiProperty(name: "resourceAccountId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceAccountId
        {
            get;
        }

        /// <summary>Share Resource identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/share#resource_id Share#resource_id}
        /// </remarks>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceId
        {
            get;
        }

        /// <summary>Resource Type. Available values: "custom-ruleset", "gateway-policy", "gateway-destination-ip", "gateway-block-page-settings", "gateway-extended-email-matching", "idp-federation-grant".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/share#resource_type Share#resource_type}
        /// </remarks>
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IShareResources), fullyQualifiedName: "cloudflare.share.ShareResources")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Share.IShareResources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Resource Metadata.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/share#meta Share#meta}
            /// </remarks>
            [JsiiProperty(name: "meta", typeJson: "{\"primitive\":\"string\"}")]
            public string Meta
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Account identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/share#resource_account_id Share#resource_account_id}
            /// </remarks>
            [JsiiProperty(name: "resourceAccountId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceAccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Share Resource identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/share#resource_id Share#resource_id}
            /// </remarks>
            [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Resource Type. Available values: "custom-ruleset", "gateway-policy", "gateway-destination-ip", "gateway-block-page-settings", "gateway-extended-email-matching", "idp-federation-grant".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/share#resource_type Share#resource_type}
            /// </remarks>
            [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
