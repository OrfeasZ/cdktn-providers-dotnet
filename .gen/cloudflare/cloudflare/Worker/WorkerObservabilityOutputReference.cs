using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Worker
{
    [JsiiClass(nativeType: typeof(cloudflare.Worker.WorkerObservabilityOutputReference), fullyQualifiedName: "cloudflare.worker.WorkerObservabilityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WorkerObservabilityOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WorkerObservabilityOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WorkerObservabilityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkerObservabilityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.worker.WorkerObservabilityLogs\"}}]")]
        public virtual void PutLogs(cloudflare.Worker.IWorkerObservabilityLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.Worker.IWorkerObservabilityLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTraces", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.worker.WorkerObservabilityTraces\"}}]")]
        public virtual void PutTraces(cloudflare.Worker.IWorkerObservabilityTraces @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.Worker.IWorkerObservabilityTraces)}, new object[]{@value});
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

        [JsiiMethod(name: "resetLogs")]
        public virtual void ResetLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTraces")]
        public virtual void ResetTraces()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerObservabilityLogsOutputReference\"}")]
        public virtual cloudflare.Worker.WorkerObservabilityLogsOutputReference Logs
        {
            get => GetInstanceProperty<cloudflare.Worker.WorkerObservabilityLogsOutputReference>()!;
        }

        [JsiiProperty(name: "traces", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerObservabilityTracesOutputReference\"}")]
        public virtual cloudflare.Worker.WorkerObservabilityTracesOutputReference Traces
        {
            get => GetInstanceProperty<cloudflare.Worker.WorkerObservabilityTracesOutputReference>()!;
        }

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

        [JsiiOptional]
        [JsiiProperty(name: "logsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.worker.WorkerObservabilityLogs\"}]}}", isOptional: true)]
        public virtual object? LogsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tracesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.worker.WorkerObservabilityTraces\"}]}}", isOptional: true)]
        public virtual object? TracesInput
        {
            get => GetInstanceProperty<object?>();
        }

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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.worker.WorkerObservability\"}]}}", isOptional: true)]
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
                        case cloudflare.Worker.IWorkerObservability cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.Worker.IWorkerObservability).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
