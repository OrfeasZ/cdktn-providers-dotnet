using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Worker
{
    [JsiiInterface(nativeType: typeof(IWorkerSubdomain), fullyQualifiedName: "cloudflare.worker.WorkerSubdomain")]
    public interface IWorkerSubdomain
    {
        /// <summary>Whether the *.workers.dev subdomain is enabled for the Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker#enabled Worker#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether [preview URLs](https://developers.cloudflare.com/workers/configuration/previews/) are enabled for the Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker#previews_enabled Worker#previews_enabled}
        /// </remarks>
        [JsiiProperty(name: "previewsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PreviewsEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkerSubdomain), fullyQualifiedName: "cloudflare.worker.WorkerSubdomain")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Worker.IWorkerSubdomain
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether the *.workers.dev subdomain is enabled for the Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker#enabled Worker#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether [preview URLs](https://developers.cloudflare.com/workers/configuration/previews/) are enabled for the Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker#previews_enabled Worker#previews_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "previewsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PreviewsEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
