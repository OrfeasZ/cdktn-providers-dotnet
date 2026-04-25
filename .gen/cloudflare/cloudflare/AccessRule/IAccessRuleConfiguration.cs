using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AccessRule
{
    [JsiiInterface(nativeType: typeof(IAccessRuleConfiguration), fullyQualifiedName: "cloudflare.accessRule.AccessRuleConfiguration")]
    public interface IAccessRuleConfiguration
    {
        /// <summary>The configuration target.</summary>
        /// <remarks>
        /// You must set the target to <c>ip</c> when specifying an IP address in the rule.
        /// Available values: "ip", "ip6", "ip_range", "asn", "country".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/access_rule#target AccessRule#target}
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

        /// <summary>The IP address to match. This address will be compared to the IP address of incoming requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/access_rule#value AccessRule#value}
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

        [JsiiTypeProxy(nativeType: typeof(IAccessRuleConfiguration), fullyQualifiedName: "cloudflare.accessRule.AccessRuleConfiguration")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AccessRule.IAccessRuleConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The configuration target.</summary>
            /// <remarks>
            /// You must set the target to <c>ip</c> when specifying an IP address in the rule.
            /// Available values: "ip", "ip6", "ip_range", "asn", "country".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/access_rule#target AccessRule#target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Target
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The IP address to match. This address will be compared to the IP address of incoming requests.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/access_rule#value AccessRule#value}
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
