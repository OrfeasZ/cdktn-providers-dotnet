using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDnsLocation
{
    [JsiiClass(nativeType: typeof(cloudflare.ZeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsOutputReference), fullyQualifiedName: "cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ZeroTrustDnsLocationEndpointsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ZeroTrustDnsLocationEndpointsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ZeroTrustDnsLocationEndpointsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustDnsLocationEndpointsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDoh", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDoh\"}}]")]
        public virtual void PutDoh(cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsDoh @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsDoh)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDot", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDot\"}}]")]
        public virtual void PutDot(cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsDot @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsDot)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIpv4", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv4\"}}]")]
        public virtual void PutIpv4(cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsIpv4 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsIpv4)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIpv6", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv6\"}}]")]
        public virtual void PutIpv6(cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsIpv6 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsIpv6)}, new object[]{@value});
        }

        [JsiiProperty(name: "doh", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDohOutputReference\"}")]
        public virtual cloudflare.ZeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDohOutputReference Doh
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDohOutputReference>()!;
        }

        [JsiiProperty(name: "dot", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDotOutputReference\"}")]
        public virtual cloudflare.ZeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDotOutputReference Dot
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDotOutputReference>()!;
        }

        [JsiiProperty(name: "ipv4", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv4OutputReference\"}")]
        public virtual cloudflare.ZeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv4OutputReference Ipv4
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv4OutputReference>()!;
        }

        [JsiiProperty(name: "ipv6", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv6OutputReference\"}")]
        public virtual cloudflare.ZeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv6OutputReference Ipv6
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv6OutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dohInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDoh\"}]}}", isOptional: true)]
        public virtual object? DohInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dotInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDot\"}]}}", isOptional: true)]
        public virtual object? DotInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv4Input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv4\"}]}}", isOptional: true)]
        public virtual object? Ipv4Input
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv6Input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv6\"}]}}", isOptional: true)]
        public virtual object? Ipv6Input
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpoints\"}]}}", isOptional: true)]
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
                        case cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpoints cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpoints).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
