using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskChannel
{
    [JsiiInterface(nativeType: typeof(IMskChannelIcebergDestinationCatalog), fullyQualifiedName: "aws.mskChannel.MskChannelIcebergDestinationCatalog")]
    public interface IMskChannelIcebergDestinationCatalog
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#catalog_arn MskChannel#catalog_arn}.</summary>
        [JsiiProperty(name: "catalogArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CatalogArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#warehouse_location MskChannel#warehouse_location}.</summary>
        [JsiiProperty(name: "warehouseLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WarehouseLocation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskChannelIcebergDestinationCatalog), fullyQualifiedName: "aws.mskChannel.MskChannelIcebergDestinationCatalog")]
        internal sealed class _Proxy : DeputyBase, aws.MskChannel.IMskChannelIcebergDestinationCatalog
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#catalog_arn MskChannel#catalog_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "catalogArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CatalogArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#warehouse_location MskChannel#warehouse_location}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "warehouseLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WarehouseLocation
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
