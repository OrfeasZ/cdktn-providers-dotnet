using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskChannel
{
    [JsiiByValue(fqn: "aws.mskChannel.MskChannelIcebergDestinationCatalog")]
    public class MskChannelIcebergDestinationCatalog : aws.MskChannel.IMskChannelIcebergDestinationCatalog
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#catalog_arn MskChannel#catalog_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "catalogArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CatalogArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#warehouse_location MskChannel#warehouse_location}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "warehouseLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WarehouseLocation
        {
            get;
            set;
        }
    }
}
