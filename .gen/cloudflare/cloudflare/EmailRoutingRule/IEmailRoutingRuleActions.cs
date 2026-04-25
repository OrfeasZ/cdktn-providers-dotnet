using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.EmailRoutingRule
{
    [JsiiInterface(nativeType: typeof(IEmailRoutingRuleActions), fullyQualifiedName: "cloudflare.emailRoutingRule.EmailRoutingRuleActions")]
    public interface IEmailRoutingRuleActions
    {
        /// <summary>Type of supported action. Available values: "drop", "forward", "worker".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/email_routing_rule#type EmailRoutingRule#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/email_routing_rule#value EmailRoutingRule#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmailRoutingRuleActions), fullyQualifiedName: "cloudflare.emailRoutingRule.EmailRoutingRuleActions")]
        internal sealed class _Proxy : DeputyBase, cloudflare.EmailRoutingRule.IEmailRoutingRuleActions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Type of supported action. Available values: "drop", "forward", "worker".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/email_routing_rule#type EmailRoutingRule#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/email_routing_rule#value EmailRoutingRule#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Value
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
