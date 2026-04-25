using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PipelineStream
{
    [JsiiInterface(nativeType: typeof(IPipelineStreamSchema), fullyQualifiedName: "cloudflare.pipelineStream.PipelineStreamSchema")]
    public interface IPipelineStreamSchema
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#fields PipelineStream#fields}.</summary>
        [JsiiProperty(name: "fields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pipelineStream.PipelineStreamSchemaFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Fields
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#format PipelineStream#format}.</summary>
        [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"cloudflare.pipelineStream.PipelineStreamSchemaFormat\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PipelineStream.IPipelineStreamSchemaFormat? Format
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#inferred PipelineStream#inferred}.</summary>
        [JsiiProperty(name: "inferred", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Inferred
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipelineStreamSchema), fullyQualifiedName: "cloudflare.pipelineStream.PipelineStreamSchema")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PipelineStream.IPipelineStreamSchema
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#fields PipelineStream#fields}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pipelineStream.PipelineStreamSchemaFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Fields
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#format PipelineStream#format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"cloudflare.pipelineStream.PipelineStreamSchemaFormat\"}", isOptional: true)]
            public cloudflare.PipelineStream.IPipelineStreamSchemaFormat? Format
            {
                get => GetInstanceProperty<cloudflare.PipelineStream.IPipelineStreamSchemaFormat?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#inferred PipelineStream#inferred}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inferred", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Inferred
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
