using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesInterfacesSourceHostdevUsbOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceHostdevUsbOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesInterfacesSourceHostdevUsbOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesInterfacesSourceHostdevUsbOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesInterfacesSourceHostdevUsbOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesInterfacesSourceHostdevUsbOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevUsbAddress\"}}]")]
        public virtual void PutAddress(libvirt.Domain.IDomainDevicesInterfacesSourceHostdevUsbAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesSourceHostdevUsbAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProduct", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevUsbProduct\"}}]")]
        public virtual void PutProduct(libvirt.Domain.IDomainDevicesInterfacesSourceHostdevUsbProduct @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesSourceHostdevUsbProduct)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVendor", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevUsbVendor\"}}]")]
        public virtual void PutVendor(libvirt.Domain.IDomainDevicesInterfacesSourceHostdevUsbVendor @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesSourceHostdevUsbVendor)}, new object[]{@value});
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

        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevUsbAddressOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesSourceHostdevUsbAddressOutputReference Address
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesSourceHostdevUsbAddressOutputReference>()!;
        }

        [JsiiProperty(name: "product", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevUsbProductOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesSourceHostdevUsbProductOutputReference Product
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesSourceHostdevUsbProductOutputReference>()!;
        }

        [JsiiProperty(name: "vendor", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevUsbVendorOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesSourceHostdevUsbVendorOutputReference Vendor
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesSourceHostdevUsbVendorOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesSourceHostdevUsbAddress" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addressInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevUsbAddress\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesSourceHostdevUsbProduct" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "productInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevUsbProduct\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesSourceHostdevUsbVendor" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vendorInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevUsbVendor\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesSourceHostdevUsb" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevUsb\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesInterfacesSourceHostdevUsb cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesInterfacesSourceHostdevUsb).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
