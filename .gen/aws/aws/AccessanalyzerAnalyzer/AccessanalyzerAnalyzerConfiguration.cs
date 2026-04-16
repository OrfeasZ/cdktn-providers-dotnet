using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AccessanalyzerAnalyzer
{
    [JsiiByValue(fqn: "aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfiguration")]
    public class AccessanalyzerAnalyzerConfiguration : aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfiguration
    {
        /// <summary>internal_access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/accessanalyzer_analyzer#internal_access AccessanalyzerAnalyzer#internal_access}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalAccess", typeJson: "{\"fqn\":\"aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccess\"}", isOptional: true)]
        public aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationInternalAccess? InternalAccess
        {
            get;
            set;
        }

        /// <summary>unused_access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/accessanalyzer_analyzer#unused_access AccessanalyzerAnalyzer#unused_access}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "unusedAccess", typeJson: "{\"fqn\":\"aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationUnusedAccess\"}", isOptional: true)]
        public aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationUnusedAccess? UnusedAccess
        {
            get;
            set;
        }
    }
}
