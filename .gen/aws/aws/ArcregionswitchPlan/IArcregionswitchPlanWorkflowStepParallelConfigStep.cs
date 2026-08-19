using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiInterface(nativeType: typeof(IArcregionswitchPlanWorkflowStepParallelConfigStep), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStep")]
    public interface IArcregionswitchPlanWorkflowStepParallelConfigStep
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#execution_block_type ArcregionswitchPlan#execution_block_type}.</summary>
        [JsiiProperty(name: "executionBlockType", typeJson: "{\"primitive\":\"string\"}")]
        string ExecutionBlockType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#name ArcregionswitchPlan#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>arc_routing_control_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#arc_routing_control_config ArcregionswitchPlan#arc_routing_control_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepArcRoutingControlConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "arcRoutingControlConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepArcRoutingControlConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ArcRoutingControlConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>aurora_provisioned_scaling_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#aurora_provisioned_scaling_config ArcregionswitchPlan#aurora_provisioned_scaling_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepAuroraProvisionedScalingConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "auroraProvisionedScalingConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepAuroraProvisionedScalingConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AuroraProvisionedScalingConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>aurora_serverless_scaling_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#aurora_serverless_scaling_config ArcregionswitchPlan#aurora_serverless_scaling_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepAuroraServerlessScalingConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "auroraServerlessScalingConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepAuroraServerlessScalingConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AuroraServerlessScalingConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_action_lambda_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#custom_action_lambda_config ArcregionswitchPlan#custom_action_lambda_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepCustomActionLambdaConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "customActionLambdaConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepCustomActionLambdaConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomActionLambdaConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#description ArcregionswitchPlan#description}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#document_db_config ArcregionswitchPlan#document_db_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepDocumentDbConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "documentDbConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepDocumentDbConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#ec2_asg_capacity_increase_config ArcregionswitchPlan#ec2_asg_capacity_increase_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEc2AsgCapacityIncreaseConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ec2AsgCapacityIncreaseConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEc2AsgCapacityIncreaseConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#ecs_capacity_increase_config ArcregionswitchPlan#ecs_capacity_increase_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEcsCapacityIncreaseConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ecsCapacityIncreaseConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEcsCapacityIncreaseConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#eks_resource_scaling_config ArcregionswitchPlan#eks_resource_scaling_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "eksResourceScalingConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#execution_approval_config ArcregionswitchPlan#execution_approval_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepExecutionApprovalConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "executionApprovalConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepExecutionApprovalConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#global_aurora_config ArcregionswitchPlan#global_aurora_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepGlobalAuroraConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "globalAuroraConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepGlobalAuroraConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GlobalAuroraConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_event_source_mapping_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#lambda_event_source_mapping_config ArcregionswitchPlan#lambda_event_source_mapping_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepLambdaEventSourceMappingConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "lambdaEventSourceMappingConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepLambdaEventSourceMappingConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LambdaEventSourceMappingConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>neptune_global_database_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#neptune_global_database_config ArcregionswitchPlan#neptune_global_database_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepNeptuneGlobalDatabaseConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "neptuneGlobalDatabaseConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepNeptuneGlobalDatabaseConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NeptuneGlobalDatabaseConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>rds_create_cross_region_read_replica_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#rds_create_cross_region_read_replica_config ArcregionswitchPlan#rds_create_cross_region_read_replica_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepRdsCreateCrossRegionReadReplicaConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "rdsCreateCrossRegionReadReplicaConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepRdsCreateCrossRegionReadReplicaConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RdsCreateCrossRegionReadReplicaConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>rds_promote_read_replica_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#rds_promote_read_replica_config ArcregionswitchPlan#rds_promote_read_replica_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepRdsPromoteReadReplicaConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "rdsPromoteReadReplicaConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepRdsPromoteReadReplicaConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RdsPromoteReadReplicaConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>region_switch_plan_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#region_switch_plan_config ArcregionswitchPlan#region_switch_plan_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepRegionSwitchPlanConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "regionSwitchPlanConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepRegionSwitchPlanConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#route53_health_check_config ArcregionswitchPlan#route53_health_check_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepRoute53HealthCheckConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "route53HealthCheckConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepRoute53HealthCheckConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Route53HealthCheckConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IArcregionswitchPlanWorkflowStepParallelConfigStep), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStep")]
        internal sealed class _Proxy : DeputyBase, aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStep
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#execution_block_type ArcregionswitchPlan#execution_block_type}.</summary>
            [JsiiProperty(name: "executionBlockType", typeJson: "{\"primitive\":\"string\"}")]
            public string ExecutionBlockType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#name ArcregionswitchPlan#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>arc_routing_control_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#arc_routing_control_config ArcregionswitchPlan#arc_routing_control_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepArcRoutingControlConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "arcRoutingControlConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepArcRoutingControlConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ArcRoutingControlConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>aurora_provisioned_scaling_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#aurora_provisioned_scaling_config ArcregionswitchPlan#aurora_provisioned_scaling_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepAuroraProvisionedScalingConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "auroraProvisionedScalingConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepAuroraProvisionedScalingConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AuroraProvisionedScalingConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>aurora_serverless_scaling_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#aurora_serverless_scaling_config ArcregionswitchPlan#aurora_serverless_scaling_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepAuroraServerlessScalingConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "auroraServerlessScalingConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepAuroraServerlessScalingConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AuroraServerlessScalingConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>custom_action_lambda_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#custom_action_lambda_config ArcregionswitchPlan#custom_action_lambda_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepCustomActionLambdaConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customActionLambdaConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepCustomActionLambdaConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomActionLambdaConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#description ArcregionswitchPlan#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>document_db_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#document_db_config ArcregionswitchPlan#document_db_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepDocumentDbConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "documentDbConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepDocumentDbConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DocumentDbConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ec2_asg_capacity_increase_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#ec2_asg_capacity_increase_config ArcregionswitchPlan#ec2_asg_capacity_increase_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEc2AsgCapacityIncreaseConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ec2AsgCapacityIncreaseConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEc2AsgCapacityIncreaseConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ec2AsgCapacityIncreaseConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ecs_capacity_increase_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#ecs_capacity_increase_config ArcregionswitchPlan#ecs_capacity_increase_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEcsCapacityIncreaseConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ecsCapacityIncreaseConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEcsCapacityIncreaseConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EcsCapacityIncreaseConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>eks_resource_scaling_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#eks_resource_scaling_config ArcregionswitchPlan#eks_resource_scaling_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eksResourceScalingConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EksResourceScalingConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>execution_approval_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#execution_approval_config ArcregionswitchPlan#execution_approval_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepExecutionApprovalConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "executionApprovalConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepExecutionApprovalConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ExecutionApprovalConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>global_aurora_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#global_aurora_config ArcregionswitchPlan#global_aurora_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepGlobalAuroraConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "globalAuroraConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepGlobalAuroraConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? GlobalAuroraConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>lambda_event_source_mapping_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#lambda_event_source_mapping_config ArcregionswitchPlan#lambda_event_source_mapping_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepLambdaEventSourceMappingConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaEventSourceMappingConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepLambdaEventSourceMappingConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LambdaEventSourceMappingConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>neptune_global_database_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#neptune_global_database_config ArcregionswitchPlan#neptune_global_database_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepNeptuneGlobalDatabaseConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "neptuneGlobalDatabaseConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepNeptuneGlobalDatabaseConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NeptuneGlobalDatabaseConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>rds_create_cross_region_read_replica_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#rds_create_cross_region_read_replica_config ArcregionswitchPlan#rds_create_cross_region_read_replica_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepRdsCreateCrossRegionReadReplicaConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rdsCreateCrossRegionReadReplicaConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepRdsCreateCrossRegionReadReplicaConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RdsCreateCrossRegionReadReplicaConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>rds_promote_read_replica_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#rds_promote_read_replica_config ArcregionswitchPlan#rds_promote_read_replica_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepRdsPromoteReadReplicaConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rdsPromoteReadReplicaConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepRdsPromoteReadReplicaConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RdsPromoteReadReplicaConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>region_switch_plan_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#region_switch_plan_config ArcregionswitchPlan#region_switch_plan_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepRegionSwitchPlanConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regionSwitchPlanConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepRegionSwitchPlanConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RegionSwitchPlanConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>route53_health_check_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#route53_health_check_config ArcregionswitchPlan#route53_health_check_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepRoute53HealthCheckConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "route53HealthCheckConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepRoute53HealthCheckConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Route53HealthCheckConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
