using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesDisksMirrorBackingStoreSourceNetworkOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesDisksMirrorBackingStoreSourceNetworkOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesDisksMirrorBackingStoreSourceNetworkOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesDisksMirrorBackingStoreSourceNetworkOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuth", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkAuth\"}}]")]
        public virtual void PutAuth(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkAuth @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkAuth)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkConfig\"}}]")]
        public virtual void PutConfig(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkConfig)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkHosts" />)[]</param>
        [JsiiMethod(name: "putHosts", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkHosts\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHosts(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkHosts[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkHosts).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkHosts).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkIdentity\"}}]")]
        public virtual void PutIdentity(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInitiator", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkInitiator\"}}]")]
        public virtual void PutInitiator(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkInitiator @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkInitiator)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKnownHosts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkKnownHosts\"}}]")]
        public virtual void PutKnownHosts(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkKnownHosts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkKnownHosts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReconnect", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkReconnect\"}}]")]
        public virtual void PutReconnect(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkReconnect @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkReconnect)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSnapshot", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkSnapshot\"}}]")]
        public virtual void PutSnapshot(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkSnapshot @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkSnapshot)}, new object[]{@value});
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

        [JsiiProperty(name: "auth", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkAuthOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkAuthOutputReference Auth
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkAuthOutputReference>()!;
        }

        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkConfigOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkConfigOutputReference Config
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkConfigOutputReference>()!;
        }

        [JsiiProperty(name: "hosts", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkHostsList\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkHostsList Hosts
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkHostsList>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkIdentityOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkIdentityOutputReference Identity
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "initiator", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkInitiatorOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkInitiatorOutputReference Initiator
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkInitiatorOutputReference>()!;
        }

        [JsiiProperty(name: "knownHosts", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkKnownHostsOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkKnownHostsOutputReference KnownHosts
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkKnownHostsOutputReference>()!;
        }

        [JsiiProperty(name: "reconnect", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkReconnectOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkReconnectOutputReference Reconnect
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkReconnectOutputReference>()!;
        }

        [JsiiProperty(name: "snapshot", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkSnapshotOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkSnapshotOutputReference Snapshot
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkSnapshotOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkAuth" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkAuth\"}]}}", isOptional: true)]
        public virtual object? AuthInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkConfig" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkConfig\"}]}}", isOptional: true)]
        public virtual object? ConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkHosts" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkHosts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HostsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkIdentity" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkIdentity\"}]}}", isOptional: true)]
        public virtual object? IdentityInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkInitiator" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "initiatorInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkInitiator\"}]}}", isOptional: true)]
        public virtual object? InitiatorInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkKnownHosts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "knownHostsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkKnownHosts\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkReconnect" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reconnectInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkReconnect\"}]}}", isOptional: true)]
        public virtual object? ReconnectInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetworkSnapshot" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkSnapshot\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetwork" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetwork\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetwork cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetwork).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
