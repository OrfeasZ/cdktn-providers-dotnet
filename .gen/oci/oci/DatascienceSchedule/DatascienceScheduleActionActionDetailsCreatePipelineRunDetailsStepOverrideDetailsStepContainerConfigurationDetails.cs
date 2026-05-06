using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsStepContainerConfigurationDetails")]
    public class DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsStepContainerConfigurationDetails : oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsStepContainerConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#container_type DatascienceSchedule#container_type}.</summary>
        [JsiiProperty(name: "containerType", typeJson: "{\"primitive\":\"string\"}")]
        public string ContainerType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#image DatascienceSchedule#image}.</summary>
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public string Image
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#cmd DatascienceSchedule#cmd}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cmd", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Cmd
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#entrypoint DatascienceSchedule#entrypoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "entrypoint", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Entrypoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#image_digest DatascienceSchedule#image_digest}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageDigest
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#image_signature_id DatascienceSchedule#image_signature_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageSignatureId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageSignatureId
        {
            get;
            set;
        }
    }
}
