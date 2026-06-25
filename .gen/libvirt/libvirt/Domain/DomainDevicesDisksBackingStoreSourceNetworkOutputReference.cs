using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesDisksBackingStoreSourceNetworkOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesDisksBackingStoreSourceNetworkOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesDisksBackingStoreSourceNetworkOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesDisksBackingStoreSourceNetworkOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesDisksBackingStoreSourceNetworkOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuth", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkAuth\"}}]")]
        public virtual void PutAuth(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkAuth @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkAuth)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkConfig\"}}]")]
        public virtual void PutConfig(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkConfig)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkHosts" />)[]</param>
        [JsiiMethod(name: "putHosts", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkHosts\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHosts(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkHosts[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkHosts).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkHosts).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkIdentity\"}}]")]
        public virtual void PutIdentity(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInitiator", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkInitiator\"}}]")]
        public virtual void PutInitiator(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkInitiator @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkInitiator)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKnownHosts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkKnownHosts\"}}]")]
        public virtual void PutKnownHosts(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkKnownHosts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkKnownHosts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReconnect", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkReconnect\"}}]")]
        public virtual void PutReconnect(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkReconnect @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkReconnect)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSnapshot", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkSnapshot\"}}]")]
        public virtual void PutSnapshot(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkSnapshot @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkSnapshot)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuth")]
        public virtual void ResetAuth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfig")]
        public virtual void ResetConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHosts")]
        public virtual void ResetHosts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentity")]
        public virtual void ResetIdentity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitiator")]
        public virtual void ResetInitiator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKnownHosts")]
        public virtual void ResetKnownHosts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtocol")]
        public virtual void ResetProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQuery")]
        public virtual void ResetQuery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReconnect")]
        public virtual void ResetReconnect()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapshot")]
        public virtual void ResetSnapshot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTls")]
        public virtual void ResetTls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTlsHostname")]
        public virtual void ResetTlsHostname()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "auth", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkAuthOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksBackingStoreSourceNetworkAuthOutputReference Auth
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksBackingStoreSourceNetworkAuthOutputReference>()!;
        }

        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkConfigOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksBackingStoreSourceNetworkConfigOutputReference Config
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksBackingStoreSourceNetworkConfigOutputReference>()!;
        }

        [JsiiProperty(name: "hosts", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkHostsList\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksBackingStoreSourceNetworkHostsList Hosts
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksBackingStoreSourceNetworkHostsList>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkIdentityOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksBackingStoreSourceNetworkIdentityOutputReference Identity
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksBackingStoreSourceNetworkIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "initiator", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkInitiatorOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksBackingStoreSourceNetworkInitiatorOutputReference Initiator
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksBackingStoreSourceNetworkInitiatorOutputReference>()!;
        }

        [JsiiProperty(name: "knownHosts", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkKnownHostsOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksBackingStoreSourceNetworkKnownHostsOutputReference KnownHosts
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksBackingStoreSourceNetworkKnownHostsOutputReference>()!;
        }

        [JsiiProperty(name: "reconnect", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkReconnectOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksBackingStoreSourceNetworkReconnectOutputReference Reconnect
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksBackingStoreSourceNetworkReconnectOutputReference>()!;
        }

        [JsiiProperty(name: "snapshot", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkSnapshotOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksBackingStoreSourceNetworkSnapshotOutputReference Snapshot
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksBackingStoreSourceNetworkSnapshotOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkAuth" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkAuth\"}]}}", isOptional: true)]
        public virtual object? AuthInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkConfig" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkConfig\"}]}}", isOptional: true)]
        public virtual object? ConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkHosts" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkHosts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HostsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkIdentity" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkIdentity\"}]}}", isOptional: true)]
        public virtual object? IdentityInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkInitiator" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "initiatorInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkInitiator\"}]}}", isOptional: true)]
        public virtual object? InitiatorInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkKnownHosts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "knownHostsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkKnownHosts\"}]}}", isOptional: true)]
        public virtual object? KnownHostsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QueryInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkReconnect" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reconnectInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkReconnect\"}]}}", isOptional: true)]
        public virtual object? ReconnectInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetworkSnapshot" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetworkSnapshot\"}]}}", isOptional: true)]
        public virtual object? SnapshotInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsHostnameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TlsHostnameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TlsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Query
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tls", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tls
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tlsHostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TlsHostname
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetwork" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceNetwork\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetwork cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksBackingStoreSourceNetwork).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
