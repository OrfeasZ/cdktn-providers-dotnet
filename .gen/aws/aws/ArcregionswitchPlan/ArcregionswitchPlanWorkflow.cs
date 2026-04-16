using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflow")]
    public class ArcregionswitchPlanWorkflow : aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#workflow_target_action ArcregionswitchPlan#workflow_target_action}.</summary>
        [JsiiProperty(name: "workflowTargetAction", typeJson: "{\"primitive\":\"string\"}")]
        public string WorkflowTargetAction
        {
            get;
            set;
        }

        private object? _step;

        /// <summary>step block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#step ArcregionswitchPlan#step}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "step", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStep\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Step
        {
            get => _step;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStep[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStep).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _step = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#workflow_description ArcregionswitchPlan#workflow_description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "workflowDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WorkflowDescription
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#workflow_target_region ArcregionswitchPlan#workflow_target_region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "workflowTargetRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WorkflowTargetRegion
        {
            get;
            set;
        }
    }
}
