using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesHostdevsSubsysScsiSourceIscsiOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesHostdevsSubsysScsiSourceIscsiOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesHostdevsSubsysScsiSourceIscsiOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesHostdevsSubsysScsiSourceIscsiOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesHostdevsSubsysScsiSourceIscsiOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuth", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiAuth\"}}]")]
        public virtual void PutAuth(libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiAuth @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiAuth)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiHost" />)[]</param>
        [JsiiMethod(name: "putHost", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiHost\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHost(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiHost[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiHost).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiHost).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInitiator", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiInitiator\"}}]")]
        public virtual void PutInitiator(libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiInitiator @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiInitiator)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuth")]
        public virtual void ResetAuth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHost")]
        public virtual void ResetHost()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitiator")]
        public virtual void ResetInitiator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "auth", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiAuthOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesHostdevsSubsysScsiSourceIscsiAuthOutputReference Auth
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesHostdevsSubsysScsiSourceIscsiAuthOutputReference>()!;
        }

        [JsiiProperty(name: "host", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiHostList\"}")]
        public virtual libvirt.Domain.DomainDevicesHostdevsSubsysScsiSourceIscsiHostList Host
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesHostdevsSubsysScsiSourceIscsiHostList>()!;
        }

        [JsiiProperty(name: "initiator", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiInitiatorOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesHostdevsSubsysScsiSourceIscsiInitiatorOutputReference Initiator
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesHostdevsSubsysScsiSourceIscsiInitiatorOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiAuth" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiAuth\"}]}}", isOptional: true)]
        public virtual object? AuthInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiHost" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiHost\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HostInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiInitiator" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "initiatorInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiInitiator\"}]}}", isOptional: true)]
        public virtual object? InitiatorInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsi" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsi\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsi cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsi).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
