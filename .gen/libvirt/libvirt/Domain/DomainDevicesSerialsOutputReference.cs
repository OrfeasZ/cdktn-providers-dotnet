using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesSerialsOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesSerialsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DomainDevicesSerialsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DomainDevicesSerialsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DomainDevicesSerialsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesSerialsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAcpi", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesSerialsAcpi\"}}]")]
        public virtual void PutAcpi(libvirt.Domain.IDomainDevicesSerialsAcpi @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesSerialsAcpi)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesSerialsAddress\"}}]")]
        public virtual void PutAddress(libvirt.Domain.IDomainDevicesSerialsAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesSerialsAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAlias", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesSerialsAlias\"}}]")]
        public virtual void PutAlias(libvirt.Domain.IDomainDevicesSerialsAlias @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesSerialsAlias)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLog", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesSerialsLog\"}}]")]
        public virtual void PutLog(libvirt.Domain.IDomainDevicesSerialsLog @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesSerialsLog)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProtocol", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesSerialsProtocol\"}}]")]
        public virtual void PutProtocol(libvirt.Domain.IDomainDevicesSerialsProtocol @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesSerialsProtocol)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesSerialsSource\"}}]")]
        public virtual void PutSource(libvirt.Domain.IDomainDevicesSerialsSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesSerialsSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesSerialsTarget\"}}]")]
        public virtual void PutTarget(libvirt.Domain.IDomainDevicesSerialsTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesSerialsTarget)}, new object[]{@value});
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

        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSerialsAcpiOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesSerialsAcpiOutputReference Acpi
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesSerialsAcpiOutputReference>()!;
        }

        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSerialsAddressOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesSerialsAddressOutputReference Address
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesSerialsAddressOutputReference>()!;
        }

        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSerialsAliasOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesSerialsAliasOutputReference Alias
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesSerialsAliasOutputReference>()!;
        }

        [JsiiProperty(name: "log", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSerialsLogOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesSerialsLogOutputReference Log
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesSerialsLogOutputReference>()!;
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSerialsProtocolOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesSerialsProtocolOutputReference Protocol
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesSerialsProtocolOutputReference>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSerialsSourceOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesSerialsSourceOutputReference Source
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesSerialsSourceOutputReference>()!;
        }

        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSerialsTargetOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesSerialsTargetOutputReference Target
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesSerialsTargetOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesSerialsAcpi" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acpiInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesSerialsAcpi\"}]}}", isOptional: true)]
        public virtual object? AcpiInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesSerialsAddress" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addressInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesSerialsAddress\"}]}}", isOptional: true)]
        public virtual object? AddressInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesSerialsAlias" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "aliasInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesSerialsAlias\"}]}}", isOptional: true)]
        public virtual object? AliasInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesSerialsLog" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesSerialsLog\"}]}}", isOptional: true)]
        public virtual object? LogInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesSerialsProtocol" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "protocolInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesSerialsProtocol\"}]}}", isOptional: true)]
        public virtual object? ProtocolInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesSerialsSource" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesSerialsSource\"}]}}", isOptional: true)]
        public virtual object? SourceInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesSerialsTarget" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesSerialsTarget\"}]}}", isOptional: true)]
        public virtual object? TargetInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesSerials" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesSerials\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesSerials cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesSerials).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
