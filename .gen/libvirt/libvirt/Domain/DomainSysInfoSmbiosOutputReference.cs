using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainSysInfoSmbiosOutputReference), fullyQualifiedName: "libvirt.domain.DomainSysInfoSmbiosOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainSysInfoSmbiosOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainSysInfoSmbiosOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainSysInfoSmbiosOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainSysInfoSmbiosOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBaseBoard", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosBaseBoard\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutBaseBoard(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainSysInfoSmbiosBaseBoard[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainSysInfoSmbiosBaseBoard).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainSysInfoSmbiosBaseBoard).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBios", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosBios\"}}]")]
        public virtual void PutBios(libvirt.Domain.IDomainSysInfoSmbiosBios @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainSysInfoSmbiosBios)}, new object[]{@value});
        }

        [JsiiMethod(name: "putChassis", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosChassis\"}}]")]
        public virtual void PutChassis(libvirt.Domain.IDomainSysInfoSmbiosChassis @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainSysInfoSmbiosChassis)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMemory", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosMemory\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMemory(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainSysInfoSmbiosMemory[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainSysInfoSmbiosMemory).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainSysInfoSmbiosMemory).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOemStrings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosOemStrings\"}}]")]
        public virtual void PutOemStrings(libvirt.Domain.IDomainSysInfoSmbiosOemStrings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainSysInfoSmbiosOemStrings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProcessor", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosProcessor\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutProcessor(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainSysInfoSmbiosProcessor[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainSysInfoSmbiosProcessor).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainSysInfoSmbiosProcessor).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSystemAttribute", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosSystem\"}}]")]
        public virtual void PutSystemAttribute(libvirt.Domain.IDomainSysInfoSmbiosSystem @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainSysInfoSmbiosSystem)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBaseBoard")]
        public virtual void ResetBaseBoard()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBios")]
        public virtual void ResetBios()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetChassis")]
        public virtual void ResetChassis()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemory")]
        public virtual void ResetMemory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOemStrings")]
        public virtual void ResetOemStrings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProcessor")]
        public virtual void ResetProcessor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSystemAttribute")]
        public virtual void ResetSystemAttribute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "baseBoard", typeJson: "{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosBaseBoardList\"}")]
        public virtual libvirt.Domain.DomainSysInfoSmbiosBaseBoardList BaseBoard
        {
            get => GetInstanceProperty<libvirt.Domain.DomainSysInfoSmbiosBaseBoardList>()!;
        }

        [JsiiProperty(name: "bios", typeJson: "{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosBiosOutputReference\"}")]
        public virtual libvirt.Domain.DomainSysInfoSmbiosBiosOutputReference Bios
        {
            get => GetInstanceProperty<libvirt.Domain.DomainSysInfoSmbiosBiosOutputReference>()!;
        }

        [JsiiProperty(name: "chassis", typeJson: "{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosChassisOutputReference\"}")]
        public virtual libvirt.Domain.DomainSysInfoSmbiosChassisOutputReference Chassis
        {
            get => GetInstanceProperty<libvirt.Domain.DomainSysInfoSmbiosChassisOutputReference>()!;
        }

        [JsiiProperty(name: "memory", typeJson: "{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosMemoryList\"}")]
        public virtual libvirt.Domain.DomainSysInfoSmbiosMemoryList Memory
        {
            get => GetInstanceProperty<libvirt.Domain.DomainSysInfoSmbiosMemoryList>()!;
        }

        [JsiiProperty(name: "oemStrings", typeJson: "{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosOemStringsOutputReference\"}")]
        public virtual libvirt.Domain.DomainSysInfoSmbiosOemStringsOutputReference OemStrings
        {
            get => GetInstanceProperty<libvirt.Domain.DomainSysInfoSmbiosOemStringsOutputReference>()!;
        }

        [JsiiProperty(name: "processor", typeJson: "{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosProcessorList\"}")]
        public virtual libvirt.Domain.DomainSysInfoSmbiosProcessorList Processor
        {
            get => GetInstanceProperty<libvirt.Domain.DomainSysInfoSmbiosProcessorList>()!;
        }

        [JsiiProperty(name: "systemAttribute", typeJson: "{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosSystemOutputReference\"}")]
        public virtual libvirt.Domain.DomainSysInfoSmbiosSystemOutputReference SystemAttribute
        {
            get => GetInstanceProperty<libvirt.Domain.DomainSysInfoSmbiosSystemOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "baseBoardInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosBaseBoard\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? BaseBoardInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "biosInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosBios\"}]}}", isOptional: true)]
        public virtual object? BiosInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "chassisInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosChassis\"}]}}", isOptional: true)]
        public virtual object? ChassisInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosMemory\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MemoryInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oemStringsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosOemStrings\"}]}}", isOptional: true)]
        public virtual object? OemStringsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "processorInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosProcessor\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ProcessorInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "systemAttributeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosSystem\"}]}}", isOptional: true)]
        public virtual object? SystemAttributeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainSysInfoSmbios\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainSysInfoSmbios cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainSysInfoSmbios).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
