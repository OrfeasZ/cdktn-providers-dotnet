using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesHostdevsSubsysUsbSourceOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysUsbSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesHostdevsSubsysUsbSourceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesHostdevsSubsysUsbSourceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesHostdevsSubsysUsbSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesHostdevsSubsysUsbSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysUsbSourceAddress\"}}]")]
        public virtual void PutAddress(libvirt.Domain.IDomainDevicesHostdevsSubsysUsbSourceAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesHostdevsSubsysUsbSourceAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProduct", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysUsbSourceProduct\"}}]")]
        public virtual void PutProduct(libvirt.Domain.IDomainDevicesHostdevsSubsysUsbSourceProduct @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesHostdevsSubsysUsbSourceProduct)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVendor", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysUsbSourceVendor\"}}]")]
        public virtual void PutVendor(libvirt.Domain.IDomainDevicesHostdevsSubsysUsbSourceVendor @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesHostdevsSubsysUsbSourceVendor)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAddress")]
        public virtual void ResetAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGuestReset")]
        public virtual void ResetGuestReset()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProduct")]
        public virtual void ResetProduct()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartUpPolicy")]
        public virtual void ResetStartUpPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVendor")]
        public virtual void ResetVendor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysUsbSourceAddressOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesHostdevsSubsysUsbSourceAddressOutputReference Address
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesHostdevsSubsysUsbSourceAddressOutputReference>()!;
        }

        [JsiiProperty(name: "product", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysUsbSourceProductOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesHostdevsSubsysUsbSourceProductOutputReference Product
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesHostdevsSubsysUsbSourceProductOutputReference>()!;
        }

        [JsiiProperty(name: "vendor", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysUsbSourceVendorOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesHostdevsSubsysUsbSourceVendorOutputReference Vendor
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesHostdevsSubsysUsbSourceVendorOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesHostdevsSubsysUsbSourceAddress" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addressInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysUsbSourceAddress\"}]}}", isOptional: true)]
        public virtual object? AddressInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "guestResetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GuestResetInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesHostdevsSubsysUsbSourceProduct" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "productInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysUsbSourceProduct\"}]}}", isOptional: true)]
        public virtual object? ProductInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startUpPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StartUpPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesHostdevsSubsysUsbSourceVendor" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vendorInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysUsbSourceVendor\"}]}}", isOptional: true)]
        public virtual object? VendorInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "guestReset", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GuestReset
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startUpPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartUpPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesHostdevsSubsysUsbSource" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysUsbSource\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesHostdevsSubsysUsbSource cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesHostdevsSubsysUsbSource).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
