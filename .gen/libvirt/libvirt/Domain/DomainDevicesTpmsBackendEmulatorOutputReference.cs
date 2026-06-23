using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesTpmsBackendEmulatorOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesTpmsBackendEmulatorOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainDevicesTpmsBackendEmulatorOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainDevicesTpmsBackendEmulatorOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainDevicesTpmsBackendEmulatorOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesTpmsBackendEmulatorOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putActivePcrBanks", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorActivePcrBanks\"}}]")]
        public virtual void PutActivePcrBanks(libvirt.Domain.IDomainDevicesTpmsBackendEmulatorActivePcrBanks @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesTpmsBackendEmulatorActivePcrBanks)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorEncryption\"}}]")]
        public virtual void PutEncryption(libvirt.Domain.IDomainDevicesTpmsBackendEmulatorEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesTpmsBackendEmulatorEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorProfile\"}}]")]
        public virtual void PutProfile(libvirt.Domain.IDomainDevicesTpmsBackendEmulatorProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesTpmsBackendEmulatorProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorSource\"}}]")]
        public virtual void PutSource(libvirt.Domain.IDomainDevicesTpmsBackendEmulatorSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesTpmsBackendEmulatorSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActivePcrBanks")]
        public virtual void ResetActivePcrBanks()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDebug")]
        public virtual void ResetDebug()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryption")]
        public virtual void ResetEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPersistentState")]
        public virtual void ResetPersistentState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProfile")]
        public virtual void ResetProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSource")]
        public virtual void ResetSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersion")]
        public virtual void ResetVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "activePcrBanks", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorActivePcrBanksOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesTpmsBackendEmulatorActivePcrBanksOutputReference ActivePcrBanks
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesTpmsBackendEmulatorActivePcrBanksOutputReference>()!;
        }

        [JsiiProperty(name: "encryption", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorEncryptionOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesTpmsBackendEmulatorEncryptionOutputReference Encryption
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesTpmsBackendEmulatorEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "profile", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorProfileOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesTpmsBackendEmulatorProfileOutputReference Profile
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesTpmsBackendEmulatorProfileOutputReference>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorSourceOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesTpmsBackendEmulatorSourceOutputReference Source
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesTpmsBackendEmulatorSourceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activePcrBanksInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorActivePcrBanks\"}]}}", isOptional: true)]
        public virtual object? ActivePcrBanksInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "debugInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DebugInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorEncryption\"}]}}", isOptional: true)]
        public virtual object? EncryptionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "persistentStateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PersistentStateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "profileInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorProfile\"}]}}", isOptional: true)]
        public virtual object? ProfileInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorSource\"}]}}", isOptional: true)]
        public virtual object? SourceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "debug", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Debug
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "persistentState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PersistentState
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulator\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesTpmsBackendEmulator cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesTpmsBackendEmulator).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
