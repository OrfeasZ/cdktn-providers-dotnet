using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesAudiosAlsaOutputOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosAlsaOutputOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesAudiosAlsaOutputOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesAudiosAlsaOutputOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesAudiosAlsaOutputOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesAudiosAlsaOutputOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesAudiosAlsaOutputSettings\"}}]")]
        public virtual void PutSettings(libvirt.Domain.IDomainDevicesAudiosAlsaOutputSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesAudiosAlsaOutputSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBufferLength")]
        public virtual void ResetBufferLength()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDev")]
        public virtual void ResetDev()
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

        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosAlsaOutputSettingsOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesAudiosAlsaOutputSettingsOutputReference Settings
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesAudiosAlsaOutputSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bufferLengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BufferLengthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "devInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DevInput
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

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesAudiosAlsaOutputSettings" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "settingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesAudiosAlsaOutputSettings\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Dev
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

        [JsiiProperty(name: "voices", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Voices
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesAudiosAlsaOutput" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesAudiosAlsaOutput\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesAudiosAlsaOutput cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesAudiosAlsaOutput).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
