using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiInterface(nativeType: typeof(IArcregionswitchPlanWorkflowStepEksResourceScalingConfigScalingResourcesResources), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEksResourceScalingConfigScalingResourcesResources")]
    public interface IArcregionswitchPlanWorkflowStepEksResourceScalingConfigScalingResourcesResources
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#name ArcregionswitchPlan#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#namespace ArcregionswitchPlan#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#resource_name ArcregionswitchPlan#resource_name}.</summary>
        [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#hpa_name ArcregionswitchPlan#hpa_name}.</summary>
        [JsiiProperty(name: "hpaName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HpaName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IArcregionswitchPlanWorkflowStepEksResourceScalingConfigScalingResourcesResources), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEksResourceScalingConfigScalingResourcesResources")]
        internal sealed class _Proxy : DeputyBase, aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepEksResourceScalingConfigScalingResourcesResources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#name ArcregionswitchPlan#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#namespace ArcregionswitchPlan#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#resource_name ArcregionswitchPlan#resource_name}.</summary>
            [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#hpa_name ArcregionswitchPlan#hpa_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hpaName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HpaName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
