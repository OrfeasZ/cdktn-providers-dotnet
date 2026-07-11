using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualMachine
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineConfig), fullyQualifiedName: "azurestack.virtualMachine.VirtualMachineConfig")]
    public interface IVirtualMachineConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#location VirtualMachine#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#name VirtualMachine#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#network_interface_ids VirtualMachine#network_interface_ids}.</summary>
        [JsiiProperty(name: "networkInterfaceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] NetworkInterfaceIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#resource_group_name VirtualMachine#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>storage_os_disk block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#storage_os_disk VirtualMachine#storage_os_disk}
        /// </remarks>
        [JsiiProperty(name: "storageOsDisk", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineStorageOsDisk\"}")]
        azurestack.VirtualMachine.IVirtualMachineStorageOsDisk StorageOsDisk
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#vm_size VirtualMachine#vm_size}.</summary>
        [JsiiProperty(name: "vmSize", typeJson: "{\"primitive\":\"string\"}")]
        string VmSize
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#availability_set_id VirtualMachine#availability_set_id}.</summary>
        [JsiiProperty(name: "availabilitySetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailabilitySetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>boot_diagnostics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#boot_diagnostics VirtualMachine#boot_diagnostics}
        /// </remarks>
        [JsiiProperty(name: "bootDiagnostics", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineBootDiagnostics\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.VirtualMachine.IVirtualMachineBootDiagnostics? BootDiagnostics
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#delete_data_disks_on_termination VirtualMachine#delete_data_disks_on_termination}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "deleteDataDisksOnTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeleteDataDisksOnTermination
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#delete_os_disk_on_termination VirtualMachine#delete_os_disk_on_termination}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "deleteOsDiskOnTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeleteOsDiskOnTermination
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#id VirtualMachine#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#identity VirtualMachine#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.VirtualMachine.IVirtualMachineIdentity? Identity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#license_type VirtualMachine#license_type}.</summary>
        [JsiiProperty(name: "licenseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LicenseType
        {
            get
            {
                return null;
            }
        }

        /// <summary>os_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#os_profile VirtualMachine#os_profile}
        /// </remarks>
        [JsiiProperty(name: "osProfile", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineOsProfile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.VirtualMachine.IVirtualMachineOsProfile? OsProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>os_profile_linux_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#os_profile_linux_config VirtualMachine#os_profile_linux_config}
        /// </remarks>
        [JsiiProperty(name: "osProfileLinuxConfig", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineOsProfileLinuxConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.VirtualMachine.IVirtualMachineOsProfileLinuxConfig? OsProfileLinuxConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>os_profile_secrets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#os_profile_secrets VirtualMachine#os_profile_secrets}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachine.IVirtualMachineOsProfileSecrets" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "osProfileSecrets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachine.VirtualMachineOsProfileSecrets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#os_profile_windows_config VirtualMachine#os_profile_windows_config}
        /// </remarks>
        [JsiiProperty(name: "osProfileWindowsConfig", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineOsProfileWindowsConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.VirtualMachine.IVirtualMachineOsProfileWindowsConfig? OsProfileWindowsConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>plan block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#plan VirtualMachine#plan}
        /// </remarks>
        [JsiiProperty(name: "plan", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachinePlan\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.VirtualMachine.IVirtualMachinePlan? Plan
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#primary_network_interface_id VirtualMachine#primary_network_interface_id}.</summary>
        [JsiiProperty(name: "primaryNetworkInterfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrimaryNetworkInterfaceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_data_disk block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#storage_data_disk VirtualMachine#storage_data_disk}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachine.IVirtualMachineStorageDataDisk" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "storageDataDisk", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachine.VirtualMachineStorageDataDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StorageDataDisk
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_image_reference block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#storage_image_reference VirtualMachine#storage_image_reference}
        /// </remarks>
        [JsiiProperty(name: "storageImageReference", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineStorageImageReference\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.VirtualMachine.IVirtualMachineStorageImageReference? StorageImageReference
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#tags VirtualMachine#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#timeouts VirtualMachine#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.VirtualMachine.IVirtualMachineTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#zones VirtualMachine#zones}.</summary>
        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Zones
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineConfig), fullyQualifiedName: "azurestack.virtualMachine.VirtualMachineConfig")]
        internal sealed class _Proxy : DeputyBase, azurestack.VirtualMachine.IVirtualMachineConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#location VirtualMachine#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#name VirtualMachine#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#network_interface_ids VirtualMachine#network_interface_ids}.</summary>
            [JsiiProperty(name: "networkInterfaceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] NetworkInterfaceIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#resource_group_name VirtualMachine#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>storage_os_disk block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#storage_os_disk VirtualMachine#storage_os_disk}
            /// </remarks>
            [JsiiProperty(name: "storageOsDisk", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineStorageOsDisk\"}")]
            public azurestack.VirtualMachine.IVirtualMachineStorageOsDisk StorageOsDisk
            {
                get => GetInstanceProperty<azurestack.VirtualMachine.IVirtualMachineStorageOsDisk>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#vm_size VirtualMachine#vm_size}.</summary>
            [JsiiProperty(name: "vmSize", typeJson: "{\"primitive\":\"string\"}")]
            public string VmSize
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#availability_set_id VirtualMachine#availability_set_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilitySetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilitySetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>boot_diagnostics block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#boot_diagnostics VirtualMachine#boot_diagnostics}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bootDiagnostics", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineBootDiagnostics\"}", isOptional: true)]
            public azurestack.VirtualMachine.IVirtualMachineBootDiagnostics? BootDiagnostics
            {
                get => GetInstanceProperty<azurestack.VirtualMachine.IVirtualMachineBootDiagnostics?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#delete_data_disks_on_termination VirtualMachine#delete_data_disks_on_termination}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deleteDataDisksOnTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DeleteDataDisksOnTermination
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#delete_os_disk_on_termination VirtualMachine#delete_os_disk_on_termination}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deleteOsDiskOnTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DeleteOsDiskOnTermination
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#id VirtualMachine#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#identity VirtualMachine#identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineIdentity\"}", isOptional: true)]
            public azurestack.VirtualMachine.IVirtualMachineIdentity? Identity
            {
                get => GetInstanceProperty<azurestack.VirtualMachine.IVirtualMachineIdentity?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#license_type VirtualMachine#license_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "licenseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LicenseType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>os_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#os_profile VirtualMachine#os_profile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "osProfile", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineOsProfile\"}", isOptional: true)]
            public azurestack.VirtualMachine.IVirtualMachineOsProfile? OsProfile
            {
                get => GetInstanceProperty<azurestack.VirtualMachine.IVirtualMachineOsProfile?>();
            }

            /// <summary>os_profile_linux_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#os_profile_linux_config VirtualMachine#os_profile_linux_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "osProfileLinuxConfig", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineOsProfileLinuxConfig\"}", isOptional: true)]
            public azurestack.VirtualMachine.IVirtualMachineOsProfileLinuxConfig? OsProfileLinuxConfig
            {
                get => GetInstanceProperty<azurestack.VirtualMachine.IVirtualMachineOsProfileLinuxConfig?>();
            }

            /// <summary>os_profile_secrets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#os_profile_secrets VirtualMachine#os_profile_secrets}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachine.IVirtualMachineOsProfileSecrets" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "osProfileSecrets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachine.VirtualMachineOsProfileSecrets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OsProfileSecrets
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>os_profile_windows_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#os_profile_windows_config VirtualMachine#os_profile_windows_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "osProfileWindowsConfig", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineOsProfileWindowsConfig\"}", isOptional: true)]
            public azurestack.VirtualMachine.IVirtualMachineOsProfileWindowsConfig? OsProfileWindowsConfig
            {
                get => GetInstanceProperty<azurestack.VirtualMachine.IVirtualMachineOsProfileWindowsConfig?>();
            }

            /// <summary>plan block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#plan VirtualMachine#plan}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "plan", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachinePlan\"}", isOptional: true)]
            public azurestack.VirtualMachine.IVirtualMachinePlan? Plan
            {
                get => GetInstanceProperty<azurestack.VirtualMachine.IVirtualMachinePlan?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#primary_network_interface_id VirtualMachine#primary_network_interface_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "primaryNetworkInterfaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrimaryNetworkInterfaceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>storage_data_disk block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#storage_data_disk VirtualMachine#storage_data_disk}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualMachine.IVirtualMachineStorageDataDisk" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageDataDisk", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualMachine.VirtualMachineStorageDataDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StorageDataDisk
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>storage_image_reference block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#storage_image_reference VirtualMachine#storage_image_reference}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageImageReference", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineStorageImageReference\"}", isOptional: true)]
            public azurestack.VirtualMachine.IVirtualMachineStorageImageReference? StorageImageReference
            {
                get => GetInstanceProperty<azurestack.VirtualMachine.IVirtualMachineStorageImageReference?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#tags VirtualMachine#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#timeouts VirtualMachine#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurestack.virtualMachine.VirtualMachineTimeouts\"}", isOptional: true)]
            public azurestack.VirtualMachine.IVirtualMachineTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurestack.VirtualMachine.IVirtualMachineTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#zones VirtualMachine#zones}.</summary>
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
