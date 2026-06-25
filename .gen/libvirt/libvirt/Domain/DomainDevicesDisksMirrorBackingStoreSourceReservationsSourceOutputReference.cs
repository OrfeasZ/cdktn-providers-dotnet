using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDbus", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceDbus\"}}]")]
        public virtual void PutDbus(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceDbus @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceDbus)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDev", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceDev\"}}]")]
        public virtual void PutDev(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceDev @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceDev)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceFile\"}}]")]
        public virtual void PutFile(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceFile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceFile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNmdm", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceNmdm\"}}]")]
        public virtual void PutNmdm(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceNmdm @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceNmdm)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPipe", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourcePipe\"}}]")]
        public virtual void PutPipe(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourcePipe @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourcePipe)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPty", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourcePty\"}}]")]
        public virtual void PutPty(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourcePty @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourcePty)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQemuVdAgent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceQemuVdAgent\"}}]")]
        public virtual void PutQemuVdAgent(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceQemuVdAgent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceQemuVdAgent)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSpicePort", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceSpicePort\"}}]")]
        public virtual void PutSpicePort(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceSpicePort @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceSpicePort)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTcp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceTcp\"}}]")]
        public virtual void PutTcp(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceTcp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceTcp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUdp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceUdp\"}}]")]
        public virtual void PutUdp(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceUdp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceUdp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUnix", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceUnix\"}}]")]
        public virtual void PutUnix(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceUnix @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceUnix)}, new object[]{@value});
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

        [JsiiProperty(name: "dbus", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceDbusOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceDbusOutputReference Dbus
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceDbusOutputReference>()!;
        }

        [JsiiProperty(name: "dev", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceDevOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceDevOutputReference Dev
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceDevOutputReference>()!;
        }

        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceFileOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceFileOutputReference File
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceFileOutputReference>()!;
        }

        [JsiiProperty(name: "nmdm", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceNmdmOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceNmdmOutputReference Nmdm
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceNmdmOutputReference>()!;
        }

        [JsiiProperty(name: "pipe", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourcePipeOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourcePipeOutputReference Pipe
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourcePipeOutputReference>()!;
        }

        [JsiiProperty(name: "pty", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourcePtyOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourcePtyOutputReference Pty
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourcePtyOutputReference>()!;
        }

        [JsiiProperty(name: "qemuVdAgent", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceQemuVdAgentOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceQemuVdAgentOutputReference QemuVdAgent
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceQemuVdAgentOutputReference>()!;
        }

        [JsiiProperty(name: "spicePort", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceSpicePortOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceSpicePortOutputReference SpicePort
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceSpicePortOutputReference>()!;
        }

        [JsiiProperty(name: "tcp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceTcpOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceTcpOutputReference Tcp
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceTcpOutputReference>()!;
        }

        [JsiiProperty(name: "udp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceUdpOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceUdpOutputReference Udp
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceUdpOutputReference>()!;
        }

        [JsiiProperty(name: "unix", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceUnixOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceUnixOutputReference Unix
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceUnixOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceDbus" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbusInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceDbus\"}]}}", isOptional: true)]
        public virtual object? DbusInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceDev" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "devInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceDev\"}]}}", isOptional: true)]
        public virtual object? DevInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceFile" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceFile\"}]}}", isOptional: true)]
        public virtual object? FileInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceNmdm" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nmdmInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceNmdm\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourcePipe" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pipeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourcePipe\"}]}}", isOptional: true)]
        public virtual object? PipeInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourcePty" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ptyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourcePty\"}]}}", isOptional: true)]
        public virtual object? PtyInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceQemuVdAgent" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "qemuVdAgentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceQemuVdAgent\"}]}}", isOptional: true)]
        public virtual object? QemuVdAgentInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceSpicePort" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spicePortInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceSpicePort\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceTcp" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tcpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceTcp\"}]}}", isOptional: true)]
        public virtual object? TcpInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceUdp" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "udpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceUdp\"}]}}", isOptional: true)]
        public virtual object? UdpInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceUnix" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "unixInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceUnix\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSource" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSource\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSource cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSource).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
