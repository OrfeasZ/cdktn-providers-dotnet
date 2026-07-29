using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEvaluationJob
{
    [JsiiByValue(fqn: "aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigAutomated")]
    public class BedrockEvaluationJobEvaluationConfigAutomated : aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigAutomated
    {
        private object? _customMetricConfig;

        /// <summary>custom_metric_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrock_evaluation_job#custom_metric_config BedrockEvaluationJob#custom_metric_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigAutomatedCustomMetricConfig" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customMetricConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigAutomatedCustomMetricConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomMetricConfig
        {
            get => _customMetricConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigAutomatedCustomMetricConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigAutomatedCustomMetricConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customMetricConfig = value;
            }
        }

        private object? _datasetMetricConfig;

        /// <summary>dataset_metric_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrock_evaluation_job#dataset_metric_config BedrockEvaluationJob#dataset_metric_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigAutomatedDatasetMetricConfig" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "datasetMetricConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigAutomatedDatasetMetricConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DatasetMetricConfig
        {
            get => _datasetMetricConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigAutomatedDatasetMetricConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigAutomatedDatasetMetricConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _datasetMetricConfig = value;
            }
        }

        private object? _evaluatorModelConfig;

        /// <summary>evaluator_model_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrock_evaluation_job#evaluator_model_config BedrockEvaluationJob#evaluator_model_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigAutomatedEvaluatorModelConfig" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "evaluatorModelConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigAutomatedEvaluatorModelConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EvaluatorModelConfig
        {
            get => _evaluatorModelConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigAutomatedEvaluatorModelConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigAutomatedEvaluatorModelConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _evaluatorModelConfig = value;
            }
        }
    }
}
