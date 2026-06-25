using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesAudiosOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DomainDevicesAudiosOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DomainDevicesAudiosOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesAudiosOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesAudiosOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAlsa", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesAudiosAlsa\"}}]")]
        public virtual void PutAlsa(libvirt.Domain.IDomainDevicesAudiosAlsa @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesAudiosAlsa)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCoreAudio", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesAudiosCoreAudio\"}}]")]
        public virtual void PutCoreAudio(libvirt.Domain.IDomainDevicesAudiosCoreAudio @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesAudiosCoreAudio)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDbus", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesAudiosDbus\"}}]")]
        public virtual void PutDbus(libvirt.Domain.IDomainDevicesAudiosDbus @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesAudiosDbus)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesAudiosFile\"}}]")]
        public virtual void PutFile(libvirt.Domain.IDomainDevicesAudiosFile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesAudiosFile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJack", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesAudiosJack\"}}]")]
        public virtual void PutJack(libvirt.Domain.IDomainDevicesAudiosJack @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesAudiosJack)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNone", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesAudiosNone\"}}]")]
        public virtual void PutNone(libvirt.Domain.IDomainDevicesAudiosNone @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesAudiosNone)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOss", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesAudiosOss\"}}]")]
        public virtual void PutOss(libvirt.Domain.IDomainDevicesAudiosOss @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesAudiosOss)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPipeWire", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPipeWire\"}}]")]
        public virtual void PutPipeWire(libvirt.Domain.IDomainDevicesAudiosPipeWire @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesAudiosPipeWire)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPulseAudio", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPulseAudio\"}}]")]
        public virtual void PutPulseAudio(libvirt.Domain.IDomainDevicesAudiosPulseAudio @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesAudiosPulseAudio)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSdl", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesAudiosSdl\"}}]")]
        public virtual void PutSdl(libvirt.Domain.IDomainDevicesAudiosSdl @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesAudiosSdl)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSpice", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesAudiosSpice\"}}]")]
        public virtual void PutSpice(libvirt.Domain.IDomainDevicesAudiosSpice @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesAudiosSpice)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAlsa")]
        public virtual void ResetAlsa()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCoreAudio")]
        public virtual void ResetCoreAudio()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDbus")]
        public virtual void ResetDbus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFile")]
        public virtual void ResetFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJack")]
        public virtual void ResetJack()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNone")]
        public virtual void ResetNone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOss")]
        public virtual void ResetOss()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPipeWire")]
        public virtual void ResetPipeWire()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPulseAudio")]
        public virtual void ResetPulseAudio()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSdl")]
        public virtual void ResetSdl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpice")]
        public virtual void ResetSpice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimerPeriod")]
        public virtual void ResetTimerPeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "alsa", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosAlsaOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesAudiosAlsaOutputReference Alsa
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesAudiosAlsaOutputReference>()!;
        }

        [JsiiProperty(name: "coreAudio", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosCoreAudioOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesAudiosCoreAudioOutputReference CoreAudio
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesAudiosCoreAudioOutputReference>()!;
        }

        [JsiiProperty(name: "dbus", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosDbusOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesAudiosDbusOutputReference Dbus
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesAudiosDbusOutputReference>()!;
        }

        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosFileOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesAudiosFileOutputReference File
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesAudiosFileOutputReference>()!;
        }

        [JsiiProperty(name: "jack", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosJackOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesAudiosJackOutputReference Jack
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesAudiosJackOutputReference>()!;
        }

        [JsiiProperty(name: "none", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosNoneOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesAudiosNoneOutputReference None
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesAudiosNoneOutputReference>()!;
        }

        [JsiiProperty(name: "oss", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosOssOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesAudiosOssOutputReference Oss
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesAudiosOssOutputReference>()!;
        }

        [JsiiProperty(name: "pipeWire", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPipeWireOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesAudiosPipeWireOutputReference PipeWire
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesAudiosPipeWireOutputReference>()!;
        }

        [JsiiProperty(name: "pulseAudio", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPulseAudioOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesAudiosPulseAudioOutputReference PulseAudio
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesAudiosPulseAudioOutputReference>()!;
        }

        [JsiiProperty(name: "sdl", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosSdlOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesAudiosSdlOutputReference Sdl
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesAudiosSdlOutputReference>()!;
        }

        [JsiiProperty(name: "spice", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosSpiceOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesAudiosSpiceOutputReference Spice
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesAudiosSpiceOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesAudiosAlsa" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alsaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesAudiosAlsa\"}]}}", isOptional: true)]
        public virtual object? AlsaInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesAudiosCoreAudio" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "coreAudioInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesAudiosCoreAudio\"}]}}", isOptional: true)]
        public virtual object? CoreAudioInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesAudiosDbus" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbusInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesAudiosDbus\"}]}}", isOptional: true)]
        public virtual object? DbusInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesAudiosFile" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesAudiosFile\"}]}}", isOptional: true)]
        public virtual object? FileInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IdInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesAudiosJack" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jackInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesAudiosJack\"}]}}", isOptional: true)]
        public virtual object? JackInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesAudiosNone" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "noneInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesAudiosNone\"}]}}", isOptional: true)]
        public virtual object? NoneInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesAudiosOss" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ossInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesAudiosOss\"}]}}", isOptional: true)]
        public virtual object? OssInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesAudiosPipeWire" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pipeWireInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPipeWire\"}]}}", isOptional: true)]
        public virtual object? PipeWireInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesAudiosPulseAudio" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pulseAudioInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesAudiosPulseAudio\"}]}}", isOptional: true)]
        public virtual object? PulseAudioInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesAudiosSdl" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sdlInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesAudiosSdl\"}]}}", isOptional: true)]
        public virtual object? SdlInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesAudiosSpice" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spiceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesAudiosSpice\"}]}}", isOptional: true)]
        public virtual object? SpiceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timerPeriodInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TimerPeriodInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Id
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timerPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimerPeriod
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesAudios" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesAudios\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesAudios cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesAudios).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
