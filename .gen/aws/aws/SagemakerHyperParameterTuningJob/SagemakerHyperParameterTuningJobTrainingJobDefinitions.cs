using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitions")]
    public class SagemakerHyperParameterTuningJobTrainingJobDefinitions : aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#role_arn SagemakerHyperParameterTuningJob#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        private object? _algorithmSpecification;

        /// <summary>algorithm_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#algorithm_specification SagemakerHyperParameterTuningJob#algorithm_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "algorithmSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsAlgorithmSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AlgorithmSpecification
        {
            get => _algorithmSpecification;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsAlgorithmSpecification[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsAlgorithmSpecification).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _algorithmSpecification = value;
            }
        }

        private object? _checkpointConfig;

        /// <summary>checkpoint_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#checkpoint_config SagemakerHyperParameterTuningJob#checkpoint_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "checkpointConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsCheckpointConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CheckpointConfig
        {
            get => _checkpointConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsCheckpointConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsCheckpointConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _checkpointConfig = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#definition_name SagemakerHyperParameterTuningJob#definition_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "definitionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefinitionName
        {
            get;
            set;
        }

        private object? _enableInterContainerTrafficEncryption;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#enable_inter_container_traffic_encryption SagemakerHyperParameterTuningJob#enable_inter_container_traffic_encryption}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableInterContainerTrafficEncryption", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnableInterContainerTrafficEncryption
        {
            get => _enableInterContainerTrafficEncryption;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enableInterContainerTrafficEncryption = value;
            }
        }

        private object? _enableManagedSpotTraining;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#enable_managed_spot_training SagemakerHyperParameterTuningJob#enable_managed_spot_training}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableManagedSpotTraining", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnableManagedSpotTraining
        {
            get => _enableManagedSpotTraining;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enableManagedSpotTraining = value;
            }
        }

        private object? _enableNetworkIsolation;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#enable_network_isolation SagemakerHyperParameterTuningJob#enable_network_isolation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableNetworkIsolation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnableNetworkIsolation
        {
            get => _enableNetworkIsolation;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enableNetworkIsolation = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#environment SagemakerHyperParameterTuningJob#environment}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Environment
        {
            get;
            set;
        }

        private object? _hyperParameterRanges;

        /// <summary>hyper_parameter_ranges block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#hyper_parameter_ranges SagemakerHyperParameterTuningJob#hyper_parameter_ranges}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hyperParameterRanges", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterRanges\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HyperParameterRanges
        {
            get => _hyperParameterRanges;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterRanges[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterRanges).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _hyperParameterRanges = value;
            }
        }

        private object? _hyperParameterTuningResourceConfig;

        /// <summary>hyper_parameter_tuning_resource_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#hyper_parameter_tuning_resource_config SagemakerHyperParameterTuningJob#hyper_parameter_tuning_resource_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hyperParameterTuningResourceConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterTuningResourceConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HyperParameterTuningResourceConfig
        {
            get => _hyperParameterTuningResourceConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterTuningResourceConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsHyperParameterTuningResourceConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _hyperParameterTuningResourceConfig = value;
            }
        }

        private object? _inputDataConfig;

        /// <summary>input_data_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#input_data_config SagemakerHyperParameterTuningJob#input_data_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inputDataConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsInputDataConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InputDataConfig
        {
            get => _inputDataConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsInputDataConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsInputDataConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _inputDataConfig = value;
            }
        }

        private object? _outputDataConfig;

        /// <summary>output_data_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#output_data_config SagemakerHyperParameterTuningJob#output_data_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outputDataConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsOutputDataConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OutputDataConfig
        {
            get => _outputDataConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsOutputDataConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsOutputDataConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _outputDataConfig = value;
            }
        }

        private object? _resourceConfig;

        /// <summary>resource_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#resource_config SagemakerHyperParameterTuningJob#resource_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsResourceConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceConfig
        {
            get => _resourceConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsResourceConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsResourceConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceConfig = value;
            }
        }

        private object? _retryStrategy;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#retry_strategy SagemakerHyperParameterTuningJob#retry_strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retryStrategy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsRetryStrategy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RetryStrategy
        {
            get => _retryStrategy;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsRetryStrategy[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsRetryStrategy).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _retryStrategy = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#static_hyper_parameters SagemakerHyperParameterTuningJob#static_hyper_parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "staticHyperParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? StaticHyperParameters
        {
            get;
            set;
        }

        private object? _stoppingCondition;

        /// <summary>stopping_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#stopping_condition SagemakerHyperParameterTuningJob#stopping_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stoppingCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsStoppingCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StoppingCondition
        {
            get => _stoppingCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsStoppingCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsStoppingCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stoppingCondition = value;
            }
        }

        private object? _tuningObjective;

        /// <summary>tuning_objective block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#tuning_objective SagemakerHyperParameterTuningJob#tuning_objective}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tuningObjective", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsTuningObjective\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TuningObjective
        {
            get => _tuningObjective;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsTuningObjective[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsTuningObjective).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tuningObjective = value;
            }
        }

        private object? _vpcConfig;

        /// <summary>vpc_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#vpc_config SagemakerHyperParameterTuningJob#vpc_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpcConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobTrainingJobDefinitionsVpcConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VpcConfig
        {
            get => _vpcConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsVpcConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobTrainingJobDefinitionsVpcConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _vpcConfig = value;
            }
        }
    }
}
