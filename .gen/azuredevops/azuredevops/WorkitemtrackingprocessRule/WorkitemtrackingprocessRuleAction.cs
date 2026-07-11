using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.WorkitemtrackingprocessRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.workitemtrackingprocessRule.WorkitemtrackingprocessRuleAction")]
    public class WorkitemtrackingprocessRuleAction : azuredevops.WorkitemtrackingprocessRule.IWorkitemtrackingprocessRuleAction
    {
        /// <summary>Type of action.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_rule#action_type WorkitemtrackingprocessRule#action_type}
        /// </remarks>
        [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
        public string ActionType
        {
            get;
            set;
        }

        /// <summary>Field (reference name) to act on.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_rule#target_field WorkitemtrackingprocessRule#target_field}
        /// </remarks>
        [JsiiProperty(name: "targetField", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetField
        {
            get;
            set;
        }

        /// <summary>Value to set on the target field.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_rule#value WorkitemtrackingprocessRule#value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
