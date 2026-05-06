using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstanceConfiguration
{
    [JsiiByValue(fqn: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsBlockVolumes")]
    public class CoreInstanceConfigurationInstanceDetailsOptionsBlockVolumes : oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsBlockVolumes
    {
        /// <summary>attach_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#attach_details CoreInstanceConfiguration#attach_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "attachDetails", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesAttachDetails\"}", isOptional: true)]
        public oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesAttachDetails? AttachDetails
        {
            get;
            set;
        }

        /// <summary>create_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#create_details CoreInstanceConfiguration#create_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createDetails", typeJson: "{\"fqn\":\"oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetails\"}", isOptional: true)]
        public oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsBlockVolumesCreateDetails? CreateDetails
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
