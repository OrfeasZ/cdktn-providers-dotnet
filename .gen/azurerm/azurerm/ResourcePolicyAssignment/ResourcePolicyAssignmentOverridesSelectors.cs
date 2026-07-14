using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourcePolicyAssignment
{
    [JsiiByValue(fqn: "azurerm.resourcePolicyAssignment.ResourcePolicyAssignmentOverridesSelectors")]
    public class ResourcePolicyAssignmentOverridesSelectors : azurerm.ResourcePolicyAssignment.IResourcePolicyAssignmentOverridesSelectors
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/resource_policy_assignment#in ResourcePolicyAssignment#in}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "in", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? In
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/resource_policy_assignment#kind ResourcePolicyAssignment#kind}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Kind
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/resource_policy_assignment#not_in ResourcePolicyAssignment#not_in}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notIn", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NotIn
        {
            get;
            set;
        }
    }
}
