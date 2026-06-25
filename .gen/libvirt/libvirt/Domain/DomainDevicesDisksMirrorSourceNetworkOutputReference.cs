using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesDisksMirrorSourceNetworkOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorSourceNetworkOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesDisksMirrorSourceNetworkOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesDisksMirrorSourceNetworkOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesDisksMirrorSourceNetworkOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesDisksMirrorSourceNetworkOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuth", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkAuth\"}}]")]
        public virtual void PutAuth(libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkAuth @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkAuth)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkConfig\"}}]")]
        public virtual void PutConfig(libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkConfig)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkHosts" />)[]</param>
        [JsiiMethod(name: "putHosts", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkHosts\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHosts(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkHosts[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkHosts).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkHosts).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkIdentity\"}}]")]
        public virtual void PutIdentity(libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInitiator", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkInitiator\"}}]")]
        public virtual void PutInitiator(libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkInitiator @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkInitiator)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKnownHosts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkKnownHosts\"}}]")]
        public virtual void PutKnownHosts(libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkKnownHosts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkKnownHosts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReconnect", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkReconnect\"}}]")]
        public virtual void PutReconnect(libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkReconnect @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkReconnect)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSnapshot", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkSnapshot\"}}]")]
        public virtual void PutSnapshot(libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkSnapshot @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkSnapshot)}, new object[]{@value});
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

        [JsiiProperty(name: "auth", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkAuthOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceNetworkAuthOutputReference Auth
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceNetworkAuthOutputReference>()!;
        }

        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkConfigOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceNetworkConfigOutputReference Config
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceNetworkConfigOutputReference>()!;
        }

        [JsiiProperty(name: "hosts", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkHostsList\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceNetworkHostsList Hosts
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceNetworkHostsList>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkIdentityOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceNetworkIdentityOutputReference Identity
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceNetworkIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "initiator", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkInitiatorOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceNetworkInitiatorOutputReference Initiator
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceNetworkInitiatorOutputReference>()!;
        }

        [JsiiProperty(name: "knownHosts", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkKnownHostsOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceNetworkKnownHostsOutputReference KnownHosts
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceNetworkKnownHostsOutputReference>()!;
        }

        [JsiiProperty(name: "reconnect", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkReconnectOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceNetworkReconnectOutputReference Reconnect
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceNetworkReconnectOutputReference>()!;
        }

        [JsiiProperty(name: "snapshot", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkSnapshotOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceNetworkSnapshotOutputReference Snapshot
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceNetworkSnapshotOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkAuth" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkAuth\"}]}}", isOptional: true)]
        public virtual object? AuthInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkConfig" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkConfig\"}]}}", isOptional: true)]
        public virtual object? ConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkHosts" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkHosts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HostsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkIdentity" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkIdentity\"}]}}", isOptional: true)]
        public virtual object? IdentityInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkInitiator" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "initiatorInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkInitiator\"}]}}", isOptional: true)]
        public virtual object? InitiatorInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkKnownHosts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "knownHostsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkKnownHosts\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkReconnect" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reconnectInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkReconnect\"}]}}", isOptional: true)]
        public virtual object? ReconnectInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceNetworkSnapshot" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkSnapshot\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceNetwork" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetwork\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesDisksMirrorSourceNetwork cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceNetwork).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
