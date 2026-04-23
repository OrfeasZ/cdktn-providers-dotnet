using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEcsCapacityIncreaseConfig")]
    public class ArcregionswitchPlanWorkflowStepParallelConfigStepEcsCapacityIncreaseConfig : aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEcsCapacityIncreaseConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#capacity_monitoring_approach ArcregionswitchPlan#capacity_monitoring_approach}.</summary>
        [JsiiProperty(name: "capacityMonitoringApproach", typeJson: "{\"primitive\":\"string\"}")]
        public string CapacityMonitoringApproach
        {
            get;
            set;
        }

        private object? _service;

        /// <summary>service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#service ArcregionswitchPlan#service}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "service", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEcsCapacityIncreaseConfigService\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Service
        {
            get => _service;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEcsCapacityIncreaseConfigService[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEcsCapacityIncreaseConfigService).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _service = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#target_percent ArcregionswitchPlan#target_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetPercent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#timeout_minutes ArcregionswitchPlan#timeout_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimeoutMinutes
        {
            get;
            set;
        }

        private object? _ungraceful;

        /// <summary>ungraceful block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#ungraceful ArcregionswitchPlan#ungraceful}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ungraceful", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEcsCapacityIncreaseConfigUngraceful\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Ungraceful
        {
            get => _ungraceful;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEcsCapacityIncreaseConfigUngraceful[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEcsCapacityIncreaseConfigUngraceful).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ungraceful = value;
            }
        }
    }
}
