using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DatabricksWorkspace
{
    [JsiiInterface(nativeType: typeof(IDatabricksWorkspaceConfig), fullyQualifiedName: "azurerm.databricksWorkspace.DatabricksWorkspaceConfig")]
    public interface IDatabricksWorkspaceConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#location DatabricksWorkspace#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#name DatabricksWorkspace#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#resource_group_name DatabricksWorkspace#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#sku DatabricksWorkspace#sku}.</summary>
        [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
        string Sku
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#access_connector_id DatabricksWorkspace#access_connector_id}.</summary>
        [JsiiProperty(name: "accessConnectorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessConnectorId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#customer_managed_key_enabled DatabricksWorkspace#customer_managed_key_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "customerManagedKeyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomerManagedKeyEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#custom_parameters DatabricksWorkspace#custom_parameters}
        /// </remarks>
        [JsiiProperty(name: "customParameters", typeJson: "{\"fqn\":\"azurerm.databricksWorkspace.DatabricksWorkspaceCustomParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DatabricksWorkspace.IDatabricksWorkspaceCustomParameters? CustomParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#default_storage_firewall_enabled DatabricksWorkspace#default_storage_firewall_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "defaultStorageFirewallEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DefaultStorageFirewallEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>enhanced_security_compliance block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#enhanced_security_compliance DatabricksWorkspace#enhanced_security_compliance}
        /// </remarks>
        [JsiiProperty(name: "enhancedSecurityCompliance", typeJson: "{\"fqn\":\"azurerm.databricksWorkspace.DatabricksWorkspaceEnhancedSecurityCompliance\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DatabricksWorkspace.IDatabricksWorkspaceEnhancedSecurityCompliance? EnhancedSecurityCompliance
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#id DatabricksWorkspace#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#infrastructure_encryption_enabled DatabricksWorkspace#infrastructure_encryption_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "infrastructureEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InfrastructureEncryptionEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#load_balancer_backend_address_pool_id DatabricksWorkspace#load_balancer_backend_address_pool_id}.</summary>
        [JsiiProperty(name: "loadBalancerBackendAddressPoolId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LoadBalancerBackendAddressPoolId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#managed_disk_cmk_key_vault_id DatabricksWorkspace#managed_disk_cmk_key_vault_id}.</summary>
        [JsiiProperty(name: "managedDiskCmkKeyVaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagedDiskCmkKeyVaultId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#managed_disk_cmk_key_vault_key_id DatabricksWorkspace#managed_disk_cmk_key_vault_key_id}.</summary>
        [JsiiProperty(name: "managedDiskCmkKeyVaultKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagedDiskCmkKeyVaultKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#managed_disk_cmk_rotation_to_latest_version_enabled DatabricksWorkspace#managed_disk_cmk_rotation_to_latest_version_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "managedDiskCmkRotationToLatestVersionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ManagedDiskCmkRotationToLatestVersionEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#managed_resource_group_name DatabricksWorkspace#managed_resource_group_name}.</summary>
        [JsiiProperty(name: "managedResourceGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagedResourceGroupName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#managed_services_cmk_key_vault_id DatabricksWorkspace#managed_services_cmk_key_vault_id}.</summary>
        [JsiiProperty(name: "managedServicesCmkKeyVaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagedServicesCmkKeyVaultId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#managed_services_cmk_key_vault_key_id DatabricksWorkspace#managed_services_cmk_key_vault_key_id}.</summary>
        [JsiiProperty(name: "managedServicesCmkKeyVaultKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagedServicesCmkKeyVaultKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#network_security_group_rules_required DatabricksWorkspace#network_security_group_rules_required}.</summary>
        [JsiiProperty(name: "networkSecurityGroupRulesRequired", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetworkSecurityGroupRulesRequired
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#public_network_access_enabled DatabricksWorkspace#public_network_access_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PublicNetworkAccessEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#tags DatabricksWorkspace#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#timeouts DatabricksWorkspace#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.databricksWorkspace.DatabricksWorkspaceTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DatabricksWorkspace.IDatabricksWorkspaceTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabricksWorkspaceConfig), fullyQualifiedName: "azurerm.databricksWorkspace.DatabricksWorkspaceConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.DatabricksWorkspace.IDatabricksWorkspaceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#location DatabricksWorkspace#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#name DatabricksWorkspace#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#resource_group_name DatabricksWorkspace#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#sku DatabricksWorkspace#sku}.</summary>
            [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
            public string Sku
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#access_connector_id DatabricksWorkspace#access_connector_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessConnectorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessConnectorId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#customer_managed_key_enabled DatabricksWorkspace#customer_managed_key_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customerManagedKeyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CustomerManagedKeyEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>custom_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#custom_parameters DatabricksWorkspace#custom_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customParameters", typeJson: "{\"fqn\":\"azurerm.databricksWorkspace.DatabricksWorkspaceCustomParameters\"}", isOptional: true)]
            public azurerm.DatabricksWorkspace.IDatabricksWorkspaceCustomParameters? CustomParameters
            {
                get => GetInstanceProperty<azurerm.DatabricksWorkspace.IDatabricksWorkspaceCustomParameters?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#default_storage_firewall_enabled DatabricksWorkspace#default_storage_firewall_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultStorageFirewallEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DefaultStorageFirewallEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>enhanced_security_compliance block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#enhanced_security_compliance DatabricksWorkspace#enhanced_security_compliance}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enhancedSecurityCompliance", typeJson: "{\"fqn\":\"azurerm.databricksWorkspace.DatabricksWorkspaceEnhancedSecurityCompliance\"}", isOptional: true)]
            public azurerm.DatabricksWorkspace.IDatabricksWorkspaceEnhancedSecurityCompliance? EnhancedSecurityCompliance
            {
                get => GetInstanceProperty<azurerm.DatabricksWorkspace.IDatabricksWorkspaceEnhancedSecurityCompliance?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#id DatabricksWorkspace#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#infrastructure_encryption_enabled DatabricksWorkspace#infrastructure_encryption_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "infrastructureEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? InfrastructureEncryptionEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#load_balancer_backend_address_pool_id DatabricksWorkspace#load_balancer_backend_address_pool_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancerBackendAddressPoolId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LoadBalancerBackendAddressPoolId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#managed_disk_cmk_key_vault_id DatabricksWorkspace#managed_disk_cmk_key_vault_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managedDiskCmkKeyVaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagedDiskCmkKeyVaultId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#managed_disk_cmk_key_vault_key_id DatabricksWorkspace#managed_disk_cmk_key_vault_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managedDiskCmkKeyVaultKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagedDiskCmkKeyVaultKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#managed_disk_cmk_rotation_to_latest_version_enabled DatabricksWorkspace#managed_disk_cmk_rotation_to_latest_version_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managedDiskCmkRotationToLatestVersionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ManagedDiskCmkRotationToLatestVersionEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#managed_resource_group_name DatabricksWorkspace#managed_resource_group_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managedResourceGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagedResourceGroupName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#managed_services_cmk_key_vault_id DatabricksWorkspace#managed_services_cmk_key_vault_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managedServicesCmkKeyVaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagedServicesCmkKeyVaultId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#managed_services_cmk_key_vault_key_id DatabricksWorkspace#managed_services_cmk_key_vault_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managedServicesCmkKeyVaultKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagedServicesCmkKeyVaultKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#network_security_group_rules_required DatabricksWorkspace#network_security_group_rules_required}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkSecurityGroupRulesRequired", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetworkSecurityGroupRulesRequired
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#public_network_access_enabled DatabricksWorkspace#public_network_access_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PublicNetworkAccessEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#tags DatabricksWorkspace#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/databricks_workspace#timeouts DatabricksWorkspace#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.databricksWorkspace.DatabricksWorkspaceTimeouts\"}", isOptional: true)]
            public azurerm.DatabricksWorkspace.IDatabricksWorkspaceTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.DatabricksWorkspace.IDatabricksWorkspaceTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
