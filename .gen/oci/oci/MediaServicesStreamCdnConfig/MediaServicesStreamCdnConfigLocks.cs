using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MediaServicesStreamCdnConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.mediaServicesStreamCdnConfig.MediaServicesStreamCdnConfigLocks")]
    public class MediaServicesStreamCdnConfigLocks : oci.MediaServicesStreamCdnConfig.IMediaServicesStreamCdnConfigLocks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_stream_cdn_config#compartment_id MediaServicesStreamCdnConfig#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public string CompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_stream_cdn_config#type MediaServicesStreamCdnConfig#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_stream_cdn_config#message MediaServicesStreamCdnConfig#message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Message
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_stream_cdn_config#related_resource_id MediaServicesStreamCdnConfig#related_resource_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "relatedResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RelatedResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/media_services_stream_cdn_config#time_created MediaServicesStreamCdnConfig#time_created}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeCreated
        {
            get;
            set;
        }
    }
}
