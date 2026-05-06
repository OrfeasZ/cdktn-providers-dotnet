using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreInstance.CoreInstanceLaunchVolumeAttachmentsLaunchCreateVolumeDetails")]
    public class CoreInstanceLaunchVolumeAttachmentsLaunchCreateVolumeDetails : oci.CoreInstance.ICoreInstanceLaunchVolumeAttachmentsLaunchCreateVolumeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#size_in_gbs CoreInstance#size_in_gbs}.</summary>
        [JsiiProperty(name: "sizeInGbs", typeJson: "{\"primitive\":\"string\"}")]
        public string SizeInGbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#volume_creation_type CoreInstance#volume_creation_type}.</summary>
        [JsiiProperty(name: "volumeCreationType", typeJson: "{\"primitive\":\"string\"}")]
        public string VolumeCreationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#compartment_id CoreInstance#compartment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#display_name CoreInstance#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#kms_key_id CoreInstance#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance#vpus_per_gb CoreInstance#vpus_per_gb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpusPerGb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VpusPerGb
        {
            get;
            set;
        }
    }
}
