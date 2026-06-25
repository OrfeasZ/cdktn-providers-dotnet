using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainOsNvRamSourceVhostUserOutputReference), fullyQualifiedName: "libvirt.domain.DomainOsNvRamSourceVhostUserOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainOsNvRamSourceVhostUserOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainOsNvRamSourceVhostUserOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainOsNvRamSourceVhostUserOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainOsNvRamSourceVhostUserOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDbus", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserDbus\"}}]")]
        public virtual void PutDbus(libvirt.Domain.IDomainOsNvRamSourceVhostUserDbus @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceVhostUserDbus)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDev", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserDev\"}}]")]
        public virtual void PutDev(libvirt.Domain.IDomainOsNvRamSourceVhostUserDev @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceVhostUserDev)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserFile\"}}]")]
        public virtual void PutFile(libvirt.Domain.IDomainOsNvRamSourceVhostUserFile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceVhostUserFile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNmdm", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserNmdm\"}}]")]
        public virtual void PutNmdm(libvirt.Domain.IDomainOsNvRamSourceVhostUserNmdm @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceVhostUserNmdm)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPipe", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserPipe\"}}]")]
        public virtual void PutPipe(libvirt.Domain.IDomainOsNvRamSourceVhostUserPipe @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceVhostUserPipe)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPty", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserPty\"}}]")]
        public virtual void PutPty(libvirt.Domain.IDomainOsNvRamSourceVhostUserPty @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceVhostUserPty)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQemuVdAgent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserQemuVdAgent\"}}]")]
        public virtual void PutQemuVdAgent(libvirt.Domain.IDomainOsNvRamSourceVhostUserQemuVdAgent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceVhostUserQemuVdAgent)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSpicePort", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserSpicePort\"}}]")]
        public virtual void PutSpicePort(libvirt.Domain.IDomainOsNvRamSourceVhostUserSpicePort @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceVhostUserSpicePort)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTcp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserTcp\"}}]")]
        public virtual void PutTcp(libvirt.Domain.IDomainOsNvRamSourceVhostUserTcp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceVhostUserTcp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUdp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserUdp\"}}]")]
        public virtual void PutUdp(libvirt.Domain.IDomainOsNvRamSourceVhostUserUdp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceVhostUserUdp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUnix", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserUnix\"}}]")]
        public virtual void PutUnix(libvirt.Domain.IDomainOsNvRamSourceVhostUserUnix @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceVhostUserUnix)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDbus")]
        public virtual void ResetDbus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDev")]
        public virtual void ResetDev()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFile")]
        public virtual void ResetFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNmdm")]
        public virtual void ResetNmdm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNull")]
        public virtual void ResetNull()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPipe")]
        public virtual void ResetPipe()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPty")]
        public virtual void ResetPty()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQemuVdAgent")]
        public virtual void ResetQemuVdAgent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpicePort")]
        public virtual void ResetSpicePort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpiceVmc")]
        public virtual void ResetSpiceVmc()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStdIo")]
        public virtual void ResetStdIo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTcp")]
        public virtual void ResetTcp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUdp")]
        public virtual void ResetUdp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUnix")]
        public virtual void ResetUnix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVc")]
        public virtual void ResetVc()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dbus", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserDbusOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceVhostUserDbusOutputReference Dbus
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceVhostUserDbusOutputReference>()!;
        }

        [JsiiProperty(name: "dev", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserDevOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceVhostUserDevOutputReference Dev
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceVhostUserDevOutputReference>()!;
        }

        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserFileOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceVhostUserFileOutputReference File
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceVhostUserFileOutputReference>()!;
        }

        [JsiiProperty(name: "nmdm", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserNmdmOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceVhostUserNmdmOutputReference Nmdm
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceVhostUserNmdmOutputReference>()!;
        }

        [JsiiProperty(name: "pipe", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserPipeOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceVhostUserPipeOutputReference Pipe
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceVhostUserPipeOutputReference>()!;
        }

        [JsiiProperty(name: "pty", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserPtyOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceVhostUserPtyOutputReference Pty
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceVhostUserPtyOutputReference>()!;
        }

        [JsiiProperty(name: "qemuVdAgent", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserQemuVdAgentOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceVhostUserQemuVdAgentOutputReference QemuVdAgent
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceVhostUserQemuVdAgentOutputReference>()!;
        }

        [JsiiProperty(name: "spicePort", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserSpicePortOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceVhostUserSpicePortOutputReference SpicePort
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceVhostUserSpicePortOutputReference>()!;
        }

        [JsiiProperty(name: "tcp", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserTcpOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceVhostUserTcpOutputReference Tcp
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceVhostUserTcpOutputReference>()!;
        }

        [JsiiProperty(name: "udp", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserUdpOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceVhostUserUdpOutputReference Udp
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceVhostUserUdpOutputReference>()!;
        }

        [JsiiProperty(name: "unix", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserUnixOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceVhostUserUnixOutputReference Unix
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceVhostUserUnixOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainOsNvRamSourceVhostUserDbus" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbusInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserDbus\"}]}}", isOptional: true)]
        public virtual object? DbusInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainOsNvRamSourceVhostUserDev" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "devInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserDev\"}]}}", isOptional: true)]
        public virtual object? DevInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainOsNvRamSourceVhostUserFile" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserFile\"}]}}", isOptional: true)]
        public virtual object? FileInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainOsNvRamSourceVhostUserNmdm" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nmdmInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserNmdm\"}]}}", isOptional: true)]
        public virtual object? NmdmInput
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainOsNvRamSourceVhostUserPipe" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pipeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserPipe\"}]}}", isOptional: true)]
        public virtual object? PipeInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainOsNvRamSourceVhostUserPty" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ptyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserPty\"}]}}", isOptional: true)]
        public virtual object? PtyInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainOsNvRamSourceVhostUserQemuVdAgent" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "qemuVdAgentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserQemuVdAgent\"}]}}", isOptional: true)]
        public virtual object? QemuVdAgentInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainOsNvRamSourceVhostUserSpicePort" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spicePortInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserSpicePort\"}]}}", isOptional: true)]
        public virtual object? SpicePortInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spiceVmcInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SpiceVmcInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stdIoInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? StdIoInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainOsNvRamSourceVhostUserTcp" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tcpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserTcp\"}]}}", isOptional: true)]
        public virtual object? TcpInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainOsNvRamSourceVhostUserUdp" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "udpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserUdp\"}]}}", isOptional: true)]
        public virtual object? UdpInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainOsNvRamSourceVhostUserUnix" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "unixInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserUnix\"}]}}", isOptional: true)]
        public virtual object? UnixInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vcInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? VcInput
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
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "spiceVmc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object SpiceVmc
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
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "stdIo", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object StdIo
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
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "vc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Vc
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainOsNvRamSourceVhostUser" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUser\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainOsNvRamSourceVhostUser cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainOsNvRamSourceVhostUser).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
