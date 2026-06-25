using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesAudiosJackInputOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosJackInputOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesAudiosJackInputOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesAudiosJackInputOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesAudiosJackInputOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesAudiosJackInputOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesAudiosJackInputSettings\"}}]")]
        public virtual void PutSettings(libvirt.Domain.IDomainDevicesAudiosJackInputSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesAudiosJackInputSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBufferLength")]
        public virtual void ResetBufferLength()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientName")]
        public virtual void ResetClientName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectPorts")]
        public virtual void ResetConnectPorts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExactName")]
        public virtual void ResetExactName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFixedSettings")]
        public virtual void ResetFixedSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMixingEngine")]
        public virtual void ResetMixingEngine()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerName")]
        public virtual void ResetServerName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSettings")]
        public virtual void ResetSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVoices")]
        public virtual void ResetVoices()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosJackInputSettingsOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesAudiosJackInputSettingsOutputReference Settings
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesAudiosJackInputSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bufferLengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BufferLengthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectPortsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectPortsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exactNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExactNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fixedSettingsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FixedSettingsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mixingEngineInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MixingEngineInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServerNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesAudiosJackInputSettings" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "settingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesAudiosJackInputSettings\"}]}}", isOptional: true)]
        public virtual object? SettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "voicesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? VoicesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "bufferLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BufferLength
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "connectPorts", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectPorts
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "exactName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExactName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fixedSettings", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FixedSettings
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mixingEngine", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MixingEngine
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "voices", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Voices
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesAudiosJackInput" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesAudiosJackInput\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesAudiosJackInput cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesAudiosJackInput).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
