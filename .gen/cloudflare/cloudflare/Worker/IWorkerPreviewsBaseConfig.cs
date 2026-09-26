using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Worker
{
    [JsiiInterface(nativeType: typeof(IWorkerPreviewsBaseConfig), fullyQualifiedName: "cloudflare.worker.WorkerPreviewsBaseConfig")]
    public interface IWorkerPreviewsBaseConfig
    {
        /// <summary>Cache options used when creating new Previews.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#cache_options Worker#cache_options}
        /// </remarks>
        [JsiiProperty(name: "cacheOptions", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigCacheOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Worker.IWorkerPreviewsBaseConfigCacheOptions? CacheOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Bindings used when creating new Previews, keyed by binding name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#env Worker#env}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.Worker.IWorkerPreviewsBaseConfigEnv" />&gt;</para>
        /// </remarks>
        [JsiiProperty(name: "env", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigEnv\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Env
        {
            get
            {
                return null;
            }
        }

        /// <summary>Resource limits enforced at runtime for newly created Previews.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#limits Worker#limits}
        /// </remarks>
        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigLimits\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Worker.IWorkerPreviewsBaseConfigLimits? Limits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether logpush is enabled when creating new Previews.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#logpush Worker#logpush}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "logpush", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Logpush
        {
            get
            {
                return null;
            }
        }

        /// <summary>Observability settings used when creating new Previews.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#observability Worker#observability}
        /// </remarks>
        [JsiiProperty(name: "observability", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservability\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Worker.IWorkerPreviewsBaseConfigObservability? Observability
        {
            get
            {
                return null;
            }
        }

        /// <summary>Placement configuration used when creating new Previews.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#placement Worker#placement}
        /// </remarks>
        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigPlacement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.Worker.IWorkerPreviewsBaseConfigPlacement? Placement
        {
            get
            {
                return null;
            }
        }

        /// <summary>Other Workers that should consume logs from newly created Previews.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#tail_consumers Worker#tail_consumers}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.Worker.IWorkerPreviewsBaseConfigTailConsumers" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "tailConsumers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigTailConsumers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TailConsumers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkerPreviewsBaseConfig), fullyQualifiedName: "cloudflare.worker.WorkerPreviewsBaseConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Worker.IWorkerPreviewsBaseConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Cache options used when creating new Previews.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#cache_options Worker#cache_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cacheOptions", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigCacheOptions\"}", isOptional: true)]
            public cloudflare.Worker.IWorkerPreviewsBaseConfigCacheOptions? CacheOptions
            {
                get => GetInstanceProperty<cloudflare.Worker.IWorkerPreviewsBaseConfigCacheOptions?>();
            }

            /// <summary>Bindings used when creating new Previews, keyed by binding name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#env Worker#env}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.Worker.IWorkerPreviewsBaseConfigEnv" />&gt;</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "env", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigEnv\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Env
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Resource limits enforced at runtime for newly created Previews.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#limits Worker#limits}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigLimits\"}", isOptional: true)]
            public cloudflare.Worker.IWorkerPreviewsBaseConfigLimits? Limits
            {
                get => GetInstanceProperty<cloudflare.Worker.IWorkerPreviewsBaseConfigLimits?>();
            }

            /// <summary>Whether logpush is enabled when creating new Previews.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#logpush Worker#logpush}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logpush", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Logpush
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Observability settings used when creating new Previews.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#observability Worker#observability}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "observability", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservability\"}", isOptional: true)]
            public cloudflare.Worker.IWorkerPreviewsBaseConfigObservability? Observability
            {
                get => GetInstanceProperty<cloudflare.Worker.IWorkerPreviewsBaseConfigObservability?>();
            }

            /// <summary>Placement configuration used when creating new Previews.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#placement Worker#placement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigPlacement\"}", isOptional: true)]
            public cloudflare.Worker.IWorkerPreviewsBaseConfigPlacement? Placement
            {
                get => GetInstanceProperty<cloudflare.Worker.IWorkerPreviewsBaseConfigPlacement?>();
            }

            /// <summary>Other Workers that should consume logs from newly created Previews.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#tail_consumers Worker#tail_consumers}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.Worker.IWorkerPreviewsBaseConfigTailConsumers" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tailConsumers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigTailConsumers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TailConsumers
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
