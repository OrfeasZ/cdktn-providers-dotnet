using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigA")]
    public class SagemakerHyperParameterTuningJobConfigA : aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigA
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#strategy SagemakerHyperParameterTuningJob#strategy}.</summary>
        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}")]
        public string Strategy
        {
            get;
            set;
        }

        private object? _objective;

        /// <summary>objective block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#objective SagemakerHyperParameterTuningJob#objective}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "objective", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigObjective\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Objective
        {
            get => _objective;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigObjective[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigObjective).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _objective = value;
            }
        }

        private object? _parameterRanges;

        /// <summary>parameter_ranges block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#parameter_ranges SagemakerHyperParameterTuningJob#parameter_ranges}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parameterRanges", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRanges\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ParameterRanges
        {
            get => _parameterRanges;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRanges[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRanges).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _parameterRanges = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#random_seed SagemakerHyperParameterTuningJob#random_seed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "randomSeed", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RandomSeed
        {
            get;
            set;
        }

        private object? _resourceLimits;

        /// <summary>resource_limits block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#resource_limits SagemakerHyperParameterTuningJob#resource_limits}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceLimits", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigResourceLimits\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceLimits
        {
            get => _resourceLimits;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigResourceLimits[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigResourceLimits).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceLimits = value;
            }
        }

        private object? _strategyConfig;

        /// <summary>strategy_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#strategy_config SagemakerHyperParameterTuningJob#strategy_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "strategyConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigStrategyConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StrategyConfig
        {
            get => _strategyConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigStrategyConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigStrategyConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _strategyConfig = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#training_job_early_stopping_type SagemakerHyperParameterTuningJob#training_job_early_stopping_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trainingJobEarlyStoppingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrainingJobEarlyStoppingType
        {
            get;
            set;
        }

        private object? _tuningJobCompletionCriteria;

        /// <summary>tuning_job_completion_criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_hyper_parameter_tuning_job#tuning_job_completion_criteria SagemakerHyperParameterTuningJob#tuning_job_completion_criteria}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tuningJobCompletionCriteria", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteria\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TuningJobCompletionCriteria
        {
            get => _tuningJobCompletionCriteria;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteria[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteria).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tuningJobCompletionCriteria = value;
            }
        }
    }
}
