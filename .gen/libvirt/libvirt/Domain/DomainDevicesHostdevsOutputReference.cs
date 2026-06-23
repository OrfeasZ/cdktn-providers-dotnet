using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesHostdevsOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DomainDevicesHostdevsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DomainDevicesHostdevsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DomainDevicesHostdevsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesHostdevsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAcpi", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsAcpi\"}}]")]
        public virtual void PutAcpi(libvirt.Domain.IDomainDevicesHostdevsAcpi @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesHostdevsAcpi)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsAddress\"}}]")]
        public virtual void PutAddress(libvirt.Domain.IDomainDevicesHostdevsAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesHostdevsAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAlias", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsAlias\"}}]")]
        public virtual void PutAlias(libvirt.Domain.IDomainDevicesHostdevsAlias @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesHostdevsAlias)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBoot", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsBoot\"}}]")]
        public virtual void PutBoot(libvirt.Domain.IDomainDevicesHostdevsBoot @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesHostdevsBoot)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCapsMisc", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsCapsMisc\"}}]")]
        public virtual void PutCapsMisc(libvirt.Domain.IDomainDevicesHostdevsCapsMisc @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesHostdevsCapsMisc)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCapsNet", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsCapsNet\"}}]")]
        public virtual void PutCapsNet(libvirt.Domain.IDomainDevicesHostdevsCapsNet @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesHostdevsCapsNet)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCapsStorage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsCapsStorage\"}}]")]
        public virtual void PutCapsStorage(libvirt.Domain.IDomainDevicesHostdevsCapsStorage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesHostdevsCapsStorage)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRom", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsRom\"}}]")]
        public virtual void PutRom(libvirt.Domain.IDomainDevicesHostdevsRom @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesHostdevsRom)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSubsysMDev", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysMDev\"}}]")]
        public virtual void PutSubsysMDev(libvirt.Domain.IDomainDevicesHostdevsSubsysMDev @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesHostdevsSubsysMDev)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSubsysPci", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysPci\"}}]")]
        public virtual void PutSubsysPci(libvirt.Domain.IDomainDevicesHostdevsSubsysPci @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesHostdevsSubsysPci)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSubsysScsi", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsi\"}}]")]
        public virtual void PutSubsysScsi(libvirt.Domain.IDomainDevicesHostdevsSubsysScsi @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesHostdevsSubsysScsi)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSubsysScsiHost", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiHost\"}}]")]
        public virtual void PutSubsysScsiHost(libvirt.Domain.IDomainDevicesHostdevsSubsysScsiHost @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesHostdevsSubsysScsiHost)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSubsysUsb", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysUsb\"}}]")]
        public virtual void PutSubsysUsb(libvirt.Domain.IDomainDevicesHostdevsSubsysUsb @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesHostdevsSubsysUsb)}, new object[]{@value});
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

        [JsiiMethod(name: "resetBoot")]
        public virtual void ResetBoot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCapsMisc")]
        public virtual void ResetCapsMisc()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCapsNet")]
        public virtual void ResetCapsNet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCapsStorage")]
        public virtual void ResetCapsStorage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManaged")]
        public virtual void ResetManaged()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRom")]
        public virtual void ResetRom()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubsysMDev")]
        public virtual void ResetSubsysMDev()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubsysPci")]
        public virtual void ResetSubsysPci()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubsysScsi")]
        public virtual void ResetSubsysScsi()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubsysScsiHost")]
        public virtual void ResetSubsysScsiHost()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubsysUsb")]
        public virtual void ResetSubsysUsb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsAcpiOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesHostdevsAcpiOutputReference Acpi
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesHostdevsAcpiOutputReference>()!;
        }

        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsAddressOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesHostdevsAddressOutputReference Address
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesHostdevsAddressOutputReference>()!;
        }

        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsAliasOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesHostdevsAliasOutputReference Alias
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesHostdevsAliasOutputReference>()!;
        }

        [JsiiProperty(name: "boot", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsBootOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesHostdevsBootOutputReference Boot
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesHostdevsBootOutputReference>()!;
        }

        [JsiiProperty(name: "capsMisc", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsCapsMiscOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesHostdevsCapsMiscOutputReference CapsMisc
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesHostdevsCapsMiscOutputReference>()!;
        }

        [JsiiProperty(name: "capsNet", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsCapsNetOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesHostdevsCapsNetOutputReference CapsNet
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesHostdevsCapsNetOutputReference>()!;
        }

        [JsiiProperty(name: "capsStorage", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsCapsStorageOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesHostdevsCapsStorageOutputReference CapsStorage
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesHostdevsCapsStorageOutputReference>()!;
        }

        [JsiiProperty(name: "rom", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsRomOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesHostdevsRomOutputReference Rom
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesHostdevsRomOutputReference>()!;
        }

        [JsiiProperty(name: "subsysMDev", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysMDevOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesHostdevsSubsysMDevOutputReference SubsysMDev
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesHostdevsSubsysMDevOutputReference>()!;
        }

        [JsiiProperty(name: "subsysPci", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysPciOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesHostdevsSubsysPciOutputReference SubsysPci
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesHostdevsSubsysPciOutputReference>()!;
        }

        [JsiiProperty(name: "subsysScsi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesHostdevsSubsysScsiOutputReference SubsysScsi
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesHostdevsSubsysScsiOutputReference>()!;
        }

        [JsiiProperty(name: "subsysScsiHost", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiHostOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesHostdevsSubsysScsiHostOutputReference SubsysScsiHost
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesHostdevsSubsysScsiHostOutputReference>()!;
        }

        [JsiiProperty(name: "subsysUsb", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysUsbOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesHostdevsSubsysUsbOutputReference SubsysUsb
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesHostdevsSubsysUsbOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "acpiInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsAcpi\"}]}}", isOptional: true)]
        public virtual object? AcpiInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "addressInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsAddress\"}]}}", isOptional: true)]
        public virtual object? AddressInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "aliasInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsAlias\"}]}}", isOptional: true)]
        public virtual object? AliasInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bootInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsBoot\"}]}}", isOptional: true)]
        public virtual object? BootInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capsMiscInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsCapsMisc\"}]}}", isOptional: true)]
        public virtual object? CapsMiscInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capsNetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsCapsNet\"}]}}", isOptional: true)]
        public virtual object? CapsNetInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capsStorageInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsCapsStorage\"}]}}", isOptional: true)]
        public virtual object? CapsStorageInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ManagedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "romInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsRom\"}]}}", isOptional: true)]
        public virtual object? RomInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subsysMDevInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysMDev\"}]}}", isOptional: true)]
        public virtual object? SubsysMDevInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subsysPciInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysPci\"}]}}", isOptional: true)]
        public virtual object? SubsysPciInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subsysScsiHostInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiHost\"}]}}", isOptional: true)]
        public virtual object? SubsysScsiHostInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subsysScsiInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsi\"}]}}", isOptional: true)]
        public virtual object? SubsysScsiInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subsysUsbInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysUsb\"}]}}", isOptional: true)]
        public virtual object? SubsysUsbInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "managed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Managed
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesHostdevs\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesHostdevs cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesHostdevs).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
