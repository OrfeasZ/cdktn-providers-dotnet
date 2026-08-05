using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerTrafficPolicy
{
    [JsiiInterface(nativeType: typeof(IMailmanagerTrafficPolicyPolicyStatementConditionIpExpressionEvaluate), fullyQualifiedName: "aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionIpExpressionEvaluate")]
    public interface IMailmanagerTrafficPolicyPolicyStatementConditionIpExpressionEvaluate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/mailmanager_traffic_policy#attribute MailmanagerTrafficPolicy#attribute}.</summary>
        [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}")]
        string Attribute
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerTrafficPolicyPolicyStatementConditionIpExpressionEvaluate), fullyQualifiedName: "aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionIpExpressionEvaluate")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionIpExpressionEvaluate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/mailmanager_traffic_policy#attribute MailmanagerTrafficPolicy#attribute}.</summary>
            [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}")]
            public string Attribute
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
