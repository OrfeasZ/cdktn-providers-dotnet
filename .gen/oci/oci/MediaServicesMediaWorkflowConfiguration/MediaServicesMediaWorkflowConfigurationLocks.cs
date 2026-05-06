using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MediaServicesMediaWorkflowConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.mediaServicesMediaWorkflowConfiguration.MediaServicesMediaWorkflowConfigurationLocks")]
    public class MediaServicesMediaWorkflowConfigurationLocks : oci.MediaServicesMediaWorkflowConfiguration.IMediaServicesMediaWorkflowConfigurationLocks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_media_workflow_configuration#compartment_id MediaServicesMediaWorkflowConfiguration#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public string CompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_media_workflow_configuration#type MediaServicesMediaWorkflowConfiguration#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_media_workflow_configuration#message MediaServicesMediaWorkflowConfiguration#message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Message
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_media_workflow_configuration#related_resource_id MediaServicesMediaWorkflowConfiguration#related_resource_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "relatedResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RelatedResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_media_workflow_configuration#time_created MediaServicesMediaWorkflowConfiguration#time_created}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeCreated
        {
            get;
            set;
        }
    }
}
