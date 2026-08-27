using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SiteRecoveryReplicatedVm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.siteRecoveryReplicatedVm.SiteRecoveryReplicatedVmConfig")]
    public class SiteRecoveryReplicatedVmConfig : azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#name SiteRecoveryReplicatedVm#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#recovery_replication_policy_id SiteRecoveryReplicatedVm#recovery_replication_policy_id}.</summary>
        [JsiiProperty(name: "recoveryReplicationPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public string RecoveryReplicationPolicyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#recovery_vault_name SiteRecoveryReplicatedVm#recovery_vault_name}.</summary>
        [JsiiProperty(name: "recoveryVaultName", typeJson: "{\"primitive\":\"string\"}")]
        public string RecoveryVaultName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#resource_group_name SiteRecoveryReplicatedVm#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#source_recovery_fabric_name SiteRecoveryReplicatedVm#source_recovery_fabric_name}.</summary>
        [JsiiProperty(name: "sourceRecoveryFabricName", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceRecoveryFabricName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#source_recovery_protection_container_name SiteRecoveryReplicatedVm#source_recovery_protection_container_name}.</summary>
        [JsiiProperty(name: "sourceRecoveryProtectionContainerName", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceRecoveryProtectionContainerName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#source_vm_id SiteRecoveryReplicatedVm#source_vm_id}.</summary>
        [JsiiProperty(name: "sourceVmId", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceVmId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#target_recovery_fabric_id SiteRecoveryReplicatedVm#target_recovery_fabric_id}.</summary>
        [JsiiProperty(name: "targetRecoveryFabricId", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetRecoveryFabricId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#target_recovery_protection_container_id SiteRecoveryReplicatedVm#target_recovery_protection_container_id}.</summary>
        [JsiiProperty(name: "targetRecoveryProtectionContainerId", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetRecoveryProtectionContainerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#target_resource_group_id SiteRecoveryReplicatedVm#target_resource_group_id}.</summary>
        [JsiiProperty(name: "targetResourceGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetResourceGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#id SiteRecoveryReplicatedVm#id}.</summary>
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

        private object? _managedDisk;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#managed_disk SiteRecoveryReplicatedVm#managed_disk}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmManagedDisk" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managedDisk", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.siteRecoveryReplicatedVm.SiteRecoveryReplicatedVmManagedDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmManagedDisk[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmManagedDisk).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _managedDisk = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#multi_vm_group_name SiteRecoveryReplicatedVm#multi_vm_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "multiVmGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MultiVmGroupName
        {
            get;
            set;
        }

        private object? _networkInterface;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#network_interface SiteRecoveryReplicatedVm#network_interface}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmNetworkInterface" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkInterface", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.siteRecoveryReplicatedVm.SiteRecoveryReplicatedVmNetworkInterface\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmNetworkInterface[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmNetworkInterface).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkInterface = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#target_availability_set_id SiteRecoveryReplicatedVm#target_availability_set_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetAvailabilitySetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetAvailabilitySetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#target_boot_diagnostic_storage_account_id SiteRecoveryReplicatedVm#target_boot_diagnostic_storage_account_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetBootDiagnosticStorageAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetBootDiagnosticStorageAccountId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#target_capacity_reservation_group_id SiteRecoveryReplicatedVm#target_capacity_reservation_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetCapacityReservationGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetCapacityReservationGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#target_edge_zone SiteRecoveryReplicatedVm#target_edge_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetEdgeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetEdgeZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#target_network_id SiteRecoveryReplicatedVm#target_network_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetNetworkId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#target_proximity_placement_group_id SiteRecoveryReplicatedVm#target_proximity_placement_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetProximityPlacementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetProximityPlacementGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#target_virtual_machine_scale_set_id SiteRecoveryReplicatedVm#target_virtual_machine_scale_set_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetVirtualMachineScaleSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetVirtualMachineScaleSetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#target_virtual_machine_size SiteRecoveryReplicatedVm#target_virtual_machine_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetVirtualMachineSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetVirtualMachineSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#target_zone SiteRecoveryReplicatedVm#target_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#test_network_id SiteRecoveryReplicatedVm#test_network_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "testNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TestNetworkId
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#timeouts SiteRecoveryReplicatedVm#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.siteRecoveryReplicatedVm.SiteRecoveryReplicatedVmTimeouts\"}", isOptional: true)]
        public azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmTimeouts? Timeouts
        {
            get;
            set;
        }

        private object? _unmanagedDisk;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/site_recovery_replicated_vm#unmanaged_disk SiteRecoveryReplicatedVm#unmanaged_disk}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmUnmanagedDisk" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "unmanagedDisk", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.siteRecoveryReplicatedVm.SiteRecoveryReplicatedVmUnmanagedDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UnmanagedDisk
        {
            get => _unmanagedDisk;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmUnmanagedDisk[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmUnmanagedDisk).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _unmanagedDisk = value;
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
