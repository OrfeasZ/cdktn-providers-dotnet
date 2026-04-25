using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PipelineStream
{
    [JsiiInterface(nativeType: typeof(IPipelineStreamFormat), fullyQualifiedName: "cloudflare.pipelineStream.PipelineStreamFormat")]
    public interface IPipelineStreamFormat
    {
        /// <summary>Available values: "json", "parquet".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#type PipelineStream#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Available values: "uncompressed", "snappy", "gzip", "zstd", "lz4".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#compression PipelineStream#compression}
        /// </remarks>
        [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Compression
        {
            get
            {
                return null;
            }
        }

        /// <summary>Available values: "number", "string", "bytes".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#decimal_encoding PipelineStream#decimal_encoding}
        /// </remarks>
        [JsiiProperty(name: "decimalEncoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DecimalEncoding
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#row_group_bytes PipelineStream#row_group_bytes}.</summary>
        [JsiiProperty(name: "rowGroupBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RowGroupBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Available values: "rfc3339", "unix_millis".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#timestamp_format PipelineStream#timestamp_format}
        /// </remarks>
        [JsiiProperty(name: "timestampFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimestampFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#unstructured PipelineStream#unstructured}.</summary>
        [JsiiProperty(name: "unstructured", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Unstructured
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipelineStreamFormat), fullyQualifiedName: "cloudflare.pipelineStream.PipelineStreamFormat")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PipelineStream.IPipelineStreamFormat
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Available values: "json", "parquet".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#type PipelineStream#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Available values: "uncompressed", "snappy", "gzip", "zstd", "lz4".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#compression PipelineStream#compression}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Compression
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Available values: "number", "string", "bytes".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#decimal_encoding PipelineStream#decimal_encoding}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "decimalEncoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DecimalEncoding
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#row_group_bytes PipelineStream#row_group_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rowGroupBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RowGroupBytes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Available values: "rfc3339", "unix_millis".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#timestamp_format PipelineStream#timestamp_format}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timestampFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimestampFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#unstructured PipelineStream#unstructured}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "unstructured", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Unstructured
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
