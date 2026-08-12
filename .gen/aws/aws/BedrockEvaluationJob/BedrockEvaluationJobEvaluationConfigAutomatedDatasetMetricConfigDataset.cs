using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEvaluationJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigAutomatedDatasetMetricConfigDataset")]
    public class BedrockEvaluationJobEvaluationConfigAutomatedDatasetMetricConfigDataset : aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigAutomatedDatasetMetricConfigDataset
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrock_evaluation_job#name BedrockEvaluationJob#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object? _datasetLocation;

        /// <summary>dataset_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrock_evaluation_job#dataset_location BedrockEvaluationJob#dataset_location}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigAutomatedDatasetMetricConfigDatasetDatasetLocation" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "datasetLocation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigAutomatedDatasetMetricConfigDatasetDatasetLocation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DatasetLocation
        {
            get => _datasetLocation;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigAutomatedDatasetMetricConfigDatasetDatasetLocation[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigAutomatedDatasetMetricConfigDatasetDatasetLocation).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _datasetLocation = value;
            }
        }
    }
}
