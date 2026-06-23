using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesGraphicsOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DomainDevicesGraphicsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DomainDevicesGraphicsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DomainDevicesGraphicsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesGraphicsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAudio", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsAudio\"}}]")]
        public virtual void PutAudio(libvirt.Domain.IDomainDevicesGraphicsAudio @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesGraphicsAudio)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDbus", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsDbus\"}}]")]
        public virtual void PutDbus(libvirt.Domain.IDomainDevicesGraphicsDbus @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesGraphicsDbus)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDesktop", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsDesktop\"}}]")]
        public virtual void PutDesktop(libvirt.Domain.IDomainDevicesGraphicsDesktop @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesGraphicsDesktop)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEglHeadless", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsEglHeadless\"}}]")]
        public virtual void PutEglHeadless(libvirt.Domain.IDomainDevicesGraphicsEglHeadless @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesGraphicsEglHeadless)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRdp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsRdp\"}}]")]
        public virtual void PutRdp(libvirt.Domain.IDomainDevicesGraphicsRdp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesGraphicsRdp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSdl", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSdl\"}}]")]
        public virtual void PutSdl(libvirt.Domain.IDomainDevicesGraphicsSdl @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesGraphicsSdl)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSpice", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpice\"}}]")]
        public virtual void PutSpice(libvirt.Domain.IDomainDevicesGraphicsSpice @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesGraphicsSpice)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVnc", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsVnc\"}}]")]
        public virtual void PutVnc(libvirt.Domain.IDomainDevicesGraphicsVnc @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesGraphicsVnc)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAudio")]
        public virtual void ResetAudio()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDbus")]
        public virtual void ResetDbus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDesktop")]
        public virtual void ResetDesktop()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEglHeadless")]
        public virtual void ResetEglHeadless()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRdp")]
        public virtual void ResetRdp()
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

        [JsiiMethod(name: "resetVnc")]
        public virtual void ResetVnc()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "audio", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsAudioOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesGraphicsAudioOutputReference Audio
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesGraphicsAudioOutputReference>()!;
        }

        [JsiiProperty(name: "dbus", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsDbusOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesGraphicsDbusOutputReference Dbus
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesGraphicsDbusOutputReference>()!;
        }

        [JsiiProperty(name: "desktop", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsDesktopOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesGraphicsDesktopOutputReference Desktop
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesGraphicsDesktopOutputReference>()!;
        }

        [JsiiProperty(name: "eglHeadless", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsEglHeadlessOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesGraphicsEglHeadlessOutputReference EglHeadless
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesGraphicsEglHeadlessOutputReference>()!;
        }

        [JsiiProperty(name: "rdp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsRdpOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesGraphicsRdpOutputReference Rdp
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesGraphicsRdpOutputReference>()!;
        }

        [JsiiProperty(name: "sdl", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSdlOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesGraphicsSdlOutputReference Sdl
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesGraphicsSdlOutputReference>()!;
        }

        [JsiiProperty(name: "spice", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesGraphicsSpiceOutputReference Spice
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesGraphicsSpiceOutputReference>()!;
        }

        [JsiiProperty(name: "vnc", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsVncOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesGraphicsVncOutputReference Vnc
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesGraphicsVncOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "audioInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsAudio\"}]}}", isOptional: true)]
        public virtual object? AudioInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbusInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsDbus\"}]}}", isOptional: true)]
        public virtual object? DbusInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "desktopInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsDesktop\"}]}}", isOptional: true)]
        public virtual object? DesktopInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eglHeadlessInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsEglHeadless\"}]}}", isOptional: true)]
        public virtual object? EglHeadlessInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rdpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsRdp\"}]}}", isOptional: true)]
        public virtual object? RdpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sdlInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSdl\"}]}}", isOptional: true)]
        public virtual object? SdlInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spiceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpice\"}]}}", isOptional: true)]
        public virtual object? SpiceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vncInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsVnc\"}]}}", isOptional: true)]
        public virtual object? VncInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesGraphics\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesGraphics cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesGraphics).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
