using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.EmailRoutingRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.emailRoutingRule.EmailRoutingRuleActions")]
    public class EmailRoutingRuleActions : cloudflare.EmailRoutingRule.IEmailRoutingRuleActions
    {
        /// <summary>Type of supported action. Available values: "drop", "forward", "worker".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/email_routing_rule#type EmailRoutingRule#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/email_routing_rule#value EmailRoutingRule#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Value
        {
            get;
            set;
        }
    }
}
