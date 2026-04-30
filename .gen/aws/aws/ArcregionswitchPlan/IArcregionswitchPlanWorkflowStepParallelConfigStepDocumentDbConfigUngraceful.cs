using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiInterface(nativeType: typeof(IArcregionswitchPlanWorkflowStepParallelConfigStepDocumentDbConfigUngraceful), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepDocumentDbConfigUngraceful")]
    public interface IArcregionswitchPlanWorkflowStepParallelConfigStepDocumentDbConfigUngraceful
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#ungraceful ArcregionswitchPlan#ungraceful}.</summary>
        [JsiiProperty(name: "ungraceful", typeJson: "{\"primitive\":\"string\"}")]
        string Ungraceful
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IArcregionswitchPlanWorkflowStepParallelConfigStepDocumentDbConfigUngraceful), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepDocumentDbConfigUngraceful")]
        internal sealed class _Proxy : DeputyBase, aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepDocumentDbConfigUngraceful
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
