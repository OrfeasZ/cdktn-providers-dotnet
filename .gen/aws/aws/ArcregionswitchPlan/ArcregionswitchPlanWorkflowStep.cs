using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStep")]
    public class ArcregionswitchPlanWorkflowStep : aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStep
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#execution_block_type ArcregionswitchPlan#execution_block_type}.</summary>
        [JsiiProperty(name: "executionBlockType", typeJson: "{\"primitive\":\"string\"}")]
        public string ExecutionBlockType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#name ArcregionswitchPlan#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object? _arcRoutingControlConfig;

        /// <summary>arc_routing_control_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#arc_routing_control_config ArcregionswitchPlan#arc_routing_control_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "arcRoutingControlConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepArcRoutingControlConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ArcRoutingControlConfig
        {
            get => _arcRoutingControlConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepArcRoutingControlConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepArcRoutingControlConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _arcRoutingControlConfig = value;
            }
        }

        private object? _customActionLambdaConfig;

        /// <summary>custom_action_lambda_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#custom_action_lambda_config ArcregionswitchPlan#custom_action_lambda_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customActionLambdaConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepCustomActionLambdaConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomActionLambdaConfig
        {
            get => _customActionLambdaConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepCustomActionLambdaConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepCustomActionLambdaConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customActionLambdaConfig = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#description ArcregionswitchPlan#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        private object? _documentDbConfig;

        /// <summary>document_db_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#document_db_config ArcregionswitchPlan#document_db_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "documentDbConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepDocumentDbConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DocumentDbConfig
        {
            get => _documentDbConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepDocumentDbConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepDocumentDbConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _documentDbConfig = value;
            }
        }

        private object? _ec2AsgCapacityIncreaseConfig;

        /// <summary>ec2_asg_capacity_increase_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#ec2_asg_capacity_increase_config ArcregionswitchPlan#ec2_asg_capacity_increase_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ec2AsgCapacityIncreaseConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEc2AsgCapacityIncreaseConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Ec2AsgCapacityIncreaseConfig
        {
            get => _ec2AsgCapacityIncreaseConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepEc2AsgCapacityIncreaseConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepEc2AsgCapacityIncreaseConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ec2AsgCapacityIncreaseConfig = value;
            }
        }

        private object? _ecsCapacityIncreaseConfig;

        /// <summary>ecs_capacity_increase_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#ecs_capacity_increase_config ArcregionswitchPlan#ecs_capacity_increase_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ecsCapacityIncreaseConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEcsCapacityIncreaseConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EcsCapacityIncreaseConfig
        {
            get => _ecsCapacityIncreaseConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepEcsCapacityIncreaseConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepEcsCapacityIncreaseConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ecsCapacityIncreaseConfig = value;
            }
        }

        private object? _eksResourceScalingConfig;

        /// <summary>eks_resource_scaling_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#eks_resource_scaling_config ArcregionswitchPlan#eks_resource_scaling_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eksResourceScalingConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEksResourceScalingConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EksResourceScalingConfig
        {
            get => _eksResourceScalingConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepEksResourceScalingConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepEksResourceScalingConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _eksResourceScalingConfig = value;
            }
        }

        private object? _executionApprovalConfig;

        /// <summary>execution_approval_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#execution_approval_config ArcregionswitchPlan#execution_approval_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "executionApprovalConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepExecutionApprovalConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ExecutionApprovalConfig
        {
            get => _executionApprovalConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepExecutionApprovalConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepExecutionApprovalConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _executionApprovalConfig = value;
            }
        }

        private object? _globalAuroraConfig;

        /// <summary>global_aurora_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#global_aurora_config ArcregionswitchPlan#global_aurora_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "globalAuroraConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepGlobalAuroraConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GlobalAuroraConfig
        {
            get => _globalAuroraConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepGlobalAuroraConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepGlobalAuroraConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _globalAuroraConfig = value;
            }
        }

        private object? _parallelConfig;

        /// <summary>parallel_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#parallel_config ArcregionswitchPlan#parallel_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parallelConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ParallelConfig
        {
            get => _parallelConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _parallelConfig = value;
            }
        }

        private object? _regionSwitchPlanConfig;

        /// <summary>region_switch_plan_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#region_switch_plan_config ArcregionswitchPlan#region_switch_plan_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "regionSwitchPlanConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepRegionSwitchPlanConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RegionSwitchPlanConfig
        {
            get => _regionSwitchPlanConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepRegionSwitchPlanConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepRegionSwitchPlanConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _regionSwitchPlanConfig = value;
            }
        }

        private object? _route53HealthCheckConfig;

        /// <summary>route53_health_check_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#route53_health_check_config ArcregionswitchPlan#route53_health_check_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "route53HealthCheckConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepRoute53HealthCheckConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Route53HealthCheckConfig
        {
            get => _route53HealthCheckConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepRoute53HealthCheckConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepRoute53HealthCheckConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _route53HealthCheckConfig = value;
            }
        }
    }
}
