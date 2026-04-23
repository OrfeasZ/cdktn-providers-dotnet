using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiInterface(nativeType: typeof(IArcregionswitchPlanWorkflowStepParallelConfigStepCustomActionLambdaConfigUngraceful), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepCustomActionLambdaConfigUngraceful")]
    public interface IArcregionswitchPlanWorkflowStepParallelConfigStepCustomActionLambdaConfigUngraceful
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#behavior ArcregionswitchPlan#behavior}.</summary>
        [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}")]
        string Behavior
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IArcregionswitchPlanWorkflowStepParallelConfigStepCustomActionLambdaConfigUngraceful), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepCustomActionLambdaConfigUngraceful")]
        internal sealed class _Proxy : DeputyBase, aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepCustomActionLambdaConfigUngraceful
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#behavior ArcregionswitchPlan#behavior}.</summary>
            [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}")]
            public string Behavior
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
