using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTableOptimizer
{
    [JsiiByValue(fqn: "aws.glueCatalogTableOptimizer.GlueCatalogTableOptimizerConfigurationCompactionConfigurationIcebergConfiguration")]
    public class GlueCatalogTableOptimizerConfigurationCompactionConfigurationIcebergConfiguration : aws.GlueCatalogTableOptimizer.IGlueCatalogTableOptimizerConfigurationCompactionConfigurationIcebergConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/glue_catalog_table_optimizer#delete_file_threshold GlueCatalogTableOptimizer#delete_file_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deleteFileThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DeleteFileThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/glue_catalog_table_optimizer#min_input_files GlueCatalogTableOptimizer#min_input_files}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minInputFiles", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinInputFiles
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/glue_catalog_table_optimizer#strategy GlueCatalogTableOptimizer#strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Strategy
        {
            get;
            set;
        }
    }
}
