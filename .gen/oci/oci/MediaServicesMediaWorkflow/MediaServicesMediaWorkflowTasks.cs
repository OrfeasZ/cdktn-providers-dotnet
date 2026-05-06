using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MediaServicesMediaWorkflow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.mediaServicesMediaWorkflow.MediaServicesMediaWorkflowTasks")]
    public class MediaServicesMediaWorkflowTasks : oci.MediaServicesMediaWorkflow.IMediaServicesMediaWorkflowTasks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_media_workflow#key MediaServicesMediaWorkflow#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_media_workflow#parameters MediaServicesMediaWorkflow#parameters}.</summary>
        [JsiiProperty(name: "parameters", typeJson: "{\"primitive\":\"string\"}")]
        public string Parameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_media_workflow#type MediaServicesMediaWorkflow#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_media_workflow#version MediaServicesMediaWorkflow#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public string Version
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_media_workflow#enable_parameter_reference MediaServicesMediaWorkflow#enable_parameter_reference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableParameterReference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EnableParameterReference
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_media_workflow#enable_when_referenced_parameter_equals MediaServicesMediaWorkflow#enable_when_referenced_parameter_equals}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableWhenReferencedParameterEquals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? EnableWhenReferencedParameterEquals
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_media_workflow#prerequisites MediaServicesMediaWorkflow#prerequisites}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prerequisites", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Prerequisites
        {
            get;
            set;
        }
    }
}
