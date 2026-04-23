using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTable
{
    [JsiiInterface(nativeType: typeof(IS3TablesTableMetadataIcebergSchema), fullyQualifiedName: "aws.s3TablesTable.S3TablesTableMetadataIcebergSchema")]
    public interface IS3TablesTableMetadataIcebergSchema
    {
        /// <summary>field block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3tables_table#field S3TablesTable#field}
        /// </remarks>
        [JsiiProperty(name: "field", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3TablesTable.S3TablesTableMetadataIcebergSchemaField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Field
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3TablesTableMetadataIcebergSchema), fullyQualifiedName: "aws.s3TablesTable.S3TablesTableMetadataIcebergSchema")]
        internal sealed class _Proxy : DeputyBase, aws.S3TablesTable.IS3TablesTableMetadataIcebergSchema
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3tables_table#field S3TablesTable#field}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "field", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3TablesTable.S3TablesTableMetadataIcebergSchemaField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Field
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
