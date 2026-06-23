using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesChannelsTargetOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesChannelsTargetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesChannelsTargetOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesChannelsTargetOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesChannelsTargetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesChannelsTargetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGuestFwd", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesChannelsTargetGuestFwd\"}}]")]
        public virtual void PutGuestFwd(libvirt.Domain.IDomainDevicesChannelsTargetGuestFwd @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesChannelsTargetGuestFwd)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVirtIo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesChannelsTargetVirtIo\"}}]")]
        public virtual void PutVirtIo(libvirt.Domain.IDomainDevicesChannelsTargetVirtIo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesChannelsTargetVirtIo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putXen", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesChannelsTargetXen\"}}]")]
        public virtual void PutXen(libvirt.Domain.IDomainDevicesChannelsTargetXen @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesChannelsTargetXen)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetGuestFwd")]
        public virtual void ResetGuestFwd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVirtIo")]
        public virtual void ResetVirtIo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetXen")]
        public virtual void ResetXen()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "guestFwd", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesChannelsTargetGuestFwdOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesChannelsTargetGuestFwdOutputReference GuestFwd
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesChannelsTargetGuestFwdOutputReference>()!;
        }

        [JsiiProperty(name: "virtIo", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesChannelsTargetVirtIoOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesChannelsTargetVirtIoOutputReference VirtIo
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesChannelsTargetVirtIoOutputReference>()!;
        }

        [JsiiProperty(name: "xen", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesChannelsTargetXenOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesChannelsTargetXenOutputReference Xen
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesChannelsTargetXenOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "guestFwdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesChannelsTargetGuestFwd\"}]}}", isOptional: true)]
        public virtual object? GuestFwdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtIoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesChannelsTargetVirtIo\"}]}}", isOptional: true)]
        public virtual object? VirtIoInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "xenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesChannelsTargetXen\"}]}}", isOptional: true)]
        public virtual object? XenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesChannelsTarget\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesChannelsTarget cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesChannelsTarget).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
