using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Worker
{
    [JsiiClass(nativeType: typeof(cloudflare.Worker.WorkerPreviewsBaseConfigOutputReference), fullyQualifiedName: "cloudflare.worker.WorkerPreviewsBaseConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WorkerPreviewsBaseConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WorkerPreviewsBaseConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkerPreviewsBaseConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkerPreviewsBaseConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCacheOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigCacheOptions\"}}]")]
        public virtual void PutCacheOptions(cloudflare.Worker.IWorkerPreviewsBaseConfigCacheOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.Worker.IWorkerPreviewsBaseConfigCacheOptions)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.Worker.IWorkerPreviewsBaseConfigEnv" />&gt;</param>
        [JsiiMethod(name: "putEnv", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigEnv\"},\"kind\":\"map\"}}]}}}]")]
        public virtual void PutEnv(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case System.Collections.Generic.IDictionary<string, cloudflare.Worker.IWorkerPreviewsBaseConfigEnv> cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.Worker.IWorkerPreviewsBaseConfigEnv).FullName}>; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.Worker.IWorkerPreviewsBaseConfigEnv).FullName}>; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLimits", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigLimits\"}}]")]
        public virtual void PutLimits(cloudflare.Worker.IWorkerPreviewsBaseConfigLimits @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.Worker.IWorkerPreviewsBaseConfigLimits)}, new object[]{@value});
        }

        [JsiiMethod(name: "putObservability", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservability\"}}]")]
        public virtual void PutObservability(cloudflare.Worker.IWorkerPreviewsBaseConfigObservability @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.Worker.IWorkerPreviewsBaseConfigObservability)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlacement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigPlacement\"}}]")]
        public virtual void PutPlacement(cloudflare.Worker.IWorkerPreviewsBaseConfigPlacement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.Worker.IWorkerPreviewsBaseConfigPlacement)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.Worker.IWorkerPreviewsBaseConfigTailConsumers" />)[]</param>
        [JsiiMethod(name: "putTailConsumers", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigTailConsumers\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTailConsumers(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case cloudflare.Worker.IWorkerPreviewsBaseConfigTailConsumers[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.Worker.IWorkerPreviewsBaseConfigTailConsumers).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.Worker.IWorkerPreviewsBaseConfigTailConsumers).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCacheOptions")]
        public virtual void ResetCacheOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnv")]
        public virtual void ResetEnv()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLimits")]
        public virtual void ResetLimits()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogpush")]
        public virtual void ResetLogpush()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObservability")]
        public virtual void ResetObservability()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacement")]
        public virtual void ResetPlacement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTailConsumers")]
        public virtual void ResetTailConsumers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cacheOptions", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigCacheOptionsOutputReference\"}")]
        public virtual cloudflare.Worker.WorkerPreviewsBaseConfigCacheOptionsOutputReference CacheOptions
        {
            get => GetInstanceProperty<cloudflare.Worker.WorkerPreviewsBaseConfigCacheOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigEnvMap\"}")]
        public virtual cloudflare.Worker.WorkerPreviewsBaseConfigEnvMap Env
        {
            get => GetInstanceProperty<cloudflare.Worker.WorkerPreviewsBaseConfigEnvMap>()!;
        }

        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigLimitsOutputReference\"}")]
        public virtual cloudflare.Worker.WorkerPreviewsBaseConfigLimitsOutputReference Limits
        {
            get => GetInstanceProperty<cloudflare.Worker.WorkerPreviewsBaseConfigLimitsOutputReference>()!;
        }

        [JsiiProperty(name: "observability", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservabilityOutputReference\"}")]
        public virtual cloudflare.Worker.WorkerPreviewsBaseConfigObservabilityOutputReference Observability
        {
            get => GetInstanceProperty<cloudflare.Worker.WorkerPreviewsBaseConfigObservabilityOutputReference>()!;
        }

        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigPlacementOutputReference\"}")]
        public virtual cloudflare.Worker.WorkerPreviewsBaseConfigPlacementOutputReference Placement
        {
            get => GetInstanceProperty<cloudflare.Worker.WorkerPreviewsBaseConfigPlacementOutputReference>()!;
        }

        [JsiiProperty(name: "tailConsumers", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigTailConsumersList\"}")]
        public virtual cloudflare.Worker.WorkerPreviewsBaseConfigTailConsumersList TailConsumers
        {
            get => GetInstanceProperty<cloudflare.Worker.WorkerPreviewsBaseConfigTailConsumersList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.Worker.IWorkerPreviewsBaseConfigCacheOptions" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cacheOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigCacheOptions\"}]}}", isOptional: true)]
        public virtual object? CacheOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.Worker.IWorkerPreviewsBaseConfigEnv" />&gt;</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "envInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigEnv\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? EnvInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.Worker.IWorkerPreviewsBaseConfigLimits" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "limitsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigLimits\"}]}}", isOptional: true)]
        public virtual object? LimitsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logpushInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? LogpushInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.Worker.IWorkerPreviewsBaseConfigObservability" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "observabilityInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservability\"}]}}", isOptional: true)]
        public virtual object? ObservabilityInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.Worker.IWorkerPreviewsBaseConfigPlacement" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "placementInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigPlacement\"}]}}", isOptional: true)]
        public virtual object? PlacementInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.Worker.IWorkerPreviewsBaseConfigTailConsumers" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tailConsumersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigTailConsumers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TailConsumersInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "logpush", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Logpush
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.Worker.IWorkerPreviewsBaseConfig" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfig\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.Worker.IWorkerPreviewsBaseConfig cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.Worker.IWorkerPreviewsBaseConfig).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
