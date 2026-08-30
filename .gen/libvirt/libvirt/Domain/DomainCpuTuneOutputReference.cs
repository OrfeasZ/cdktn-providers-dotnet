using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainCpuTuneOutputReference), fullyQualifiedName: "libvirt.domain.DomainCpuTuneOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainCpuTuneOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainCpuTuneOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainCpuTuneOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainCpuTuneOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneCacheTune" />)[]</param>
        [JsiiMethod(name: "putCacheTune", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneCacheTune\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCacheTune(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainCpuTuneCacheTune[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuTuneCacheTune).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuTuneCacheTune).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmulatorPin", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainCpuTuneEmulatorPin\"}}]")]
        public virtual void PutEmulatorPin(libvirt.Domain.IDomainCpuTuneEmulatorPin @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainCpuTuneEmulatorPin)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmulatorSched", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainCpuTuneEmulatorSched\"}}]")]
        public virtual void PutEmulatorSched(libvirt.Domain.IDomainCpuTuneEmulatorSched @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainCpuTuneEmulatorSched)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneEnergyTune" />)[]</param>
        [JsiiMethod(name: "putEnergyTune", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneEnergyTune\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEnergyTune(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainCpuTuneEnergyTune[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuTuneEnergyTune).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuTuneEnergyTune).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneIoThreadPin" />)[]</param>
        [JsiiMethod(name: "putIoThreadPin", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneIoThreadPin\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIoThreadPin(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainCpuTuneIoThreadPin[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuTuneIoThreadPin).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuTuneIoThreadPin).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneIoThreadSched" />)[]</param>
        [JsiiMethod(name: "putIoThreadSched", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneIoThreadSched\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIoThreadSched(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainCpuTuneIoThreadSched[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuTuneIoThreadSched).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuTuneIoThreadSched).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneMemoryTune" />)[]</param>
        [JsiiMethod(name: "putMemoryTune", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneMemoryTune\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMemoryTune(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainCpuTuneMemoryTune[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuTuneMemoryTune).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuTuneMemoryTune).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneVcpuPin" />)[]</param>
        [JsiiMethod(name: "putVcpuPin", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneVcpuPin\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutVcpuPin(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainCpuTuneVcpuPin[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuTuneVcpuPin).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuTuneVcpuPin).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneVcpuSched" />)[]</param>
        [JsiiMethod(name: "putVcpuSched", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneVcpuSched\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutVcpuSched(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainCpuTuneVcpuSched[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuTuneVcpuSched).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuTuneVcpuSched).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCacheTune")]
        public virtual void ResetCacheTune()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmulatorPeriod")]
        public virtual void ResetEmulatorPeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmulatorPin")]
        public virtual void ResetEmulatorPin()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmulatorQuota")]
        public virtual void ResetEmulatorQuota()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmulatorSched")]
        public virtual void ResetEmulatorSched()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnergyTune")]
        public virtual void ResetEnergyTune()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGlobalPeriod")]
        public virtual void ResetGlobalPeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGlobalQuota")]
        public virtual void ResetGlobalQuota()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIoThreadPeriod")]
        public virtual void ResetIoThreadPeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIoThreadPin")]
        public virtual void ResetIoThreadPin()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIoThreadQuota")]
        public virtual void ResetIoThreadQuota()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIoThreadSched")]
        public virtual void ResetIoThreadSched()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemoryTune")]
        public virtual void ResetMemoryTune()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPeriod")]
        public virtual void ResetPeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQuota")]
        public virtual void ResetQuota()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShares")]
        public virtual void ResetShares()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVcpuPin")]
        public virtual void ResetVcpuPin()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVcpuSched")]
        public virtual void ResetVcpuSched()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cacheTune", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuTuneCacheTuneList\"}")]
        public virtual libvirt.Domain.DomainCpuTuneCacheTuneList CacheTune
        {
            get => GetInstanceProperty<libvirt.Domain.DomainCpuTuneCacheTuneList>()!;
        }

        [JsiiProperty(name: "emulatorPin", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuTuneEmulatorPinOutputReference\"}")]
        public virtual libvirt.Domain.DomainCpuTuneEmulatorPinOutputReference EmulatorPin
        {
            get => GetInstanceProperty<libvirt.Domain.DomainCpuTuneEmulatorPinOutputReference>()!;
        }

        [JsiiProperty(name: "emulatorSched", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuTuneEmulatorSchedOutputReference\"}")]
        public virtual libvirt.Domain.DomainCpuTuneEmulatorSchedOutputReference EmulatorSched
        {
            get => GetInstanceProperty<libvirt.Domain.DomainCpuTuneEmulatorSchedOutputReference>()!;
        }

        [JsiiProperty(name: "energyTune", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuTuneEnergyTuneList\"}")]
        public virtual libvirt.Domain.DomainCpuTuneEnergyTuneList EnergyTune
        {
            get => GetInstanceProperty<libvirt.Domain.DomainCpuTuneEnergyTuneList>()!;
        }

        [JsiiProperty(name: "ioThreadPin", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuTuneIoThreadPinList\"}")]
        public virtual libvirt.Domain.DomainCpuTuneIoThreadPinList IoThreadPin
        {
            get => GetInstanceProperty<libvirt.Domain.DomainCpuTuneIoThreadPinList>()!;
        }

        [JsiiProperty(name: "ioThreadSched", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuTuneIoThreadSchedList\"}")]
        public virtual libvirt.Domain.DomainCpuTuneIoThreadSchedList IoThreadSched
        {
            get => GetInstanceProperty<libvirt.Domain.DomainCpuTuneIoThreadSchedList>()!;
        }

        [JsiiProperty(name: "memoryTune", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuTuneMemoryTuneList\"}")]
        public virtual libvirt.Domain.DomainCpuTuneMemoryTuneList MemoryTune
        {
            get => GetInstanceProperty<libvirt.Domain.DomainCpuTuneMemoryTuneList>()!;
        }

        [JsiiProperty(name: "vcpuPin", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuTuneVcpuPinList\"}")]
        public virtual libvirt.Domain.DomainCpuTuneVcpuPinList VcpuPin
        {
            get => GetInstanceProperty<libvirt.Domain.DomainCpuTuneVcpuPinList>()!;
        }

        [JsiiProperty(name: "vcpuSched", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuTuneVcpuSchedList\"}")]
        public virtual libvirt.Domain.DomainCpuTuneVcpuSchedList VcpuSched
        {
            get => GetInstanceProperty<libvirt.Domain.DomainCpuTuneVcpuSchedList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneCacheTune" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cacheTuneInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneCacheTune\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CacheTuneInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emulatorPeriodInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? EmulatorPeriodInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainCpuTuneEmulatorPin" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "emulatorPinInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainCpuTuneEmulatorPin\"}]}}", isOptional: true)]
        public virtual object? EmulatorPinInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emulatorQuotaInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? EmulatorQuotaInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainCpuTuneEmulatorSched" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "emulatorSchedInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainCpuTuneEmulatorSched\"}]}}", isOptional: true)]
        public virtual object? EmulatorSchedInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneEnergyTune" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "energyTuneInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneEnergyTune\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EnergyTuneInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "globalPeriodInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? GlobalPeriodInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "globalQuotaInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? GlobalQuotaInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ioThreadPeriodInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IoThreadPeriodInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneIoThreadPin" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ioThreadPinInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneIoThreadPin\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IoThreadPinInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ioThreadQuotaInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IoThreadQuotaInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneIoThreadSched" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ioThreadSchedInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneIoThreadSched\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IoThreadSchedInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneMemoryTune" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memoryTuneInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneMemoryTune\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MemoryTuneInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "periodInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PeriodInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "quotaInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? QuotaInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sharesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SharesInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneVcpuPin" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vcpuPinInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneVcpuPin\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? VcpuPinInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuTuneVcpuSched" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vcpuSchedInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneVcpuSched\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? VcpuSchedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "emulatorPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EmulatorPeriod
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emulatorQuota", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EmulatorQuota
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "globalPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GlobalPeriod
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "globalQuota", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GlobalQuota
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ioThreadPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IoThreadPeriod
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ioThreadQuota", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IoThreadQuota
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Period
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "quota", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Quota
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shares", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Shares
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainCpuTune" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainCpuTune\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainCpuTune cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuTune).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
