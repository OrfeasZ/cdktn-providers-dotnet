using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesDisksMirrorSourceOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesDisksMirrorSourceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesDisksMirrorSourceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesDisksMirrorSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesDisksMirrorSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBlock", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceBlock\"}}]")]
        public virtual void PutBlock(libvirt.Domain.IDomainDevicesDisksMirrorSourceBlock @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceBlock)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCookies", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceCookies\"}}]")]
        public virtual void PutCookies(libvirt.Domain.IDomainDevicesDisksMirrorSourceCookies @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceCookies)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataStore", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceDataStore\"}}]")]
        public virtual void PutDataStore(libvirt.Domain.IDomainDevicesDisksMirrorSourceDataStore @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceDataStore)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDir", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceDir\"}}]")]
        public virtual void PutDir(libvirt.Domain.IDomainDevicesDisksMirrorSourceDir @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceDir)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceEncryption\"}}]")]
        public virtual void PutEncryption(libvirt.Domain.IDomainDevicesDisksMirrorSourceEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceFile\"}}]")]
        public virtual void PutFile(libvirt.Domain.IDomainDevicesDisksMirrorSourceFile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceFile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetwork", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetwork\"}}]")]
        public virtual void PutNetwork(libvirt.Domain.IDomainDevicesDisksMirrorSourceNetwork @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceNetwork)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNvme", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNvme\"}}]")]
        public virtual void PutNvme(libvirt.Domain.IDomainDevicesDisksMirrorSourceNvme @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceNvme)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReadahead", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceReadahead\"}}]")]
        public virtual void PutReadahead(libvirt.Domain.IDomainDevicesDisksMirrorSourceReadahead @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceReadahead)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReservations", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceReservations\"}}]")]
        public virtual void PutReservations(libvirt.Domain.IDomainDevicesDisksMirrorSourceReservations @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceReservations)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSlices", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceSlices\"}}]")]
        public virtual void PutSlices(libvirt.Domain.IDomainDevicesDisksMirrorSourceSlices @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceSlices)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSsl", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceSsl\"}}]")]
        public virtual void PutSsl(libvirt.Domain.IDomainDevicesDisksMirrorSourceSsl @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceSsl)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeout", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceTimeout\"}}]")]
        public virtual void PutTimeout(libvirt.Domain.IDomainDevicesDisksMirrorSourceTimeout @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceTimeout)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVhostUser", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUser\"}}]")]
        public virtual void PutVhostUser(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUser @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUser)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVhostVdpa", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostVdpa\"}}]")]
        public virtual void PutVhostVdpa(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostVdpa @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostVdpa)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVolume", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVolume\"}}]")]
        public virtual void PutVolume(libvirt.Domain.IDomainDevicesDisksMirrorSourceVolume @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorSourceVolume)}, new object[]{@value});
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

        [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceBlockOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceBlockOutputReference Block
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceBlockOutputReference>()!;
        }

        [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceCookiesOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceCookiesOutputReference Cookies
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceCookiesOutputReference>()!;
        }

        [JsiiProperty(name: "dataStore", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceDataStoreOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceDataStoreOutputReference DataStore
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceDataStoreOutputReference>()!;
        }

        [JsiiProperty(name: "dir", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceDirOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceDirOutputReference Dir
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceDirOutputReference>()!;
        }

        [JsiiProperty(name: "encryption", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceEncryptionOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceEncryptionOutputReference Encryption
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceFileOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceFileOutputReference File
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceFileOutputReference>()!;
        }

        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetworkOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceNetworkOutputReference Network
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceNetworkOutputReference>()!;
        }

        [JsiiProperty(name: "nvme", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNvmeOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceNvmeOutputReference Nvme
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceNvmeOutputReference>()!;
        }

        [JsiiProperty(name: "readahead", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceReadaheadOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceReadaheadOutputReference Readahead
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceReadaheadOutputReference>()!;
        }

        [JsiiProperty(name: "reservations", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceReservationsOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceReservationsOutputReference Reservations
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceReservationsOutputReference>()!;
        }

        [JsiiProperty(name: "slices", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceSlicesOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceSlicesOutputReference Slices
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceSlicesOutputReference>()!;
        }

        [JsiiProperty(name: "ssl", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceSslOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceSslOutputReference Ssl
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceSslOutputReference>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceTimeoutOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceTimeoutOutputReference Timeout
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceTimeoutOutputReference>()!;
        }

        [JsiiProperty(name: "vhostUser", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUserOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserOutputReference VhostUser
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceVhostUserOutputReference>()!;
        }

        [JsiiProperty(name: "vhostVdpa", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostVdpaOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceVhostVdpaOutputReference VhostVdpa
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceVhostVdpaOutputReference>()!;
        }

        [JsiiProperty(name: "volume", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVolumeOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorSourceVolumeOutputReference Volume
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorSourceVolumeOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceBlock" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blockInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceBlock\"}]}}", isOptional: true)]
        public virtual object? BlockInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceCookies" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cookiesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceCookies\"}]}}", isOptional: true)]
        public virtual object? CookiesInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceDataStore" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataStoreInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceDataStore\"}]}}", isOptional: true)]
        public virtual object? DataStoreInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceDir" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dirInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceDir\"}]}}", isOptional: true)]
        public virtual object? DirInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceEncryption" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceEncryption\"}]}}", isOptional: true)]
        public virtual object? EncryptionInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceFile" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceFile\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceNetwork" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNetwork\"}]}}", isOptional: true)]
        public virtual object? NetworkInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceNvme" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nvmeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceNvme\"}]}}", isOptional: true)]
        public virtual object? NvmeInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceReadahead" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readaheadInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceReadahead\"}]}}", isOptional: true)]
        public virtual object? ReadaheadInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceReservations" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reservationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceReservations\"}]}}", isOptional: true)]
        public virtual object? ReservationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceSlices" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "slicesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceSlices\"}]}}", isOptional: true)]
        public virtual object? SlicesInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceSsl" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sslInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceSsl\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceTimeout" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceTimeout\"}]}}", isOptional: true)]
        public virtual object? TimeoutInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostUser" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vhostUserInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostUser\"}]}}", isOptional: true)]
        public virtual object? VhostUserInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceVhostVdpa" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vhostVdpaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVhostVdpa\"}]}}", isOptional: true)]
        public virtual object? VhostVdpaInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceVolume" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "volumeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceVolume\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorSource" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSource\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesDisksMirrorSource cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksMirrorSource).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
