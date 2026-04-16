using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewayLogging
{
    [JsiiClass(nativeType: typeof(cloudflare.ZeroTrustGatewayLogging.ZeroTrustGatewayLoggingSettingsByRuleTypeOutputReference), fullyQualifiedName: "cloudflare.zeroTrustGatewayLogging.ZeroTrustGatewayLoggingSettingsByRuleTypeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ZeroTrustGatewayLoggingSettingsByRuleTypeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ZeroTrustGatewayLoggingSettingsByRuleTypeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ZeroTrustGatewayLoggingSettingsByRuleTypeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustGatewayLoggingSettingsByRuleTypeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDns", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewayLogging.ZeroTrustGatewayLoggingSettingsByRuleTypeDns\"}}]")]
        public virtual void PutDns(cloudflare.ZeroTrustGatewayLogging.IZeroTrustGatewayLoggingSettingsByRuleTypeDns @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewayLogging.IZeroTrustGatewayLoggingSettingsByRuleTypeDns)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewayLogging.ZeroTrustGatewayLoggingSettingsByRuleTypeHttp\"}}]")]
        public virtual void PutHttp(cloudflare.ZeroTrustGatewayLogging.IZeroTrustGatewayLoggingSettingsByRuleTypeHttp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewayLogging.IZeroTrustGatewayLoggingSettingsByRuleTypeHttp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putL4", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewayLogging.ZeroTrustGatewayLoggingSettingsByRuleTypeL4\"}}]")]
        public virtual void PutL4(cloudflare.ZeroTrustGatewayLogging.IZeroTrustGatewayLoggingSettingsByRuleTypeL4 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewayLogging.IZeroTrustGatewayLoggingSettingsByRuleTypeL4)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDns")]
        public virtual void ResetDns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttp")]
        public virtual void ResetHttp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetL4")]
        public virtual void ResetL4()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayLogging.ZeroTrustGatewayLoggingSettingsByRuleTypeDnsOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewayLogging.ZeroTrustGatewayLoggingSettingsByRuleTypeDnsOutputReference Dns
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewayLogging.ZeroTrustGatewayLoggingSettingsByRuleTypeDnsOutputReference>()!;
        }

        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayLogging.ZeroTrustGatewayLoggingSettingsByRuleTypeHttpOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewayLogging.ZeroTrustGatewayLoggingSettingsByRuleTypeHttpOutputReference Http
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewayLogging.ZeroTrustGatewayLoggingSettingsByRuleTypeHttpOutputReference>()!;
        }

        [JsiiProperty(name: "l4", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayLogging.ZeroTrustGatewayLoggingSettingsByRuleTypeL4OutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewayLogging.ZeroTrustGatewayLoggingSettingsByRuleTypeL4OutputReference L4
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewayLogging.ZeroTrustGatewayLoggingSettingsByRuleTypeL4OutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewayLogging.ZeroTrustGatewayLoggingSettingsByRuleTypeDns\"}]}}", isOptional: true)]
        public virtual object? DnsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewayLogging.ZeroTrustGatewayLoggingSettingsByRuleTypeHttp\"}]}}", isOptional: true)]
        public virtual object? HttpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "l4Input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewayLogging.ZeroTrustGatewayLoggingSettingsByRuleTypeL4\"}]}}", isOptional: true)]
        public virtual object? L4Input
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewayLogging.ZeroTrustGatewayLoggingSettingsByRuleType\"}]}}", isOptional: true)]
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
                        case cloudflare.ZeroTrustGatewayLogging.IZeroTrustGatewayLoggingSettingsByRuleType cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustGatewayLogging.IZeroTrustGatewayLoggingSettingsByRuleType).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
