using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiInterface(nativeType: typeof(IArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigKubernetesResourceType), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigKubernetesResourceType")]
    public interface IArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigKubernetesResourceType
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#api_version ArcregionswitchPlan#api_version}.</summary>
        [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}")]
        string ApiVersion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#kind ArcregionswitchPlan#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        string Kind
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigKubernetesResourceType), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigKubernetesResourceType")]
        internal sealed class _Proxy : DeputyBase, aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigKubernetesResourceType
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#api_version ArcregionswitchPlan#api_version}.</summary>
            [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#kind ArcregionswitchPlan#kind}.</summary>
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
            public string Kind
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
