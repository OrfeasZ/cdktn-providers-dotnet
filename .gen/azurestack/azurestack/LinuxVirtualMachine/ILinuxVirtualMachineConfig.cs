using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.LinuxVirtualMachine
{
    [JsiiInterface(nativeType: typeof(ILinuxVirtualMachineConfig), fullyQualifiedName: "azurestack.linuxVirtualMachine.LinuxVirtualMachineConfig")]
    public interface ILinuxVirtualMachineConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#admin_username LinuxVirtualMachine#admin_username}.</summary>
        [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}")]
        string AdminUsername
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#location LinuxVirtualMachine#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#name LinuxVirtualMachine#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#network_interface_ids LinuxVirtualMachine#network_interface_ids}.</summary>
        [JsiiProperty(name: "networkInterfaceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] NetworkInterfaceIds
        {
            get;
        }

        /// <summary>os_disk block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#os_disk LinuxVirtualMachine#os_disk}
        /// </remarks>
        [JsiiProperty(name: "osDisk", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineOsDisk\"}")]
        azurestack.LinuxVirtualMachine.ILinuxVirtualMachineOsDisk OsDisk
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#resource_group_name LinuxVirtualMachine#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#size LinuxVirtualMachine#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"string\"}")]
        string Size
        {
            get;
        }

        /// <summary>additional_capabilities block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#additional_capabilities LinuxVirtualMachine#additional_capabilities}
        /// </remarks>
        [JsiiProperty(name: "additionalCapabilities", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineAdditionalCapabilities\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.LinuxVirtualMachine.ILinuxVirtualMachineAdditionalCapabilities? AdditionalCapabilities
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#admin_password LinuxVirtualMachine#admin_password}.</summary>
        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdminPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>admin_ssh_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#admin_ssh_key LinuxVirtualMachine#admin_ssh_key}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.LinuxVirtualMachine.ILinuxVirtualMachineAdminSshKey" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "adminSshKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineAdminSshKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AdminSshKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#allow_extension_operations LinuxVirtualMachine#allow_extension_operations}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "allowExtensionOperations", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowExtensionOperations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#availability_set_id LinuxVirtualMachine#availability_set_id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#boot_diagnostics LinuxVirtualMachine#boot_diagnostics}
        /// </remarks>
        [JsiiProperty(name: "bootDiagnostics", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineBootDiagnostics\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.LinuxVirtualMachine.ILinuxVirtualMachineBootDiagnostics? BootDiagnostics
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#computer_name LinuxVirtualMachine#computer_name}.</summary>
        [JsiiProperty(name: "computerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComputerName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#custom_data LinuxVirtualMachine#custom_data}.</summary>
        [JsiiProperty(name: "customData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomData
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#disable_password_authentication LinuxVirtualMachine#disable_password_authentication}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "disablePasswordAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisablePasswordAuthentication
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#encryption_at_host_enabled LinuxVirtualMachine#encryption_at_host_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "encryptionAtHostEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EncryptionAtHostEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#eviction_policy LinuxVirtualMachine#eviction_policy}.</summary>
        [JsiiProperty(name: "evictionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EvictionPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#extensions_time_budget LinuxVirtualMachine#extensions_time_budget}.</summary>
        [JsiiProperty(name: "extensionsTimeBudget", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExtensionsTimeBudget
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#id LinuxVirtualMachine#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#license_type LinuxVirtualMachine#license_type}.</summary>
        [JsiiProperty(name: "licenseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LicenseType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#max_bid_price LinuxVirtualMachine#max_bid_price}.</summary>
        [JsiiProperty(name: "maxBidPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxBidPrice
        {
            get
            {
                return null;
            }
        }

        /// <summary>plan block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#plan LinuxVirtualMachine#plan}
        /// </remarks>
        [JsiiProperty(name: "plan", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachinePlan\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.LinuxVirtualMachine.ILinuxVirtualMachinePlan? Plan
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#priority LinuxVirtualMachine#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#provision_vm_agent LinuxVirtualMachine#provision_vm_agent}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "provisionVmAgent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProvisionVmAgent
        {
            get
            {
                return null;
            }
        }

        /// <summary>secret block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#secret LinuxVirtualMachine#secret}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.LinuxVirtualMachine.ILinuxVirtualMachineSecret" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "secret", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineSecret\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Secret
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#source_image_id LinuxVirtualMachine#source_image_id}.</summary>
        [JsiiProperty(name: "sourceImageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceImageId
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_image_reference block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#source_image_reference LinuxVirtualMachine#source_image_reference}
        /// </remarks>
        [JsiiProperty(name: "sourceImageReference", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineSourceImageReference\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.LinuxVirtualMachine.ILinuxVirtualMachineSourceImageReference? SourceImageReference
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#tags LinuxVirtualMachine#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#timeouts LinuxVirtualMachine#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurestack.LinuxVirtualMachine.ILinuxVirtualMachineTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#virtual_machine_scale_set_id LinuxVirtualMachine#virtual_machine_scale_set_id}.</summary>
        [JsiiProperty(name: "virtualMachineScaleSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VirtualMachineScaleSetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#zone LinuxVirtualMachine#zone}.</summary>
        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Zone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxVirtualMachineConfig), fullyQualifiedName: "azurestack.linuxVirtualMachine.LinuxVirtualMachineConfig")]
        internal sealed class _Proxy : DeputyBase, azurestack.LinuxVirtualMachine.ILinuxVirtualMachineConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#admin_username LinuxVirtualMachine#admin_username}.</summary>
            [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}")]
            public string AdminUsername
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#location LinuxVirtualMachine#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#name LinuxVirtualMachine#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#network_interface_ids LinuxVirtualMachine#network_interface_ids}.</summary>
            [JsiiProperty(name: "networkInterfaceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] NetworkInterfaceIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>os_disk block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#os_disk LinuxVirtualMachine#os_disk}
            /// </remarks>
            [JsiiProperty(name: "osDisk", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineOsDisk\"}")]
            public azurestack.LinuxVirtualMachine.ILinuxVirtualMachineOsDisk OsDisk
            {
                get => GetInstanceProperty<azurestack.LinuxVirtualMachine.ILinuxVirtualMachineOsDisk>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#resource_group_name LinuxVirtualMachine#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#size LinuxVirtualMachine#size}.</summary>
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"string\"}")]
            public string Size
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>additional_capabilities block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#additional_capabilities LinuxVirtualMachine#additional_capabilities}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "additionalCapabilities", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineAdditionalCapabilities\"}", isOptional: true)]
            public azurestack.LinuxVirtualMachine.ILinuxVirtualMachineAdditionalCapabilities? AdditionalCapabilities
            {
                get => GetInstanceProperty<azurestack.LinuxVirtualMachine.ILinuxVirtualMachineAdditionalCapabilities?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#admin_password LinuxVirtualMachine#admin_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdminPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>admin_ssh_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#admin_ssh_key LinuxVirtualMachine#admin_ssh_key}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.LinuxVirtualMachine.ILinuxVirtualMachineAdminSshKey" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "adminSshKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineAdminSshKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AdminSshKey
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#allow_extension_operations LinuxVirtualMachine#allow_extension_operations}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowExtensionOperations", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AllowExtensionOperations
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#availability_set_id LinuxVirtualMachine#availability_set_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilitySetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilitySetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>boot_diagnostics block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#boot_diagnostics LinuxVirtualMachine#boot_diagnostics}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bootDiagnostics", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineBootDiagnostics\"}", isOptional: true)]
            public azurestack.LinuxVirtualMachine.ILinuxVirtualMachineBootDiagnostics? BootDiagnostics
            {
                get => GetInstanceProperty<azurestack.LinuxVirtualMachine.ILinuxVirtualMachineBootDiagnostics?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#computer_name LinuxVirtualMachine#computer_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComputerName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#custom_data LinuxVirtualMachine#custom_data}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomData
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#disable_password_authentication LinuxVirtualMachine#disable_password_authentication}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disablePasswordAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisablePasswordAuthentication
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#encryption_at_host_enabled LinuxVirtualMachine#encryption_at_host_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionAtHostEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EncryptionAtHostEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#eviction_policy LinuxVirtualMachine#eviction_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "evictionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EvictionPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#extensions_time_budget LinuxVirtualMachine#extensions_time_budget}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "extensionsTimeBudget", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExtensionsTimeBudget
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#id LinuxVirtualMachine#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#license_type LinuxVirtualMachine#license_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "licenseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LicenseType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#max_bid_price LinuxVirtualMachine#max_bid_price}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxBidPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxBidPrice
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>plan block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#plan LinuxVirtualMachine#plan}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "plan", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachinePlan\"}", isOptional: true)]
            public azurestack.LinuxVirtualMachine.ILinuxVirtualMachinePlan? Plan
            {
                get => GetInstanceProperty<azurestack.LinuxVirtualMachine.ILinuxVirtualMachinePlan?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#priority LinuxVirtualMachine#priority}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Priority
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#provision_vm_agent LinuxVirtualMachine#provision_vm_agent}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisionVmAgent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ProvisionVmAgent
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>secret block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#secret LinuxVirtualMachine#secret}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.LinuxVirtualMachine.ILinuxVirtualMachineSecret" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secret", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineSecret\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Secret
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#source_image_id LinuxVirtualMachine#source_image_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceImageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceImageId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>source_image_reference block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#source_image_reference LinuxVirtualMachine#source_image_reference}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceImageReference", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineSourceImageReference\"}", isOptional: true)]
            public azurestack.LinuxVirtualMachine.ILinuxVirtualMachineSourceImageReference? SourceImageReference
            {
                get => GetInstanceProperty<azurestack.LinuxVirtualMachine.ILinuxVirtualMachineSourceImageReference?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#tags LinuxVirtualMachine#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#timeouts LinuxVirtualMachine#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineTimeouts\"}", isOptional: true)]
            public azurestack.LinuxVirtualMachine.ILinuxVirtualMachineTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurestack.LinuxVirtualMachine.ILinuxVirtualMachineTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#virtual_machine_scale_set_id LinuxVirtualMachine#virtual_machine_scale_set_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "virtualMachineScaleSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VirtualMachineScaleSetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/linux_virtual_machine#zone LinuxVirtualMachine#zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Zone
            {
                get => GetInstanceProperty<string?>();
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
