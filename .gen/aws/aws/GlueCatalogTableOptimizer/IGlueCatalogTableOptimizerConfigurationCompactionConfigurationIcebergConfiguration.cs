using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTableOptimizer
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogTableOptimizerConfigurationCompactionConfigurationIcebergConfiguration), fullyQualifiedName: "aws.glueCatalogTableOptimizer.GlueCatalogTableOptimizerConfigurationCompactionConfigurationIcebergConfiguration")]
    public interface IGlueCatalogTableOptimizerConfigurationCompactionConfigurationIcebergConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/glue_catalog_table_optimizer#delete_file_threshold GlueCatalogTableOptimizer#delete_file_threshold}.</summary>
        [JsiiProperty(name: "deleteFileThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DeleteFileThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/glue_catalog_table_optimizer#min_input_files GlueCatalogTableOptimizer#min_input_files}.</summary>
        [JsiiProperty(name: "minInputFiles", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinInputFiles
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/glue_catalog_table_optimizer#strategy GlueCatalogTableOptimizer#strategy}.</summary>
        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Strategy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogTableOptimizerConfigurationCompactionConfigurationIcebergConfiguration), fullyQualifiedName: "aws.glueCatalogTableOptimizer.GlueCatalogTableOptimizerConfigurationCompactionConfigurationIcebergConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.GlueCatalogTableOptimizer.IGlueCatalogTableOptimizerConfigurationCompactionConfigurationIcebergConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/glue_catalog_table_optimizer#delete_file_threshold GlueCatalogTableOptimizer#delete_file_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deleteFileThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DeleteFileThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/glue_catalog_table_optimizer#min_input_files GlueCatalogTableOptimizer#min_input_files}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minInputFiles", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinInputFiles
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/glue_catalog_table_optimizer#strategy GlueCatalogTableOptimizer#strategy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Strategy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
