using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesInterfacesSourceHostdevPciAddressOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceHostdevPciAddressOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesInterfacesSourceHostdevPciAddressOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesInterfacesSourceHostdevPciAddressOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesInterfacesSourceHostdevPciAddressOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesInterfacesSourceHostdevPciAddressOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putZpci", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevPciAddressZpci\"}}]")]
        public virtual void PutZpci(libvirt.Domain.IDomainDevicesInterfacesSourceHostdevPciAddressZpci @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesSourceHostdevPciAddressZpci)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBus")]
        public virtual void ResetBus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDomain")]
        public virtual void ResetDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFunction")]
        public virtual void ResetFunction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMultiFunction")]
        public virtual void ResetMultiFunction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSlot")]
        public virtual void ResetSlot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZpci")]
        public virtual void ResetZpci()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "zpci", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevPciAddressZpciOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesSourceHostdevPciAddressZpciOutputReference Zpci
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesSourceHostdevPciAddressZpciOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "busInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BusInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DomainInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "functionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FunctionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "multiFunctionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MultiFunctionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "slotInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SlotInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesSourceHostdevPciAddressZpci" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "zpciInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevPciAddressZpci\"}]}}", isOptional: true)]
        public virtual object? ZpciInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "bus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Bus
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Domain
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "function", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Function
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "multiFunction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MultiFunction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "slot", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Slot
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesSourceHostdevPciAddress" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevPciAddress\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesInterfacesSourceHostdevPciAddress cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesInterfacesSourceHostdevPciAddress).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
