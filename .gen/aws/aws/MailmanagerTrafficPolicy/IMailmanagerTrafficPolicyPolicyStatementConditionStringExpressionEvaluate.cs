using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerTrafficPolicy
{
    [JsiiInterface(nativeType: typeof(IMailmanagerTrafficPolicyPolicyStatementConditionStringExpressionEvaluate), fullyQualifiedName: "aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionStringExpressionEvaluate")]
    public interface IMailmanagerTrafficPolicyPolicyStatementConditionStringExpressionEvaluate
    {
        /// <summary>analysis block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_traffic_policy#analysis MailmanagerTrafficPolicy#analysis}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionStringExpressionEvaluateAnalysis" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "analysis", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionStringExpressionEvaluateAnalysis\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Analysis
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_traffic_policy#attribute MailmanagerTrafficPolicy#attribute}.</summary>
        [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Attribute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerTrafficPolicyPolicyStatementConditionStringExpressionEvaluate), fullyQualifiedName: "aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionStringExpressionEvaluate")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionStringExpressionEvaluate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>analysis block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_traffic_policy#analysis MailmanagerTrafficPolicy#analysis}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionStringExpressionEvaluateAnalysis" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "analysis", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionStringExpressionEvaluateAnalysis\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Analysis
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_traffic_policy#attribute MailmanagerTrafficPolicy#attribute}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Attribute
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
