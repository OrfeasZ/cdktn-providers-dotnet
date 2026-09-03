using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineScaleSetConfig), fullyQualifiedName: "azurerm.virtualMachineScaleSet.VirtualMachineScaleSetConfig")]
    public interface IVirtualMachineScaleSetConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#location VirtualMachineScaleSet#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#name VirtualMachineScaleSet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>network_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#network_profile VirtualMachineScaleSet#network_profile}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetNetworkProfile" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "networkProfile", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetNetworkProfile\"},\"kind\":\"array\"}}]}}")]
        object NetworkProfile
        {
            get;
        }

        /// <summary>os_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#os_profile VirtualMachineScaleSet#os_profile}
        /// </remarks>
        [JsiiProperty(name: "osProfile", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfile\"}")]
        azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfile OsProfile
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#resource_group_name VirtualMachineScaleSet#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>sku block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#sku VirtualMachineScaleSet#sku}
        /// </remarks>
        [JsiiProperty(name: "sku", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetSku\"}")]
        azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetSku Sku
        {
            get;
        }

        /// <summary>storage_profile_os_disk block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#storage_profile_os_disk VirtualMachineScaleSet#storage_profile_os_disk}
        /// </remarks>
        [JsiiProperty(name: "storageProfileOsDisk", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileOsDisk\"}")]
        azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileOsDisk StorageProfileOsDisk
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#upgrade_policy_mode VirtualMachineScaleSet#upgrade_policy_mode}.</summary>
        [JsiiProperty(name: "upgradePolicyMode", typeJson: "{\"primitive\":\"string\"}")]
        string UpgradePolicyMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#automatic_os_upgrade VirtualMachineScaleSet#automatic_os_upgrade}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "automaticOsUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutomaticOsUpgrade
        {
            get
            {
                return null;
            }
        }

        /// <summary>boot_diagnostics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#boot_diagnostics VirtualMachineScaleSet#boot_diagnostics}
        /// </remarks>
        [JsiiProperty(name: "bootDiagnostics", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetBootDiagnostics\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetBootDiagnostics? BootDiagnostics
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#eviction_policy VirtualMachineScaleSet#eviction_policy}.</summary>
        [JsiiProperty(name: "evictionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EvictionPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>extension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#extension VirtualMachineScaleSet#extension}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetExtension" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "extension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetExtension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Extension
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#health_probe_id VirtualMachineScaleSet#health_probe_id}.</summary>
        [JsiiProperty(name: "healthProbeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HealthProbeId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#id VirtualMachineScaleSet#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#identity VirtualMachineScaleSet#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetIdentity? Identity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#license_type VirtualMachineScaleSet#license_type}.</summary>
        [JsiiProperty(name: "licenseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LicenseType
        {
            get
            {
                return null;
            }
        }

        /// <summary>os_profile_linux_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#os_profile_linux_config VirtualMachineScaleSet#os_profile_linux_config}
        /// </remarks>
        [JsiiProperty(name: "osProfileLinuxConfig", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileLinuxConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileLinuxConfig? OsProfileLinuxConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>os_profile_secrets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#os_profile_secrets VirtualMachineScaleSet#os_profile_secrets}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileSecrets" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "osProfileSecrets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileSecrets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OsProfileSecrets
        {
            get
            {
                return null;
            }
        }

        /// <summary>os_profile_windows_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#os_profile_windows_config VirtualMachineScaleSet#os_profile_windows_config}
        /// </remarks>
        [JsiiProperty(name: "osProfileWindowsConfig", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileWindowsConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileWindowsConfig? OsProfileWindowsConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#overprovision VirtualMachineScaleSet#overprovision}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "overprovision", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Overprovision
        {
            get
            {
                return null;
            }
        }

        /// <summary>plan block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#plan VirtualMachineScaleSet#plan}
        /// </remarks>
        [JsiiProperty(name: "plan", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetPlan\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetPlan? Plan
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#priority VirtualMachineScaleSet#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#proximity_placement_group_id VirtualMachineScaleSet#proximity_placement_group_id}.</summary>
        [JsiiProperty(name: "proximityPlacementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProximityPlacementGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>rolling_upgrade_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#rolling_upgrade_policy VirtualMachineScaleSet#rolling_upgrade_policy}
        /// </remarks>
        [JsiiProperty(name: "rollingUpgradePolicy", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetRollingUpgradePolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetRollingUpgradePolicy? RollingUpgradePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#single_placement_group VirtualMachineScaleSet#single_placement_group}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "singlePlacementGroup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SinglePlacementGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_profile_data_disk block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#storage_profile_data_disk VirtualMachineScaleSet#storage_profile_data_disk}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileDataDisk" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "storageProfileDataDisk", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileDataDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StorageProfileDataDisk
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_profile_image_reference block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#storage_profile_image_reference VirtualMachineScaleSet#storage_profile_image_reference}
        /// </remarks>
        [JsiiProperty(name: "storageProfileImageReference", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileImageReference\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileImageReference? StorageProfileImageReference
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#tags VirtualMachineScaleSet#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#timeouts VirtualMachineScaleSet#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#zones VirtualMachineScaleSet#zones}.</summary>
        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Zones
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineScaleSetConfig), fullyQualifiedName: "azurerm.virtualMachineScaleSet.VirtualMachineScaleSetConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#location VirtualMachineScaleSet#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#name VirtualMachineScaleSet#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>network_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#network_profile VirtualMachineScaleSet#network_profile}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetNetworkProfile" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "networkProfile", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetNetworkProfile\"},\"kind\":\"array\"}}]}}")]
            public object NetworkProfile
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>os_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#os_profile VirtualMachineScaleSet#os_profile}
            /// </remarks>
            [JsiiProperty(name: "osProfile", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfile\"}")]
            public azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfile OsProfile
            {
                get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfile>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#resource_group_name VirtualMachineScaleSet#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>sku block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#sku VirtualMachineScaleSet#sku}
            /// </remarks>
            [JsiiProperty(name: "sku", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetSku\"}")]
            public azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetSku Sku
            {
                get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetSku>()!;
            }

            /// <summary>storage_profile_os_disk block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#storage_profile_os_disk VirtualMachineScaleSet#storage_profile_os_disk}
            /// </remarks>
            [JsiiProperty(name: "storageProfileOsDisk", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileOsDisk\"}")]
            public azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileOsDisk StorageProfileOsDisk
            {
                get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileOsDisk>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#upgrade_policy_mode VirtualMachineScaleSet#upgrade_policy_mode}.</summary>
            [JsiiProperty(name: "upgradePolicyMode", typeJson: "{\"primitive\":\"string\"}")]
            public string UpgradePolicyMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#automatic_os_upgrade VirtualMachineScaleSet#automatic_os_upgrade}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "automaticOsUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AutomaticOsUpgrade
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>boot_diagnostics block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#boot_diagnostics VirtualMachineScaleSet#boot_diagnostics}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bootDiagnostics", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetBootDiagnostics\"}", isOptional: true)]
            public azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetBootDiagnostics? BootDiagnostics
            {
                get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetBootDiagnostics?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#eviction_policy VirtualMachineScaleSet#eviction_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "evictionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EvictionPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>extension block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#extension VirtualMachineScaleSet#extension}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetExtension" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "extension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetExtension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Extension
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#health_probe_id VirtualMachineScaleSet#health_probe_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "healthProbeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HealthProbeId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#id VirtualMachineScaleSet#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#identity VirtualMachineScaleSet#identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetIdentity\"}", isOptional: true)]
            public azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetIdentity? Identity
            {
                get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetIdentity?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#license_type VirtualMachineScaleSet#license_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "licenseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LicenseType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>os_profile_linux_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#os_profile_linux_config VirtualMachineScaleSet#os_profile_linux_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "osProfileLinuxConfig", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileLinuxConfig\"}", isOptional: true)]
            public azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileLinuxConfig? OsProfileLinuxConfig
            {
                get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileLinuxConfig?>();
            }

            /// <summary>os_profile_secrets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#os_profile_secrets VirtualMachineScaleSet#os_profile_secrets}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileSecrets" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "osProfileSecrets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileSecrets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OsProfileSecrets
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>os_profile_windows_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#os_profile_windows_config VirtualMachineScaleSet#os_profile_windows_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "osProfileWindowsConfig", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileWindowsConfig\"}", isOptional: true)]
            public azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileWindowsConfig? OsProfileWindowsConfig
            {
                get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileWindowsConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#overprovision VirtualMachineScaleSet#overprovision}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "overprovision", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Overprovision
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>plan block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#plan VirtualMachineScaleSet#plan}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "plan", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetPlan\"}", isOptional: true)]
            public azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetPlan? Plan
            {
                get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetPlan?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#priority VirtualMachineScaleSet#priority}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Priority
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#proximity_placement_group_id VirtualMachineScaleSet#proximity_placement_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "proximityPlacementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProximityPlacementGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>rolling_upgrade_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#rolling_upgrade_policy VirtualMachineScaleSet#rolling_upgrade_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rollingUpgradePolicy", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetRollingUpgradePolicy\"}", isOptional: true)]
            public azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetRollingUpgradePolicy? RollingUpgradePolicy
            {
                get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetRollingUpgradePolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#single_placement_group VirtualMachineScaleSet#single_placement_group}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "singlePlacementGroup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SinglePlacementGroup
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>storage_profile_data_disk block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#storage_profile_data_disk VirtualMachineScaleSet#storage_profile_data_disk}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileDataDisk" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageProfileDataDisk", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileDataDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StorageProfileDataDisk
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>storage_profile_image_reference block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#storage_profile_image_reference VirtualMachineScaleSet#storage_profile_image_reference}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageProfileImageReference", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileImageReference\"}", isOptional: true)]
            public azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileImageReference? StorageProfileImageReference
            {
                get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileImageReference?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#tags VirtualMachineScaleSet#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#timeouts VirtualMachineScaleSet#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetTimeouts\"}", isOptional: true)]
            public azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set#zones VirtualMachineScaleSet#zones}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Zones
            {
                get => GetInstanceProperty<string[]?>();
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
