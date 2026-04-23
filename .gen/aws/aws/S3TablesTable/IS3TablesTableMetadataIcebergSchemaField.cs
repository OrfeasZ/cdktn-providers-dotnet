using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTable
{
    [JsiiInterface(nativeType: typeof(IS3TablesTableMetadataIcebergSchemaField), fullyQualifiedName: "aws.s3TablesTable.S3TablesTableMetadataIcebergSchemaField")]
    public interface IS3TablesTableMetadataIcebergSchemaField
    {
        /// <summary>The name of the field.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3tables_table#name S3TablesTable#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The field type. S3 Tables supports all Apache Iceberg primitive types.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3tables_table#type S3TablesTable#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>A Boolean value that specifies whether values are required for each row in this field. Default: false.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3tables_table#required S3TablesTable#required}
        /// </remarks>
        [JsiiProperty(name: "required", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Required
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3TablesTableMetadataIcebergSchemaField), fullyQualifiedName: "aws.s3TablesTable.S3TablesTableMetadataIcebergSchemaField")]
        internal sealed class _Proxy : DeputyBase, aws.S3TablesTable.IS3TablesTableMetadataIcebergSchemaField
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the field.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3tables_table#name S3TablesTable#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The field type. S3 Tables supports all Apache Iceberg primitive types.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3tables_table#type S3TablesTable#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A Boolean value that specifies whether values are required for each row in this field. Default: false.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3tables_table#required S3TablesTable#required}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "required", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Required
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
