using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiByValue(fqn: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRanges")]
    public class SagemakerHyperParameterTuningJobConfigParameterRanges : aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRanges
    {
        private object? _autoParameters;

        /// <summary>auto_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#auto_parameters SagemakerHyperParameterTuningJob#auto_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesAutoParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AutoParameters
        {
            get => _autoParameters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRangesAutoParameters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRangesAutoParameters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _autoParameters = value;
            }
        }

        private object? _categoricalParameterRanges;

        /// <summary>categorical_parameter_ranges block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#categorical_parameter_ranges SagemakerHyperParameterTuningJob#categorical_parameter_ranges}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "categoricalParameterRanges", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesCategoricalParameterRanges\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CategoricalParameterRanges
        {
            get => _categoricalParameterRanges;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRangesCategoricalParameterRanges[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRangesCategoricalParameterRanges).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _categoricalParameterRanges = value;
            }
        }

        private object? _continuousParameterRanges;

        /// <summary>continuous_parameter_ranges block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#continuous_parameter_ranges SagemakerHyperParameterTuningJob#continuous_parameter_ranges}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "continuousParameterRanges", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesContinuousParameterRanges\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ContinuousParameterRanges
        {
            get => _continuousParameterRanges;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRangesContinuousParameterRanges[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRangesContinuousParameterRanges).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _continuousParameterRanges = value;
            }
        }

        private object? _integerParameterRanges;

        /// <summary>integer_parameter_ranges block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#integer_parameter_ranges SagemakerHyperParameterTuningJob#integer_parameter_ranges}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "integerParameterRanges", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesIntegerParameterRanges\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IntegerParameterRanges
        {
            get => _integerParameterRanges;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRangesIntegerParameterRanges[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRangesIntegerParameterRanges).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _integerParameterRanges = value;
            }
        }
    }
}
