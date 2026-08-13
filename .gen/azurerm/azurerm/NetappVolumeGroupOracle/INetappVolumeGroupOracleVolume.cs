using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeGroupOracle
{
    [JsiiInterface(nativeType: typeof(INetappVolumeGroupOracleVolume), fullyQualifiedName: "azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolume")]
    public interface INetappVolumeGroupOracleVolume
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#capacity_pool_id NetappVolumeGroupOracle#capacity_pool_id}.</summary>
        [JsiiProperty(name: "capacityPoolId", typeJson: "{\"primitive\":\"string\"}")]
        string CapacityPoolId
        {
            get;
        }

        /// <summary>export_policy_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#export_policy_rule NetappVolumeGroupOracle#export_policy_rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeExportPolicyRule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "exportPolicyRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolumeExportPolicyRule\"},\"kind\":\"array\"}}]}}")]
        object ExportPolicyRule
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#name NetappVolumeGroupOracle#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#protocols NetappVolumeGroupOracle#protocols}.</summary>
        [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Protocols
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#security_style NetappVolumeGroupOracle#security_style}.</summary>
        [JsiiProperty(name: "securityStyle", typeJson: "{\"primitive\":\"string\"}")]
        string SecurityStyle
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#service_level NetappVolumeGroupOracle#service_level}.</summary>
        [JsiiProperty(name: "serviceLevel", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceLevel
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#snapshot_directory_visible NetappVolumeGroupOracle#snapshot_directory_visible}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "snapshotDirectoryVisible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object SnapshotDirectoryVisible
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#storage_quota_in_gb NetappVolumeGroupOracle#storage_quota_in_gb}.</summary>
        [JsiiProperty(name: "storageQuotaInGb", typeJson: "{\"primitive\":\"number\"}")]
        double StorageQuotaInGb
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#subnet_id NetappVolumeGroupOracle#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#throughput_in_mibps NetappVolumeGroupOracle#throughput_in_mibps}.</summary>
        [JsiiProperty(name: "throughputInMibps", typeJson: "{\"primitive\":\"number\"}")]
        double ThroughputInMibps
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#volume_path NetappVolumeGroupOracle#volume_path}.</summary>
        [JsiiProperty(name: "volumePath", typeJson: "{\"primitive\":\"string\"}")]
        string VolumePath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#volume_spec_name NetappVolumeGroupOracle#volume_spec_name}.</summary>
        [JsiiProperty(name: "volumeSpecName", typeJson: "{\"primitive\":\"string\"}")]
        string VolumeSpecName
        {
            get;
        }

        /// <summary>data_protection_replication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#data_protection_replication NetappVolumeGroupOracle#data_protection_replication}
        /// </remarks>
        [JsiiProperty(name: "dataProtectionReplication", typeJson: "{\"fqn\":\"azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolumeDataProtectionReplication\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeDataProtectionReplication? DataProtectionReplication
        {
            get
            {
                return null;
            }
        }

        /// <summary>data_protection_snapshot_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#data_protection_snapshot_policy NetappVolumeGroupOracle#data_protection_snapshot_policy}
        /// </remarks>
        [JsiiProperty(name: "dataProtectionSnapshotPolicy", typeJson: "{\"fqn\":\"azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicy? DataProtectionSnapshotPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#encryption_key_source NetappVolumeGroupOracle#encryption_key_source}.</summary>
        [JsiiProperty(name: "encryptionKeySource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptionKeySource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#key_vault_private_endpoint_id NetappVolumeGroupOracle#key_vault_private_endpoint_id}.</summary>
        [JsiiProperty(name: "keyVaultPrivateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyVaultPrivateEndpointId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#network_features NetappVolumeGroupOracle#network_features}.</summary>
        [JsiiProperty(name: "networkFeatures", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetworkFeatures
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#proximity_placement_group_id NetappVolumeGroupOracle#proximity_placement_group_id}.</summary>
        [JsiiProperty(name: "proximityPlacementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProximityPlacementGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#tags NetappVolumeGroupOracle#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#zone NetappVolumeGroupOracle#zone}.</summary>
        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Zone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetappVolumeGroupOracleVolume), fullyQualifiedName: "azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolume")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolume
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#capacity_pool_id NetappVolumeGroupOracle#capacity_pool_id}.</summary>
            [JsiiProperty(name: "capacityPoolId", typeJson: "{\"primitive\":\"string\"}")]
            public string CapacityPoolId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>export_policy_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#export_policy_rule NetappVolumeGroupOracle#export_policy_rule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeExportPolicyRule" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "exportPolicyRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolumeExportPolicyRule\"},\"kind\":\"array\"}}]}}")]
            public object ExportPolicyRule
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#name NetappVolumeGroupOracle#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#protocols NetappVolumeGroupOracle#protocols}.</summary>
            [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Protocols
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#security_style NetappVolumeGroupOracle#security_style}.</summary>
            [JsiiProperty(name: "securityStyle", typeJson: "{\"primitive\":\"string\"}")]
            public string SecurityStyle
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#service_level NetappVolumeGroupOracle#service_level}.</summary>
            [JsiiProperty(name: "serviceLevel", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceLevel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#snapshot_directory_visible NetappVolumeGroupOracle#snapshot_directory_visible}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "snapshotDirectoryVisible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object SnapshotDirectoryVisible
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#storage_quota_in_gb NetappVolumeGroupOracle#storage_quota_in_gb}.</summary>
            [JsiiProperty(name: "storageQuotaInGb", typeJson: "{\"primitive\":\"number\"}")]
            public double StorageQuotaInGb
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#subnet_id NetappVolumeGroupOracle#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#throughput_in_mibps NetappVolumeGroupOracle#throughput_in_mibps}.</summary>
            [JsiiProperty(name: "throughputInMibps", typeJson: "{\"primitive\":\"number\"}")]
            public double ThroughputInMibps
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#volume_path NetappVolumeGroupOracle#volume_path}.</summary>
            [JsiiProperty(name: "volumePath", typeJson: "{\"primitive\":\"string\"}")]
            public string VolumePath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#volume_spec_name NetappVolumeGroupOracle#volume_spec_name}.</summary>
            [JsiiProperty(name: "volumeSpecName", typeJson: "{\"primitive\":\"string\"}")]
            public string VolumeSpecName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>data_protection_replication block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#data_protection_replication NetappVolumeGroupOracle#data_protection_replication}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataProtectionReplication", typeJson: "{\"fqn\":\"azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolumeDataProtectionReplication\"}", isOptional: true)]
            public azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeDataProtectionReplication? DataProtectionReplication
            {
                get => GetInstanceProperty<azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeDataProtectionReplication?>();
            }

            /// <summary>data_protection_snapshot_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#data_protection_snapshot_policy NetappVolumeGroupOracle#data_protection_snapshot_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataProtectionSnapshotPolicy", typeJson: "{\"fqn\":\"azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicy\"}", isOptional: true)]
            public azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicy? DataProtectionSnapshotPolicy
            {
                get => GetInstanceProperty<azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#encryption_key_source NetappVolumeGroupOracle#encryption_key_source}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionKeySource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptionKeySource
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#key_vault_private_endpoint_id NetappVolumeGroupOracle#key_vault_private_endpoint_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyVaultPrivateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyVaultPrivateEndpointId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#network_features NetappVolumeGroupOracle#network_features}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkFeatures", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetworkFeatures
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#proximity_placement_group_id NetappVolumeGroupOracle#proximity_placement_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "proximityPlacementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProximityPlacementGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#tags NetappVolumeGroupOracle#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_group_oracle#zone NetappVolumeGroupOracle#zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Zone
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
