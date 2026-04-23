using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerHyperParameterTuningJobConfigA), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigA")]
    public interface ISagemakerHyperParameterTuningJobConfigA
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#strategy SagemakerHyperParameterTuningJob#strategy}.</summary>
        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}")]
        string Strategy
        {
            get;
        }

        /// <summary>objective block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#objective SagemakerHyperParameterTuningJob#objective}
        /// </remarks>
        [JsiiProperty(name: "objective", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigObjective\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Objective
        {
            get
            {
                return null;
            }
        }

        /// <summary>parameter_ranges block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#parameter_ranges SagemakerHyperParameterTuningJob#parameter_ranges}
        /// </remarks>
        [JsiiProperty(name: "parameterRanges", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRanges\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ParameterRanges
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#random_seed SagemakerHyperParameterTuningJob#random_seed}.</summary>
        [JsiiProperty(name: "randomSeed", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RandomSeed
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_limits block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#resource_limits SagemakerHyperParameterTuningJob#resource_limits}
        /// </remarks>
        [JsiiProperty(name: "resourceLimits", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigResourceLimits\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceLimits
        {
            get
            {
                return null;
            }
        }

        /// <summary>strategy_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#strategy_config SagemakerHyperParameterTuningJob#strategy_config}
        /// </remarks>
        [JsiiProperty(name: "strategyConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigStrategyConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StrategyConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#training_job_early_stopping_type SagemakerHyperParameterTuningJob#training_job_early_stopping_type}.</summary>
        [JsiiProperty(name: "trainingJobEarlyStoppingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrainingJobEarlyStoppingType
        {
            get
            {
                return null;
            }
        }

        /// <summary>tuning_job_completion_criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#tuning_job_completion_criteria SagemakerHyperParameterTuningJob#tuning_job_completion_criteria}
        /// </remarks>
        [JsiiProperty(name: "tuningJobCompletionCriteria", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteria\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TuningJobCompletionCriteria
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerHyperParameterTuningJobConfigA), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigA")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#strategy SagemakerHyperParameterTuningJob#strategy}.</summary>
            [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}")]
            public string Strategy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>objective block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#objective SagemakerHyperParameterTuningJob#objective}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "objective", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigObjective\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Objective
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>parameter_ranges block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#parameter_ranges SagemakerHyperParameterTuningJob#parameter_ranges}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parameterRanges", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRanges\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ParameterRanges
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#random_seed SagemakerHyperParameterTuningJob#random_seed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "randomSeed", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RandomSeed
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>resource_limits block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#resource_limits SagemakerHyperParameterTuningJob#resource_limits}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceLimits", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigResourceLimits\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceLimits
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>strategy_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#strategy_config SagemakerHyperParameterTuningJob#strategy_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "strategyConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigStrategyConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StrategyConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#training_job_early_stopping_type SagemakerHyperParameterTuningJob#training_job_early_stopping_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trainingJobEarlyStoppingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrainingJobEarlyStoppingType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>tuning_job_completion_criteria block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#tuning_job_completion_criteria SagemakerHyperParameterTuningJob#tuning_job_completion_criteria}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tuningJobCompletionCriteria", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigTuningJobCompletionCriteria\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TuningJobCompletionCriteria
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
