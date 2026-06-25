using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainCpuOutputReference), fullyQualifiedName: "libvirt.domain.DomainCpuOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainCpuOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainCpuOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainCpuOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainCpuOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCache", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainCpuCache\"}}]")]
        public virtual void PutCache(libvirt.Domain.IDomainCpuCache @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainCpuCache)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuFeatures" />)[]</param>
        [JsiiMethod(name: "putFeatures", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuFeatures\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFeatures(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainCpuFeatures[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuFeatures).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuFeatures).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMaxPhysAddr", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainCpuMaxPhysAddr\"}}]")]
        public virtual void PutMaxPhysAddr(libvirt.Domain.IDomainCpuMaxPhysAddr @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainCpuMaxPhysAddr)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNuma", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainCpuNuma\"}}]")]
        public virtual void PutNuma(libvirt.Domain.IDomainCpuNuma @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainCpuNuma)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTopology", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainCpuTopology\"}}]")]
        public virtual void PutTopology(libvirt.Domain.IDomainCpuTopology @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainCpuTopology)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCache")]
        public virtual void ResetCache()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCheck")]
        public virtual void ResetCheck()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeprecatedFeatures")]
        public virtual void ResetDeprecatedFeatures()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFeatures")]
        public virtual void ResetFeatures()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMatch")]
        public virtual void ResetMatch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxPhysAddr")]
        public virtual void ResetMaxPhysAddr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMigratable")]
        public virtual void ResetMigratable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMode")]
        public virtual void ResetMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModel")]
        public virtual void ResetModel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModelFallback")]
        public virtual void ResetModelFallback()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModelVendorId")]
        public virtual void ResetModelVendorId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNuma")]
        public virtual void ResetNuma()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTopology")]
        public virtual void ResetTopology()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVendor")]
        public virtual void ResetVendor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cache", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuCacheOutputReference\"}")]
        public virtual libvirt.Domain.DomainCpuCacheOutputReference Cache
        {
            get => GetInstanceProperty<libvirt.Domain.DomainCpuCacheOutputReference>()!;
        }

        [JsiiProperty(name: "features", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuFeaturesList\"}")]
        public virtual libvirt.Domain.DomainCpuFeaturesList Features
        {
            get => GetInstanceProperty<libvirt.Domain.DomainCpuFeaturesList>()!;
        }

        [JsiiProperty(name: "maxPhysAddr", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuMaxPhysAddrOutputReference\"}")]
        public virtual libvirt.Domain.DomainCpuMaxPhysAddrOutputReference MaxPhysAddr
        {
            get => GetInstanceProperty<libvirt.Domain.DomainCpuMaxPhysAddrOutputReference>()!;
        }

        [JsiiProperty(name: "numa", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuNumaOutputReference\"}")]
        public virtual libvirt.Domain.DomainCpuNumaOutputReference Numa
        {
            get => GetInstanceProperty<libvirt.Domain.DomainCpuNumaOutputReference>()!;
        }

        [JsiiProperty(name: "topology", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuTopologyOutputReference\"}")]
        public virtual libvirt.Domain.DomainCpuTopologyOutputReference Topology
        {
            get => GetInstanceProperty<libvirt.Domain.DomainCpuTopologyOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainCpuCache" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cacheInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainCpuCache\"}]}}", isOptional: true)]
        public virtual object? CacheInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "checkInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CheckInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deprecatedFeaturesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeprecatedFeaturesInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuFeatures" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "featuresInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuFeatures\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FeaturesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MatchInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainCpuMaxPhysAddr" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxPhysAddrInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainCpuMaxPhysAddr\"}]}}", isOptional: true)]
        public virtual object? MaxPhysAddrInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "migratableInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? MigratableInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelFallbackInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelFallbackInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelVendorIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelVendorIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainCpuNuma" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "numaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainCpuNuma\"}]}}", isOptional: true)]
        public virtual object? NumaInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainCpuTopology" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "topologyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainCpuTopology\"}]}}", isOptional: true)]
        public virtual object? TopologyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vendorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VendorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "check", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Check
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deprecatedFeatures", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeprecatedFeatures
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "match", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Match
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "migratable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Migratable
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

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Model
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelFallback", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelFallback
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelVendorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelVendorId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vendor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Vendor
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainCpu" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainCpu\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainCpu cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpu).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
