using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTable
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInput")]
    public class GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInput : aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInput
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#location GlueCatalogTable#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public string Location
        {
            get;
            set;
        }

        /// <summary>schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#schema GlueCatalogTable#schema}
        /// </remarks>
        [JsiiProperty(name: "schema", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputSchema\"}")]
        public aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputSchema Schema
        {
            get;
            set;
        }

        /// <summary>partition_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#partition_spec GlueCatalogTable#partition_spec}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "partitionSpec", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpec\"}", isOptional: true)]
        public aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpec? PartitionSpec
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#properties GlueCatalogTable#properties}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Properties
        {
            get;
            set;
        }

        /// <summary>sort_order block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#sort_order GlueCatalogTable#sort_order}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sortOrder", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputSortOrder\"}", isOptional: true)]
        public aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputSortOrder? SortOrder
        {
            get;
            set;
        }
    }
}
