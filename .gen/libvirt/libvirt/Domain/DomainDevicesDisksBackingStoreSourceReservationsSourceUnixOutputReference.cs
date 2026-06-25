using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesDisksBackingStoreSourceReservationsSourceUnixOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksBackingStoreSourceReservationsSourceUnixOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesDisksBackingStoreSourceReservationsSourceUnixOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesDisksBackingStoreSourceReservationsSourceUnixOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesDisksBackingStoreSourceReservationsSourceUnixOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesDisksBackingStoreSourceReservationsSourceUnixOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putReconnect", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceReservationsSourceUnixReconnect\"}}]")]
        public virtual void PutReconnect(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceReservationsSourceUnixReconnect @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceReservationsSourceUnixReconnect)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksBackingStoreSourceReservationsSourceUnixSecLabel" />)[]</param>
        [JsiiMethod(name: "putSecLabel", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceReservationsSourceUnixSecLabel\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSecLabel(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainDevicesDisksBackingStoreSourceReservationsSourceUnixSecLabel[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceReservationsSourceUnixSecLabel).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceReservationsSourceUnixSecLabel).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMode")]
        public virtual void ResetMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPath")]
        public virtual void ResetPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReconnect")]
        public virtual void ResetReconnect()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecLabel")]
        public virtual void ResetSecLabel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "reconnect", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceReservationsSourceUnixReconnectOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksBackingStoreSourceReservationsSourceUnixReconnectOutputReference Reconnect
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksBackingStoreSourceReservationsSourceUnixReconnectOutputReference>()!;
        }

        [JsiiProperty(name: "secLabel", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceReservationsSourceUnixSecLabelList\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksBackingStoreSourceReservationsSourceUnixSecLabelList SecLabel
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksBackingStoreSourceReservationsSourceUnixSecLabelList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "modeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PathInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksBackingStoreSourceReservationsSourceUnixReconnect" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reconnectInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceReservationsSourceUnixReconnect\"}]}}", isOptional: true)]
        public virtual object? ReconnectInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksBackingStoreSourceReservationsSourceUnixSecLabel" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secLabelInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceReservationsSourceUnixSecLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SecLabelInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksBackingStoreSourceReservationsSourceUnix" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceReservationsSourceUnix\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesDisksBackingStoreSourceReservationsSourceUnix cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceReservationsSourceUnix).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
