using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTableOptimizer
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogTableOptimizerConfigurationCompactionConfiguration), fullyQualifiedName: "aws.glueCatalogTableOptimizer.GlueCatalogTableOptimizerConfigurationCompactionConfiguration")]
    public interface IGlueCatalogTableOptimizerConfigurationCompactionConfiguration
    {
        /// <summary>iceberg_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/glue_catalog_table_optimizer#iceberg_configuration GlueCatalogTableOptimizer#iceberg_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.GlueCatalogTableOptimizer.IGlueCatalogTableOptimizerConfigurationCompactionConfigurationIcebergConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "icebergConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalogTableOptimizer.GlueCatalogTableOptimizerConfigurationCompactionConfigurationIcebergConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IcebergConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogTableOptimizerConfigurationCompactionConfiguration), fullyQualifiedName: "aws.glueCatalogTableOptimizer.GlueCatalogTableOptimizerConfigurationCompactionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.GlueCatalogTableOptimizer.IGlueCatalogTableOptimizerConfigurationCompactionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>iceberg_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/glue_catalog_table_optimizer#iceberg_configuration GlueCatalogTableOptimizer#iceberg_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.GlueCatalogTableOptimizer.IGlueCatalogTableOptimizerConfigurationCompactionConfigurationIcebergConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "icebergConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalogTableOptimizer.GlueCatalogTableOptimizerConfigurationCompactionConfigurationIcebergConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IcebergConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
