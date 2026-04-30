using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterRanges), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterRanges")]
    public interface ISagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterRanges
    {
        /// <summary>auto_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#auto_parameters SagemakerHyperParameterTuningJob#auto_parameters}
        /// </remarks>
        [JsiiProperty(name: "autoParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterRangesAutoParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>categorical_parameter_ranges block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#categorical_parameter_ranges SagemakerHyperParameterTuningJob#categorical_parameter_ranges}
        /// </remarks>
        [JsiiProperty(name: "categoricalParameterRanges", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterRangesCategoricalParameterRanges\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CategoricalParameterRanges
        {
            get
            {
                return null;
            }
        }

        /// <summary>continuous_parameter_ranges block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#continuous_parameter_ranges SagemakerHyperParameterTuningJob#continuous_parameter_ranges}
        /// </remarks>
        [JsiiProperty(name: "continuousParameterRanges", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterRangesContinuousParameterRanges\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ContinuousParameterRanges
        {
            get
            {
                return null;
            }
        }

        /// <summary>integer_parameter_ranges block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#integer_parameter_ranges SagemakerHyperParameterTuningJob#integer_parameter_ranges}
        /// </remarks>
        [JsiiProperty(name: "integerParameterRanges", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterRangesIntegerParameterRanges\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IntegerParameterRanges
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterRanges), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterRanges")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterRanges
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>auto_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#auto_parameters SagemakerHyperParameterTuningJob#auto_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterRangesAutoParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AutoParameters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>categorical_parameter_ranges block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#categorical_parameter_ranges SagemakerHyperParameterTuningJob#categorical_parameter_ranges}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "categoricalParameterRanges", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterRangesCategoricalParameterRanges\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CategoricalParameterRanges
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>continuous_parameter_ranges block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#continuous_parameter_ranges SagemakerHyperParameterTuningJob#continuous_parameter_ranges}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "continuousParameterRanges", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterRangesContinuousParameterRanges\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ContinuousParameterRanges
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>integer_parameter_ranges block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#integer_parameter_ranges SagemakerHyperParameterTuningJob#integer_parameter_ranges}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "integerParameterRanges", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterRangesIntegerParameterRanges\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IntegerParameterRanges
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
