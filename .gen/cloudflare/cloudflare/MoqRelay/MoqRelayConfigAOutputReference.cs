using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MoqRelay
{
    [JsiiClass(nativeType: typeof(cloudflare.MoqRelay.MoqRelayConfigAOutputReference), fullyQualifiedName: "cloudflare.moqRelay.MoqRelayConfigAOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MoqRelayConfigAOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MoqRelayConfigAOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MoqRelayConfigAOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MoqRelayConfigAOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLingeringSubscribe", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.moqRelay.MoqRelayConfigLingeringSubscribe\"}}]")]
        public virtual void PutLingeringSubscribe(cloudflare.MoqRelay.IMoqRelayConfigLingeringSubscribe @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.MoqRelay.IMoqRelayConfigLingeringSubscribe)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpstreams", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.moqRelay.MoqRelayConfigUpstreams\"}}]")]
        public virtual void PutUpstreams(cloudflare.MoqRelay.IMoqRelayConfigUpstreams @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.MoqRelay.IMoqRelayConfigUpstreams)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLingeringSubscribe")]
        public virtual void ResetLingeringSubscribe()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpstreams")]
        public virtual void ResetUpstreams()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "lingeringSubscribe", typeJson: "{\"fqn\":\"cloudflare.moqRelay.MoqRelayConfigLingeringSubscribeOutputReference\"}")]
        public virtual cloudflare.MoqRelay.MoqRelayConfigLingeringSubscribeOutputReference LingeringSubscribe
        {
            get => GetInstanceProperty<cloudflare.MoqRelay.MoqRelayConfigLingeringSubscribeOutputReference>()!;
        }

        [JsiiProperty(name: "upstreams", typeJson: "{\"fqn\":\"cloudflare.moqRelay.MoqRelayConfigUpstreamsOutputReference\"}")]
        public virtual cloudflare.MoqRelay.MoqRelayConfigUpstreamsOutputReference Upstreams
        {
            get => GetInstanceProperty<cloudflare.MoqRelay.MoqRelayConfigUpstreamsOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.MoqRelay.IMoqRelayConfigLingeringSubscribe" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lingeringSubscribeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.moqRelay.MoqRelayConfigLingeringSubscribe\"}]}}", isOptional: true)]
        public virtual object? LingeringSubscribeInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.MoqRelay.IMoqRelayConfigUpstreams" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "upstreamsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.moqRelay.MoqRelayConfigUpstreams\"}]}}", isOptional: true)]
        public virtual object? UpstreamsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.MoqRelay.IMoqRelayConfigA" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.moqRelay.MoqRelayConfigA\"}]}}", isOptional: true)]
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
                        case cloudflare.MoqRelay.IMoqRelayConfigA cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.MoqRelay.IMoqRelayConfigA).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
