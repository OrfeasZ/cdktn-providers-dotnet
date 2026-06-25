using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainOsOutputReference), fullyQualifiedName: "libvirt.domain.DomainOsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainOsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainOsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainOsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainOsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAcpi", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsAcpi\"}}]")]
        public virtual void PutAcpi(libvirt.Domain.IDomainOsAcpi @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsAcpi)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBios", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsBios\"}}]")]
        public virtual void PutBios(libvirt.Domain.IDomainOsBios @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsBios)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainOsBootDevices" />)[]</param>
        [JsiiMethod(name: "putBootDevices", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainOsBootDevices\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutBootDevices(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainOsBootDevices[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainOsBootDevices).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainOsBootDevices).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBootMenu", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsBootMenu\"}}]")]
        public virtual void PutBootMenu(libvirt.Domain.IDomainOsBootMenu @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsBootMenu)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFirmwareInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsFirmwareInfo\"}}]")]
        public virtual void PutFirmwareInfo(libvirt.Domain.IDomainOsFirmwareInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsFirmwareInfo)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainOsInitEnv" />)[]</param>
        [JsiiMethod(name: "putInitEnv", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainOsInitEnv\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutInitEnv(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainOsInitEnv[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainOsInitEnv).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainOsInitEnv).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNvRam", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRam\"}}]")]
        public virtual void PutNvRam(libvirt.Domain.IDomainOsNvRam @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRam)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSmBios", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsSmBios\"}}]")]
        public virtual void PutSmBios(libvirt.Domain.IDomainOsSmBios @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsSmBios)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcpi")]
        public virtual void ResetAcpi()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBios")]
        public virtual void ResetBios()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBootDevices")]
        public virtual void ResetBootDevices()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBootMenu")]
        public virtual void ResetBootMenu()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCmdline")]
        public virtual void ResetCmdline()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDtb")]
        public virtual void ResetDtb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirmware")]
        public virtual void ResetFirmware()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirmwareInfo")]
        public virtual void ResetFirmwareInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInit")]
        public virtual void ResetInit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitArgs")]
        public virtual void ResetInitArgs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitDir")]
        public virtual void ResetInitDir()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitEnv")]
        public virtual void ResetInitEnv()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitGroup")]
        public virtual void ResetInitGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitrd")]
        public virtual void ResetInitrd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitUser")]
        public virtual void ResetInitUser()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKernel")]
        public virtual void ResetKernel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoader")]
        public virtual void ResetLoader()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoaderFormat")]
        public virtual void ResetLoaderFormat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoaderReadonly")]
        public virtual void ResetLoaderReadonly()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoaderSecure")]
        public virtual void ResetLoaderSecure()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoaderStateless")]
        public virtual void ResetLoaderStateless()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoaderType")]
        public virtual void ResetLoaderType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNvRam")]
        public virtual void ResetNvRam()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShim")]
        public virtual void ResetShim()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmBios")]
        public virtual void ResetSmBios()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTypeArch")]
        public virtual void ResetTypeArch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTypeMachine")]
        public virtual void ResetTypeMachine()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsAcpiOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsAcpiOutputReference Acpi
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsAcpiOutputReference>()!;
        }

        [JsiiProperty(name: "bios", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsBiosOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsBiosOutputReference Bios
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsBiosOutputReference>()!;
        }

        [JsiiProperty(name: "bootDevices", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsBootDevicesList\"}")]
        public virtual libvirt.Domain.DomainOsBootDevicesList BootDevices
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsBootDevicesList>()!;
        }

        [JsiiProperty(name: "bootMenu", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsBootMenuOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsBootMenuOutputReference BootMenu
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsBootMenuOutputReference>()!;
        }

        [JsiiProperty(name: "firmwareInfo", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsFirmwareInfoOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsFirmwareInfoOutputReference FirmwareInfo
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsFirmwareInfoOutputReference>()!;
        }

        [JsiiProperty(name: "initEnv", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsInitEnvList\"}")]
        public virtual libvirt.Domain.DomainOsInitEnvList InitEnv
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsInitEnvList>()!;
        }

        [JsiiProperty(name: "nvRam", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamOutputReference NvRam
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamOutputReference>()!;
        }

        [JsiiProperty(name: "smBios", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsSmBiosOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsSmBiosOutputReference SmBios
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsSmBiosOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainOsAcpi" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acpiInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsAcpi\"}]}}", isOptional: true)]
        public virtual object? AcpiInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainOsBios" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "biosInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsBios\"}]}}", isOptional: true)]
        public virtual object? BiosInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainOsBootDevices" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bootDevicesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainOsBootDevices\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? BootDevicesInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainOsBootMenu" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bootMenuInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsBootMenu\"}]}}", isOptional: true)]
        public virtual object? BootMenuInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cmdlineInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CmdlineInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dtbInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DtbInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainOsFirmwareInfo" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "firmwareInfoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsFirmwareInfo\"}]}}", isOptional: true)]
        public virtual object? FirmwareInfoInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firmwareInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FirmwareInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initArgsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? InitArgsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initDirInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InitDirInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainOsInitEnv" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "initEnvInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainOsInitEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? InitEnvInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initGroupInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InitGroupInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InitInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initrdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InitrdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initUserInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InitUserInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kernelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KernelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loaderFormatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LoaderFormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loaderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LoaderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loaderReadonlyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LoaderReadonlyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loaderSecureInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LoaderSecureInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loaderStatelessInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LoaderStatelessInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loaderTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LoaderTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainOsNvRam" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nvRamInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRam\"}]}}", isOptional: true)]
        public virtual object? NvRamInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shimInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShimInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainOsSmBios" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "smBiosInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsSmBios\"}]}}", isOptional: true)]
        public virtual object? SmBiosInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeArchInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeArchInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeMachineInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeMachineInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "cmdline", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cmdline
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dtb", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Dtb
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "firmware", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Firmware
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "init", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Init
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "initArgs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] InitArgs
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "initDir", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InitDir
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "initGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InitGroup
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "initrd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Initrd
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "initUser", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InitUser
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kernel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kernel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loader", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Loader
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loaderFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoaderFormat
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loaderReadonly", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoaderReadonly
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loaderSecure", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoaderSecure
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loaderStateless", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoaderStateless
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loaderType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoaderType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shim", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shim
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

        [JsiiProperty(name: "typeArch", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TypeArch
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "typeMachine", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TypeMachine
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainOs" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOs\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainOs cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainOs).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
