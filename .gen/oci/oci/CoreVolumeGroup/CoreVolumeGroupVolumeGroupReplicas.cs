using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVolumeGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreVolumeGroup.CoreVolumeGroupVolumeGroupReplicas")]
    public class CoreVolumeGroupVolumeGroupReplicas : oci.CoreVolumeGroup.ICoreVolumeGroupVolumeGroupReplicas
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group#availability_domain CoreVolumeGroup#availability_domain}.</summary>
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public string AvailabilityDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group#display_name CoreVolumeGroup#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_group#xrr_kms_key_id CoreVolumeGroup#xrr_kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "xrrKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? XrrKmsKeyId
        {
            get;
            set;
        }
    }
}
