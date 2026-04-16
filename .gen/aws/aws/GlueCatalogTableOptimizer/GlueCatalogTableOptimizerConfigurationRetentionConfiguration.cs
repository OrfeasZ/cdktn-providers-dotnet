using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTableOptimizer
{
    [JsiiByValue(fqn: "aws.glueCatalogTableOptimizer.GlueCatalogTableOptimizerConfigurationRetentionConfiguration")]
    public class GlueCatalogTableOptimizerConfigurationRetentionConfiguration : aws.GlueCatalogTableOptimizer.IGlueCatalogTableOptimizerConfigurationRetentionConfiguration
    {
        private object? _icebergConfiguration;

        /// <summary>iceberg_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/glue_catalog_table_optimizer#iceberg_configuration GlueCatalogTableOptimizer#iceberg_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "icebergConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalogTableOptimizer.GlueCatalogTableOptimizerConfigurationRetentionConfigurationIcebergConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IcebergConfiguration
        {
            get => _icebergConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.GlueCatalogTableOptimizer.IGlueCatalogTableOptimizerConfigurationRetentionConfigurationIcebergConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.GlueCatalogTableOptimizer.IGlueCatalogTableOptimizerConfigurationRetentionConfigurationIcebergConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _icebergConfiguration = value;
            }
        }
    }
}
