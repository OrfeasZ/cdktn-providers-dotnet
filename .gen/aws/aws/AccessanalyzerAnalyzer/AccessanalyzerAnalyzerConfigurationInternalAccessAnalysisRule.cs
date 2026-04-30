using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AccessanalyzerAnalyzer
{
    [JsiiByValue(fqn: "aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRule")]
    public class AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRule : aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRule
    {
        private object? _inclusion;

        /// <summary>inclusion block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/accessanalyzer_analyzer#inclusion AccessanalyzerAnalyzer#inclusion}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inclusion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.accessanalyzerAnalyzer.AccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRuleInclusion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Inclusion
        {
            get => _inclusion;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRuleInclusion[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AccessanalyzerAnalyzer.IAccessanalyzerAnalyzerConfigurationInternalAccessAnalysisRuleInclusion).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _inclusion = value;
            }
        }
    }
}
