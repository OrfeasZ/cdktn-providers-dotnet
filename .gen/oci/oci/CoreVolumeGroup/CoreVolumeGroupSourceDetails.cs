using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVolumeGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreVolumeGroup.CoreVolumeGroupSourceDetails")]
    public class CoreVolumeGroupSourceDetails : oci.CoreVolumeGroup.ICoreVolumeGroupSourceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group#type CoreVolumeGroup#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group#volume_group_backup_id CoreVolumeGroup#volume_group_backup_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumeGroupBackupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VolumeGroupBackupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group#volume_group_id CoreVolumeGroup#volume_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumeGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VolumeGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group#volume_group_replica_id CoreVolumeGroup#volume_group_replica_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumeGroupReplicaId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VolumeGroupReplicaId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group#volume_ids CoreVolumeGroup#volume_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumeIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? VolumeIds
        {
            get;
            set;
        }
    }
}
