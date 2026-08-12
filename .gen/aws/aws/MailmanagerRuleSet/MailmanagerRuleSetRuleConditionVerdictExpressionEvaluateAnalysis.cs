using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleConditionVerdictExpressionEvaluateAnalysis")]
    public class MailmanagerRuleSetRuleConditionVerdictExpressionEvaluateAnalysis : aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleConditionVerdictExpressionEvaluateAnalysis
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#analyzer MailmanagerRuleSet#analyzer}.</summary>
        [JsiiProperty(name: "analyzer", typeJson: "{\"primitive\":\"string\"}")]
        public string Analyzer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#result_field MailmanagerRuleSet#result_field}.</summary>
        [JsiiProperty(name: "resultField", typeJson: "{\"primitive\":\"string\"}")]
        public string ResultField
        {
            get;
            set;
        }
    }
}
