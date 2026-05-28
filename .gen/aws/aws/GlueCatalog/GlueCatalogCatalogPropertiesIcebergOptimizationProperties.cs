using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalog
{
    [JsiiByValue(fqn: "aws.glueCatalog.GlueCatalogCatalogPropertiesIcebergOptimizationProperties")]
    public class GlueCatalogCatalogPropertiesIcebergOptimizationProperties : aws.GlueCatalog.IGlueCatalogCatalogPropertiesIcebergOptimizationProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/glue_catalog#compaction GlueCatalog#compaction}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compaction", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Compaction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/glue_catalog#orphan_file_deletion GlueCatalog#orphan_file_deletion}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "orphanFileDeletion", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? OrphanFileDeletion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/glue_catalog#retention GlueCatalog#retention}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retention", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Retention
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/glue_catalog#role_arn GlueCatalog#role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RoleArn
        {
            get;
            set;
        }
    }
}
