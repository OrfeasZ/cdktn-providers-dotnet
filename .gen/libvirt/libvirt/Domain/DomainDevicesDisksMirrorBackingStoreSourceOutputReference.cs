using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesDisksMirrorBackingStoreSourceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesDisksMirrorBackingStoreSourceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesDisksMirrorBackingStoreSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesDisksMirrorBackingStoreSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBlock", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceBlock\"}}]")]
        public virtual void PutBlock(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceBlock @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceBlock)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCookies", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceCookies\"}}]")]
        public virtual void PutCookies(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceCookies @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceCookies)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataStore", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceDataStore\"}}]")]
        public virtual void PutDataStore(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceDataStore @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceDataStore)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDir", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceDir\"}}]")]
        public virtual void PutDir(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceDir @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceDir)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceEncryption\"}}]")]
        public virtual void PutEncryption(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceFile\"}}]")]
        public virtual void PutFile(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceFile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceFile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetwork", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetwork\"}}]")]
        public virtual void PutNetwork(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetwork @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetwork)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNvme", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNvme\"}}]")]
        public virtual void PutNvme(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNvme @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNvme)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReadahead", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReadahead\"}}]")]
        public virtual void PutReadahead(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReadahead @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReadahead)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReservations", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservations\"}}]")]
        public virtual void PutReservations(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservations @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservations)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSlices", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceSlices\"}}]")]
        public virtual void PutSlices(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceSlices @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceSlices)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSsl", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceSsl\"}}]")]
        public virtual void PutSsl(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceSsl @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceSsl)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeout", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceTimeout\"}}]")]
        public virtual void PutTimeout(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceTimeout @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceTimeout)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVhostUser", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceVhostUser\"}}]")]
        public virtual void PutVhostUser(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceVhostUser @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceVhostUser)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVhostVdpa", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceVhostVdpa\"}}]")]
        public virtual void PutVhostVdpa(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceVhostVdpa @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceVhostVdpa)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVolume", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceVolume\"}}]")]
        public virtual void PutVolume(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceVolume @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceVolume)}, new object[]{@value});
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

        [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceBlockOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceBlockOutputReference Block
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceBlockOutputReference>()!;
        }

        [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceCookiesOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceCookiesOutputReference Cookies
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceCookiesOutputReference>()!;
        }

        [JsiiProperty(name: "dataStore", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceDataStoreOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceDataStoreOutputReference DataStore
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceDataStoreOutputReference>()!;
        }

        [JsiiProperty(name: "dir", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceDirOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceDirOutputReference Dir
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceDirOutputReference>()!;
        }

        [JsiiProperty(name: "encryption", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceEncryptionOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceEncryptionOutputReference Encryption
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceFileOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceFileOutputReference File
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceFileOutputReference>()!;
        }

        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkOutputReference Network
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceNetworkOutputReference>()!;
        }

        [JsiiProperty(name: "nvme", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNvmeOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceNvmeOutputReference Nvme
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceNvmeOutputReference>()!;
        }

        [JsiiProperty(name: "readahead", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReadaheadOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReadaheadOutputReference Readahead
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReadaheadOutputReference>()!;
        }

        [JsiiProperty(name: "reservations", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsOutputReference Reservations
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsOutputReference>()!;
        }

        [JsiiProperty(name: "slices", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceSlicesOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceSlicesOutputReference Slices
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceSlicesOutputReference>()!;
        }

        [JsiiProperty(name: "ssl", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceSslOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceSslOutputReference Ssl
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceSslOutputReference>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceTimeoutOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceTimeoutOutputReference Timeout
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceTimeoutOutputReference>()!;
        }

        [JsiiProperty(name: "vhostUser", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceVhostUserOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceVhostUserOutputReference VhostUser
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceVhostUserOutputReference>()!;
        }

        [JsiiProperty(name: "vhostVdpa", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceVhostVdpaOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceVhostVdpaOutputReference VhostVdpa
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceVhostVdpaOutputReference>()!;
        }

        [JsiiProperty(name: "volume", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceVolumeOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceVolumeOutputReference Volume
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesDisksMirrorBackingStoreSourceVolumeOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceBlock" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blockInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceBlock\"}]}}", isOptional: true)]
        public virtual object? BlockInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceCookies" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cookiesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceCookies\"}]}}", isOptional: true)]
        public virtual object? CookiesInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceDataStore" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataStoreInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceDataStore\"}]}}", isOptional: true)]
        public virtual object? DataStoreInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceDir" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dirInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceDir\"}]}}", isOptional: true)]
        public virtual object? DirInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceEncryption" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceEncryption\"}]}}", isOptional: true)]
        public virtual object? EncryptionInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceFile" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceFile\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNetwork" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNetwork\"}]}}", isOptional: true)]
        public virtual object? NetworkInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceNvme" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nvmeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceNvme\"}]}}", isOptional: true)]
        public virtual object? NvmeInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReadahead" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readaheadInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReadahead\"}]}}", isOptional: true)]
        public virtual object? ReadaheadInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservations" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reservationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservations\"}]}}", isOptional: true)]
        public virtual object? ReservationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceSlices" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "slicesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceSlices\"}]}}", isOptional: true)]
        public virtual object? SlicesInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceSsl" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sslInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceSsl\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceTimeout" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceTimeout\"}]}}", isOptional: true)]
        public virtual object? TimeoutInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceVhostUser" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vhostUserInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceVhostUser\"}]}}", isOptional: true)]
        public virtual object? VhostUserInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceVhostVdpa" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vhostVdpaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceVhostVdpa\"}]}}", isOptional: true)]
        public virtual object? VhostVdpaInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceVolume" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "volumeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceVolume\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSource" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSource\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSource cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSource).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
