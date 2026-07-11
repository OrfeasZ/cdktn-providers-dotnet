using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.WindowsVirtualMachineScaleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetConfig")]
    public class WindowsVirtualMachineScaleSetConfig : azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#admin_password WindowsVirtualMachineScaleSet#admin_password}.</summary>
        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public string AdminPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#admin_username WindowsVirtualMachineScaleSet#admin_username}.</summary>
        [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}")]
        public string AdminUsername
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#instances WindowsVirtualMachineScaleSet#instances}.</summary>
        [JsiiProperty(name: "instances", typeJson: "{\"primitive\":\"number\"}")]
        public double Instances
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#location WindowsVirtualMachineScaleSet#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public string Location
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#name WindowsVirtualMachineScaleSet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object _networkInterface;

        /// <summary>network_interface block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#network_interface WindowsVirtualMachineScaleSet#network_interface}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetNetworkInterface" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "networkInterface", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetNetworkInterface\"},\"kind\":\"array\"}}]}}")]
        public object NetworkInterface
        {
            get => _networkInterface;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetNetworkInterface[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetNetworkInterface).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetNetworkInterface).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkInterface = value;
            }
        }

        /// <summary>os_disk block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#os_disk WindowsVirtualMachineScaleSet#os_disk}
        /// </remarks>
        [JsiiProperty(name: "osDisk", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetOsDisk\"}")]
        public azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetOsDisk OsDisk
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#resource_group_name WindowsVirtualMachineScaleSet#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#sku WindowsVirtualMachineScaleSet#sku}.</summary>
        [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
        public string Sku
        {
            get;
            set;
        }

        /// <summary>additional_capabilities block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#additional_capabilities WindowsVirtualMachineScaleSet#additional_capabilities}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalCapabilities", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAdditionalCapabilities\"}", isOptional: true)]
        public azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAdditionalCapabilities? AdditionalCapabilities
        {
            get;
            set;
        }

        private object? _additionalUnattendContent;

        /// <summary>additional_unattend_content block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#additional_unattend_content WindowsVirtualMachineScaleSet#additional_unattend_content}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAdditionalUnattendContent" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalUnattendContent", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAdditionalUnattendContent\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AdditionalUnattendContent
        {
            get => _additionalUnattendContent;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAdditionalUnattendContent[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAdditionalUnattendContent).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _additionalUnattendContent = value;
            }
        }

        /// <summary>automatic_instance_repair block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#automatic_instance_repair WindowsVirtualMachineScaleSet#automatic_instance_repair}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "automaticInstanceRepair", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAutomaticInstanceRepair\"}", isOptional: true)]
        public azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAutomaticInstanceRepair? AutomaticInstanceRepair
        {
            get;
            set;
        }

        /// <summary>automatic_os_upgrade_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#automatic_os_upgrade_policy WindowsVirtualMachineScaleSet#automatic_os_upgrade_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "automaticOsUpgradePolicy", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetAutomaticOsUpgradePolicy\"}", isOptional: true)]
        public azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetAutomaticOsUpgradePolicy? AutomaticOsUpgradePolicy
        {
            get;
            set;
        }

        /// <summary>boot_diagnostics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#boot_diagnostics WindowsVirtualMachineScaleSet#boot_diagnostics}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bootDiagnostics", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetBootDiagnostics\"}", isOptional: true)]
        public azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetBootDiagnostics? BootDiagnostics
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#computer_name_prefix WindowsVirtualMachineScaleSet#computer_name_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "computerNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ComputerNamePrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#custom_data WindowsVirtualMachineScaleSet#custom_data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomData
        {
            get;
            set;
        }

        private object? _dataDisk;

        /// <summary>data_disk block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#data_disk WindowsVirtualMachineScaleSet#data_disk}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetDataDisk" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataDisk", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetDataDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DataDisk
        {
            get => _dataDisk;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetDataDisk[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetDataDisk).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dataDisk = value;
            }
        }

        private object? _doNotRunExtensionsOnOverprovisionedMachines;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#do_not_run_extensions_on_overprovisioned_machines WindowsVirtualMachineScaleSet#do_not_run_extensions_on_overprovisioned_machines}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "doNotRunExtensionsOnOverprovisionedMachines", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DoNotRunExtensionsOnOverprovisionedMachines
        {
            get => _doNotRunExtensionsOnOverprovisionedMachines;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _doNotRunExtensionsOnOverprovisionedMachines = value;
            }
        }

        private object? _enableAutomaticUpdates;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#enable_automatic_updates WindowsVirtualMachineScaleSet#enable_automatic_updates}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enableAutomaticUpdates", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnableAutomaticUpdates
        {
            get => _enableAutomaticUpdates;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enableAutomaticUpdates = value;
            }
        }

        private object? _encryptionAtHostEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#encryption_at_host_enabled WindowsVirtualMachineScaleSet#encryption_at_host_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionAtHostEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EncryptionAtHostEnabled
        {
            get => _encryptionAtHostEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _encryptionAtHostEnabled = value;
            }
        }

        private object? _extension;

        /// <summary>extension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#extension WindowsVirtualMachineScaleSet#extension}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetExtension" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "extension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetExtension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Extension
        {
            get => _extension;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetExtension[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetExtension).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _extension = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#health_probe_id WindowsVirtualMachineScaleSet#health_probe_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthProbeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HealthProbeId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#id WindowsVirtualMachineScaleSet#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#license_type WindowsVirtualMachineScaleSet#license_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "licenseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LicenseType
        {
            get;
            set;
        }

        private object? _overprovision;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#overprovision WindowsVirtualMachineScaleSet#overprovision}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "overprovision", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Overprovision
        {
            get => _overprovision;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _overprovision = value;
            }
        }

        /// <summary>plan block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#plan WindowsVirtualMachineScaleSet#plan}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "plan", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetPlan\"}", isOptional: true)]
        public azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetPlan? Plan
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#platform_fault_domain_count WindowsVirtualMachineScaleSet#platform_fault_domain_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "platformFaultDomainCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PlatformFaultDomainCount
        {
            get;
            set;
        }

        private object? _provisionVmAgent;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#provision_vm_agent WindowsVirtualMachineScaleSet#provision_vm_agent}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisionVmAgent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ProvisionVmAgent
        {
            get => _provisionVmAgent;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _provisionVmAgent = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#scale_in_policy WindowsVirtualMachineScaleSet#scale_in_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scaleInPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScaleInPolicy
        {
            get;
            set;
        }

        private object? _secret;

        /// <summary>secret block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#secret WindowsVirtualMachineScaleSet#secret}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetSecret" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secret", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetSecret\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Secret
        {
            get => _secret;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetSecret[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetSecret).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _secret = value;
            }
        }

        private object? _singlePlacementGroup;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#single_placement_group WindowsVirtualMachineScaleSet#single_placement_group}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "singlePlacementGroup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SinglePlacementGroup
        {
            get => _singlePlacementGroup;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _singlePlacementGroup = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#source_image_id WindowsVirtualMachineScaleSet#source_image_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceImageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceImageId
        {
            get;
            set;
        }

        /// <summary>source_image_reference block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#source_image_reference WindowsVirtualMachineScaleSet#source_image_reference}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceImageReference", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetSourceImageReference\"}", isOptional: true)]
        public azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetSourceImageReference? SourceImageReference
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#tags WindowsVirtualMachineScaleSet#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>terminate_notification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#terminate_notification WindowsVirtualMachineScaleSet#terminate_notification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "terminateNotification", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetTerminateNotification\"}", isOptional: true)]
        public azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetTerminateNotification? TerminateNotification
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#timeouts WindowsVirtualMachineScaleSet#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetTimeouts\"}", isOptional: true)]
        public azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#timezone WindowsVirtualMachineScaleSet#timezone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Timezone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#upgrade_mode WindowsVirtualMachineScaleSet#upgrade_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "upgradeMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpgradeMode
        {
            get;
            set;
        }

        private object? _winrmListener;

        /// <summary>winrm_listener block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/windows_virtual_machine_scale_set#winrm_listener WindowsVirtualMachineScaleSet#winrm_listener}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetWinrmListener" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "winrmListener", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetWinrmListener\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? WinrmListener
        {
            get => _winrmListener;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetWinrmListener[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetWinrmListener).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _winrmListener = value;
            }
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
