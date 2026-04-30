using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTable
{
    [JsiiByValue(fqn: "aws.glueCatalogTable.GlueCatalogTableViewDefinitionRepresentations")]
    public class GlueCatalogTableViewDefinitionRepresentations : aws.GlueCatalogTable.IGlueCatalogTableViewDefinitionRepresentations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#dialect GlueCatalogTable#dialect}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dialect", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Dialect
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#dialect_version GlueCatalogTable#dialect_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dialectVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DialectVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#validation_connection GlueCatalogTable#validation_connection}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "validationConnection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ValidationConnection
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#view_expanded_text GlueCatalogTable#view_expanded_text}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "viewExpandedText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ViewExpandedText
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#view_original_text GlueCatalogTable#view_original_text}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "viewOriginalText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ViewOriginalText
        {
            get;
            set;
        }
    }
}
