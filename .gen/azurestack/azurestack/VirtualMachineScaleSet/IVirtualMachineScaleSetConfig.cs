using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineScaleSetConfig), fullyQualifiedName: "azurestack.virtualMachineScaleSet.VirtualMachineScaleSetConfig")]
    public interface IVirtualMachineScaleSetConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#location VirtualMachineScaleSet#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#name VirtualMachineScaleSet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>network_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#network_profile VirtualMachineScaleSet#network_profile}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetNetworkProfile" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "networkProfile", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetNetworkProfile\"},\"kind\":\"array\"}}]}}")]
        object NetworkProfile
        {
            get;
        }

        /// <summary>os_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#os_profile VirtualMachineScaleSet#os_profile}
        /// </remarks>
        [JsiiProperty(name: "osProfile", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfile\"}")]
        azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfile OsProfile
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#resource_group_name VirtualMachineScaleSet#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>sku block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#sku VirtualMachineScaleSet#sku}
        /// </remarks>
        [JsiiProperty(name: "sku", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetSku\"}")]
        azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetSku Sku
        {
            get;
        }

        /// <summary>storage_profile_os_disk block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#storage_profile_os_disk VirtualMachineScaleSet#storage_profile_os_disk}
        /// </remarks>
        [JsiiProperty(name: "storageProfileOsDisk", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileOsDisk\"}")]
        azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileOsDisk StorageProfileOsDisk
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#upgrade_policy_mode VirtualMachineScaleSet#upgrade_policy_mode}.</summary>
        [JsiiProperty(name: "upgradePolicyMode", typeJson: "{\"primitive\":\"string\"}")]
        string UpgradePolicyMode
        {
            get;
        }

        /// <summary>boot_diagnostics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#boot_diagnostics VirtualMachineScaleSet#boot_diagnostics}
        /// </remarks>
        [JsiiProperty(name: "bootDiagnostics", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetBootDiagnostics\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetBootDiagnostics? BootDiagnostics
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#eviction_policy VirtualMachineScaleSet#eviction_policy}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#extension VirtualMachineScaleSet#extension}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetExtension" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "extension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetExtension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Extension
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#health_probe_id VirtualMachineScaleSet#health_probe_id}.</summary>
        [JsiiProperty(name: "healthProbeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HealthProbeId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#id VirtualMachineScaleSet#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#identity VirtualMachineScaleSet#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetIdentity? Identity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#license_type VirtualMachineScaleSet#license_type}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#os_profile_linux_config VirtualMachineScaleSet#os_profile_linux_config}
        /// </remarks>
        [JsiiProperty(name: "osProfileLinuxConfig", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileLinuxConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileLinuxConfig? OsProfileLinuxConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>os_profile_secrets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#os_profile_secrets VirtualMachineScaleSet#os_profile_secrets}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileSecrets" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "osProfileSecrets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileSecrets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#os_profile_windows_config VirtualMachineScaleSet#os_profile_windows_config}
        /// </remarks>
        [JsiiProperty(name: "osProfileWindowsConfig", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileWindowsConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileWindowsConfig? OsProfileWindowsConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#overprovision VirtualMachineScaleSet#overprovision}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#plan VirtualMachineScaleSet#plan}
        /// </remarks>
        [JsiiProperty(name: "plan", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetPlan\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetPlan? Plan
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#priority VirtualMachineScaleSet#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>rolling_upgrade_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#rolling_upgrade_policy VirtualMachineScaleSet#rolling_upgrade_policy}
        /// </remarks>
        [JsiiProperty(name: "rollingUpgradePolicy", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetRollingUpgradePolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetRollingUpgradePolicy? RollingUpgradePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#single_placement_group VirtualMachineScaleSet#single_placement_group}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#storage_profile_data_disk VirtualMachineScaleSet#storage_profile_data_disk}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileDataDisk" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "storageProfileDataDisk", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileDataDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#storage_profile_image_reference VirtualMachineScaleSet#storage_profile_image_reference}
        /// </remarks>
        [JsiiProperty(name: "storageProfileImageReference", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileImageReference\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileImageReference? StorageProfileImageReference
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#tags VirtualMachineScaleSet#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#timeouts VirtualMachineScaleSet#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#zones VirtualMachineScaleSet#zones}.</summary>
        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Zones
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineScaleSetConfig), fullyQualifiedName: "azurestack.virtualMachineScaleSet.VirtualMachineScaleSetConfig")]
        internal sealed class _Proxy : DeputyBase, azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#location VirtualMachineScaleSet#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#name VirtualMachineScaleSet#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>network_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#network_profile VirtualMachineScaleSet#network_profile}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetNetworkProfile" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "networkProfile", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetNetworkProfile\"},\"kind\":\"array\"}}]}}")]
            public object NetworkProfile
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>os_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#os_profile VirtualMachineScaleSet#os_profile}
            /// </remarks>
            [JsiiProperty(name: "osProfile", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfile\"}")]
            public azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfile OsProfile
            {
                get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfile>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#resource_group_name VirtualMachineScaleSet#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>sku block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#sku VirtualMachineScaleSet#sku}
            /// </remarks>
            [JsiiProperty(name: "sku", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetSku\"}")]
            public azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetSku Sku
            {
                get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetSku>()!;
            }

            /// <summary>storage_profile_os_disk block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#storage_profile_os_disk VirtualMachineScaleSet#storage_profile_os_disk}
            /// </remarks>
            [JsiiProperty(name: "storageProfileOsDisk", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileOsDisk\"}")]
            public azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileOsDisk StorageProfileOsDisk
            {
                get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileOsDisk>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#upgrade_policy_mode VirtualMachineScaleSet#upgrade_policy_mode}.</summary>
            [JsiiProperty(name: "upgradePolicyMode", typeJson: "{\"primitive\":\"string\"}")]
            public string UpgradePolicyMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>boot_diagnostics block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#boot_diagnostics VirtualMachineScaleSet#boot_diagnostics}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bootDiagnostics", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetBootDiagnostics\"}", isOptional: true)]
            public azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetBootDiagnostics? BootDiagnostics
            {
                get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetBootDiagnostics?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#eviction_policy VirtualMachineScaleSet#eviction_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "evictionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EvictionPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>extension block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#extension VirtualMachineScaleSet#extension}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetExtension" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "extension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetExtension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Extension
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#health_probe_id VirtualMachineScaleSet#health_probe_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "healthProbeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HealthProbeId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#id VirtualMachineScaleSet#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#identity VirtualMachineScaleSet#identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetIdentity\"}", isOptional: true)]
            public azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetIdentity? Identity
            {
                get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetIdentity?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#license_type VirtualMachineScaleSet#license_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "licenseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LicenseType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>os_profile_linux_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#os_profile_linux_config VirtualMachineScaleSet#os_profile_linux_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "osProfileLinuxConfig", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileLinuxConfig\"}", isOptional: true)]
            public azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileLinuxConfig? OsProfileLinuxConfig
            {
                get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileLinuxConfig?>();
            }

            /// <summary>os_profile_secrets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#os_profile_secrets VirtualMachineScaleSet#os_profile_secrets}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileSecrets" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "osProfileSecrets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileSecrets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OsProfileSecrets
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>os_profile_windows_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#os_profile_windows_config VirtualMachineScaleSet#os_profile_windows_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "osProfileWindowsConfig", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileWindowsConfig\"}", isOptional: true)]
            public azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileWindowsConfig? OsProfileWindowsConfig
            {
                get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileWindowsConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#overprovision VirtualMachineScaleSet#overprovision}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#plan VirtualMachineScaleSet#plan}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "plan", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetPlan\"}", isOptional: true)]
            public azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetPlan? Plan
            {
                get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetPlan?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#priority VirtualMachineScaleSet#priority}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Priority
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>rolling_upgrade_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#rolling_upgrade_policy VirtualMachineScaleSet#rolling_upgrade_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rollingUpgradePolicy", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetRollingUpgradePolicy\"}", isOptional: true)]
            public azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetRollingUpgradePolicy? RollingUpgradePolicy
            {
                get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetRollingUpgradePolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#single_placement_group VirtualMachineScaleSet#single_placement_group}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#storage_profile_data_disk VirtualMachineScaleSet#storage_profile_data_disk}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileDataDisk" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageProfileDataDisk", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileDataDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StorageProfileDataDisk
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>storage_profile_image_reference block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#storage_profile_image_reference VirtualMachineScaleSet#storage_profile_image_reference}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageProfileImageReference", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileImageReference\"}", isOptional: true)]
            public azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileImageReference? StorageProfileImageReference
            {
                get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileImageReference?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#tags VirtualMachineScaleSet#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#timeouts VirtualMachineScaleSet#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurestack.virtualMachineScaleSet.VirtualMachineScaleSetTimeouts\"}", isOptional: true)]
            public azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurestack.VirtualMachineScaleSet.IVirtualMachineScaleSetTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine_scale_set#zones VirtualMachineScaleSet#zones}.</summary>
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
