using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiInterface(nativeType: typeof(IArcregionswitchPlanWorkflow), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflow")]
    public interface IArcregionswitchPlanWorkflow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#workflow_target_action ArcregionswitchPlan#workflow_target_action}.</summary>
        [JsiiProperty(name: "workflowTargetAction", typeJson: "{\"primitive\":\"string\"}")]
        string WorkflowTargetAction
        {
            get;
        }

        /// <summary>step block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#step ArcregionswitchPlan#step}
        /// </remarks>
        [JsiiProperty(name: "step", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStep\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Step
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#workflow_description ArcregionswitchPlan#workflow_description}.</summary>
        [JsiiProperty(name: "workflowDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WorkflowDescription
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#workflow_target_region ArcregionswitchPlan#workflow_target_region}.</summary>
        [JsiiProperty(name: "workflowTargetRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WorkflowTargetRegion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IArcregionswitchPlanWorkflow), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflow")]
        internal sealed class _Proxy : DeputyBase, aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#workflow_target_action ArcregionswitchPlan#workflow_target_action}.</summary>
            [JsiiProperty(name: "workflowTargetAction", typeJson: "{\"primitive\":\"string\"}")]
            public string WorkflowTargetAction
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>step block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#step ArcregionswitchPlan#step}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "step", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStep\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Step
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#workflow_description ArcregionswitchPlan#workflow_description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "workflowDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WorkflowDescription
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#workflow_target_region ArcregionswitchPlan#workflow_target_region}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "workflowTargetRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WorkflowTargetRegion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
