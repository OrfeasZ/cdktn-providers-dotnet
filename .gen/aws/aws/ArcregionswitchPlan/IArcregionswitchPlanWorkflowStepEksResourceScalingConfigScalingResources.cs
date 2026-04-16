using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiInterface(nativeType: typeof(IArcregionswitchPlanWorkflowStepEksResourceScalingConfigScalingResources), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEksResourceScalingConfigScalingResources")]
    public interface IArcregionswitchPlanWorkflowStepEksResourceScalingConfigScalingResources
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#namespace ArcregionswitchPlan#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#resources ArcregionswitchPlan#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEksResourceScalingConfigScalingResourcesResources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Resources
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IArcregionswitchPlanWorkflowStepEksResourceScalingConfigScalingResources), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEksResourceScalingConfigScalingResources")]
        internal sealed class _Proxy : DeputyBase, aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepEksResourceScalingConfigScalingResources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#namespace ArcregionswitchPlan#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>resources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#resources ArcregionswitchPlan#resources}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEksResourceScalingConfigScalingResourcesResources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Resources
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
