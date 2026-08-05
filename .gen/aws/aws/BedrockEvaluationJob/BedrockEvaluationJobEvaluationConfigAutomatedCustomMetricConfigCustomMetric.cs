using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEvaluationJob
{
    [JsiiByValue(fqn: "aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigAutomatedCustomMetricConfigCustomMetric")]
    public class BedrockEvaluationJobEvaluationConfigAutomatedCustomMetricConfigCustomMetric : aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigAutomatedCustomMetricConfigCustomMetric
    {
        private object? _customMetricDefinition;

        /// <summary>custom_metric_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrock_evaluation_job#custom_metric_definition BedrockEvaluationJob#custom_metric_definition}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinition" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customMetricDefinition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomMetricDefinition
        {
            get => _customMetricDefinition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigAutomatedCustomMetricConfigCustomMetricCustomMetricDefinition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customMetricDefinition = value;
            }
        }
    }
}
