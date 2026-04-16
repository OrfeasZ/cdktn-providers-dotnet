using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTable
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputSortOrderFields), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputSortOrderFields")]
    public interface IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputSortOrderFields
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/glue_catalog_table#direction GlueCatalogTable#direction}.</summary>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}")]
        string Direction
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/glue_catalog_table#null_order GlueCatalogTable#null_order}.</summary>
        [JsiiProperty(name: "nullOrder", typeJson: "{\"primitive\":\"string\"}")]
        string NullOrder
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/glue_catalog_table#source_id GlueCatalogTable#source_id}.</summary>
        [JsiiProperty(name: "sourceId", typeJson: "{\"primitive\":\"number\"}")]
        double SourceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/glue_catalog_table#transform GlueCatalogTable#transform}.</summary>
        [JsiiProperty(name: "transform", typeJson: "{\"primitive\":\"string\"}")]
        string Transform
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputSortOrderFields), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputSortOrderFields")]
        internal sealed class _Proxy : DeputyBase, aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputSortOrderFields
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/glue_catalog_table#direction GlueCatalogTable#direction}.</summary>
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}")]
            public string Direction
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/glue_catalog_table#null_order GlueCatalogTable#null_order}.</summary>
            [JsiiProperty(name: "nullOrder", typeJson: "{\"primitive\":\"string\"}")]
            public string NullOrder
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/glue_catalog_table#source_id GlueCatalogTable#source_id}.</summary>
            [JsiiProperty(name: "sourceId", typeJson: "{\"primitive\":\"number\"}")]
            public double SourceId
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/glue_catalog_table#transform GlueCatalogTable#transform}.</summary>
            [JsiiProperty(name: "transform", typeJson: "{\"primitive\":\"string\"}")]
            public string Transform
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
