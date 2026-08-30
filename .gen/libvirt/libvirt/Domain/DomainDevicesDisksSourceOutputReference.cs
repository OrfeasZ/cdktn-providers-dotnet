using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesDisksSourceOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesDisksSourceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesDisksSourceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesDisksSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesDisksSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBlock", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceBlock\"}}]")]
        public virtual void PutBlock(libvirt.Domain.IDomainDevicesDisksSourceBlock @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceBlock)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCookies", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceCookies\"}}]")]
        public virtual void PutCookies(libvirt.Domain.IDomainDevicesDisksSourceCookies @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceCookies)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCtl", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceCtl\"}}]")]
        public virtual void PutCtl(libvirt.Domain.IDomainDevicesDisksSourceCtl @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceCtl)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataStore", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceDataStore\"}}]")]
        public virtual void PutDataStore(libvirt.Domain.IDomainDevicesDisksSourceDataStore @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceDataStore)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDir", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceDir\"}}]")]
        public virtual void PutDir(libvirt.Domain.IDomainDevicesDisksSourceDir @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceDir)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceEncryption\"}}]")]
        public virtual void PutEncryption(libvirt.Domain.IDomainDevicesDisksSourceEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceFile\"}}]")]
        public virtual void PutFile(libvirt.Domain.IDomainDevicesDisksSourceFile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceFile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetwork", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetwork\"}}]")]
        public virtual void PutNetwork(libvirt.Domain.IDomainDevicesDisksSourceNetwork @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceNetwork)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNvme", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNvme\"}}]")]
        public virtual void PutNvme(libvirt.Domain.IDomainDevicesDisksSourceNvme @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceNvme)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReadahead", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReadahead\"}}]")]
        public virtual void PutReadahead(libvirt.Domain.IDomainDevicesDisksSourceReadahead @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceReadahead)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReservations", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservations\"}}]")]
        public virtual void PutReservations(libvirt.Domain.IDomainDevicesDisksSourceReservations @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceReservations)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSlices", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceSlices\"}}]")]
        public virtual void PutSlices(libvirt.Domain.IDomainDevicesDisksSourceSlices @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceSlices)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSsl", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceSsl\"}}]")]
        public virtual void PutSsl(libvirt.Domain.IDomainDevicesDisksSourceSsl @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceSsl)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeout", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceTimeout\"}}]")]
        public virtual void PutTimeout(libvirt.Domain.IDomainDevicesDisksSourceTimeout @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceTimeout)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVhostUser", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUser\"}}]")]
        public virtual void PutVhostUser(libvirt.Domain.IDomainDevicesDisksSourceVhostUser @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceVhostUser)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVhostVdpa", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostVdpa\"}}]")]
        public virtual void PutVhostVdpa(libvirt.Domain.IDomainDevicesDisksSourceVhostVdpa @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceVhostVdpa)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVolume", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVolume\"}}]")]
        public virtual void PutVolume(libvirt.Domain.IDomainDevicesDisksSourceVolume @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksSourceVolume)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBlock")]
        public virtual void ResetBlock()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCookies")]
        public virtual void ResetCookies()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCtl")]
        public virtual void ResetCtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataStore")]
        public virtual void ResetDataStore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDir")]
        public virtual void ResetDir()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryption")]
        public virtual void ResetEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFile")]
        public virtual void ResetFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIndex")]
        public virtual void ResetIndex()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetwork")]
        public virtual void ResetNetwork()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNvme")]
        public virtual void ResetNvme()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReadahead")]
        public virtual void ResetReadahead()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReservations")]
        public virtual void ResetReservations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSlices")]
        public virtual void ResetSlices()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSsl")]
        public virtual void ResetSsl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartupPolicy")]
        public virtual void ResetStartupPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeout")]
        public virtual void ResetTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVhostUser")]
        public virtual void ResetVhostUser()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVhostVdpa")]
        public virtual void ResetVhostVdpa()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVolume")]
        public virtual void ResetVolume()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceBlockOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceBlockOutputReference Block
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceBlockOutputReference>()!;
        }

        [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceCookiesOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceCookiesOutputReference Cookies
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceCookiesOutputReference>()!;
        }

        [JsiiProperty(name: "ctl", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceCtlOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceCtlOutputReference Ctl
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceCtlOutputReference>()!;
        }

        [JsiiProperty(name: "dataStore", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceDataStoreOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceDataStoreOutputReference DataStore
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceDataStoreOutputReference>()!;
        }

        [JsiiProperty(name: "dir", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceDirOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceDirOutputReference Dir
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceDirOutputReference>()!;
        }

        [JsiiProperty(name: "encryption", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceEncryptionOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceEncryptionOutputReference Encryption
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceFileOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceFileOutputReference File
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceFileOutputReference>()!;
        }

        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetworkOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceNetworkOutputReference Network
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceNetworkOutputReference>()!;
        }

        [JsiiProperty(name: "nvme", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNvmeOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceNvmeOutputReference Nvme
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceNvmeOutputReference>()!;
        }

        [JsiiProperty(name: "readahead", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReadaheadOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceReadaheadOutputReference Readahead
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceReadaheadOutputReference>()!;
        }

        [JsiiProperty(name: "reservations", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservationsOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceReservationsOutputReference Reservations
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceReservationsOutputReference>()!;
        }

        [JsiiProperty(name: "slices", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceSlicesOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceSlicesOutputReference Slices
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceSlicesOutputReference>()!;
        }

        [JsiiProperty(name: "ssl", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceSslOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceSslOutputReference Ssl
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceSslOutputReference>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceTimeoutOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceTimeoutOutputReference Timeout
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceTimeoutOutputReference>()!;
        }

        [JsiiProperty(name: "vhostUser", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceVhostUserOutputReference VhostUser
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceVhostUserOutputReference>()!;
        }

        [JsiiProperty(name: "vhostVdpa", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostVdpaOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceVhostVdpaOutputReference VhostVdpa
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceVhostVdpaOutputReference>()!;
        }

        [JsiiProperty(name: "volume", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVolumeOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksSourceVolumeOutputReference Volume
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksSourceVolumeOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceBlock" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blockInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceBlock\"}]}}", isOptional: true)]
        public virtual object? BlockInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceCookies" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cookiesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceCookies\"}]}}", isOptional: true)]
        public virtual object? CookiesInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceCtl" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ctlInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceCtl\"}]}}", isOptional: true)]
        public virtual object? CtlInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceDataStore" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataStoreInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceDataStore\"}]}}", isOptional: true)]
        public virtual object? DataStoreInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceDir" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dirInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceDir\"}]}}", isOptional: true)]
        public virtual object? DirInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceEncryption" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceEncryption\"}]}}", isOptional: true)]
        public virtual object? EncryptionInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceFile" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceFile\"}]}}", isOptional: true)]
        public virtual object? FileInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "indexInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IndexInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceNetwork" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNetwork\"}]}}", isOptional: true)]
        public virtual object? NetworkInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceNvme" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nvmeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceNvme\"}]}}", isOptional: true)]
        public virtual object? NvmeInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceReadahead" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readaheadInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReadahead\"}]}}", isOptional: true)]
        public virtual object? ReadaheadInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceReservations" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reservationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceReservations\"}]}}", isOptional: true)]
        public virtual object? ReservationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceSlices" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "slicesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceSlices\"}]}}", isOptional: true)]
        public virtual object? SlicesInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceSsl" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sslInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceSsl\"}]}}", isOptional: true)]
        public virtual object? SslInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startupPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StartupPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceTimeout" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceTimeout\"}]}}", isOptional: true)]
        public virtual object? TimeoutInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceVhostUser" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vhostUserInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUser\"}]}}", isOptional: true)]
        public virtual object? VhostUserInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceVhostVdpa" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vhostVdpaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostVdpa\"}]}}", isOptional: true)]
        public virtual object? VhostVdpaInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSourceVolume" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "volumeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVolume\"}]}}", isOptional: true)]
        public virtual object? VolumeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "index", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Index
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startupPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartupPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksSource" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksSource\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesDisksSource cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksSource).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
