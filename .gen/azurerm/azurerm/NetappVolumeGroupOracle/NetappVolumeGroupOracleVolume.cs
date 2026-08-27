using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeGroupOracle
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolume")]
    public class NetappVolumeGroupOracleVolume : azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolume
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_oracle#capacity_pool_id NetappVolumeGroupOracle#capacity_pool_id}.</summary>
        [JsiiProperty(name: "capacityPoolId", typeJson: "{\"primitive\":\"string\"}")]
        public string CapacityPoolId
        {
            get;
            set;
        }

        private object _exportPolicyRule;

        /// <summary>export_policy_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_oracle#export_policy_rule NetappVolumeGroupOracle#export_policy_rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeExportPolicyRule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "exportPolicyRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolumeExportPolicyRule\"},\"kind\":\"array\"}}]}}")]
        public object ExportPolicyRule
        {
            get => _exportPolicyRule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeExportPolicyRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeExportPolicyRule).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeExportPolicyRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _exportPolicyRule = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_oracle#name NetappVolumeGroupOracle#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_oracle#protocols NetappVolumeGroupOracle#protocols}.</summary>
        [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Protocols
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_oracle#security_style NetappVolumeGroupOracle#security_style}.</summary>
        [JsiiProperty(name: "securityStyle", typeJson: "{\"primitive\":\"string\"}")]
        public string SecurityStyle
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_oracle#service_level NetappVolumeGroupOracle#service_level}.</summary>
        [JsiiProperty(name: "serviceLevel", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceLevel
        {
            get;
            set;
        }

        private object _snapshotDirectoryVisible;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_oracle#snapshot_directory_visible NetappVolumeGroupOracle#snapshot_directory_visible}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "snapshotDirectoryVisible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object SnapshotDirectoryVisible
        {
            get => _snapshotDirectoryVisible;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _snapshotDirectoryVisible = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_oracle#storage_quota_in_gb NetappVolumeGroupOracle#storage_quota_in_gb}.</summary>
        [JsiiProperty(name: "storageQuotaInGb", typeJson: "{\"primitive\":\"number\"}")]
        public double StorageQuotaInGb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_oracle#subnet_id NetappVolumeGroupOracle#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_oracle#throughput_in_mibps NetappVolumeGroupOracle#throughput_in_mibps}.</summary>
        [JsiiProperty(name: "throughputInMibps", typeJson: "{\"primitive\":\"number\"}")]
        public double ThroughputInMibps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_oracle#volume_path NetappVolumeGroupOracle#volume_path}.</summary>
        [JsiiProperty(name: "volumePath", typeJson: "{\"primitive\":\"string\"}")]
        public string VolumePath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_oracle#volume_spec_name NetappVolumeGroupOracle#volume_spec_name}.</summary>
        [JsiiProperty(name: "volumeSpecName", typeJson: "{\"primitive\":\"string\"}")]
        public string VolumeSpecName
        {
            get;
            set;
        }

        /// <summary>data_protection_replication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_oracle#data_protection_replication NetappVolumeGroupOracle#data_protection_replication}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataProtectionReplication", typeJson: "{\"fqn\":\"azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolumeDataProtectionReplication\"}", isOptional: true)]
        public azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeDataProtectionReplication? DataProtectionReplication
        {
            get;
            set;
        }

        /// <summary>data_protection_snapshot_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_oracle#data_protection_snapshot_policy NetappVolumeGroupOracle#data_protection_snapshot_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataProtectionSnapshotPolicy", typeJson: "{\"fqn\":\"azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicy\"}", isOptional: true)]
        public azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicy? DataProtectionSnapshotPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_oracle#encryption_key_source NetappVolumeGroupOracle#encryption_key_source}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionKeySource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EncryptionKeySource
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_oracle#key_vault_private_endpoint_id NetappVolumeGroupOracle#key_vault_private_endpoint_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyVaultPrivateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyVaultPrivateEndpointId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_oracle#network_features NetappVolumeGroupOracle#network_features}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkFeatures", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkFeatures
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_oracle#proximity_placement_group_id NetappVolumeGroupOracle#proximity_placement_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "proximityPlacementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProximityPlacementGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_oracle#tags NetappVolumeGroupOracle#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_group_oracle#zone NetappVolumeGroupOracle#zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Zone
        {
            get;
            set;
        }
    }
}
