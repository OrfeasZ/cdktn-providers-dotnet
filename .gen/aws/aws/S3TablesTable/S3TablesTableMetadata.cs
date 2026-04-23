using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3TablesTable
{
    [JsiiByValue(fqn: "aws.s3TablesTable.S3TablesTableMetadata")]
    public class S3TablesTableMetadata : aws.S3TablesTable.IS3TablesTableMetadata
    {
        private object? _iceberg;

        /// <summary>iceberg block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3tables_table#iceberg S3TablesTable#iceberg}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iceberg", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3TablesTable.S3TablesTableMetadataIceberg\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Iceberg
        {
            get => _iceberg;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.S3TablesTable.IS3TablesTableMetadataIceberg[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.S3TablesTable.IS3TablesTableMetadataIceberg).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _iceberg = value;
            }
        }
    }
}
