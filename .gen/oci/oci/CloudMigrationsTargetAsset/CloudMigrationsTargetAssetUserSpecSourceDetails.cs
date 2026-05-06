using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudMigrationsTargetAsset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecSourceDetails")]
    public class CloudMigrationsTargetAssetUserSpecSourceDetails : oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecSourceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#source_type CloudMigrationsTargetAsset#source_type}.</summary>
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#boot_volume_id CloudMigrationsTargetAsset#boot_volume_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bootVolumeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BootVolumeId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#boot_volume_size_in_gbs CloudMigrationsTargetAsset#boot_volume_size_in_gbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bootVolumeSizeInGbs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BootVolumeSizeInGbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#boot_volume_vpus_per_gb CloudMigrationsTargetAsset#boot_volume_vpus_per_gb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bootVolumeVpusPerGb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BootVolumeVpusPerGb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#image_id CloudMigrationsTargetAsset#image_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#kms_key_id CloudMigrationsTargetAsset#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }
    }
}
