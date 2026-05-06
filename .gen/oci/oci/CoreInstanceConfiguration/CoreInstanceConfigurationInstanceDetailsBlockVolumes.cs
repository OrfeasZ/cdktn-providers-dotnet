using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstanceConfiguration
{
    [JsiiByValue(fqn: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsBlockVolumes")]
    public class CoreInstanceConfigurationInstanceDetailsBlockVolumes : oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsBlockVolumes
    {
        /// <summary>attach_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#attach_details CoreInstanceConfiguration#attach_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "attachDetails", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsBlockVolumesAttachDetails\"}", isOptional: true)]
        public oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsBlockVolumesAttachDetails? AttachDetails
        {
            get;
            set;
        }

        /// <summary>create_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#create_details CoreInstanceConfiguration#create_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createDetails", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsBlockVolumesCreateDetails\"}", isOptional: true)]
        public oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsBlockVolumesCreateDetails? CreateDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#volume_id CoreInstanceConfiguration#volume_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VolumeId
        {
            get;
            set;
        }
    }
}
