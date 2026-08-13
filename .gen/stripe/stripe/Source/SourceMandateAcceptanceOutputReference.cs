using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Source
{
    [JsiiClass(nativeType: typeof(stripe.Source.SourceMandateAcceptanceOutputReference), fullyQualifiedName: "stripe.source.SourceMandateAcceptanceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SourceMandateAcceptanceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SourceMandateAcceptanceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SourceMandateAcceptanceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SourceMandateAcceptanceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOffline", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.source.SourceMandateAcceptanceOffline\"}}]")]
        public virtual void PutOffline(stripe.Source.ISourceMandateAcceptanceOffline @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Source.ISourceMandateAcceptanceOffline)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOnline", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.source.SourceMandateAcceptanceOnline\"}}]")]
        public virtual void PutOnline(stripe.Source.ISourceMandateAcceptanceOnline @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Source.ISourceMandateAcceptanceOnline)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDate")]
        public virtual void ResetDate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIp")]
        public virtual void ResetIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOffline")]
        public virtual void ResetOffline()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnline")]
        public virtual void ResetOnline()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserAgent")]
        public virtual void ResetUserAgent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "offline", typeJson: "{\"fqn\":\"stripe.source.SourceMandateAcceptanceOfflineOutputReference\"}")]
        public virtual stripe.Source.SourceMandateAcceptanceOfflineOutputReference Offline
        {
            get => GetInstanceProperty<stripe.Source.SourceMandateAcceptanceOfflineOutputReference>()!;
        }

        [JsiiProperty(name: "online", typeJson: "{\"fqn\":\"stripe.source.SourceMandateAcceptanceOnlineOutputReference\"}")]
        public virtual stripe.Source.SourceMandateAcceptanceOnlineOutputReference Online
        {
            get => GetInstanceProperty<stripe.Source.SourceMandateAcceptanceOnlineOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dateInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DateInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Source.ISourceMandateAcceptanceOffline" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "offlineInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.source.SourceMandateAcceptanceOffline\"}]}}", isOptional: true)]
        public virtual object? OfflineInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Source.ISourceMandateAcceptanceOnline" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onlineInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.source.SourceMandateAcceptanceOnline\"}]}}", isOptional: true)]
        public virtual object? OnlineInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userAgentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserAgentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Date
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ip
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userAgent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserAgent
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Source.ISourceMandateAcceptance" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.source.SourceMandateAcceptance\"}]}}", isOptional: true)]
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
                        case stripe.Source.ISourceMandateAcceptance cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Source.ISourceMandateAcceptance).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
