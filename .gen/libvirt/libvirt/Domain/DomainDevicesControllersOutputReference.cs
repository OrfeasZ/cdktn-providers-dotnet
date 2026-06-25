using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesControllersOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesControllersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DomainDevicesControllersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DomainDevicesControllersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DomainDevicesControllersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesControllersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAcpi", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesControllersAcpi\"}}]")]
        public virtual void PutAcpi(libvirt.Domain.IDomainDevicesControllersAcpi @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesControllersAcpi)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesControllersAddress\"}}]")]
        public virtual void PutAddress(libvirt.Domain.IDomainDevicesControllersAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesControllersAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAlias", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesControllersAlias\"}}]")]
        public virtual void PutAlias(libvirt.Domain.IDomainDevicesControllersAlias @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesControllersAlias)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDriver", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesControllersDriver\"}}]")]
        public virtual void PutDriver(libvirt.Domain.IDomainDevicesControllersDriver @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesControllersDriver)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNvme", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesControllersNvme\"}}]")]
        public virtual void PutNvme(libvirt.Domain.IDomainDevicesControllersNvme @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesControllersNvme)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPci", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesControllersPci\"}}]")]
        public virtual void PutPci(libvirt.Domain.IDomainDevicesControllersPci @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesControllersPci)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUsb", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesControllersUsb\"}}]")]
        public virtual void PutUsb(libvirt.Domain.IDomainDevicesControllersUsb @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesControllersUsb)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVirtIoSerial", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesControllersVirtIoSerial\"}}]")]
        public virtual void PutVirtIoSerial(libvirt.Domain.IDomainDevicesControllersVirtIoSerial @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesControllersVirtIoSerial)}, new object[]{@value});
        }

        [JsiiMethod(name: "putXenBus", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesControllersXenBus\"}}]")]
        public virtual void PutXenBus(libvirt.Domain.IDomainDevicesControllersXenBus @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesControllersXenBus)}, new object[]{@value});
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

        [JsiiMethod(name: "resetDriver")]
        public virtual void ResetDriver()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIndex")]
        public virtual void ResetIndex()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModel")]
        public virtual void ResetModel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNvme")]
        public virtual void ResetNvme()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPci")]
        public virtual void ResetPci()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsb")]
        public virtual void ResetUsb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVirtIoSerial")]
        public virtual void ResetVirtIoSerial()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetXenBus")]
        public virtual void ResetXenBus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersAcpiOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesControllersAcpiOutputReference Acpi
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesControllersAcpiOutputReference>()!;
        }

        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersAddressOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesControllersAddressOutputReference Address
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesControllersAddressOutputReference>()!;
        }

        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersAliasOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesControllersAliasOutputReference Alias
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesControllersAliasOutputReference>()!;
        }

        [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersDriverOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesControllersDriverOutputReference Driver
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesControllersDriverOutputReference>()!;
        }

        [JsiiProperty(name: "nvme", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersNvmeOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesControllersNvmeOutputReference Nvme
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesControllersNvmeOutputReference>()!;
        }

        [JsiiProperty(name: "pci", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersPciOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesControllersPciOutputReference Pci
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesControllersPciOutputReference>()!;
        }

        [JsiiProperty(name: "usb", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersUsbOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesControllersUsbOutputReference Usb
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesControllersUsbOutputReference>()!;
        }

        [JsiiProperty(name: "virtIoSerial", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersVirtIoSerialOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesControllersVirtIoSerialOutputReference VirtIoSerial
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesControllersVirtIoSerialOutputReference>()!;
        }

        [JsiiProperty(name: "xenBus", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersXenBusOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesControllersXenBusOutputReference XenBus
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesControllersXenBusOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesControllersAcpi" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acpiInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesControllersAcpi\"}]}}", isOptional: true)]
        public virtual object? AcpiInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesControllersAddress" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addressInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesControllersAddress\"}]}}", isOptional: true)]
        public virtual object? AddressInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesControllersAlias" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "aliasInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesControllersAlias\"}]}}", isOptional: true)]
        public virtual object? AliasInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesControllersDriver" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "driverInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesControllersDriver\"}]}}", isOptional: true)]
        public virtual object? DriverInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "indexInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IndexInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesControllersNvme" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nvmeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesControllersNvme\"}]}}", isOptional: true)]
        public virtual object? NvmeInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesControllersPci" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pciInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesControllersPci\"}]}}", isOptional: true)]
        public virtual object? PciInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesControllersUsb" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usbInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesControllersUsb\"}]}}", isOptional: true)]
        public virtual object? UsbInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesControllersVirtIoSerial" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtIoSerialInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesControllersVirtIoSerial\"}]}}", isOptional: true)]
        public virtual object? VirtIoSerialInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesControllersXenBus" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "xenBusInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesControllersXenBus\"}]}}", isOptional: true)]
        public virtual object? XenBusInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "index", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Index
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Model
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesControllers" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesControllers\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesControllers cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesControllers).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
