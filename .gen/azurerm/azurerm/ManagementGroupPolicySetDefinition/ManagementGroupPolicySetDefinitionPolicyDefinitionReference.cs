using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagementGroupPolicySetDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.managementGroupPolicySetDefinition.ManagementGroupPolicySetDefinitionPolicyDefinitionReference")]
    public class ManagementGroupPolicySetDefinitionPolicyDefinitionReference : azurerm.ManagementGroupPolicySetDefinition.IManagementGroupPolicySetDefinitionPolicyDefinitionReference
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/management_group_policy_set_definition#policy_definition_id ManagementGroupPolicySetDefinition#policy_definition_id}.</summary>
        [JsiiProperty(name: "policyDefinitionId", typeJson: "{\"primitive\":\"string\"}")]
        public string PolicyDefinitionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/management_group_policy_set_definition#parameter_values ManagementGroupPolicySetDefinition#parameter_values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parameterValues", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ParameterValues
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/management_group_policy_set_definition#policy_group_names ManagementGroupPolicySetDefinition#policy_group_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "policyGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PolicyGroupNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/management_group_policy_set_definition#reference_id ManagementGroupPolicySetDefinition#reference_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "referenceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReferenceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/management_group_policy_set_definition#version ManagementGroupPolicySetDefinition#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
