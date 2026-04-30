using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTable
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFields")]
    public class GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFields : aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFields
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#name GlueCatalogTable#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#source_id GlueCatalogTable#source_id}.</summary>
        [JsiiProperty(name: "sourceId", typeJson: "{\"primitive\":\"number\"}")]
        public double SourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#transform GlueCatalogTable#transform}.</summary>
        [JsiiProperty(name: "transform", typeJson: "{\"primitive\":\"string\"}")]
        public string Transform
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#field_id GlueCatalogTable#field_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fieldId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FieldId
        {
            get;
            set;
        }
    }
}
