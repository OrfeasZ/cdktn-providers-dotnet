using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareEmailRoutingRule
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareEmailRoutingRuleFilter), fullyQualifiedName: "cloudflare.dataCloudflareEmailRoutingRule.DataCloudflareEmailRoutingRuleFilter")]
    public interface IDataCloudflareEmailRoutingRuleFilter
    {
        /// <summary>Filter by enabled routing rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/email_routing_rule#enabled DataCloudflareEmailRoutingRule#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareEmailRoutingRuleFilter), fullyQualifiedName: "cloudflare.dataCloudflareEmailRoutingRule.DataCloudflareEmailRoutingRuleFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareEmailRoutingRule.IDataCloudflareEmailRoutingRuleFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Filter by enabled routing rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/email_routing_rule#enabled DataCloudflareEmailRoutingRule#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
