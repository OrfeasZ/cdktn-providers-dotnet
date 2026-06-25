using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesChannelsOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesChannelsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DomainDevicesChannelsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DomainDevicesChannelsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DomainDevicesChannelsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesChannelsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAcpi", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesChannelsAcpi\"}}]")]
        public virtual void PutAcpi(libvirt.Domain.IDomainDevicesChannelsAcpi @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesChannelsAcpi)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesChannelsAddress\"}}]")]
        public virtual void PutAddress(libvirt.Domain.IDomainDevicesChannelsAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesChannelsAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAlias", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesChannelsAlias\"}}]")]
        public virtual void PutAlias(libvirt.Domain.IDomainDevicesChannelsAlias @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesChannelsAlias)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLog", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesChannelsLog\"}}]")]
        public virtual void PutLog(libvirt.Domain.IDomainDevicesChannelsLog @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesChannelsLog)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProtocol", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesChannelsProtocol\"}}]")]
        public virtual void PutProtocol(libvirt.Domain.IDomainDevicesChannelsProtocol @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesChannelsProtocol)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesChannelsSource\"}}]")]
        public virtual void PutSource(libvirt.Domain.IDomainDevicesChannelsSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesChannelsSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesChannelsTarget\"}}]")]
        public virtual void PutTarget(libvirt.Domain.IDomainDevicesChannelsTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesChannelsTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcpi")]
        public virtual void ResetAcpi()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAddress")]
        public virtual void ResetAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAlias")]
        public virtual void ResetAlias()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLog")]
        public virtual void ResetLog()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtocol")]
        public virtual void ResetProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSource")]
        public virtual void ResetSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTarget")]
        public virtual void ResetTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesChannelsAcpiOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesChannelsAcpiOutputReference Acpi
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesChannelsAcpiOutputReference>()!;
        }

        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesChannelsAddressOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesChannelsAddressOutputReference Address
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesChannelsAddressOutputReference>()!;
        }

        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesChannelsAliasOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesChannelsAliasOutputReference Alias
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesChannelsAliasOutputReference>()!;
        }

        [JsiiProperty(name: "log", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesChannelsLogOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesChannelsLogOutputReference Log
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesChannelsLogOutputReference>()!;
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesChannelsProtocolOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesChannelsProtocolOutputReference Protocol
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesChannelsProtocolOutputReference>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesChannelsSourceOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesChannelsSourceOutputReference Source
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesChannelsSourceOutputReference>()!;
        }

        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesChannelsTargetOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesChannelsTargetOutputReference Target
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesChannelsTargetOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesChannelsAcpi" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acpiInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesChannelsAcpi\"}]}}", isOptional: true)]
        public virtual object? AcpiInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesChannelsAddress" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addressInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesChannelsAddress\"}]}}", isOptional: true)]
        public virtual object? AddressInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesChannelsAlias" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "aliasInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesChannelsAlias\"}]}}", isOptional: true)]
        public virtual object? AliasInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesChannelsLog" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesChannelsLog\"}]}}", isOptional: true)]
        public virtual object? LogInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesChannelsProtocol" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "protocolInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesChannelsProtocol\"}]}}", isOptional: true)]
        public virtual object? ProtocolInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesChannelsSource" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesChannelsSource\"}]}}", isOptional: true)]
        public virtual object? SourceInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesChannelsTarget" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesChannelsTarget\"}]}}", isOptional: true)]
        public virtual object? TargetInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesChannels" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesChannels\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesChannels cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesChannels).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
