using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.WorkitemtrackingprocessRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.workitemtrackingprocessRule.WorkitemtrackingprocessRuleCondition")]
    public class WorkitemtrackingprocessRuleCondition : azuredevops.WorkitemtrackingprocessRule.IWorkitemtrackingprocessRuleCondition
    {
        /// <summary>Type of condition.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/workitemtrackingprocess_rule#condition_type WorkitemtrackingprocessRule#condition_type}
        /// </remarks>
        [JsiiProperty(name: "conditionType", typeJson: "{\"primitive\":\"string\"}")]
        public string ConditionType
        {
            get;
            set;
        }

        /// <summary>Field reference name for the condition.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/workitemtrackingprocess_rule#field WorkitemtrackingprocessRule#field}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Field
        {
            get;
            set;
        }

        /// <summary>Value to match for the condition.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/workitemtrackingprocess_rule#value WorkitemtrackingprocessRule#value}
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
