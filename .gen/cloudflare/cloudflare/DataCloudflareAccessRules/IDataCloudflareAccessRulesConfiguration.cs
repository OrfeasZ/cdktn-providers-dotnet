using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAccessRules
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareAccessRulesConfiguration), fullyQualifiedName: "cloudflare.dataCloudflareAccessRules.DataCloudflareAccessRulesConfiguration")]
    public interface IDataCloudflareAccessRulesConfiguration
    {
        /// <summary>Defines the target to search in existing rules. Available values: "ip", "ip_range", "asn", "country".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/access_rules#target DataCloudflareAccessRules#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Target
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines the target value to search for in existing rules: an IP address, an IP address range, or a country code, depending on the provided `configuration.target`. Notes: You can search for a single IPv4 address, an IP address range with a subnet of '/16' or '/24', or a two-letter ISO-3166-1 alpha-2 country code.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/access_rules#value DataCloudflareAccessRules#value}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareAccessRulesConfiguration), fullyQualifiedName: "cloudflare.dataCloudflareAccessRules.DataCloudflareAccessRulesConfiguration")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareAccessRules.IDataCloudflareAccessRulesConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines the target to search in existing rules. Available values: "ip", "ip_range", "asn", "country".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/access_rules#target DataCloudflareAccessRules#target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Target
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Defines the target value to search for in existing rules: an IP address, an IP address range, or a country code, depending on the provided `configuration.target`. Notes: You can search for a single IPv4 address, an IP address range with a subnet of '/16' or '/24', or a two-letter ISO-3166-1 alpha-2 country code.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/access_rules#value DataCloudflareAccessRules#value}
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
