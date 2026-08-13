using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedLustreFileSystem
{
    [JsiiInterface(nativeType: typeof(IManagedLustreFileSystemConfig), fullyQualifiedName: "azurerm.managedLustreFileSystem.ManagedLustreFileSystemConfig")]
    public interface IManagedLustreFileSystemConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#location ManagedLustreFileSystem#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>maintenance_window block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#maintenance_window ManagedLustreFileSystem#maintenance_window}
        /// </remarks>
        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemMaintenanceWindow\"}")]
        azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemMaintenanceWindow MaintenanceWindow
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#name ManagedLustreFileSystem#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#resource_group_name ManagedLustreFileSystem#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#sku_name ManagedLustreFileSystem#sku_name}.</summary>
        [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}")]
        string SkuName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#storage_capacity_in_tb ManagedLustreFileSystem#storage_capacity_in_tb}.</summary>
        [JsiiProperty(name: "storageCapacityInTb", typeJson: "{\"primitive\":\"number\"}")]
        double StorageCapacityInTb
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#subnet_id ManagedLustreFileSystem#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#zones ManagedLustreFileSystem#zones}.</summary>
        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Zones
        {
            get;
        }

        /// <summary>encryption_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#encryption_key ManagedLustreFileSystem#encryption_key}
        /// </remarks>
        [JsiiProperty(name: "encryptionKey", typeJson: "{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemEncryptionKey\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemEncryptionKey? EncryptionKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>hsm_setting block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#hsm_setting ManagedLustreFileSystem#hsm_setting}
        /// </remarks>
        [JsiiProperty(name: "hsmSetting", typeJson: "{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemHsmSetting\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemHsmSetting? HsmSetting
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#id ManagedLustreFileSystem#id}.</summary>
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

        /// <summary>identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#identity ManagedLustreFileSystem#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemIdentity? Identity
        {
            get
            {
                return null;
            }
        }

        /// <summary>root_squash block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#root_squash ManagedLustreFileSystem#root_squash}
        /// </remarks>
        [JsiiProperty(name: "rootSquash", typeJson: "{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemRootSquash\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemRootSquash? RootSquash
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#tags ManagedLustreFileSystem#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#timeouts ManagedLustreFileSystem#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedLustreFileSystemConfig), fullyQualifiedName: "azurerm.managedLustreFileSystem.ManagedLustreFileSystemConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#location ManagedLustreFileSystem#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>maintenance_window block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#maintenance_window ManagedLustreFileSystem#maintenance_window}
            /// </remarks>
            [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemMaintenanceWindow\"}")]
            public azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemMaintenanceWindow MaintenanceWindow
            {
                get => GetInstanceProperty<azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemMaintenanceWindow>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#name ManagedLustreFileSystem#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#resource_group_name ManagedLustreFileSystem#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#sku_name ManagedLustreFileSystem#sku_name}.</summary>
            [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}")]
            public string SkuName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#storage_capacity_in_tb ManagedLustreFileSystem#storage_capacity_in_tb}.</summary>
            [JsiiProperty(name: "storageCapacityInTb", typeJson: "{\"primitive\":\"number\"}")]
            public double StorageCapacityInTb
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#subnet_id ManagedLustreFileSystem#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#zones ManagedLustreFileSystem#zones}.</summary>
            [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Zones
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>encryption_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#encryption_key ManagedLustreFileSystem#encryption_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionKey", typeJson: "{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemEncryptionKey\"}", isOptional: true)]
            public azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemEncryptionKey? EncryptionKey
            {
                get => GetInstanceProperty<azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemEncryptionKey?>();
            }

            /// <summary>hsm_setting block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#hsm_setting ManagedLustreFileSystem#hsm_setting}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hsmSetting", typeJson: "{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemHsmSetting\"}", isOptional: true)]
            public azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemHsmSetting? HsmSetting
            {
                get => GetInstanceProperty<azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemHsmSetting?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#id ManagedLustreFileSystem#id}.</summary>
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

            /// <summary>identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#identity ManagedLustreFileSystem#identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemIdentity\"}", isOptional: true)]
            public azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemIdentity? Identity
            {
                get => GetInstanceProperty<azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemIdentity?>();
            }

            /// <summary>root_squash block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#root_squash ManagedLustreFileSystem#root_squash}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rootSquash", typeJson: "{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemRootSquash\"}", isOptional: true)]
            public azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemRootSquash? RootSquash
            {
                get => GetInstanceProperty<azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemRootSquash?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#tags ManagedLustreFileSystem#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_lustre_file_system#timeouts ManagedLustreFileSystem#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.managedLustreFileSystem.ManagedLustreFileSystemTimeouts\"}", isOptional: true)]
            public azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemTimeouts?>();
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
