using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiInterface(nativeType: typeof(IArcregionswitchPlanWorkflowStepParallelConfigStepArcRoutingControlConfigRegionAndRoutingControlsRoutingControl), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepArcRoutingControlConfigRegionAndRoutingControlsRoutingControl")]
    public interface IArcregionswitchPlanWorkflowStepParallelConfigStepArcRoutingControlConfigRegionAndRoutingControlsRoutingControl
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#routing_control_arn ArcregionswitchPlan#routing_control_arn}.</summary>
        [JsiiProperty(name: "routingControlArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoutingControlArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#state ArcregionswitchPlan#state}.</summary>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        string State
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IArcregionswitchPlanWorkflowStepParallelConfigStepArcRoutingControlConfigRegionAndRoutingControlsRoutingControl), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepArcRoutingControlConfigRegionAndRoutingControlsRoutingControl")]
        internal sealed class _Proxy : DeputyBase, aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepArcRoutingControlConfigRegionAndRoutingControlsRoutingControl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#routing_control_arn ArcregionswitchPlan#routing_control_arn}.</summary>
            [JsiiProperty(name: "routingControlArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoutingControlArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#state ArcregionswitchPlan#state}.</summary>
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
            public string State
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
