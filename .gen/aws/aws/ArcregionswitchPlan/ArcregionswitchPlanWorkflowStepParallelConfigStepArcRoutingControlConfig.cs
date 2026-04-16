using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiByValue(fqn: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepArcRoutingControlConfig")]
    public class ArcregionswitchPlanWorkflowStepParallelConfigStepArcRoutingControlConfig : aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepArcRoutingControlConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#cross_account_role ArcregionswitchPlan#cross_account_role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "crossAccountRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CrossAccountRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#external_id ArcregionswitchPlan#external_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExternalId
        {
            get;
            set;
        }

        private object? _regionAndRoutingControls;

        /// <summary>region_and_routing_controls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#region_and_routing_controls ArcregionswitchPlan#region_and_routing_controls}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "regionAndRoutingControls", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepArcRoutingControlConfigRegionAndRoutingControls\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RegionAndRoutingControls
        {
            get => _regionAndRoutingControls;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepArcRoutingControlConfigRegionAndRoutingControls[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepArcRoutingControlConfigRegionAndRoutingControls).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _regionAndRoutingControls = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#timeout_minutes ArcregionswitchPlan#timeout_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimeoutMinutes
        {
            get;
            set;
        }
    }
}
