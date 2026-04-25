using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PipelineSink
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.pipelineSink.PipelineSinkSchemaFormat")]
    public class PipelineSinkSchemaFormat : cloudflare.PipelineSink.IPipelineSinkSchemaFormat
    {
        /// <summary>Available values: "json", "parquet".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#type PipelineSink#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Available values: "uncompressed", "snappy", "gzip", "zstd", "lz4".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#compression PipelineSink#compression}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Compression
        {
            get;
            set;
        }

        /// <summary>Available values: "number", "string", "bytes".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#decimal_encoding PipelineSink#decimal_encoding}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "decimalEncoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DecimalEncoding
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#row_group_bytes PipelineSink#row_group_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rowGroupBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RowGroupBytes
        {
            get;
            set;
        }

        /// <summary>Available values: "rfc3339", "unix_millis".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#timestamp_format PipelineSink#timestamp_format}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timestampFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimestampFormat
        {
            get;
            set;
        }

        private object? _unstructured;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#unstructured PipelineSink#unstructured}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "unstructured", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Unstructured
        {
            get => _unstructured;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _unstructured = value;
            }
        }
    }
}
