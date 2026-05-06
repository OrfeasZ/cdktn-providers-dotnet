using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVolumeGroup
{
    [JsiiInterface(nativeType: typeof(ICoreVolumeGroupSourceDetails), fullyQualifiedName: "oci.coreVolumeGroup.CoreVolumeGroupSourceDetails")]
    public interface ICoreVolumeGroupSourceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group#type CoreVolumeGroup#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group#volume_group_backup_id CoreVolumeGroup#volume_group_backup_id}.</summary>
        [JsiiProperty(name: "volumeGroupBackupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VolumeGroupBackupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group#volume_group_id CoreVolumeGroup#volume_group_id}.</summary>
        [JsiiProperty(name: "volumeGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VolumeGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group#volume_group_replica_id CoreVolumeGroup#volume_group_replica_id}.</summary>
        [JsiiProperty(name: "volumeGroupReplicaId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VolumeGroupReplicaId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group#volume_ids CoreVolumeGroup#volume_ids}.</summary>
        [JsiiProperty(name: "volumeIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? VolumeIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreVolumeGroupSourceDetails), fullyQualifiedName: "oci.coreVolumeGroup.CoreVolumeGroupSourceDetails")]
        internal sealed class _Proxy : DeputyBase, oci.CoreVolumeGroup.ICoreVolumeGroupSourceDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group#type CoreVolumeGroup#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group#volume_group_backup_id CoreVolumeGroup#volume_group_backup_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "volumeGroupBackupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VolumeGroupBackupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group#volume_group_id CoreVolumeGroup#volume_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "volumeGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VolumeGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group#volume_group_replica_id CoreVolumeGroup#volume_group_replica_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "volumeGroupReplicaId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VolumeGroupReplicaId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group#volume_ids CoreVolumeGroup#volume_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "volumeIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? VolumeIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
