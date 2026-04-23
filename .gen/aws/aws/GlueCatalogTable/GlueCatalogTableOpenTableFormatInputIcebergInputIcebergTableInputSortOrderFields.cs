using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTable
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputSortOrderFields")]
    public class GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputSortOrderFields : aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputSortOrderFields
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/glue_catalog_table#direction GlueCatalogTable#direction}.</summary>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}")]
        public string Direction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/glue_catalog_table#null_order GlueCatalogTable#null_order}.</summary>
        [JsiiProperty(name: "nullOrder", typeJson: "{\"primitive\":\"string\"}")]
        public string NullOrder
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/glue_catalog_table#source_id GlueCatalogTable#source_id}.</summary>
        [JsiiProperty(name: "sourceId", typeJson: "{\"primitive\":\"number\"}")]
        public double SourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/glue_catalog_table#transform GlueCatalogTable#transform}.</summary>
        [JsiiProperty(name: "transform", typeJson: "{\"primitive\":\"string\"}")]
        public string Transform
        {
            get;
            set;
        }
    }
}
