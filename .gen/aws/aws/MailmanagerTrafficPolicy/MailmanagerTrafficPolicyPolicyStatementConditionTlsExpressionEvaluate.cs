using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerTrafficPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionTlsExpressionEvaluate")]
    public class MailmanagerTrafficPolicyPolicyStatementConditionTlsExpressionEvaluate : aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionTlsExpressionEvaluate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/mailmanager_traffic_policy#attribute MailmanagerTrafficPolicy#attribute}.</summary>
        [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}")]
        public string Attribute
        {
            get;
            set;
        }
    }
}
