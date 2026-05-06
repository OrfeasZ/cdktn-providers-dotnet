using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustTunnelCloudflaredConfig
{
    [JsiiClass(nativeType: typeof(cloudflare.ZeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigOutputReference), fullyQualifiedName: "cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ZeroTrustTunnelCloudflaredConfigConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ZeroTrustTunnelCloudflaredConfigConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ZeroTrustTunnelCloudflaredConfigConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustTunnelCloudflaredConfigConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIngress", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigIngress\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIngress(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfigIngress[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfigIngress).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfigIngress).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOriginRequest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigOriginRequest\"}}]")]
        public virtual void PutOriginRequest(cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfigOriginRequest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfigOriginRequest)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetIngress")]
        public virtual void ResetIngress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOriginRequest")]
        public virtual void ResetOriginRequest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "ingress", typeJson: "{\"fqn\":\"cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigIngressList\"}")]
        public virtual cloudflare.ZeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigIngressList Ingress
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigIngressList>()!;
        }

        [JsiiProperty(name: "originRequest", typeJson: "{\"fqn\":\"cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigOriginRequestOutputReference\"}")]
        public virtual cloudflare.ZeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigOriginRequestOutputReference OriginRequest
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigOriginRequestOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ingressInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigIngress\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IngressInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originRequestInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfigOriginRequest\"}]}}", isOptional: true)]
        public virtual object? OriginRequestInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustTunnelCloudflaredConfig.ZeroTrustTunnelCloudflaredConfigConfig\"}]}}", isOptional: true)]
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
                        case cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfig cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustTunnelCloudflaredConfig.IZeroTrustTunnelCloudflaredConfigConfig).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
