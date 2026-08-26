using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTable
{
    [JsiiInterface(nativeType: typeof(IS3TablesTableMetadataIceberg), fullyQualifiedName: "aws.s3TablesTable.S3TablesTableMetadataIceberg")]
    public interface IS3TablesTableMetadataIceberg
    {
        /// <summary>A map of configuration properties for the Iceberg table, for example `write.distribution-mode` and `write.sort-order`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/s3tables_table#properties S3TablesTable#properties}
        /// </remarks>
        [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Properties
        {
            get
            {
                return null;
            }
        }

        /// <summary>schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/s3tables_table#schema S3TablesTable#schema}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.S3TablesTable.IS3TablesTableMetadataIcebergSchema" />)[]</para>
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

            /// <summary>A map of configuration properties for the Iceberg table, for example `write.distribution-mode` and `write.sort-order`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/s3tables_table#properties S3TablesTable#properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Properties
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>schema block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/s3tables_table#schema S3TablesTable#schema}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.S3TablesTable.IS3TablesTableMetadataIcebergSchema" />)[]</para>
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
