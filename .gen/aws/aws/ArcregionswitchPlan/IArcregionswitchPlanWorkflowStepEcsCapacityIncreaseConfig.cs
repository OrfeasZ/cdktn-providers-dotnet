using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiInterface(nativeType: typeof(IArcregionswitchPlanWorkflowStepEcsCapacityIncreaseConfig), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEcsCapacityIncreaseConfig")]
    public interface IArcregionswitchPlanWorkflowStepEcsCapacityIncreaseConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#capacity_monitoring_approach ArcregionswitchPlan#capacity_monitoring_approach}.</summary>
        [JsiiProperty(name: "capacityMonitoringApproach", typeJson: "{\"primitive\":\"string\"}")]
        string CapacityMonitoringApproach
        {
            get;
        }

        /// <summary>service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#service ArcregionswitchPlan#service}
        /// </remarks>
        [JsiiProperty(name: "service", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEcsCapacityIncreaseConfigService\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Service
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#target_percent ArcregionswitchPlan#target_percent}.</summary>
        [JsiiProperty(name: "targetPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetPercent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#timeout_minutes ArcregionswitchPlan#timeout_minutes}.</summary>
        [JsiiProperty(name: "timeoutMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TimeoutMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>ungraceful block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#ungraceful ArcregionswitchPlan#ungraceful}
        /// </remarks>
        [JsiiProperty(name: "ungraceful", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEcsCapacityIncreaseConfigUngraceful\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ungraceful
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IArcregionswitchPlanWorkflowStepEcsCapacityIncreaseConfig), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEcsCapacityIncreaseConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepEcsCapacityIncreaseConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#capacity_monitoring_approach ArcregionswitchPlan#capacity_monitoring_approach}.</summary>
            [JsiiProperty(name: "capacityMonitoringApproach", typeJson: "{\"primitive\":\"string\"}")]
            public string CapacityMonitoringApproach
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#service ArcregionswitchPlan#service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "service", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEcsCapacityIncreaseConfigService\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Service
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#target_percent ArcregionswitchPlan#target_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetPercent
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#timeout_minutes ArcregionswitchPlan#timeout_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeoutMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TimeoutMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>ungraceful block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#ungraceful ArcregionswitchPlan#ungraceful}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ungraceful", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEcsCapacityIncreaseConfigUngraceful\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ungraceful
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
