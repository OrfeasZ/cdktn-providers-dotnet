using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMediaServicesMediaAssetDistributionChannelAttachment
{
    [JsiiByValue(fqn: "oci.dataOciMediaServicesMediaAssetDistributionChannelAttachment.DataOciMediaServicesMediaAssetDistributionChannelAttachmentLocks")]
    public class DataOciMediaServicesMediaAssetDistributionChannelAttachmentLocks : oci.DataOciMediaServicesMediaAssetDistributionChannelAttachment.IDataOciMediaServicesMediaAssetDistributionChannelAttachmentLocks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/media_services_media_asset_distribution_channel_attachment#message DataOciMediaServicesMediaAssetDistributionChannelAttachment#message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Message
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/media_services_media_asset_distribution_channel_attachment#related_resource_id DataOciMediaServicesMediaAssetDistributionChannelAttachment#related_resource_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "relatedResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RelatedResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/media_services_media_asset_distribution_channel_attachment#time_created DataOciMediaServicesMediaAssetDistributionChannelAttachment#time_created}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeCreated
        {
            get;
            set;
        }
    }
}
