using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworksecuritymanagerPolicy
{
    [JsiiByValue(fqn: "aws.networksecuritymanagerPolicy.NetworksecuritymanagerPolicyTemplateOrRule")]
    public class NetworksecuritymanagerPolicyTemplateOrRule : aws.NetworksecuritymanagerPolicy.INetworksecuritymanagerPolicyTemplateOrRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/networksecuritymanager_policy#rule_identifier NetworksecuritymanagerPolicy#rule_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ruleIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RuleIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/networksecuritymanager_policy#template_identifier NetworksecuritymanagerPolicy#template_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "templateIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TemplateIdentifier
        {
            get;
            set;
        }
    }
}
