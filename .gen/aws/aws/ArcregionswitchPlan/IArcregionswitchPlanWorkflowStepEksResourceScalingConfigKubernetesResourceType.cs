using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiInterface(nativeType: typeof(IArcregionswitchPlanWorkflowStepEksResourceScalingConfigKubernetesResourceType), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEksResourceScalingConfigKubernetesResourceType")]
    public interface IArcregionswitchPlanWorkflowStepEksResourceScalingConfigKubernetesResourceType
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#api_version ArcregionswitchPlan#api_version}.</summary>
        [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}")]
        string ApiVersion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#kind ArcregionswitchPlan#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        string Kind
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IArcregionswitchPlanWorkflowStepEksResourceScalingConfigKubernetesResourceType), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEksResourceScalingConfigKubernetesResourceType")]
        internal sealed class _Proxy : DeputyBase, aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepEksResourceScalingConfigKubernetesResourceType
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#api_version ArcregionswitchPlan#api_version}.</summary>
            [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#kind ArcregionswitchPlan#kind}.</summary>
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
            public string Kind
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
