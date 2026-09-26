using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Worker
{
    [JsiiInterface(nativeType: typeof(IWorkerPreviewsBaseConfigCacheOptions), fullyQualifiedName: "cloudflare.worker.WorkerPreviewsBaseConfigCacheOptions")]
    public interface IWorkerPreviewsBaseConfigCacheOptions
    {
        /// <summary>Whether cached responses are shared across Worker version uploads.</summary>
        /// <remarks>
        /// This is independent of <c>enabled</c>. It can stay true
        /// while caching is off, so the preference survives turning
        /// caching off and back on.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#cross_version_cache Worker#cross_version_cache}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "crossVersionCache", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CrossVersionCache
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether caching is enabled for this Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#enabled Worker#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
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

        [JsiiTypeProxy(nativeType: typeof(IWorkerPreviewsBaseConfigCacheOptions), fullyQualifiedName: "cloudflare.worker.WorkerPreviewsBaseConfigCacheOptions")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Worker.IWorkerPreviewsBaseConfigCacheOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether cached responses are shared across Worker version uploads.</summary>
            /// <remarks>
            /// This is independent of <c>enabled</c>. It can stay true
            /// while caching is off, so the preference survives turning
            /// caching off and back on.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#cross_version_cache Worker#cross_version_cache}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "crossVersionCache", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CrossVersionCache
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether caching is enabled for this Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#enabled Worker#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
