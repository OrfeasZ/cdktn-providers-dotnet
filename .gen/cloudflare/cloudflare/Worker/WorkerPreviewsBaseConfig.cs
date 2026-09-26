using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Worker
{
    [JsiiByValue(fqn: "cloudflare.worker.WorkerPreviewsBaseConfig")]
    public class WorkerPreviewsBaseConfig : cloudflare.Worker.IWorkerPreviewsBaseConfig
    {
        /// <summary>Cache options used when creating new Previews.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#cache_options Worker#cache_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cacheOptions", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigCacheOptions\"}", isOptional: true)]
        public cloudflare.Worker.IWorkerPreviewsBaseConfigCacheOptions? CacheOptions
        {
            get;
            set;
        }

        private object? _env;

        /// <summary>Bindings used when creating new Previews, keyed by binding name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#env Worker#env}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.Worker.IWorkerPreviewsBaseConfigEnv" />&gt;</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "env", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigEnv\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? Env
        {
            get => _env;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, cloudflare.Worker.IWorkerPreviewsBaseConfigEnv> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.Worker.IWorkerPreviewsBaseConfigEnv).FullName}>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _env = value;
            }
        }

        /// <summary>Resource limits enforced at runtime for newly created Previews.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#limits Worker#limits}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigLimits\"}", isOptional: true)]
        public cloudflare.Worker.IWorkerPreviewsBaseConfigLimits? Limits
        {
            get;
            set;
        }

        private object? _logpush;

        /// <summary>Whether logpush is enabled when creating new Previews.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#logpush Worker#logpush}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logpush", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Logpush
        {
            get => _logpush;
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
                _logpush = value;
            }
        }

        /// <summary>Observability settings used when creating new Previews.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#observability Worker#observability}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "observability", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservability\"}", isOptional: true)]
        public cloudflare.Worker.IWorkerPreviewsBaseConfigObservability? Observability
        {
            get;
            set;
        }

        /// <summary>Placement configuration used when creating new Previews.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#placement Worker#placement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigPlacement\"}", isOptional: true)]
        public cloudflare.Worker.IWorkerPreviewsBaseConfigPlacement? Placement
        {
            get;
            set;
        }

        private object? _tailConsumers;

        /// <summary>Other Workers that should consume logs from newly created Previews.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/worker#tail_consumers Worker#tail_consumers}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.Worker.IWorkerPreviewsBaseConfigTailConsumers" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tailConsumers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigTailConsumers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TailConsumers
        {
            get => _tailConsumers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.Worker.IWorkerPreviewsBaseConfigTailConsumers[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.Worker.IWorkerPreviewsBaseConfigTailConsumers).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tailConsumers = value;
            }
        }
    }
}
