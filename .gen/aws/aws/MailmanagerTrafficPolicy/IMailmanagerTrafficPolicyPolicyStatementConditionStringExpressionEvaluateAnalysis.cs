using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerTrafficPolicy
{
    [JsiiInterface(nativeType: typeof(IMailmanagerTrafficPolicyPolicyStatementConditionStringExpressionEvaluateAnalysis), fullyQualifiedName: "aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionStringExpressionEvaluateAnalysis")]
    public interface IMailmanagerTrafficPolicyPolicyStatementConditionStringExpressionEvaluateAnalysis
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/mailmanager_traffic_policy#analyzer MailmanagerTrafficPolicy#analyzer}.</summary>
        [JsiiProperty(name: "analyzer", typeJson: "{\"primitive\":\"string\"}")]
        string Analyzer
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/mailmanager_traffic_policy#result_field MailmanagerTrafficPolicy#result_field}.</summary>
        [JsiiProperty(name: "resultField", typeJson: "{\"primitive\":\"string\"}")]
        string ResultField
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerTrafficPolicyPolicyStatementConditionStringExpressionEvaluateAnalysis), fullyQualifiedName: "aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionStringExpressionEvaluateAnalysis")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionStringExpressionEvaluateAnalysis
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/mailmanager_traffic_policy#analyzer MailmanagerTrafficPolicy#analyzer}.</summary>
            [JsiiProperty(name: "analyzer", typeJson: "{\"primitive\":\"string\"}")]
            public string Analyzer
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/mailmanager_traffic_policy#result_field MailmanagerTrafficPolicy#result_field}.</summary>
            [JsiiProperty(name: "resultField", typeJson: "{\"primitive\":\"string\"}")]
            public string ResultField
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
