using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainOsNvRamSourceOutputReference), fullyQualifiedName: "libvirt.domain.DomainOsNvRamSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainOsNvRamSourceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainOsNvRamSourceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainOsNvRamSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainOsNvRamSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBlock", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceBlock\"}}]")]
        public virtual void PutBlock(libvirt.Domain.IDomainOsNvRamSourceBlock @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceBlock)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCookies", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceCookies\"}}]")]
        public virtual void PutCookies(libvirt.Domain.IDomainOsNvRamSourceCookies @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceCookies)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataStore", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceDataStore\"}}]")]
        public virtual void PutDataStore(libvirt.Domain.IDomainOsNvRamSourceDataStore @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceDataStore)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDir", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceDir\"}}]")]
        public virtual void PutDir(libvirt.Domain.IDomainOsNvRamSourceDir @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceDir)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceEncryption\"}}]")]
        public virtual void PutEncryption(libvirt.Domain.IDomainOsNvRamSourceEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceFile\"}}]")]
        public virtual void PutFile(libvirt.Domain.IDomainOsNvRamSourceFile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceFile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetwork", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceNetwork\"}}]")]
        public virtual void PutNetwork(libvirt.Domain.IDomainOsNvRamSourceNetwork @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceNetwork)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNvme", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceNvme\"}}]")]
        public virtual void PutNvme(libvirt.Domain.IDomainOsNvRamSourceNvme @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceNvme)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReadahead", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReadahead\"}}]")]
        public virtual void PutReadahead(libvirt.Domain.IDomainOsNvRamSourceReadahead @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceReadahead)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReservations", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservations\"}}]")]
        public virtual void PutReservations(libvirt.Domain.IDomainOsNvRamSourceReservations @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceReservations)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSlices", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceSlices\"}}]")]
        public virtual void PutSlices(libvirt.Domain.IDomainOsNvRamSourceSlices @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceSlices)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSsl", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceSsl\"}}]")]
        public virtual void PutSsl(libvirt.Domain.IDomainOsNvRamSourceSsl @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceSsl)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeout", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceTimeout\"}}]")]
        public virtual void PutTimeout(libvirt.Domain.IDomainOsNvRamSourceTimeout @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceTimeout)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVhostUser", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUser\"}}]")]
        public virtual void PutVhostUser(libvirt.Domain.IDomainOsNvRamSourceVhostUser @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceVhostUser)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVhostVdpa", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostVdpa\"}}]")]
        public virtual void PutVhostVdpa(libvirt.Domain.IDomainOsNvRamSourceVhostVdpa @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceVhostVdpa)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVolume", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVolume\"}}]")]
        public virtual void PutVolume(libvirt.Domain.IDomainOsNvRamSourceVolume @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOsNvRamSourceVolume)}, new object[]{@value});
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

        [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceBlockOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceBlockOutputReference Block
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceBlockOutputReference>()!;
        }

        [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceCookiesOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceCookiesOutputReference Cookies
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceCookiesOutputReference>()!;
        }

        [JsiiProperty(name: "dataStore", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceDataStoreOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceDataStoreOutputReference DataStore
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceDataStoreOutputReference>()!;
        }

        [JsiiProperty(name: "dir", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceDirOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceDirOutputReference Dir
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceDirOutputReference>()!;
        }

        [JsiiProperty(name: "encryption", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceEncryptionOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceEncryptionOutputReference Encryption
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceFileOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceFileOutputReference File
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceFileOutputReference>()!;
        }

        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceNetworkOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceNetworkOutputReference Network
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceNetworkOutputReference>()!;
        }

        [JsiiProperty(name: "nvme", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceNvmeOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceNvmeOutputReference Nvme
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceNvmeOutputReference>()!;
        }

        [JsiiProperty(name: "readahead", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReadaheadOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceReadaheadOutputReference Readahead
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceReadaheadOutputReference>()!;
        }

        [JsiiProperty(name: "reservations", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservationsOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceReservationsOutputReference Reservations
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceReservationsOutputReference>()!;
        }

        [JsiiProperty(name: "slices", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceSlicesOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceSlicesOutputReference Slices
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceSlicesOutputReference>()!;
        }

        [JsiiProperty(name: "ssl", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceSslOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceSslOutputReference Ssl
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceSslOutputReference>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceTimeoutOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceTimeoutOutputReference Timeout
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceTimeoutOutputReference>()!;
        }

        [JsiiProperty(name: "vhostUser", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUserOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceVhostUserOutputReference VhostUser
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceVhostUserOutputReference>()!;
        }

        [JsiiProperty(name: "vhostVdpa", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostVdpaOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceVhostVdpaOutputReference VhostVdpa
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceVhostVdpaOutputReference>()!;
        }

        [JsiiProperty(name: "volume", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVolumeOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsNvRamSourceVolumeOutputReference Volume
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsNvRamSourceVolumeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceBlock\"}]}}", isOptional: true)]
        public virtual object? BlockInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cookiesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceCookies\"}]}}", isOptional: true)]
        public virtual object? CookiesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataStoreInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceDataStore\"}]}}", isOptional: true)]
        public virtual object? DataStoreInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dirInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceDir\"}]}}", isOptional: true)]
        public virtual object? DirInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceEncryption\"}]}}", isOptional: true)]
        public virtual object? EncryptionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceFile\"}]}}", isOptional: true)]
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

        [JsiiOptional]
        [JsiiProperty(name: "networkInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceNetwork\"}]}}", isOptional: true)]
        public virtual object? NetworkInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nvmeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceNvme\"}]}}", isOptional: true)]
        public virtual object? NvmeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "readaheadInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReadahead\"}]}}", isOptional: true)]
        public virtual object? ReadaheadInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reservationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceReservations\"}]}}", isOptional: true)]
        public virtual object? ReservationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "slicesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceSlices\"}]}}", isOptional: true)]
        public virtual object? SlicesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceSsl\"}]}}", isOptional: true)]
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

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceTimeout\"}]}}", isOptional: true)]
        public virtual object? TimeoutInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vhostUserInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostUser\"}]}}", isOptional: true)]
        public virtual object? VhostUserInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vhostVdpaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVhostVdpa\"}]}}", isOptional: true)]
        public virtual object? VhostVdpaInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceVolume\"}]}}", isOptional: true)]
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOsNvRamSource\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainOsNvRamSource cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainOsNvRamSource).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
