using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiClass(nativeType: typeof(libvirt.Pool.PoolSourceOutputReference), fullyQualifiedName: "libvirt.pool.PoolSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PoolSourceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PoolSourceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PoolSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PoolSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAdapter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.pool.PoolSourceAdapter\"}}]")]
        public virtual void PutAdapter(libvirt.Pool.IPoolSourceAdapter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Pool.IPoolSourceAdapter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuth", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.pool.PoolSourceAuth\"}}]")]
        public virtual void PutAuth(libvirt.Pool.IPoolSourceAuth @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Pool.IPoolSourceAuth)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Pool.IPoolSourceDevice" />)[]</param>
        [JsiiMethod(name: "putDevice", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.pool.PoolSourceDevice\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDevice(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Pool.IPoolSourceDevice[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Pool.IPoolSourceDevice).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Pool.IPoolSourceDevice).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDir", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.pool.PoolSourceDir\"}}]")]
        public virtual void PutDir(libvirt.Pool.IPoolSourceDir @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Pool.IPoolSourceDir)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFormat", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.pool.PoolSourceFormat\"}}]")]
        public virtual void PutFormat(libvirt.Pool.IPoolSourceFormat @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Pool.IPoolSourceFormat)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Pool.IPoolSourceHost" />)[]</param>
        [JsiiMethod(name: "putHost", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.pool.PoolSourceHost\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHost(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Pool.IPoolSourceHost[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Pool.IPoolSourceHost).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Pool.IPoolSourceHost).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInitiator", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.pool.PoolSourceInitiator\"}}]")]
        public virtual void PutInitiator(libvirt.Pool.IPoolSourceInitiator @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Pool.IPoolSourceInitiator)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProduct", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.pool.PoolSourceProduct\"}}]")]
        public virtual void PutProduct(libvirt.Pool.IPoolSourceProduct @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Pool.IPoolSourceProduct)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProtocol", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.pool.PoolSourceProtocol\"}}]")]
        public virtual void PutProtocol(libvirt.Pool.IPoolSourceProtocol @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Pool.IPoolSourceProtocol)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVendor", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.pool.PoolSourceVendor\"}}]")]
        public virtual void PutVendor(libvirt.Pool.IPoolSourceVendor @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Pool.IPoolSourceVendor)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdapter")]
        public virtual void ResetAdapter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuth")]
        public virtual void ResetAuth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDevice")]
        public virtual void ResetDevice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDir")]
        public virtual void ResetDir()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFormat")]
        public virtual void ResetFormat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHost")]
        public virtual void ResetHost()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitiator")]
        public virtual void ResetInitiator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProduct")]
        public virtual void ResetProduct()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtocol")]
        public virtual void ResetProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVendor")]
        public virtual void ResetVendor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "adapter", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceAdapterOutputReference\"}")]
        public virtual libvirt.Pool.PoolSourceAdapterOutputReference Adapter
        {
            get => GetInstanceProperty<libvirt.Pool.PoolSourceAdapterOutputReference>()!;
        }

        [JsiiProperty(name: "auth", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceAuthOutputReference\"}")]
        public virtual libvirt.Pool.PoolSourceAuthOutputReference Auth
        {
            get => GetInstanceProperty<libvirt.Pool.PoolSourceAuthOutputReference>()!;
        }

        [JsiiProperty(name: "device", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceDeviceList\"}")]
        public virtual libvirt.Pool.PoolSourceDeviceList Device
        {
            get => GetInstanceProperty<libvirt.Pool.PoolSourceDeviceList>()!;
        }

        [JsiiProperty(name: "dir", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceDirOutputReference\"}")]
        public virtual libvirt.Pool.PoolSourceDirOutputReference Dir
        {
            get => GetInstanceProperty<libvirt.Pool.PoolSourceDirOutputReference>()!;
        }

        [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceFormatOutputReference\"}")]
        public virtual libvirt.Pool.PoolSourceFormatOutputReference Format
        {
            get => GetInstanceProperty<libvirt.Pool.PoolSourceFormatOutputReference>()!;
        }

        [JsiiProperty(name: "host", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceHostList\"}")]
        public virtual libvirt.Pool.PoolSourceHostList Host
        {
            get => GetInstanceProperty<libvirt.Pool.PoolSourceHostList>()!;
        }

        [JsiiProperty(name: "initiator", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceInitiatorOutputReference\"}")]
        public virtual libvirt.Pool.PoolSourceInitiatorOutputReference Initiator
        {
            get => GetInstanceProperty<libvirt.Pool.PoolSourceInitiatorOutputReference>()!;
        }

        [JsiiProperty(name: "product", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceProductOutputReference\"}")]
        public virtual libvirt.Pool.PoolSourceProductOutputReference Product
        {
            get => GetInstanceProperty<libvirt.Pool.PoolSourceProductOutputReference>()!;
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceProtocolOutputReference\"}")]
        public virtual libvirt.Pool.PoolSourceProtocolOutputReference Protocol
        {
            get => GetInstanceProperty<libvirt.Pool.PoolSourceProtocolOutputReference>()!;
        }

        [JsiiProperty(name: "vendor", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceVendorOutputReference\"}")]
        public virtual libvirt.Pool.PoolSourceVendorOutputReference Vendor
        {
            get => GetInstanceProperty<libvirt.Pool.PoolSourceVendorOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Pool.IPoolSourceAdapter" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "adapterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolSourceAdapter\"}]}}", isOptional: true)]
        public virtual object? AdapterInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Pool.IPoolSourceAuth" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolSourceAuth\"}]}}", isOptional: true)]
        public virtual object? AuthInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Pool.IPoolSourceDevice" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deviceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.pool.PoolSourceDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DeviceInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Pool.IPoolSourceDir" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dirInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolSourceDir\"}]}}", isOptional: true)]
        public virtual object? DirInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Pool.IPoolSourceFormat" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "formatInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolSourceFormat\"}]}}", isOptional: true)]
        public virtual object? FormatInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Pool.IPoolSourceHost" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.pool.PoolSourceHost\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HostInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Pool.IPoolSourceInitiator" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "initiatorInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolSourceInitiator\"}]}}", isOptional: true)]
        public virtual object? InitiatorInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Pool.IPoolSourceProduct" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "productInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolSourceProduct\"}]}}", isOptional: true)]
        public virtual object? ProductInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Pool.IPoolSourceProtocol" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "protocolInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolSourceProtocol\"}]}}", isOptional: true)]
        public virtual object? ProtocolInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Pool.IPoolSourceVendor" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vendorInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolSourceVendor\"}]}}", isOptional: true)]
        public virtual object? VendorInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Pool.IPoolSource" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolSource\"}]}}", isOptional: true)]
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
                        case libvirt.Pool.IPoolSource cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Pool.IPoolSource).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
