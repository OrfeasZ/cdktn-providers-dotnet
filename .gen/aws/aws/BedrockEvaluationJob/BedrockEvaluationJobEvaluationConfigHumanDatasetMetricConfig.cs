using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEvaluationJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigHumanDatasetMetricConfig")]
    public class BedrockEvaluationJobEvaluationConfigHumanDatasetMetricConfig : aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigHumanDatasetMetricConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrock_evaluation_job#metric_names BedrockEvaluationJob#metric_names}.</summary>
        [JsiiProperty(name: "metricNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] MetricNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrock_evaluation_job#task_type BedrockEvaluationJob#task_type}.</summary>
        [JsiiProperty(name: "taskType", typeJson: "{\"primitive\":\"string\"}")]
        public string TaskType
        {
            get;
            set;
        }

        private object? _dataset;

        /// <summary>dataset block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrock_evaluation_job#dataset BedrockEvaluationJob#dataset}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigHumanDatasetMetricConfigDataset" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataset", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigHumanDatasetMetricConfigDataset\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Dataset
        {
            get => _dataset;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigHumanDatasetMetricConfigDataset[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigHumanDatasetMetricConfigDataset).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dataset = value;
            }
        }
    }
}
