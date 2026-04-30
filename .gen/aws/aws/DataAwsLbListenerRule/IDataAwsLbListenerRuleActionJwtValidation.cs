using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLbListenerRule
{
    [JsiiInterface(nativeType: typeof(IDataAwsLbListenerRuleActionJwtValidation), fullyQualifiedName: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionJwtValidation")]
    public interface IDataAwsLbListenerRuleActionJwtValidation
    {
        /// <summary>additional_claim block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/lb_listener_rule#additional_claim DataAwsLbListenerRule#additional_claim}
        /// </remarks>
        [JsiiProperty(name: "additionalClaim", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionJwtValidationAdditionalClaim\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AdditionalClaim
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsLbListenerRuleActionJwtValidation), fullyQualifiedName: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionJwtValidation")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionJwtValidation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>additional_claim block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/lb_listener_rule#additional_claim DataAwsLbListenerRule#additional_claim}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "additionalClaim", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionJwtValidationAdditionalClaim\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AdditionalClaim
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
