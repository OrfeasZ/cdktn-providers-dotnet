using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTable
{
    [JsiiInterface(nativeType: typeof(IS3TablesTableMetadata), fullyQualifiedName: "aws.s3TablesTable.S3TablesTableMetadata")]
    public interface IS3TablesTableMetadata
    {
        /// <summary>iceberg block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3tables_table#iceberg S3TablesTable#iceberg}
        /// </remarks>
        [JsiiProperty(name: "iceberg", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3TablesTable.S3TablesTableMetadataIceberg\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Iceberg
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3TablesTableMetadata), fullyQualifiedName: "aws.s3TablesTable.S3TablesTableMetadata")]
        internal sealed class _Proxy : DeputyBase, aws.S3TablesTable.IS3TablesTableMetadata
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>iceberg block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3tables_table#iceberg S3TablesTable#iceberg}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iceberg", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3TablesTable.S3TablesTableMetadataIceberg\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Iceberg
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
