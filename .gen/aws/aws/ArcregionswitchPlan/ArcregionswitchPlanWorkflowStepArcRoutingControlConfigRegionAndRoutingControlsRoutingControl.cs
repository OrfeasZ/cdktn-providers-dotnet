using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepArcRoutingControlConfigRegionAndRoutingControlsRoutingControl")]
    public class ArcregionswitchPlanWorkflowStepArcRoutingControlConfigRegionAndRoutingControlsRoutingControl : aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepArcRoutingControlConfigRegionAndRoutingControlsRoutingControl
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#routing_control_arn ArcregionswitchPlan#routing_control_arn}.</summary>
        [JsiiProperty(name: "routingControlArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoutingControlArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#state ArcregionswitchPlan#state}.</summary>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public string State
        {
            get;
            set;
        }
    }
}
