using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagementGroupPolicySetDefinition
{
    [JsiiInterface(nativeType: typeof(IManagementGroupPolicySetDefinitionPolicyDefinitionGroup), fullyQualifiedName: "azurerm.managementGroupPolicySetDefinition.ManagementGroupPolicySetDefinitionPolicyDefinitionGroup")]
    public interface IManagementGroupPolicySetDefinitionPolicyDefinitionGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/management_group_policy_set_definition#name ManagementGroupPolicySetDefinition#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/management_group_policy_set_definition#additional_metadata_resource_id ManagementGroupPolicySetDefinition#additional_metadata_resource_id}.</summary>
        [JsiiProperty(name: "additionalMetadataResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdditionalMetadataResourceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/management_group_policy_set_definition#category ManagementGroupPolicySetDefinition#category}.</summary>
        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Category
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/management_group_policy_set_definition#description ManagementGroupPolicySetDefinition#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/management_group_policy_set_definition#display_name ManagementGroupPolicySetDefinition#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagementGroupPolicySetDefinitionPolicyDefinitionGroup), fullyQualifiedName: "azurerm.managementGroupPolicySetDefinition.ManagementGroupPolicySetDefinitionPolicyDefinitionGroup")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagementGroupPolicySetDefinition.IManagementGroupPolicySetDefinitionPolicyDefinitionGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/management_group_policy_set_definition#name ManagementGroupPolicySetDefinition#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/management_group_policy_set_definition#additional_metadata_resource_id ManagementGroupPolicySetDefinition#additional_metadata_resource_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "additionalMetadataResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdditionalMetadataResourceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/management_group_policy_set_definition#category ManagementGroupPolicySetDefinition#category}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Category
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/management_group_policy_set_definition#description ManagementGroupPolicySetDefinition#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/management_group_policy_set_definition#display_name ManagementGroupPolicySetDefinition#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
