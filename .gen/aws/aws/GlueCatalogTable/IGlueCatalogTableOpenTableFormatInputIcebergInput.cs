using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTable
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogTableOpenTableFormatInputIcebergInput), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInput")]
    public interface IGlueCatalogTableOpenTableFormatInputIcebergInput
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/glue_catalog_table#metadata_operation GlueCatalogTable#metadata_operation}.</summary>
        [JsiiProperty(name: "metadataOperation", typeJson: "{\"primitive\":\"string\"}")]
        string MetadataOperation
        {
            get;
        }

        /// <summary>iceberg_table_input block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/glue_catalog_table#iceberg_table_input GlueCatalogTable#iceberg_table_input}
        /// </remarks>
        [JsiiProperty(name: "icebergTableInput", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInput? IcebergTableInput
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/glue_catalog_table#version GlueCatalogTable#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogTableOpenTableFormatInputIcebergInput), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInput")]
        internal sealed class _Proxy : DeputyBase, aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInput
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/glue_catalog_table#metadata_operation GlueCatalogTable#metadata_operation}.</summary>
            [JsiiProperty(name: "metadataOperation", typeJson: "{\"primitive\":\"string\"}")]
            public string MetadataOperation
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>iceberg_table_input block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/glue_catalog_table#iceberg_table_input GlueCatalogTable#iceberg_table_input}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "icebergTableInput", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInput\"}", isOptional: true)]
            public aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInput? IcebergTableInput
            {
                get => GetInstanceProperty<aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInput?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/glue_catalog_table#version GlueCatalogTable#version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
