using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTable
{
    [JsiiByValue(fqn: "aws.s3TablesTable.S3TablesTableMetadataIcebergSchema")]
    public class S3TablesTableMetadataIcebergSchema : aws.S3TablesTable.IS3TablesTableMetadataIcebergSchema
    {
        private object? _field;

        /// <summary>field block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3tables_table#field S3TablesTable#field}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "field", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3TablesTable.S3TablesTableMetadataIcebergSchemaField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Field
        {
            get => _field;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.S3TablesTable.IS3TablesTableMetadataIcebergSchemaField[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.S3TablesTable.IS3TablesTableMetadataIcebergSchemaField).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _field = value;
            }
        }
    }
}
