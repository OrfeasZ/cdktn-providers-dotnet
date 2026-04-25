using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PipelineStream
{
    [JsiiInterface(nativeType: typeof(IPipelineStreamHttpCors), fullyQualifiedName: "cloudflare.pipelineStream.PipelineStreamHttpCors")]
    public interface IPipelineStreamHttpCors
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#origins PipelineStream#origins}.</summary>
        [JsiiProperty(name: "origins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Origins
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipelineStreamHttpCors), fullyQualifiedName: "cloudflare.pipelineStream.PipelineStreamHttpCors")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PipelineStream.IPipelineStreamHttpCors
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#origins PipelineStream#origins}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "origins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Origins
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
