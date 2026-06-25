using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesDisksSourceNetworkOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksSourceNetworkOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesDisksSourceNetworkOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesDisksSourceNetworkOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesDisksSourceNetworkOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesDisksSourceNetworkOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuth", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkAuth\"}}]")]
        public virtual void PutAuth(libvirt.Domain.IDomainDevicesDisksSourceNetworkAuth @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceNetworkAuth)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkConfig\"}}]")]
        public virtual void PutConfig(libvirt.Domain.IDomainDevicesDisksSourceNetworkConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceNetworkConfig)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksSourceNetworkHosts" />)[]</param>
        [JsiiMethod(name: "putHosts", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkHosts\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHosts(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainDevicesDisksSourceNetworkHosts[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksSourceNetworkHosts).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksSourceNetworkHosts).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkIdentity\"}}]")]
        public virtual void PutIdentity(libvirt.Domain.IDomainDevicesDisksSourceNetworkIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceNetworkIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInitiator", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkInitiator\"}}]")]
        public virtual void PutInitiator(libvirt.Domain.IDomainDevicesDisksSourceNetworkInitiator @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceNetworkInitiator)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKnownHosts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkKnownHosts\"}}]")]
        public virtual void PutKnownHosts(libvirt.Domain.IDomainDevicesDisksSourceNetworkKnownHosts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceNetworkKnownHosts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReconnect", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkReconnect\"}}]")]
        public virtual void PutReconnect(libvirt.Domain.IDomainDevicesDisksSourceNetworkReconnect @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceNetworkReconnect)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSnapshot", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkSnapshot\"}}]")]
        public virtual void PutSnapshot(libvirt.Domain.IDomainDevicesDisksSourceNetworkSnapshot @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceNetworkSnapshot)}, new object[]{@value});
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

        [JsiiProperty(name: "auth", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkAuthOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceNetworkAuthOutputReference Auth
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceNetworkAuthOutputReference>()!;
        }

        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkConfigOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceNetworkConfigOutputReference Config
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceNetworkConfigOutputReference>()!;
        }

        [JsiiProperty(name: "hosts", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkHostsList\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceNetworkHostsList Hosts
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceNetworkHostsList>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkIdentityOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceNetworkIdentityOutputReference Identity
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceNetworkIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "initiator", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkInitiatorOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceNetworkInitiatorOutputReference Initiator
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceNetworkInitiatorOutputReference>()!;
        }

        [JsiiProperty(name: "knownHosts", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkKnownHostsOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceNetworkKnownHostsOutputReference KnownHosts
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceNetworkKnownHostsOutputReference>()!;
        }

        [JsiiProperty(name: "reconnect", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkReconnectOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceNetworkReconnectOutputReference Reconnect
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceNetworkReconnectOutputReference>()!;
        }

        [JsiiProperty(name: "snapshot", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkSnapshotOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceNetworkSnapshotOutputReference Snapshot
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceNetworkSnapshotOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceNetworkAuth" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkAuth\"}]}}", isOptional: true)]
        public virtual object? AuthInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceNetworkConfig" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkConfig\"}]}}", isOptional: true)]
        public virtual object? ConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksSourceNetworkHosts" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkHosts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HostsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceNetworkIdentity" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkIdentity\"}]}}", isOptional: true)]
        public virtual object? IdentityInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceNetworkInitiator" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "initiatorInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkInitiator\"}]}}", isOptional: true)]
        public virtual object? InitiatorInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceNetworkKnownHosts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "knownHostsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkKnownHosts\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceNetworkReconnect" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reconnectInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkReconnect\"}]}}", isOptional: true)]
        public virtual object? ReconnectInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceNetworkSnapshot" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkSnapshot\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceNetwork" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetwork\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesDisksSourceNetwork cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksSourceNetwork).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
