using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockCustomModel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockCustomModel.BedrockCustomModelConfig")]
    public class BedrockCustomModelConfig : aws.BedrockCustomModel.IBedrockCustomModelConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_custom_model#base_model_identifier BedrockCustomModel#base_model_identifier}.</summary>
        [JsiiProperty(name: "baseModelIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string BaseModelIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_custom_model#custom_model_name BedrockCustomModel#custom_model_name}.</summary>
        [JsiiProperty(name: "customModelName", typeJson: "{\"primitive\":\"string\"}")]
        public string CustomModelName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_custom_model#hyperparameters BedrockCustomModel#hyperparameters}.</summary>
        [JsiiProperty(name: "hyperparameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public System.Collections.Generic.IDictionary<string, string> Hyperparameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_custom_model#job_name BedrockCustomModel#job_name}.</summary>
        [JsiiProperty(name: "jobName", typeJson: "{\"primitive\":\"string\"}")]
        public string JobName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_custom_model#role_arn BedrockCustomModel#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_custom_model#customization_type BedrockCustomModel#customization_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customizationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomizationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_custom_model#custom_model_kms_key_id BedrockCustomModel#custom_model_kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customModelKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomModelKmsKeyId
        {
            get;
            set;
        }

        private object? _outputDataConfig;

        /// <summary>output_data_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_custom_model#output_data_config BedrockCustomModel#output_data_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outputDataConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockCustomModel.BedrockCustomModelOutputDataConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.BedrockCustomModel.IBedrockCustomModelOutputDataConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockCustomModel.IBedrockCustomModelOutputDataConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _outputDataConfig = value;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_custom_model#region BedrockCustomModel#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_custom_model#tags BedrockCustomModel#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_custom_model#timeouts BedrockCustomModel#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.bedrockCustomModel.BedrockCustomModelTimeouts\"}", isOptional: true)]
        public aws.BedrockCustomModel.IBedrockCustomModelTimeouts? Timeouts
        {
            get;
            set;
        }

        private object? _trainingDataConfig;

        /// <summary>training_data_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_custom_model#training_data_config BedrockCustomModel#training_data_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trainingDataConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockCustomModel.BedrockCustomModelTrainingDataConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TrainingDataConfig
        {
            get => _trainingDataConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockCustomModel.IBedrockCustomModelTrainingDataConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockCustomModel.IBedrockCustomModelTrainingDataConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _trainingDataConfig = value;
            }
        }

        private object? _validationDataConfig;

        /// <summary>validation_data_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_custom_model#validation_data_config BedrockCustomModel#validation_data_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "validationDataConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockCustomModel.BedrockCustomModelValidationDataConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ValidationDataConfig
        {
            get => _validationDataConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockCustomModel.IBedrockCustomModelValidationDataConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockCustomModel.IBedrockCustomModelValidationDataConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _validationDataConfig = value;
            }
        }

        private object? _vpcConfig;

        /// <summary>vpc_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_custom_model#vpc_config BedrockCustomModel#vpc_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpcConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockCustomModel.BedrockCustomModelVpcConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.BedrockCustomModel.IBedrockCustomModelVpcConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockCustomModel.IBedrockCustomModelVpcConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _vpcConfig = value;
            }
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
