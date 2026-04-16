using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepArcRoutingControlConfigRegionAndRoutingControls")]
    public class ArcregionswitchPlanWorkflowStepArcRoutingControlConfigRegionAndRoutingControls : aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepArcRoutingControlConfigRegionAndRoutingControls
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#region ArcregionswitchPlan#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public string Region
        {
            get;
            set;
        }

        private object? _routingControl;

        /// <summary>routing_control block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#routing_control ArcregionswitchPlan#routing_control}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "routingControl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepArcRoutingControlConfigRegionAndRoutingControlsRoutingControl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RoutingControl
        {
            get => _routingControl;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepArcRoutingControlConfigRegionAndRoutingControlsRoutingControl[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepArcRoutingControlConfigRegionAndRoutingControlsRoutingControl).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _routingControl = value;
            }
        }
    }
}
