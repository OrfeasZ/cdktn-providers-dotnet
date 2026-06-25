using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesFilesystemsOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DomainDevicesFilesystemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DomainDevicesFilesystemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DomainDevicesFilesystemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesFilesystemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAcpi", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsAcpi\"}}]")]
        public virtual void PutAcpi(libvirt.Domain.IDomainDevicesFilesystemsAcpi @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesFilesystemsAcpi)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsAddress\"}}]")]
        public virtual void PutAddress(libvirt.Domain.IDomainDevicesFilesystemsAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesFilesystemsAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAlias", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsAlias\"}}]")]
        public virtual void PutAlias(libvirt.Domain.IDomainDevicesFilesystemsAlias @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesFilesystemsAlias)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBinary", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinary\"}}]")]
        public virtual void PutBinary(libvirt.Domain.IDomainDevicesFilesystemsBinary @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesFilesystemsBinary)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBoot", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBoot\"}}]")]
        public virtual void PutBoot(libvirt.Domain.IDomainDevicesFilesystemsBoot @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesFilesystemsBoot)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDriver", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsDriver\"}}]")]
        public virtual void PutDriver(libvirt.Domain.IDomainDevicesFilesystemsDriver @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesFilesystemsDriver)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdMap", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsIdMap\"}}]")]
        public virtual void PutIdMap(libvirt.Domain.IDomainDevicesFilesystemsIdMap @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesFilesystemsIdMap)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSource\"}}]")]
        public virtual void PutSource(libvirt.Domain.IDomainDevicesFilesystemsSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesFilesystemsSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsTarget\"}}]")]
        public virtual void PutTarget(libvirt.Domain.IDomainDevicesFilesystemsTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesFilesystemsTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessMode")]
        public virtual void ResetAccessMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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

        [JsiiMethod(name: "resetBinary")]
        public virtual void ResetBinary()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBoot")]
        public virtual void ResetBoot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDmode")]
        public virtual void ResetDmode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDriver")]
        public virtual void ResetDriver()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFmode")]
        public virtual void ResetFmode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdMap")]
        public virtual void ResetIdMap()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModel")]
        public virtual void ResetModel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMultiDevs")]
        public virtual void ResetMultiDevs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReadOnly")]
        public virtual void ResetReadOnly()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSource")]
        public virtual void ResetSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpaceHardLimit")]
        public virtual void ResetSpaceHardLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpaceHardLimitUnit")]
        public virtual void ResetSpaceHardLimitUnit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpaceSoftLimit")]
        public virtual void ResetSpaceSoftLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpaceSoftLimitUnit")]
        public virtual void ResetSpaceSoftLimitUnit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTarget")]
        public virtual void ResetTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsAcpiOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesFilesystemsAcpiOutputReference Acpi
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesFilesystemsAcpiOutputReference>()!;
        }

        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsAddressOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesFilesystemsAddressOutputReference Address
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesFilesystemsAddressOutputReference>()!;
        }

        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsAliasOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesFilesystemsAliasOutputReference Alias
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesFilesystemsAliasOutputReference>()!;
        }

        [JsiiProperty(name: "binary", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinaryOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesFilesystemsBinaryOutputReference Binary
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesFilesystemsBinaryOutputReference>()!;
        }

        [JsiiProperty(name: "boot", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBootOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesFilesystemsBootOutputReference Boot
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesFilesystemsBootOutputReference>()!;
        }

        [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsDriverOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesFilesystemsDriverOutputReference Driver
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesFilesystemsDriverOutputReference>()!;
        }

        [JsiiProperty(name: "idMap", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsIdMapOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesFilesystemsIdMapOutputReference IdMap
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesFilesystemsIdMapOutputReference>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesFilesystemsSourceOutputReference Source
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesFilesystemsSourceOutputReference>()!;
        }

        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsTargetOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesFilesystemsTargetOutputReference Target
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesFilesystemsTargetOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccessModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesFilesystemsAcpi" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acpiInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsAcpi\"}]}}", isOptional: true)]
        public virtual object? AcpiInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesFilesystemsAddress" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addressInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsAddress\"}]}}", isOptional: true)]
        public virtual object? AddressInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesFilesystemsAlias" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "aliasInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsAlias\"}]}}", isOptional: true)]
        public virtual object? AliasInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesFilesystemsBinary" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "binaryInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinary\"}]}}", isOptional: true)]
        public virtual object? BinaryInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesFilesystemsBoot" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bootInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBoot\"}]}}", isOptional: true)]
        public virtual object? BootInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dmodeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DmodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesFilesystemsDriver" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "driverInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsDriver\"}]}}", isOptional: true)]
        public virtual object? DriverInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fmodeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FmodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesFilesystemsIdMap" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idMapInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsIdMap\"}]}}", isOptional: true)]
        public virtual object? IdMapInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "multiDevsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MultiDevsInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readOnlyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ReadOnlyInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesFilesystemsSource" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSource\"}]}}", isOptional: true)]
        public virtual object? SourceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spaceHardLimitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SpaceHardLimitInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spaceHardLimitUnitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpaceHardLimitUnitInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spaceSoftLimitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SpaceSoftLimitInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spaceSoftLimitUnitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpaceSoftLimitUnitInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesFilesystemsTarget" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsTarget\"}]}}", isOptional: true)]
        public virtual object? TargetInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "accessMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dmode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Dmode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fmode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Fmode
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

        [JsiiProperty(name: "multiDevs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MultiDevs
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "readOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ReadOnly
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

        [JsiiProperty(name: "spaceHardLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SpaceHardLimit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "spaceHardLimitUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpaceHardLimitUnit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "spaceSoftLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SpaceSoftLimit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "spaceSoftLimitUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpaceSoftLimitUnit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesFilesystems" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesFilesystems\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesFilesystems cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesFilesystems).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
