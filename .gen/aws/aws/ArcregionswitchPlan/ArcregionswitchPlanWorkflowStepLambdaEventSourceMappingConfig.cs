using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepLambdaEventSourceMappingConfig")]
    public class ArcregionswitchPlanWorkflowStepLambdaEventSourceMappingConfig : aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepLambdaEventSourceMappingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#action ArcregionswitchPlan#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        private object? _regionEventSourceMapping;

        /// <summary>region_event_source_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#region_event_source_mapping ArcregionswitchPlan#region_event_source_mapping}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepLambdaEventSourceMappingConfigRegionEventSourceMapping" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "regionEventSourceMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepLambdaEventSourceMappingConfigRegionEventSourceMapping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RegionEventSourceMapping
        {
            get => _regionEventSourceMapping;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepLambdaEventSourceMappingConfigRegionEventSourceMapping[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepLambdaEventSourceMappingConfigRegionEventSourceMapping).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _regionEventSourceMapping = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#timeout_minutes ArcregionswitchPlan#timeout_minutes}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/arcregionswitch_plan#ungraceful ArcregionswitchPlan#ungraceful}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepLambdaEventSourceMappingConfigUngraceful" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ungraceful", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepLambdaEventSourceMappingConfigUngraceful\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepLambdaEventSourceMappingConfigUngraceful[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepLambdaEventSourceMappingConfigUngraceful).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ungraceful = value;
            }
        }
    }
}
