using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PipelineStream
{
    [JsiiInterface(nativeType: typeof(IPipelineStreamHttp), fullyQualifiedName: "cloudflare.pipelineStream.PipelineStreamHttp")]
    public interface IPipelineStreamHttp
    {
        /// <summary>Indicates that authentication is required for the HTTP endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#authentication PipelineStream#authentication}
        /// </remarks>
        [JsiiProperty(name: "authentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Authentication
        {
            get;
        }

        /// <summary>Indicates that the HTTP endpoint is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#enabled PipelineStream#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Specifies the CORS options for the HTTP endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#cors PipelineStream#cors}
        /// </remarks>
        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"cloudflare.pipelineStream.PipelineStreamHttpCors\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PipelineStream.IPipelineStreamHttpCors? Cors
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipelineStreamHttp), fullyQualifiedName: "cloudflare.pipelineStream.PipelineStreamHttp")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PipelineStream.IPipelineStreamHttp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Indicates that authentication is required for the HTTP endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#authentication PipelineStream#authentication}
            /// </remarks>
            [JsiiProperty(name: "authentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Authentication
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Indicates that the HTTP endpoint is enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#enabled PipelineStream#enabled}
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Specifies the CORS options for the HTTP endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#cors PipelineStream#cors}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"cloudflare.pipelineStream.PipelineStreamHttpCors\"}", isOptional: true)]
            public cloudflare.PipelineStream.IPipelineStreamHttpCors? Cors
            {
                get => GetInstanceProperty<cloudflare.PipelineStream.IPipelineStreamHttpCors?>();
            }
        }
    }
}
