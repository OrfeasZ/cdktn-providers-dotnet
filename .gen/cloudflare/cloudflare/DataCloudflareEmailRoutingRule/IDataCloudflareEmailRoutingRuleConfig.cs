using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareEmailRoutingRule
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareEmailRoutingRuleConfig), fullyQualifiedName: "cloudflare.dataCloudflareEmailRoutingRule.DataCloudflareEmailRoutingRuleConfig")]
    public interface IDataCloudflareEmailRoutingRuleConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_routing_rule#zone_id DataCloudflareEmailRoutingRule#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        string ZoneId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_routing_rule#filter DataCloudflareEmailRoutingRule#filter}.</summary>
        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareEmailRoutingRule.DataCloudflareEmailRoutingRuleFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.DataCloudflareEmailRoutingRule.IDataCloudflareEmailRoutingRuleFilter? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Routing rule identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_routing_rule#rule_identifier DataCloudflareEmailRoutingRule#rule_identifier}
        /// </remarks>
        [JsiiProperty(name: "ruleIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RuleIdentifier
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareEmailRoutingRuleConfig), fullyQualifiedName: "cloudflare.dataCloudflareEmailRoutingRule.DataCloudflareEmailRoutingRuleConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareEmailRoutingRule.IDataCloudflareEmailRoutingRuleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_routing_rule#zone_id DataCloudflareEmailRoutingRule#zone_id}
            /// </remarks>
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string ZoneId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_routing_rule#filter DataCloudflareEmailRoutingRule#filter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareEmailRoutingRule.DataCloudflareEmailRoutingRuleFilter\"}", isOptional: true)]
            public cloudflare.DataCloudflareEmailRoutingRule.IDataCloudflareEmailRoutingRuleFilter? Filter
            {
                get => GetInstanceProperty<cloudflare.DataCloudflareEmailRoutingRule.IDataCloudflareEmailRoutingRuleFilter?>();
            }

            /// <summary>Routing rule identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_routing_rule#rule_identifier DataCloudflareEmailRoutingRule#rule_identifier}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ruleIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RuleIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
