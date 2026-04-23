using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodedeployDeploymentGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codedeployDeploymentGroup.CodedeployDeploymentGroupConfig")]
    public class CodedeployDeploymentGroupConfig : aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_group#app_name CodedeployDeploymentGroup#app_name}.</summary>
        [JsiiProperty(name: "appName", typeJson: "{\"primitive\":\"string\"}")]
        public string AppName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_group#deployment_group_name CodedeployDeploymentGroup#deployment_group_name}.</summary>
        [JsiiProperty(name: "deploymentGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string DeploymentGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_group#service_role_arn CodedeployDeploymentGroup#service_role_arn}.</summary>
        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceRoleArn
        {
            get;
            set;
        }

        /// <summary>alarm_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_group#alarm_configuration CodedeployDeploymentGroup#alarm_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alarmConfiguration", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupAlarmConfiguration\"}", isOptional: true)]
        public aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupAlarmConfiguration? AlarmConfiguration
        {
            get;
            set;
        }

        /// <summary>auto_rollback_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_group#auto_rollback_configuration CodedeployDeploymentGroup#auto_rollback_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoRollbackConfiguration", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupAutoRollbackConfiguration\"}", isOptional: true)]
        public aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupAutoRollbackConfiguration? AutoRollbackConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_group#autoscaling_groups CodedeployDeploymentGroup#autoscaling_groups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoscalingGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AutoscalingGroups
        {
            get;
            set;
        }

        /// <summary>blue_green_deployment_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_group#blue_green_deployment_config CodedeployDeploymentGroup#blue_green_deployment_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blueGreenDeploymentConfig", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfig\"}", isOptional: true)]
        public aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupBlueGreenDeploymentConfig? BlueGreenDeploymentConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_group#deployment_config_name CodedeployDeploymentGroup#deployment_config_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deploymentConfigName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeploymentConfigName
        {
            get;
            set;
        }

        /// <summary>deployment_style block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_group#deployment_style CodedeployDeploymentGroup#deployment_style}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deploymentStyle", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupDeploymentStyle\"}", isOptional: true)]
        public aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupDeploymentStyle? DeploymentStyle
        {
            get;
            set;
        }

        private object? _ec2TagFilter;

        /// <summary>ec2_tag_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_group#ec2_tag_filter CodedeployDeploymentGroup#ec2_tag_filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ec2TagFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupEc2TagFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Ec2TagFilter
        {
            get => _ec2TagFilter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupEc2TagFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupEc2TagFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ec2TagFilter = value;
            }
        }

        private object? _ec2TagSet;

        /// <summary>ec2_tag_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_group#ec2_tag_set CodedeployDeploymentGroup#ec2_tag_set}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ec2TagSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupEc2TagSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Ec2TagSet
        {
            get => _ec2TagSet;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupEc2TagSet[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupEc2TagSet).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ec2TagSet = value;
            }
        }

        /// <summary>ecs_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_group#ecs_service CodedeployDeploymentGroup#ecs_service}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ecsService", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupEcsService\"}", isOptional: true)]
        public aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupEcsService? EcsService
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_group#id CodedeployDeploymentGroup#id}.</summary>
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

        /// <summary>load_balancer_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_group#load_balancer_info CodedeployDeploymentGroup#load_balancer_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerInfo", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupLoadBalancerInfo\"}", isOptional: true)]
        public aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupLoadBalancerInfo? LoadBalancerInfo
        {
            get;
            set;
        }

        private object? _onPremisesInstanceTagFilter;

        /// <summary>on_premises_instance_tag_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_group#on_premises_instance_tag_filter CodedeployDeploymentGroup#on_premises_instance_tag_filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onPremisesInstanceTagFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupOnPremisesInstanceTagFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OnPremisesInstanceTagFilter
        {
            get => _onPremisesInstanceTagFilter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupOnPremisesInstanceTagFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupOnPremisesInstanceTagFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _onPremisesInstanceTagFilter = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_group#outdated_instances_strategy CodedeployDeploymentGroup#outdated_instances_strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outdatedInstancesStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutdatedInstancesStrategy
        {
            get;
            set;
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_group#region CodedeployDeploymentGroup#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_group#tags CodedeployDeploymentGroup#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_group#tags_all CodedeployDeploymentGroup#tags_all}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get;
            set;
        }

        private object? _terminationHookEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_group#termination_hook_enabled CodedeployDeploymentGroup#termination_hook_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "terminationHookEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? TerminationHookEnabled
        {
            get => _terminationHookEnabled;
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
                _terminationHookEnabled = value;
            }
        }

        private object? _triggerConfiguration;

        /// <summary>trigger_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codedeploy_deployment_group#trigger_configuration CodedeployDeploymentGroup#trigger_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "triggerConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupTriggerConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TriggerConfiguration
        {
            get => _triggerConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupTriggerConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupTriggerConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _triggerConfiguration = value;
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
