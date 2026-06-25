using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesAudiosFileOutputOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosFileOutputOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesAudiosFileOutputOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesAudiosFileOutputOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesAudiosFileOutputOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesAudiosFileOutputOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesAudiosFileOutputSettings\"}}]")]
        public virtual void PutSettings(libvirt.Domain.IDomainDevicesAudiosFileOutputSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesAudiosFileOutputSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBufferLength")]
        public virtual void ResetBufferLength()
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

        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosFileOutputSettingsOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesAudiosFileOutputSettingsOutputReference Settings
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesAudiosFileOutputSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bufferLengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BufferLengthInput
        {
            get => GetInstanceProperty<double?>();
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesAudiosFileOutputSettings" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "settingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesAudiosFileOutputSettings\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesAudiosFileOutput" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesAudiosFileOutput\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesAudiosFileOutput cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesAudiosFileOutput).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
