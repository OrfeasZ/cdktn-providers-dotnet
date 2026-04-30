using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiInterface(nativeType: typeof(IArcregionswitchPlanWorkflowStepGlobalAuroraConfigUngraceful), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepGlobalAuroraConfigUngraceful")]
    public interface IArcregionswitchPlanWorkflowStepGlobalAuroraConfigUngraceful
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#ungraceful ArcregionswitchPlan#ungraceful}.</summary>
        [JsiiProperty(name: "ungraceful", typeJson: "{\"primitive\":\"string\"}")]
        string Ungraceful
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IArcregionswitchPlanWorkflowStepGlobalAuroraConfigUngraceful), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepGlobalAuroraConfigUngraceful")]
        internal sealed class _Proxy : DeputyBase, aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepGlobalAuroraConfigUngraceful
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#ungraceful ArcregionswitchPlan#ungraceful}.</summary>
            [JsiiProperty(name: "ungraceful", typeJson: "{\"primitive\":\"string\"}")]
            public string Ungraceful
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
