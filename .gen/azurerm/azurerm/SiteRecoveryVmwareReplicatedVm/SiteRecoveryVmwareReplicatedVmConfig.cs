using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SiteRecoveryVmwareReplicatedVm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.siteRecoveryVmwareReplicatedVm.SiteRecoveryVmwareReplicatedVmConfig")]
    public class SiteRecoveryVmwareReplicatedVmConfig : azurerm.SiteRecoveryVmwareReplicatedVm.ISiteRecoveryVmwareReplicatedVmConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_vmware_replicated_vm#appliance_name SiteRecoveryVmwareReplicatedVm#appliance_name}.</summary>
        [JsiiProperty(name: "applianceName", typeJson: "{\"primitive\":\"string\"}")]
        public string ApplianceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_vmware_replicated_vm#name SiteRecoveryVmwareReplicatedVm#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_vmware_replicated_vm#physical_server_credential_name SiteRecoveryVmwareReplicatedVm#physical_server_credential_name}.</summary>
        [JsiiProperty(name: "physicalServerCredentialName", typeJson: "{\"primitive\":\"string\"}")]
        public string PhysicalServerCredentialName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_vmware_replicated_vm#recovery_replication_policy_id SiteRecoveryVmwareReplicatedVm#recovery_replication_policy_id}.</summary>
        [JsiiProperty(name: "recoveryReplicationPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public string RecoveryReplicationPolicyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_vmware_replicated_vm#recovery_vault_id SiteRecoveryVmwareReplicatedVm#recovery_vault_id}.</summary>
        [JsiiProperty(name: "recoveryVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public string RecoveryVaultId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_vmware_replicated_vm#source_vm_name SiteRecoveryVmwareReplicatedVm#source_vm_name}.</summary>
        [JsiiProperty(name: "sourceVmName", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceVmName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_vmware_replicated_vm#target_resource_group_id SiteRecoveryVmwareReplicatedVm#target_resource_group_id}.</summary>
        [JsiiProperty(name: "targetResourceGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetResourceGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_vmware_replicated_vm#target_vm_name SiteRecoveryVmwareReplicatedVm#target_vm_name}.</summary>
        [JsiiProperty(name: "targetVmName", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetVmName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_vmware_replicated_vm#default_log_storage_account_id SiteRecoveryVmwareReplicatedVm#default_log_storage_account_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultLogStorageAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultLogStorageAccountId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_vmware_replicated_vm#default_recovery_disk_type SiteRecoveryVmwareReplicatedVm#default_recovery_disk_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultRecoveryDiskType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultRecoveryDiskType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_vmware_replicated_vm#default_target_disk_encryption_set_id SiteRecoveryVmwareReplicatedVm#default_target_disk_encryption_set_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultTargetDiskEncryptionSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultTargetDiskEncryptionSetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_vmware_replicated_vm#id SiteRecoveryVmwareReplicatedVm#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_vmware_replicated_vm#license_type SiteRecoveryVmwareReplicatedVm#license_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "licenseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LicenseType
        {
            get;
            set;
        }

        private object? _managedDisk;

        /// <summary>managed_disk block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_vmware_replicated_vm#managed_disk SiteRecoveryVmwareReplicatedVm#managed_disk}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SiteRecoveryVmwareReplicatedVm.ISiteRecoveryVmwareReplicatedVmManagedDisk" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managedDisk", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.siteRecoveryVmwareReplicatedVm.SiteRecoveryVmwareReplicatedVmManagedDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ManagedDisk
        {
            get => _managedDisk;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.SiteRecoveryVmwareReplicatedVm.ISiteRecoveryVmwareReplicatedVmManagedDisk[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SiteRecoveryVmwareReplicatedVm.ISiteRecoveryVmwareReplicatedVmManagedDisk).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _managedDisk = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_vmware_replicated_vm#multi_vm_group_name SiteRecoveryVmwareReplicatedVm#multi_vm_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "multiVmGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MultiVmGroupName
        {
            get;
            set;
        }

        private object? _networkInterface;

        /// <summary>network_interface block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_vmware_replicated_vm#network_interface SiteRecoveryVmwareReplicatedVm#network_interface}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SiteRecoveryVmwareReplicatedVm.ISiteRecoveryVmwareReplicatedVmNetworkInterface" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkInterface", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.siteRecoveryVmwareReplicatedVm.SiteRecoveryVmwareReplicatedVmNetworkInterface\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NetworkInterface
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
                        case azurerm.SiteRecoveryVmwareReplicatedVm.ISiteRecoveryVmwareReplicatedVmNetworkInterface[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SiteRecoveryVmwareReplicatedVm.ISiteRecoveryVmwareReplicatedVmNetworkInterface).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkInterface = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_vmware_replicated_vm#target_availability_set_id SiteRecoveryVmwareReplicatedVm#target_availability_set_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetAvailabilitySetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetAvailabilitySetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_vmware_replicated_vm#target_boot_diagnostics_storage_account_id SiteRecoveryVmwareReplicatedVm#target_boot_diagnostics_storage_account_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetBootDiagnosticsStorageAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetBootDiagnosticsStorageAccountId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_vmware_replicated_vm#target_network_id SiteRecoveryVmwareReplicatedVm#target_network_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetNetworkId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_vmware_replicated_vm#target_proximity_placement_group_id SiteRecoveryVmwareReplicatedVm#target_proximity_placement_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetProximityPlacementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetProximityPlacementGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_vmware_replicated_vm#target_vm_size SiteRecoveryVmwareReplicatedVm#target_vm_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetVmSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetVmSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_vmware_replicated_vm#target_zone SiteRecoveryVmwareReplicatedVm#target_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_vmware_replicated_vm#test_network_id SiteRecoveryVmwareReplicatedVm#test_network_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "testNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TestNetworkId
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/site_recovery_vmware_replicated_vm#timeouts SiteRecoveryVmwareReplicatedVm#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.siteRecoveryVmwareReplicatedVm.SiteRecoveryVmwareReplicatedVmTimeouts\"}", isOptional: true)]
        public azurerm.SiteRecoveryVmwareReplicatedVm.ISiteRecoveryVmwareReplicatedVmTimeouts? Timeouts
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
