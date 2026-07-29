using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerTrafficPolicy
{
    [JsiiInterface(nativeType: typeof(IMailmanagerTrafficPolicyPolicyStatementConditionIpv6ExpressionEvaluate), fullyQualifiedName: "aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionIpv6ExpressionEvaluate")]
    public interface IMailmanagerTrafficPolicyPolicyStatementConditionIpv6ExpressionEvaluate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/mailmanager_traffic_policy#attribute MailmanagerTrafficPolicy#attribute}.</summary>
        [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}")]
        string Attribute
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerTrafficPolicyPolicyStatementConditionIpv6ExpressionEvaluate), fullyQualifiedName: "aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionIpv6ExpressionEvaluate")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionIpv6ExpressionEvaluate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/mailmanager_traffic_policy#attribute MailmanagerTrafficPolicy#attribute}.</summary>
            [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}")]
            public string Attribute
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
