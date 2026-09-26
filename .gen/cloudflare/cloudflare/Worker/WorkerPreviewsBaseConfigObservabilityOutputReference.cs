using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Worker
{
    [JsiiClass(nativeType: typeof(cloudflare.Worker.WorkerPreviewsBaseConfigObservabilityOutputReference), fullyQualifiedName: "cloudflare.worker.WorkerPreviewsBaseConfigObservabilityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WorkerPreviewsBaseConfigObservabilityOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WorkerPreviewsBaseConfigObservabilityOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WorkerPreviewsBaseConfigObservabilityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkerPreviewsBaseConfigObservabilityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIssues", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservabilityIssues\"}}]")]
        public virtual void PutIssues(cloudflare.Worker.IWorkerPreviewsBaseConfigObservabilityIssues @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.Worker.IWorkerPreviewsBaseConfigObservabilityIssues)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservabilityLogs\"}}]")]
        public virtual void PutLogs(cloudflare.Worker.IWorkerPreviewsBaseConfigObservabilityLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.Worker.IWorkerPreviewsBaseConfigObservabilityLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTraces", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservabilityTraces\"}}]")]
        public virtual void PutTraces(cloudflare.Worker.IWorkerPreviewsBaseConfigObservabilityTraces @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.Worker.IWorkerPreviewsBaseConfigObservabilityTraces)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHeadSamplingRate")]
        public virtual void ResetHeadSamplingRate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIssues")]
        public virtual void ResetIssues()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogs")]
        public virtual void ResetLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedactQueryString")]
        public virtual void ResetRedactQueryString()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTraces")]
        public virtual void ResetTraces()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "issues", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservabilityIssuesOutputReference\"}")]
        public virtual cloudflare.Worker.WorkerPreviewsBaseConfigObservabilityIssuesOutputReference Issues
        {
            get => GetInstanceProperty<cloudflare.Worker.WorkerPreviewsBaseConfigObservabilityIssuesOutputReference>()!;
        }

        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservabilityLogsOutputReference\"}")]
        public virtual cloudflare.Worker.WorkerPreviewsBaseConfigObservabilityLogsOutputReference Logs
        {
            get => GetInstanceProperty<cloudflare.Worker.WorkerPreviewsBaseConfigObservabilityLogsOutputReference>()!;
        }

        [JsiiProperty(name: "traces", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservabilityTracesOutputReference\"}")]
        public virtual cloudflare.Worker.WorkerPreviewsBaseConfigObservabilityTracesOutputReference Traces
        {
            get => GetInstanceProperty<cloudflare.Worker.WorkerPreviewsBaseConfigObservabilityTracesOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "headSamplingRateInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HeadSamplingRateInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.Worker.IWorkerPreviewsBaseConfigObservabilityIssues" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "issuesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservabilityIssues\"}]}}", isOptional: true)]
        public virtual object? IssuesInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.Worker.IWorkerPreviewsBaseConfigObservabilityLogs" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservabilityLogs\"}]}}", isOptional: true)]
        public virtual object? LogsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redactQueryStringInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RedactQueryStringInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.Worker.IWorkerPreviewsBaseConfigObservabilityTraces" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tracesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservabilityTraces\"}]}}", isOptional: true)]
        public virtual object? TracesInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Enabled
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

        [JsiiProperty(name: "headSamplingRate", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HeadSamplingRate
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "redactQueryString", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object RedactQueryString
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.Worker.IWorkerPreviewsBaseConfigObservability" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.worker.WorkerPreviewsBaseConfigObservability\"}]}}", isOptional: true)]
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
                        case cloudflare.Worker.IWorkerPreviewsBaseConfigObservability cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.Worker.IWorkerPreviewsBaseConfigObservability).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
