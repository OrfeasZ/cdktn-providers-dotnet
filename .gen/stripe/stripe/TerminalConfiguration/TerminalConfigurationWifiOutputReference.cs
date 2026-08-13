using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalConfiguration
{
    [JsiiClass(nativeType: typeof(stripe.TerminalConfiguration.TerminalConfigurationWifiOutputReference), fullyQualifiedName: "stripe.terminalConfiguration.TerminalConfigurationWifiOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TerminalConfigurationWifiOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TerminalConfigurationWifiOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected TerminalConfigurationWifiOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TerminalConfigurationWifiOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEnterpriseEapPeap", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationWifiEnterpriseEapPeap\"}}]")]
        public virtual void PutEnterpriseEapPeap(stripe.TerminalConfiguration.ITerminalConfigurationWifiEnterpriseEapPeap @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationWifiEnterpriseEapPeap)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEnterpriseEapTls", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationWifiEnterpriseEapTls\"}}]")]
        public virtual void PutEnterpriseEapTls(stripe.TerminalConfiguration.ITerminalConfigurationWifiEnterpriseEapTls @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationWifiEnterpriseEapTls)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPersonalPsk", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationWifiPersonalPsk\"}}]")]
        public virtual void PutPersonalPsk(stripe.TerminalConfiguration.ITerminalConfigurationWifiPersonalPsk @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationWifiPersonalPsk)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEnterpriseEapPeap")]
        public virtual void ResetEnterpriseEapPeap()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnterpriseEapTls")]
        public virtual void ResetEnterpriseEapTls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPersonalPsk")]
        public virtual void ResetPersonalPsk()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "enterpriseEapPeap", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationWifiEnterpriseEapPeapOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationWifiEnterpriseEapPeapOutputReference EnterpriseEapPeap
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationWifiEnterpriseEapPeapOutputReference>()!;
        }

        [JsiiProperty(name: "enterpriseEapTls", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationWifiEnterpriseEapTlsOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationWifiEnterpriseEapTlsOutputReference EnterpriseEapTls
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationWifiEnterpriseEapTlsOutputReference>()!;
        }

        [JsiiProperty(name: "personalPsk", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationWifiPersonalPskOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationWifiPersonalPskOutputReference PersonalPsk
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationWifiPersonalPskOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationWifiEnterpriseEapPeap" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enterpriseEapPeapInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationWifiEnterpriseEapPeap\"}]}}", isOptional: true)]
        public virtual object? EnterpriseEapPeapInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationWifiEnterpriseEapTls" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enterpriseEapTlsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationWifiEnterpriseEapTls\"}]}}", isOptional: true)]
        public virtual object? EnterpriseEapTlsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationWifiPersonalPsk" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "personalPskInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationWifiPersonalPsk\"}]}}", isOptional: true)]
        public virtual object? PersonalPskInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationWifi" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationWifi\"}]}}", isOptional: true)]
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
                        case stripe.TerminalConfiguration.ITerminalConfigurationWifi cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.TerminalConfiguration.ITerminalConfigurationWifi).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
