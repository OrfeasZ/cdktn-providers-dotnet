using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesRedirDevsSourceOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesRedirDevsSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesRedirDevsSourceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesRedirDevsSourceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesRedirDevsSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesRedirDevsSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDbus", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceDbus\"}}]")]
        public virtual void PutDbus(libvirt.Domain.IDomainDevicesRedirDevsSourceDbus @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesRedirDevsSourceDbus)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDev", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceDev\"}}]")]
        public virtual void PutDev(libvirt.Domain.IDomainDevicesRedirDevsSourceDev @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesRedirDevsSourceDev)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceFile\"}}]")]
        public virtual void PutFile(libvirt.Domain.IDomainDevicesRedirDevsSourceFile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesRedirDevsSourceFile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNmdm", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceNmdm\"}}]")]
        public virtual void PutNmdm(libvirt.Domain.IDomainDevicesRedirDevsSourceNmdm @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesRedirDevsSourceNmdm)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPipe", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourcePipe\"}}]")]
        public virtual void PutPipe(libvirt.Domain.IDomainDevicesRedirDevsSourcePipe @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesRedirDevsSourcePipe)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPty", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourcePty\"}}]")]
        public virtual void PutPty(libvirt.Domain.IDomainDevicesRedirDevsSourcePty @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesRedirDevsSourcePty)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQemuVdAgent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceQemuVdAgent\"}}]")]
        public virtual void PutQemuVdAgent(libvirt.Domain.IDomainDevicesRedirDevsSourceQemuVdAgent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesRedirDevsSourceQemuVdAgent)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSpicePort", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceSpicePort\"}}]")]
        public virtual void PutSpicePort(libvirt.Domain.IDomainDevicesRedirDevsSourceSpicePort @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesRedirDevsSourceSpicePort)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTcp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceTcp\"}}]")]
        public virtual void PutTcp(libvirt.Domain.IDomainDevicesRedirDevsSourceTcp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesRedirDevsSourceTcp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUdp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceUdp\"}}]")]
        public virtual void PutUdp(libvirt.Domain.IDomainDevicesRedirDevsSourceUdp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesRedirDevsSourceUdp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUnix", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceUnix\"}}]")]
        public virtual void PutUnix(libvirt.Domain.IDomainDevicesRedirDevsSourceUnix @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesRedirDevsSourceUnix)}, new object[]{@value});
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

        [JsiiProperty(name: "dbus", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceDbusOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesRedirDevsSourceDbusOutputReference Dbus
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesRedirDevsSourceDbusOutputReference>()!;
        }

        [JsiiProperty(name: "dev", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceDevOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesRedirDevsSourceDevOutputReference Dev
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesRedirDevsSourceDevOutputReference>()!;
        }

        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceFileOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesRedirDevsSourceFileOutputReference File
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesRedirDevsSourceFileOutputReference>()!;
        }

        [JsiiProperty(name: "nmdm", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceNmdmOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesRedirDevsSourceNmdmOutputReference Nmdm
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesRedirDevsSourceNmdmOutputReference>()!;
        }

        [JsiiProperty(name: "pipe", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourcePipeOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesRedirDevsSourcePipeOutputReference Pipe
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesRedirDevsSourcePipeOutputReference>()!;
        }

        [JsiiProperty(name: "pty", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourcePtyOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesRedirDevsSourcePtyOutputReference Pty
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesRedirDevsSourcePtyOutputReference>()!;
        }

        [JsiiProperty(name: "qemuVdAgent", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceQemuVdAgentOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesRedirDevsSourceQemuVdAgentOutputReference QemuVdAgent
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesRedirDevsSourceQemuVdAgentOutputReference>()!;
        }

        [JsiiProperty(name: "spicePort", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceSpicePortOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesRedirDevsSourceSpicePortOutputReference SpicePort
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesRedirDevsSourceSpicePortOutputReference>()!;
        }

        [JsiiProperty(name: "tcp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceTcpOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesRedirDevsSourceTcpOutputReference Tcp
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesRedirDevsSourceTcpOutputReference>()!;
        }

        [JsiiProperty(name: "udp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceUdpOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesRedirDevsSourceUdpOutputReference Udp
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesRedirDevsSourceUdpOutputReference>()!;
        }

        [JsiiProperty(name: "unix", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceUnixOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesRedirDevsSourceUnixOutputReference Unix
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesRedirDevsSourceUnixOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesRedirDevsSourceDbus" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbusInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceDbus\"}]}}", isOptional: true)]
        public virtual object? DbusInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesRedirDevsSourceDev" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "devInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceDev\"}]}}", isOptional: true)]
        public virtual object? DevInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesRedirDevsSourceFile" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceFile\"}]}}", isOptional: true)]
        public virtual object? FileInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesRedirDevsSourceNmdm" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nmdmInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceNmdm\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesRedirDevsSourcePipe" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pipeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourcePipe\"}]}}", isOptional: true)]
        public virtual object? PipeInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesRedirDevsSourcePty" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ptyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourcePty\"}]}}", isOptional: true)]
        public virtual object? PtyInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesRedirDevsSourceQemuVdAgent" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "qemuVdAgentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceQemuVdAgent\"}]}}", isOptional: true)]
        public virtual object? QemuVdAgentInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesRedirDevsSourceSpicePort" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spicePortInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceSpicePort\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesRedirDevsSourceTcp" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tcpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceTcp\"}]}}", isOptional: true)]
        public virtual object? TcpInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesRedirDevsSourceUdp" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "udpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceUdp\"}]}}", isOptional: true)]
        public virtual object? UdpInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesRedirDevsSourceUnix" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "unixInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceUnix\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesRedirDevsSource" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSource\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesRedirDevsSource cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesRedirDevsSource).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
