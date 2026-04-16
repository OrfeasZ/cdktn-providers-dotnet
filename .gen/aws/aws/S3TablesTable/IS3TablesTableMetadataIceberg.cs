using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTable
{
    [JsiiInterface(nativeType: typeof(IS3TablesTableMetadataIceberg), fullyQualifiedName: "aws.s3TablesTable.S3TablesTableMetadataIceberg")]
    public interface IS3TablesTableMetadataIceberg
    {
        /// <summary>schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3tables_table#schema S3TablesTable#schema}
        /// </remarks>
        [JsiiProperty(name: "schema", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3TablesTable.S3TablesTableMetadataIcebergSchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Schema
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3TablesTableMetadataIceberg), fullyQualifiedName: "aws.s3TablesTable.S3TablesTableMetadataIceberg")]
        internal sealed class _Proxy : DeputyBase, aws.S3TablesTable.IS3TablesTableMetadataIceberg
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>schema block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3tables_table#schema S3TablesTable#schema}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schema", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3TablesTable.S3TablesTableMetadataIcebergSchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Schema
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
