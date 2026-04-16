using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiInterface(nativeType: typeof(IArcregionswitchPlanWorkflowStepEksResourceScalingConfigUngraceful), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEksResourceScalingConfigUngraceful")]
    public interface IArcregionswitchPlanWorkflowStepEksResourceScalingConfigUngraceful
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#minimum_success_percentage ArcregionswitchPlan#minimum_success_percentage}.</summary>
        [JsiiProperty(name: "minimumSuccessPercentage", typeJson: "{\"primitive\":\"number\"}")]
        double MinimumSuccessPercentage
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IArcregionswitchPlanWorkflowStepEksResourceScalingConfigUngraceful), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEksResourceScalingConfigUngraceful")]
        internal sealed class _Proxy : DeputyBase, aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepEksResourceScalingConfigUngraceful
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#minimum_success_percentage ArcregionswitchPlan#minimum_success_percentage}.</summary>
            [JsiiProperty(name: "minimumSuccessPercentage", typeJson: "{\"primitive\":\"number\"}")]
            public double MinimumSuccessPercentage
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
