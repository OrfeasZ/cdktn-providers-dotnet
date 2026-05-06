using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ResourceAnalyticsTenancyAttachment
{
    [JsiiByValue(fqn: "oci.resourceAnalyticsTenancyAttachment.ResourceAnalyticsTenancyAttachmentTimeouts")]
    public class ResourceAnalyticsTenancyAttachmentTimeouts : oci.ResourceAnalyticsTenancyAttachment.IResourceAnalyticsTenancyAttachmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_analytics_tenancy_attachment#create ResourceAnalyticsTenancyAttachment#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_analytics_tenancy_attachment#delete ResourceAnalyticsTenancyAttachment#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_analytics_tenancy_attachment#read ResourceAnalyticsTenancyAttachment#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_analytics_tenancy_attachment#update ResourceAnalyticsTenancyAttachment#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
