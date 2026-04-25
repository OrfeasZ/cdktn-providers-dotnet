using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PipelineStream
{
    [JsiiInterface(nativeType: typeof(IPipelineStreamWorkerBinding), fullyQualifiedName: "cloudflare.pipelineStream.PipelineStreamWorkerBinding")]
    public interface IPipelineStreamWorkerBinding
    {
        /// <summary>Indicates that the worker binding is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#enabled PipelineStream#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPipelineStreamWorkerBinding), fullyQualifiedName: "cloudflare.pipelineStream.PipelineStreamWorkerBinding")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PipelineStream.IPipelineStreamWorkerBinding
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Indicates that the worker binding is enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#enabled PipelineStream#enabled}
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
