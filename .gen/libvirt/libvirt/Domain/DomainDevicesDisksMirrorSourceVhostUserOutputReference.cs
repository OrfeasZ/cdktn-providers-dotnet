using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesDisksMirrorSourceVhostUserOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesDisksMirrorSourceVhostUserOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesDisksMirrorSourceVhostUserOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesDisksMirrorSourceVhostUserOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDbus", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserDbus\"}}]")]
        public virtual void PutDbus(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserDbus @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserDbus)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDev", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserDev\"}}]")]
        public virtual void PutDev(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserDev @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserDev)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserFile\"}}]")]
        public virtual void PutFile(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserFile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserFile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNmdm", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserNmdm\"}}]")]
        public virtual void PutNmdm(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserNmdm @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserNmdm)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPipe", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserPipe\"}}]")]
        public virtual void PutPipe(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserPipe @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserPipe)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPty", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserPty\"}}]")]
        public virtual void PutPty(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserPty @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserPty)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQemuVdAgent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserQemuVdAgent\"}}]")]
        public virtual void PutQemuVdAgent(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserQemuVdAgent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserQemuVdAgent)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSpicePort", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserSpicePort\"}}]")]
        public virtual void PutSpicePort(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserSpicePort @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserSpicePort)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTcp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserTcp\"}}]")]
        public virtual void PutTcp(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserTcp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserTcp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUdp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserUdp\"}}]")]
        public virtual void PutUdp(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserUdp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserUdp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUnix", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserUnix\"}}]")]
        public virtual void PutUnix(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserUnix @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserUnix)}, new object[]{@value});
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

        [JsiiProperty(name: "dbus", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserDbusOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserDbusOutputReference Dbus
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserDbusOutputReference>()!;
        }

        [JsiiProperty(name: "dev", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserDevOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserDevOutputReference Dev
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserDevOutputReference>()!;
        }

        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserFileOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserFileOutputReference File
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserFileOutputReference>()!;
        }

        [JsiiProperty(name: "nmdm", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserNmdmOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserNmdmOutputReference Nmdm
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserNmdmOutputReference>()!;
        }

        [JsiiProperty(name: "pipe", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserPipeOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserPipeOutputReference Pipe
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserPipeOutputReference>()!;
        }

        [JsiiProperty(name: "pty", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserPtyOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserPtyOutputReference Pty
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserPtyOutputReference>()!;
        }

        [JsiiProperty(name: "qemuVdAgent", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserQemuVdAgentOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserQemuVdAgentOutputReference QemuVdAgent
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserQemuVdAgentOutputReference>()!;
        }

        [JsiiProperty(name: "spicePort", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserSpicePortOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserSpicePortOutputReference SpicePort
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserSpicePortOutputReference>()!;
        }

        [JsiiProperty(name: "tcp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserTcpOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserTcpOutputReference Tcp
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserTcpOutputReference>()!;
        }

        [JsiiProperty(name: "udp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserUdpOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserUdpOutputReference Udp
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserUdpOutputReference>()!;
        }

        [JsiiProperty(name: "unix", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserUnixOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserUnixOutputReference Unix
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserUnixOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserDbus" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbusInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserDbus\"}]}}", isOptional: true)]
        public virtual object? DbusInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserDev" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "devInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserDev\"}]}}", isOptional: true)]
        public virtual object? DevInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserFile" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserFile\"}]}}", isOptional: true)]
        public virtual object? FileInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserNmdm" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nmdmInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserNmdm\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserPipe" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pipeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserPipe\"}]}}", isOptional: true)]
        public virtual object? PipeInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserPty" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ptyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserPty\"}]}}", isOptional: true)]
        public virtual object? PtyInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserQemuVdAgent" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "qemuVdAgentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserQemuVdAgent\"}]}}", isOptional: true)]
        public virtual object? QemuVdAgentInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserSpicePort" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spicePortInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserSpicePort\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserTcp" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tcpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserTcp\"}]}}", isOptional: true)]
        public virtual object? TcpInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserUdp" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "udpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserUdp\"}]}}", isOptional: true)]
        public virtual object? UdpInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUserUnix" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "unixInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserUnix\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUser" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUser\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUser cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUser).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
