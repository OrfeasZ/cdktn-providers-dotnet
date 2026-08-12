using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTable
{
    [JsiiByValue(fqn: "aws.s3TablesTable.S3TablesTableMetadataIceberg")]
    public class S3TablesTableMetadataIceberg : aws.S3TablesTable.IS3TablesTableMetadataIceberg
    {
        /// <summary>A map of configuration properties for the Iceberg table, for example `write.distribution-mode` and `write.sort-order`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/s3tables_table#properties S3TablesTable#properties}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Properties
        {
            get;
            set;
        }

        private object? _schema;

        /// <summary>schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/s3tables_table#schema S3TablesTable#schema}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.S3TablesTable.IS3TablesTableMetadataIcebergSchema" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schema", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3TablesTable.S3TablesTableMetadataIcebergSchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Schema
        {
            get => _schema;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.S3TablesTable.IS3TablesTableMetadataIcebergSchema[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.S3TablesTable.IS3TablesTableMetadataIcebergSchema).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _schema = value;
            }
        }
    }
}
