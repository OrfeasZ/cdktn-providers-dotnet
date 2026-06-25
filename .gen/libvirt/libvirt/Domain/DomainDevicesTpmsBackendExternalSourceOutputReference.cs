using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesTpmsBackendExternalSourceOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesTpmsBackendExternalSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesTpmsBackendExternalSourceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesTpmsBackendExternalSourceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesTpmsBackendExternalSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesTpmsBackendExternalSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDbus", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceDbus\"}}]")]
        public virtual void PutDbus(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceDbus @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceDbus)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDev", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceDev\"}}]")]
        public virtual void PutDev(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceDev @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceDev)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceFile\"}}]")]
        public virtual void PutFile(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceFile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceFile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNmdm", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceNmdm\"}}]")]
        public virtual void PutNmdm(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceNmdm @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceNmdm)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPipe", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourcePipe\"}}]")]
        public virtual void PutPipe(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourcePipe @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourcePipe)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPty", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourcePty\"}}]")]
        public virtual void PutPty(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourcePty @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourcePty)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQemuVdAgent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceQemuVdAgent\"}}]")]
        public virtual void PutQemuVdAgent(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceQemuVdAgent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceQemuVdAgent)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSpicePort", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceSpicePort\"}}]")]
        public virtual void PutSpicePort(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceSpicePort @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceSpicePort)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTcp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceTcp\"}}]")]
        public virtual void PutTcp(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceTcp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceTcp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUdp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceUdp\"}}]")]
        public virtual void PutUdp(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceUdp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceUdp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUnix", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceUnix\"}}]")]
        public virtual void PutUnix(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceUnix @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceUnix)}, new object[]{@value});
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

        [JsiiProperty(name: "dbus", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceDbusOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesTpmsBackendExternalSourceDbusOutputReference Dbus
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesTpmsBackendExternalSourceDbusOutputReference>()!;
        }

        [JsiiProperty(name: "dev", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceDevOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesTpmsBackendExternalSourceDevOutputReference Dev
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesTpmsBackendExternalSourceDevOutputReference>()!;
        }

        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceFileOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesTpmsBackendExternalSourceFileOutputReference File
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesTpmsBackendExternalSourceFileOutputReference>()!;
        }

        [JsiiProperty(name: "nmdm", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceNmdmOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesTpmsBackendExternalSourceNmdmOutputReference Nmdm
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesTpmsBackendExternalSourceNmdmOutputReference>()!;
        }

        [JsiiProperty(name: "pipe", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourcePipeOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesTpmsBackendExternalSourcePipeOutputReference Pipe
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesTpmsBackendExternalSourcePipeOutputReference>()!;
        }

        [JsiiProperty(name: "pty", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourcePtyOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesTpmsBackendExternalSourcePtyOutputReference Pty
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesTpmsBackendExternalSourcePtyOutputReference>()!;
        }

        [JsiiProperty(name: "qemuVdAgent", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceQemuVdAgentOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesTpmsBackendExternalSourceQemuVdAgentOutputReference QemuVdAgent
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesTpmsBackendExternalSourceQemuVdAgentOutputReference>()!;
        }

        [JsiiProperty(name: "spicePort", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceSpicePortOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesTpmsBackendExternalSourceSpicePortOutputReference SpicePort
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesTpmsBackendExternalSourceSpicePortOutputReference>()!;
        }

        [JsiiProperty(name: "tcp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceTcpOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesTpmsBackendExternalSourceTcpOutputReference Tcp
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesTpmsBackendExternalSourceTcpOutputReference>()!;
        }

        [JsiiProperty(name: "udp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceUdpOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesTpmsBackendExternalSourceUdpOutputReference Udp
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesTpmsBackendExternalSourceUdpOutputReference>()!;
        }

        [JsiiProperty(name: "unix", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceUnixOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesTpmsBackendExternalSourceUnixOutputReference Unix
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesTpmsBackendExternalSourceUnixOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceDbus" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbusInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceDbus\"}]}}", isOptional: true)]
        public virtual object? DbusInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceDev" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "devInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceDev\"}]}}", isOptional: true)]
        public virtual object? DevInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceFile" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceFile\"}]}}", isOptional: true)]
        public virtual object? FileInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceNmdm" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nmdmInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceNmdm\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesTpmsBackendExternalSourcePipe" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pipeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourcePipe\"}]}}", isOptional: true)]
        public virtual object? PipeInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesTpmsBackendExternalSourcePty" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ptyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourcePty\"}]}}", isOptional: true)]
        public virtual object? PtyInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceQemuVdAgent" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "qemuVdAgentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceQemuVdAgent\"}]}}", isOptional: true)]
        public virtual object? QemuVdAgentInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceSpicePort" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spicePortInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceSpicePort\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceTcp" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tcpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceTcp\"}]}}", isOptional: true)]
        public virtual object? TcpInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceUdp" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "udpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceUdp\"}]}}", isOptional: true)]
        public virtual object? UdpInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesTpmsBackendExternalSourceUnix" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "unixInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSourceUnix\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesTpmsBackendExternalSource" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSource\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesTpmsBackendExternalSource cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesTpmsBackendExternalSource).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
