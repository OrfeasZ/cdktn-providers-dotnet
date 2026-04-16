using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbListenerRule
{
    [JsiiInterface(nativeType: typeof(ILbListenerRuleConditionHostHeader), fullyQualifiedName: "aws.lbListenerRule.LbListenerRuleConditionHostHeader")]
    public interface ILbListenerRuleConditionHostHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lb_listener_rule#regex_values LbListenerRule#regex_values}.</summary>
        [JsiiProperty(name: "regexValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? RegexValues
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lb_listener_rule#values LbListenerRule#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Values
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbListenerRuleConditionHostHeader), fullyQualifiedName: "aws.lbListenerRule.LbListenerRuleConditionHostHeader")]
        internal sealed class _Proxy : DeputyBase, aws.LbListenerRule.ILbListenerRuleConditionHostHeader
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lb_listener_rule#regex_values LbListenerRule#regex_values}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regexValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? RegexValues
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lb_listener_rule#values LbListenerRule#values}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Values
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
