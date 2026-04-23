using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiInterface(nativeType: typeof(IArcregionswitchPlanWorkflowStep), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStep")]
    public interface IArcregionswitchPlanWorkflowStep
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#execution_block_type ArcregionswitchPlan#execution_block_type}.</summary>
        [JsiiProperty(name: "executionBlockType", typeJson: "{\"primitive\":\"string\"}")]
        string ExecutionBlockType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#name ArcregionswitchPlan#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>arc_routing_control_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#arc_routing_control_config ArcregionswitchPlan#arc_routing_control_config}
        /// </remarks>
        [JsiiProperty(name: "arcRoutingControlConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepArcRoutingControlConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ArcRoutingControlConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_action_lambda_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#custom_action_lambda_config ArcregionswitchPlan#custom_action_lambda_config}
        /// </remarks>
        [JsiiProperty(name: "customActionLambdaConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepCustomActionLambdaConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomActionLambdaConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#description ArcregionswitchPlan#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>document_db_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#document_db_config ArcregionswitchPlan#document_db_config}
        /// </remarks>
        [JsiiProperty(name: "documentDbConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepDocumentDbConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DocumentDbConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>ec2_asg_capacity_increase_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#ec2_asg_capacity_increase_config ArcregionswitchPlan#ec2_asg_capacity_increase_config}
        /// </remarks>
        [JsiiProperty(name: "ec2AsgCapacityIncreaseConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEc2AsgCapacityIncreaseConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ec2AsgCapacityIncreaseConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>ecs_capacity_increase_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#ecs_capacity_increase_config ArcregionswitchPlan#ecs_capacity_increase_config}
        /// </remarks>
        [JsiiProperty(name: "ecsCapacityIncreaseConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEcsCapacityIncreaseConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EcsCapacityIncreaseConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>eks_resource_scaling_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#eks_resource_scaling_config ArcregionswitchPlan#eks_resource_scaling_config}
        /// </remarks>
        [JsiiProperty(name: "eksResourceScalingConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEksResourceScalingConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EksResourceScalingConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>execution_approval_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#execution_approval_config ArcregionswitchPlan#execution_approval_config}
        /// </remarks>
        [JsiiProperty(name: "executionApprovalConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepExecutionApprovalConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExecutionApprovalConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>global_aurora_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#global_aurora_config ArcregionswitchPlan#global_aurora_config}
        /// </remarks>
        [JsiiProperty(name: "globalAuroraConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepGlobalAuroraConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GlobalAuroraConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>parallel_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#parallel_config ArcregionswitchPlan#parallel_config}
        /// </remarks>
        [JsiiProperty(name: "parallelConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ParallelConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>region_switch_plan_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#region_switch_plan_config ArcregionswitchPlan#region_switch_plan_config}
        /// </remarks>
        [JsiiProperty(name: "regionSwitchPlanConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepRegionSwitchPlanConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RegionSwitchPlanConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>route53_health_check_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#route53_health_check_config ArcregionswitchPlan#route53_health_check_config}
        /// </remarks>
        [JsiiProperty(name: "route53HealthCheckConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepRoute53HealthCheckConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Route53HealthCheckConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IArcregionswitchPlanWorkflowStep), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStep")]
        internal sealed class _Proxy : DeputyBase, aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStep
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#execution_block_type ArcregionswitchPlan#execution_block_type}.</summary>
            [JsiiProperty(name: "executionBlockType", typeJson: "{\"primitive\":\"string\"}")]
            public string ExecutionBlockType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#name ArcregionswitchPlan#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>arc_routing_control_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#arc_routing_control_config ArcregionswitchPlan#arc_routing_control_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "arcRoutingControlConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepArcRoutingControlConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ArcRoutingControlConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>custom_action_lambda_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#custom_action_lambda_config ArcregionswitchPlan#custom_action_lambda_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customActionLambdaConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepCustomActionLambdaConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomActionLambdaConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#description ArcregionswitchPlan#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>document_db_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#document_db_config ArcregionswitchPlan#document_db_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "documentDbConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepDocumentDbConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DocumentDbConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ec2_asg_capacity_increase_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#ec2_asg_capacity_increase_config ArcregionswitchPlan#ec2_asg_capacity_increase_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ec2AsgCapacityIncreaseConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEc2AsgCapacityIncreaseConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ec2AsgCapacityIncreaseConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ecs_capacity_increase_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#ecs_capacity_increase_config ArcregionswitchPlan#ecs_capacity_increase_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ecsCapacityIncreaseConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEcsCapacityIncreaseConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EcsCapacityIncreaseConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>eks_resource_scaling_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#eks_resource_scaling_config ArcregionswitchPlan#eks_resource_scaling_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eksResourceScalingConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEksResourceScalingConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EksResourceScalingConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>execution_approval_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#execution_approval_config ArcregionswitchPlan#execution_approval_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "executionApprovalConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepExecutionApprovalConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ExecutionApprovalConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>global_aurora_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#global_aurora_config ArcregionswitchPlan#global_aurora_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "globalAuroraConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepGlobalAuroraConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? GlobalAuroraConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>parallel_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#parallel_config ArcregionswitchPlan#parallel_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parallelConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ParallelConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>region_switch_plan_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#region_switch_plan_config ArcregionswitchPlan#region_switch_plan_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regionSwitchPlanConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepRegionSwitchPlanConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RegionSwitchPlanConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>route53_health_check_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#route53_health_check_config ArcregionswitchPlan#route53_health_check_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "route53HealthCheckConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepRoute53HealthCheckConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Route53HealthCheckConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
