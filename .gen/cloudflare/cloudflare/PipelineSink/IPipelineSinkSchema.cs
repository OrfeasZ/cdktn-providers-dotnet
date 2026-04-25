using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PipelineSink
{
    [JsiiInterface(nativeType: typeof(IPipelineSinkSchema), fullyQualifiedName: "cloudflare.pipelineSink.PipelineSinkSchema")]
    public interface IPipelineSinkSchema
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#fields PipelineSink#fields}.</summary>
        [JsiiProperty(name: "fields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkSchemaFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Fields
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#format PipelineSink#format}.</summary>
        [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkSchemaFormat\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PipelineSink.IPipelineSinkSchemaFormat? Format
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#inferred PipelineSink#inferred}.</summary>
        [JsiiProperty(name: "inferred", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Inferred
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipelineSinkSchema), fullyQualifiedName: "cloudflare.pipelineSink.PipelineSinkSchema")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PipelineSink.IPipelineSinkSchema
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#fields PipelineSink#fields}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkSchemaFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Fields
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#format PipelineSink#format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkSchemaFormat\"}", isOptional: true)]
            public cloudflare.PipelineSink.IPipelineSinkSchemaFormat? Format
            {
                get => GetInstanceProperty<cloudflare.PipelineSink.IPipelineSinkSchemaFormat?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#inferred PipelineSink#inferred}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inferred", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Inferred
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
