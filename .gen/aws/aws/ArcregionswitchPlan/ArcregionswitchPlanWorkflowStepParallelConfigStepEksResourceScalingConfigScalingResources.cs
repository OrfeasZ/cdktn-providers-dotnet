using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigScalingResources")]
    public class ArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigScalingResources : aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigScalingResources
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#namespace ArcregionswitchPlan#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public string Namespace
        {
            get;
            set;
        }

        private object? _resources;

        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#resources ArcregionswitchPlan#resources}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigScalingResourcesResources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Resources
        {
            get => _resources;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigScalingResourcesResources[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigScalingResourcesResources).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resources = value;
            }
        }
    }
}
