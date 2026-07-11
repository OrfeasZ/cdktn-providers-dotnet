using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxVirtualMachineScaleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetConfig")]
    public class LinuxVirtualMachineScaleSetConfig : azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#admin_username LinuxVirtualMachineScaleSet#admin_username}.</summary>
        [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}")]
        public string AdminUsername
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#location LinuxVirtualMachineScaleSet#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public string Location
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#name LinuxVirtualMachineScaleSet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object _networkInterface;

        /// <summary>network_interface block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#network_interface LinuxVirtualMachineScaleSet#network_interface}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetNetworkInterface" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "networkInterface", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetNetworkInterface\"},\"kind\":\"array\"}}]}}")]
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
                        case azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetNetworkInterface[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetNetworkInterface).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetNetworkInterface).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkInterface = value;
            }
        }

        /// <summary>os_disk block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#os_disk LinuxVirtualMachineScaleSet#os_disk}
        /// </remarks>
        [JsiiProperty(name: "osDisk", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetOsDisk\"}")]
        public azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetOsDisk OsDisk
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#resource_group_name LinuxVirtualMachineScaleSet#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#sku LinuxVirtualMachineScaleSet#sku}.</summary>
        [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
        public string Sku
        {
            get;
            set;
        }

        /// <summary>additional_capabilities block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#additional_capabilities LinuxVirtualMachineScaleSet#additional_capabilities}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalCapabilities", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdditionalCapabilities\"}", isOptional: true)]
        public azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAdditionalCapabilities? AdditionalCapabilities
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#admin_password LinuxVirtualMachineScaleSet#admin_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdminPassword
        {
            get;
            set;
        }

        private object? _adminSshKey;

        /// <summary>admin_ssh_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#admin_ssh_key LinuxVirtualMachineScaleSet#admin_ssh_key}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAdminSshKey" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "adminSshKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdminSshKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AdminSshKey
        {
            get => _adminSshKey;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAdminSshKey[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAdminSshKey).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _adminSshKey = value;
            }
        }

        /// <summary>automatic_instance_repair block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#automatic_instance_repair LinuxVirtualMachineScaleSet#automatic_instance_repair}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "automaticInstanceRepair", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAutomaticInstanceRepair\"}", isOptional: true)]
        public azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAutomaticInstanceRepair? AutomaticInstanceRepair
        {
            get;
            set;
        }

        /// <summary>automatic_os_upgrade_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#automatic_os_upgrade_policy LinuxVirtualMachineScaleSet#automatic_os_upgrade_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "automaticOsUpgradePolicy", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAutomaticOsUpgradePolicy\"}", isOptional: true)]
        public azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAutomaticOsUpgradePolicy? AutomaticOsUpgradePolicy
        {
            get;
            set;
        }

        /// <summary>boot_diagnostics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#boot_diagnostics LinuxVirtualMachineScaleSet#boot_diagnostics}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bootDiagnostics", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetBootDiagnostics\"}", isOptional: true)]
        public azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetBootDiagnostics? BootDiagnostics
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#capacity_reservation_group_id LinuxVirtualMachineScaleSet#capacity_reservation_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CapacityReservationGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#computer_name_prefix LinuxVirtualMachineScaleSet#computer_name_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "computerNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ComputerNamePrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#custom_data LinuxVirtualMachineScaleSet#custom_data}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#data_disk LinuxVirtualMachineScaleSet#data_disk}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetDataDisk" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataDisk", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetDataDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetDataDisk[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetDataDisk).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dataDisk = value;
            }
        }

        private object? _disablePasswordAuthentication;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#disable_password_authentication LinuxVirtualMachineScaleSet#disable_password_authentication}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "disablePasswordAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DisablePasswordAuthentication
        {
            get => _disablePasswordAuthentication;
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
                _disablePasswordAuthentication = value;
            }
        }

        private object? _doNotRunExtensionsOnOverprovisionedMachines;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#do_not_run_extensions_on_overprovisioned_machines LinuxVirtualMachineScaleSet#do_not_run_extensions_on_overprovisioned_machines}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#edge_zone LinuxVirtualMachineScaleSet#edge_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "edgeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EdgeZone
        {
            get;
            set;
        }

        private object? _encryptionAtHostEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#encryption_at_host_enabled LinuxVirtualMachineScaleSet#encryption_at_host_enabled}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#eviction_policy LinuxVirtualMachineScaleSet#eviction_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "evictionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EvictionPolicy
        {
            get;
            set;
        }

        private object? _extension;

        /// <summary>extension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#extension LinuxVirtualMachineScaleSet#extension}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetExtension" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "extension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetExtension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetExtension[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetExtension).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _extension = value;
            }
        }

        private object? _extensionOperationsEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#extension_operations_enabled LinuxVirtualMachineScaleSet#extension_operations_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "extensionOperationsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ExtensionOperationsEnabled
        {
            get => _extensionOperationsEnabled;
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
                _extensionOperationsEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#extensions_time_budget LinuxVirtualMachineScaleSet#extensions_time_budget}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "extensionsTimeBudget", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExtensionsTimeBudget
        {
            get;
            set;
        }

        private object? _galleryApplication;

        /// <summary>gallery_application block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#gallery_application LinuxVirtualMachineScaleSet#gallery_application}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetGalleryApplication" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "galleryApplication", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetGalleryApplication\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GalleryApplication
        {
            get => _galleryApplication;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetGalleryApplication[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetGalleryApplication).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _galleryApplication = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#health_probe_id LinuxVirtualMachineScaleSet#health_probe_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthProbeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HealthProbeId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#host_group_id LinuxVirtualMachineScaleSet#host_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#id LinuxVirtualMachineScaleSet#id}.</summary>
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

        /// <summary>identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#identity LinuxVirtualMachineScaleSet#identity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetIdentity\"}", isOptional: true)]
        public azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetIdentity? Identity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#instances LinuxVirtualMachineScaleSet#instances}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instances", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Instances
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#max_bid_price LinuxVirtualMachineScaleSet#max_bid_price}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxBidPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxBidPrice
        {
            get;
            set;
        }

        private object? _overprovision;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#overprovision LinuxVirtualMachineScaleSet#overprovision}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#plan LinuxVirtualMachineScaleSet#plan}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "plan", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetPlan\"}", isOptional: true)]
        public azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetPlan? Plan
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#platform_fault_domain_count LinuxVirtualMachineScaleSet#platform_fault_domain_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "platformFaultDomainCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PlatformFaultDomainCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#priority LinuxVirtualMachineScaleSet#priority}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Priority
        {
            get;
            set;
        }

        private object? _provisionVmAgent;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#provision_vm_agent LinuxVirtualMachineScaleSet#provision_vm_agent}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#proximity_placement_group_id LinuxVirtualMachineScaleSet#proximity_placement_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "proximityPlacementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProximityPlacementGroupId
        {
            get;
            set;
        }

        private object? _resilientVmCreationEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#resilient_vm_creation_enabled LinuxVirtualMachineScaleSet#resilient_vm_creation_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resilientVmCreationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ResilientVmCreationEnabled
        {
            get => _resilientVmCreationEnabled;
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
                _resilientVmCreationEnabled = value;
            }
        }

        private object? _resilientVmDeletionEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#resilient_vm_deletion_enabled LinuxVirtualMachineScaleSet#resilient_vm_deletion_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resilientVmDeletionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ResilientVmDeletionEnabled
        {
            get => _resilientVmDeletionEnabled;
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
                _resilientVmDeletionEnabled = value;
            }
        }

        /// <summary>rolling_upgrade_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#rolling_upgrade_policy LinuxVirtualMachineScaleSet#rolling_upgrade_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rollingUpgradePolicy", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetRollingUpgradePolicy\"}", isOptional: true)]
        public azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetRollingUpgradePolicy? RollingUpgradePolicy
        {
            get;
            set;
        }

        /// <summary>scale_in block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#scale_in LinuxVirtualMachineScaleSet#scale_in}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scaleIn", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetScaleIn\"}", isOptional: true)]
        public azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetScaleIn? ScaleIn
        {
            get;
            set;
        }

        private object? _secret;

        /// <summary>secret block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#secret LinuxVirtualMachineScaleSet#secret}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSecret" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secret", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSecret\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSecret[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSecret).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _secret = value;
            }
        }

        private object? _secureBootEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#secure_boot_enabled LinuxVirtualMachineScaleSet#secure_boot_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secureBootEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SecureBootEnabled
        {
            get => _secureBootEnabled;
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
                _secureBootEnabled = value;
            }
        }

        private object? _singlePlacementGroup;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#single_placement_group LinuxVirtualMachineScaleSet#single_placement_group}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#source_image_id LinuxVirtualMachineScaleSet#source_image_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceImageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceImageId
        {
            get;
            set;
        }

        /// <summary>source_image_reference block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#source_image_reference LinuxVirtualMachineScaleSet#source_image_reference}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceImageReference", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSourceImageReference\"}", isOptional: true)]
        public azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSourceImageReference? SourceImageReference
        {
            get;
            set;
        }

        /// <summary>spot_restore block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#spot_restore LinuxVirtualMachineScaleSet#spot_restore}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spotRestore", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSpotRestore\"}", isOptional: true)]
        public azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSpotRestore? SpotRestore
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#tags LinuxVirtualMachineScaleSet#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>termination_notification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#termination_notification LinuxVirtualMachineScaleSet#termination_notification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "terminationNotification", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetTerminationNotification\"}", isOptional: true)]
        public azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetTerminationNotification? TerminationNotification
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#timeouts LinuxVirtualMachineScaleSet#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetTimeouts\"}", isOptional: true)]
        public azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#upgrade_mode LinuxVirtualMachineScaleSet#upgrade_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "upgradeMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpgradeMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#user_data LinuxVirtualMachineScaleSet#user_data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserData
        {
            get;
            set;
        }

        private object? _vtpmEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#vtpm_enabled LinuxVirtualMachineScaleSet#vtpm_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vtpmEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? VtpmEnabled
        {
            get => _vtpmEnabled;
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
                _vtpmEnabled = value;
            }
        }

        private object? _zoneBalance;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#zone_balance LinuxVirtualMachineScaleSet#zone_balance}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "zoneBalance", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ZoneBalance
        {
            get => _zoneBalance;
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
                _zoneBalance = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/linux_virtual_machine_scale_set#zones LinuxVirtualMachineScaleSet#zones}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Zones
        {
            get;
            set;
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
