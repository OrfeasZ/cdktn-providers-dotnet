using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesInterfacesSourceOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesInterfacesSourceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesInterfacesSourceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesInterfacesSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesInterfacesSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBridge", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceBridge\"}}]")]
        public virtual void PutBridge(libvirt.Domain.IDomainDevicesInterfacesSourceBridge @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesSourceBridge)}, new object[]{@value});
        }

        [JsiiMethod(name: "putClient", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceClient\"}}]")]
        public virtual void PutClient(libvirt.Domain.IDomainDevicesInterfacesSourceClient @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesSourceClient)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDirect", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceDirect\"}}]")]
        public virtual void PutDirect(libvirt.Domain.IDomainDevicesInterfacesSourceDirect @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesSourceDirect)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEthernet", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceEthernet\"}}]")]
        public virtual void PutEthernet(libvirt.Domain.IDomainDevicesInterfacesSourceEthernet @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesSourceEthernet)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHostdev", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdev\"}}]")]
        public virtual void PutHostdev(libvirt.Domain.IDomainDevicesInterfacesSourceHostdev @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesSourceHostdev)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInternal", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceInternal\"}}]")]
        public virtual void PutInternal(libvirt.Domain.IDomainDevicesInterfacesSourceInternal @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesSourceInternal)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMcast", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceMcast\"}}]")]
        public virtual void PutMcast(libvirt.Domain.IDomainDevicesInterfacesSourceMcast @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesSourceMcast)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetwork", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceNetwork\"}}]")]
        public virtual void PutNetwork(libvirt.Domain.IDomainDevicesInterfacesSourceNetwork @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesSourceNetwork)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceServer\"}}]")]
        public virtual void PutServer(libvirt.Domain.IDomainDevicesInterfacesSourceServer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesSourceServer)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUdp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceUdp\"}}]")]
        public virtual void PutUdp(libvirt.Domain.IDomainDevicesInterfacesSourceUdp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesSourceUdp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUser", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceUser\"}}]")]
        public virtual void PutUser(libvirt.Domain.IDomainDevicesInterfacesSourceUser @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesSourceUser)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVdpa", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceVdpa\"}}]")]
        public virtual void PutVdpa(libvirt.Domain.IDomainDevicesInterfacesSourceVdpa @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesSourceVdpa)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVds", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceVds\"}}]")]
        public virtual void PutVds(libvirt.Domain.IDomainDevicesInterfacesSourceVds @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesSourceVds)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVhostUser", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceVhostUser\"}}]")]
        public virtual void PutVhostUser(libvirt.Domain.IDomainDevicesInterfacesSourceVhostUser @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesSourceVhostUser)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBridge")]
        public virtual void ResetBridge()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClient")]
        public virtual void ResetClient()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDirect")]
        public virtual void ResetDirect()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEthernet")]
        public virtual void ResetEthernet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostdev")]
        public virtual void ResetHostdev()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInternal")]
        public virtual void ResetInternal()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMcast")]
        public virtual void ResetMcast()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetwork")]
        public virtual void ResetNetwork()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNull")]
        public virtual void ResetNull()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServer")]
        public virtual void ResetServer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUdp")]
        public virtual void ResetUdp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUser")]
        public virtual void ResetUser()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVdpa")]
        public virtual void ResetVdpa()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVds")]
        public virtual void ResetVds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVhostUser")]
        public virtual void ResetVhostUser()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "bridge", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceBridgeOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesSourceBridgeOutputReference Bridge
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesSourceBridgeOutputReference>()!;
        }

        [JsiiProperty(name: "client", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceClientOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesSourceClientOutputReference Client
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesSourceClientOutputReference>()!;
        }

        [JsiiProperty(name: "direct", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceDirectOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesSourceDirectOutputReference Direct
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesSourceDirectOutputReference>()!;
        }

        [JsiiProperty(name: "ethernet", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceEthernetOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesSourceEthernetOutputReference Ethernet
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesSourceEthernetOutputReference>()!;
        }

        [JsiiProperty(name: "hostdev", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdevOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesSourceHostdevOutputReference Hostdev
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesSourceHostdevOutputReference>()!;
        }

        [JsiiProperty(name: "internal", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceInternalOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesSourceInternalOutputReference Internal
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesSourceInternalOutputReference>()!;
        }

        [JsiiProperty(name: "mcast", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceMcastOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesSourceMcastOutputReference Mcast
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesSourceMcastOutputReference>()!;
        }

        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceNetworkOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesSourceNetworkOutputReference Network
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesSourceNetworkOutputReference>()!;
        }

        [JsiiProperty(name: "server", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceServerOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesSourceServerOutputReference Server
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesSourceServerOutputReference>()!;
        }

        [JsiiProperty(name: "udp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceUdpOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesSourceUdpOutputReference Udp
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesSourceUdpOutputReference>()!;
        }

        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceUserOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesSourceUserOutputReference User
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesSourceUserOutputReference>()!;
        }

        [JsiiProperty(name: "vdpa", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceVdpaOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesSourceVdpaOutputReference Vdpa
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesSourceVdpaOutputReference>()!;
        }

        [JsiiProperty(name: "vds", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceVdsOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesSourceVdsOutputReference Vds
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesSourceVdsOutputReference>()!;
        }

        [JsiiProperty(name: "vhostUser", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceVhostUserOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesSourceVhostUserOutputReference VhostUser
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesSourceVhostUserOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesSourceBridge" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bridgeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceBridge\"}]}}", isOptional: true)]
        public virtual object? BridgeInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesSourceClient" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceClient\"}]}}", isOptional: true)]
        public virtual object? ClientInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesSourceDirect" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "directInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceDirect\"}]}}", isOptional: true)]
        public virtual object? DirectInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesSourceEthernet" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ethernetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceEthernet\"}]}}", isOptional: true)]
        public virtual object? EthernetInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesSourceHostdev" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostdevInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceHostdev\"}]}}", isOptional: true)]
        public virtual object? HostdevInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesSourceInternal" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceInternal\"}]}}", isOptional: true)]
        public virtual object? InternalInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesSourceMcast" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mcastInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceMcast\"}]}}", isOptional: true)]
        public virtual object? McastInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesSourceNetwork" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceNetwork\"}]}}", isOptional: true)]
        public virtual object? NetworkInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nullInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? NullInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesSourceServer" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serverInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceServer\"}]}}", isOptional: true)]
        public virtual object? ServerInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesSourceUdp" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "udpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceUdp\"}]}}", isOptional: true)]
        public virtual object? UdpInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesSourceUser" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceUser\"}]}}", isOptional: true)]
        public virtual object? UserInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesSourceVdpa" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vdpaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceVdpa\"}]}}", isOptional: true)]
        public virtual object? VdpaInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesSourceVds" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vdsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceVds\"}]}}", isOptional: true)]
        public virtual object? VdsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesSourceVhostUser" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vhostUserInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceVhostUser\"}]}}", isOptional: true)]
        public virtual object? VhostUserInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "null", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Null
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

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesSource" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSource\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesInterfacesSource cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesInterfacesSource).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
