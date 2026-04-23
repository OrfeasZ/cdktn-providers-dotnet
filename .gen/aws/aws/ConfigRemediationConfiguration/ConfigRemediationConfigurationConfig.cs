using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigRemediationConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.configRemediationConfiguration.ConfigRemediationConfigurationConfig")]
    public class ConfigRemediationConfigurationConfig : aws.ConfigRemediationConfiguration.IConfigRemediationConfigurationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/config_remediation_configuration#config_rule_name ConfigRemediationConfiguration#config_rule_name}.</summary>
        [JsiiProperty(name: "configRuleName", typeJson: "{\"primitive\":\"string\"}")]
        public string ConfigRuleName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/config_remediation_configuration#target_id ConfigRemediationConfiguration#target_id}.</summary>
        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/config_remediation_configuration#target_type ConfigRemediationConfiguration#target_type}.</summary>
        [JsiiProperty(name: "targetType", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetType
        {
            get;
            set;
        }

        private object? _automatic;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/config_remediation_configuration#automatic ConfigRemediationConfiguration#automatic}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "automatic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Automatic
        {
            get => _automatic;
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
                _automatic = value;
            }
        }

        /// <summary>execution_controls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/config_remediation_configuration#execution_controls ConfigRemediationConfiguration#execution_controls}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "executionControls", typeJson: "{\"fqn\":\"aws.configRemediationConfiguration.ConfigRemediationConfigurationExecutionControls\"}", isOptional: true)]
        public aws.ConfigRemediationConfiguration.IConfigRemediationConfigurationExecutionControls? ExecutionControls
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/config_remediation_configuration#id ConfigRemediationConfiguration#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/config_remediation_configuration#maximum_automatic_attempts ConfigRemediationConfiguration#maximum_automatic_attempts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumAutomaticAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumAutomaticAttempts
        {
            get;
            set;
        }

        private object? _parameter;

        /// <summary>parameter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/config_remediation_configuration#parameter ConfigRemediationConfiguration#parameter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.configRemediationConfiguration.ConfigRemediationConfigurationParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Parameter
        {
            get => _parameter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ConfigRemediationConfiguration.IConfigRemediationConfigurationParameter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ConfigRemediationConfiguration.IConfigRemediationConfigurationParameter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _parameter = value;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/config_remediation_configuration#region ConfigRemediationConfiguration#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/config_remediation_configuration#resource_type ConfigRemediationConfiguration#resource_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/config_remediation_configuration#retry_attempt_seconds ConfigRemediationConfiguration#retry_attempt_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retryAttemptSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetryAttemptSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/config_remediation_configuration#target_version ConfigRemediationConfiguration#target_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetVersion
        {
            get;
            set;
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
