using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeGroupOracle
{
    [JsiiInterface(nativeType: typeof(INetappVolumeGroupOracleVolumeDataProtectionReplication), fullyQualifiedName: "azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolumeDataProtectionReplication")]
    public interface INetappVolumeGroupOracleVolumeDataProtectionReplication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_group_oracle#remote_volume_location NetappVolumeGroupOracle#remote_volume_location}.</summary>
        [JsiiProperty(name: "remoteVolumeLocation", typeJson: "{\"primitive\":\"string\"}")]
        string RemoteVolumeLocation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_group_oracle#remote_volume_resource_id NetappVolumeGroupOracle#remote_volume_resource_id}.</summary>
        [JsiiProperty(name: "remoteVolumeResourceId", typeJson: "{\"primitive\":\"string\"}")]
        string RemoteVolumeResourceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_group_oracle#replication_frequency NetappVolumeGroupOracle#replication_frequency}.</summary>
        [JsiiProperty(name: "replicationFrequency", typeJson: "{\"primitive\":\"string\"}")]
        string ReplicationFrequency
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_group_oracle#endpoint_type NetappVolumeGroupOracle#endpoint_type}.</summary>
        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndpointType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetappVolumeGroupOracleVolumeDataProtectionReplication), fullyQualifiedName: "azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolumeDataProtectionReplication")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeDataProtectionReplication
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_group_oracle#remote_volume_location NetappVolumeGroupOracle#remote_volume_location}.</summary>
            [JsiiProperty(name: "remoteVolumeLocation", typeJson: "{\"primitive\":\"string\"}")]
            public string RemoteVolumeLocation
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_group_oracle#remote_volume_resource_id NetappVolumeGroupOracle#remote_volume_resource_id}.</summary>
            [JsiiProperty(name: "remoteVolumeResourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string RemoteVolumeResourceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_group_oracle#replication_frequency NetappVolumeGroupOracle#replication_frequency}.</summary>
            [JsiiProperty(name: "replicationFrequency", typeJson: "{\"primitive\":\"string\"}")]
            public string ReplicationFrequency
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_group_oracle#endpoint_type NetappVolumeGroupOracle#endpoint_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndpointType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
