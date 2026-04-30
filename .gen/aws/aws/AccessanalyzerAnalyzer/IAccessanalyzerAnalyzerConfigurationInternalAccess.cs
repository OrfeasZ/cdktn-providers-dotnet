using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AccessanalyzerAnalyzer
{
    [JsiiInterface(nativeType: typeof(IAccessanalyzerAnalyzerConfigurationInternalAccess), fullyQualifiedName: "aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccess")]
    public interface IAccessanalyzerAnalyzerConfigurationInternalAccess
    {
        /// <summary>analysis_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/accessanalyzer_analyzer#analysis_rule AccessanalyzerAnalyzer#analysis_rule}
        /// </remarks>
        [JsiiProperty(name: "analysisRule", typeJson: "{\"fqn\":\"aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRule\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRule? AnalysisRule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAccessanalyzerAnalyzerConfigurationInternalAccess), fullyQualifiedName: "aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccess")]
        internal sealed class _Proxy : DeputyBase, aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationInternalAccess
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>analysis_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/accessanalyzer_analyzer#analysis_rule AccessanalyzerAnalyzer#analysis_rule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "analysisRule", typeJson: "{\"fqn\":\"aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRule\"}", isOptional: true)]
            public aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRule? AnalysisRule
            {
                get => GetInstanceProperty<aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRule?>();
            }
        }
    }
}
