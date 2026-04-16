using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiClass(nativeType: typeof(cloudflare.WorkersScript.WorkersScriptBindingsOutboundOutputReference), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptBindingsOutboundOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WorkersScriptBindingsOutboundOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WorkersScriptBindingsOutboundOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WorkersScriptBindingsOutboundOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkersScriptBindingsOutboundOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putWorker", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.workersScript.WorkersScriptBindingsOutboundWorker\"}}]")]
        public virtual void PutWorker(cloudflare.WorkersScript.IWorkersScriptBindingsOutboundWorker @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.WorkersScript.IWorkersScriptBindingsOutboundWorker)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetParams")]
        public virtual void ResetParams()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorker")]
        public virtual void ResetWorker()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "worker", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptBindingsOutboundWorkerOutputReference\"}")]
        public virtual cloudflare.WorkersScript.WorkersScriptBindingsOutboundWorkerOutputReference Worker
        {
            get => GetInstanceProperty<cloudflare.WorkersScript.WorkersScriptBindingsOutboundWorkerOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "paramsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ParamsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.workersScript.WorkersScriptBindingsOutboundWorker\"}]}}", isOptional: true)]
        public virtual object? WorkerInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "params", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Params
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.workersScript.WorkersScriptBindingsOutbound\"}]}}", isOptional: true)]
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
                        case cloudflare.WorkersScript.IWorkersScriptBindingsOutbound cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.WorkersScript.IWorkersScriptBindingsOutbound).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
