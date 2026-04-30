using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AccessanalyzerAnalyzer
{
    [JsiiByValue(fqn: "aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRuleInclusion")]
    public class AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRuleInclusion : aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRuleInclusion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/accessanalyzer_analyzer#account_ids AccessanalyzerAnalyzer#account_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accountIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AccountIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/accessanalyzer_analyzer#resource_arns AccessanalyzerAnalyzer#resource_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ResourceArns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/accessanalyzer_analyzer#resource_types AccessanalyzerAnalyzer#resource_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ResourceTypes
        {
            get;
            set;
        }
    }
}
