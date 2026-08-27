using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagementGroupPolicySetDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.managementGroupPolicySetDefinition.ManagementGroupPolicySetDefinitionPolicyDefinitionGroup")]
    public class ManagementGroupPolicySetDefinitionPolicyDefinitionGroup : azurerm.ManagementGroupPolicySetDefinition.IManagementGroupPolicySetDefinitionPolicyDefinitionGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/management_group_policy_set_definition#name ManagementGroupPolicySetDefinition#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/management_group_policy_set_definition#additional_metadata_resource_id ManagementGroupPolicySetDefinition#additional_metadata_resource_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "additionalMetadataResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdditionalMetadataResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/management_group_policy_set_definition#category ManagementGroupPolicySetDefinition#category}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Category
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/management_group_policy_set_definition#description ManagementGroupPolicySetDefinition#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/management_group_policy_set_definition#display_name ManagementGroupPolicySetDefinition#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }
    }
}
