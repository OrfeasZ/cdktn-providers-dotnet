using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AccessanalyzerAnalyzer
{
    [JsiiByValue(fqn: "aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccess")]
    public class AccessanalyzerAnalyzerConfigurationInternalAccess : aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationInternalAccess
    {
        /// <summary>analysis_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/accessanalyzer_analyzer#analysis_rule AccessanalyzerAnalyzer#analysis_rule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "analysisRule", typeJson: "{\"fqn\":\"aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRule\"}", isOptional: true)]
        public aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRule? AnalysisRule
        {
            get;
            set;
        }
    }
}
