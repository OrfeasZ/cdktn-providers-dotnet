using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEvaluationJob
{
    [JsiiInterface(nativeType: typeof(IBedrockEvaluationJobEvaluationConfigHuman), fullyQualifiedName: "aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigHuman")]
    public interface IBedrockEvaluationJobEvaluationConfigHuman
    {
        /// <summary>custom_metric block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrock_evaluation_job#custom_metric BedrockEvaluationJob#custom_metric}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigHumanCustomMetric" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "customMetric", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigHumanCustomMetric\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomMetric
        {
            get
            {
                return null;
            }
        }

        /// <summary>dataset_metric_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrock_evaluation_job#dataset_metric_config BedrockEvaluationJob#dataset_metric_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigHumanDatasetMetricConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "datasetMetricConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigHumanDatasetMetricConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DatasetMetricConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>human_workflow_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrock_evaluation_job#human_workflow_config BedrockEvaluationJob#human_workflow_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigHumanHumanWorkflowConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "humanWorkflowConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigHumanHumanWorkflowConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HumanWorkflowConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockEvaluationJobEvaluationConfigHuman), fullyQualifiedName: "aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigHuman")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigHuman
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>custom_metric block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrock_evaluation_job#custom_metric BedrockEvaluationJob#custom_metric}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigHumanCustomMetric" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customMetric", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigHumanCustomMetric\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomMetric
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>dataset_metric_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrock_evaluation_job#dataset_metric_config BedrockEvaluationJob#dataset_metric_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigHumanDatasetMetricConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "datasetMetricConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigHumanDatasetMetricConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DatasetMetricConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>human_workflow_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrock_evaluation_job#human_workflow_config BedrockEvaluationJob#human_workflow_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobEvaluationConfigHumanHumanWorkflowConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "humanWorkflowConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobEvaluationConfigHumanHumanWorkflowConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HumanWorkflowConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
