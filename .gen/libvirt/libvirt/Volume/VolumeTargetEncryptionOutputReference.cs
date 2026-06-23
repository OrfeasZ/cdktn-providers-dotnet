using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Volume
{
    [JsiiClass(nativeType: typeof(libvirt.Volume.VolumeTargetEncryptionOutputReference), fullyQualifiedName: "libvirt.volume.VolumeTargetEncryptionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VolumeTargetEncryptionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VolumeTargetEncryptionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VolumeTargetEncryptionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VolumeTargetEncryptionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCipher", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.volume.VolumeTargetEncryptionCipher\"}}]")]
        public virtual void PutCipher(libvirt.Volume.IVolumeTargetEncryptionCipher @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Volume.IVolumeTargetEncryptionCipher)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIvgen", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.volume.VolumeTargetEncryptionIvgen\"}}]")]
        public virtual void PutIvgen(libvirt.Volume.IVolumeTargetEncryptionIvgen @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Volume.IVolumeTargetEncryptionIvgen)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecret", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.volume.VolumeTargetEncryptionSecret\"}}]")]
        public virtual void PutSecret(libvirt.Volume.IVolumeTargetEncryptionSecret @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Volume.IVolumeTargetEncryptionSecret)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCipher")]
        public virtual void ResetCipher()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIvgen")]
        public virtual void ResetIvgen()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecret")]
        public virtual void ResetSecret()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cipher", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetEncryptionCipherOutputReference\"}")]
        public virtual libvirt.Volume.VolumeTargetEncryptionCipherOutputReference Cipher
        {
            get => GetInstanceProperty<libvirt.Volume.VolumeTargetEncryptionCipherOutputReference>()!;
        }

        [JsiiProperty(name: "ivgen", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetEncryptionIvgenOutputReference\"}")]
        public virtual libvirt.Volume.VolumeTargetEncryptionIvgenOutputReference Ivgen
        {
            get => GetInstanceProperty<libvirt.Volume.VolumeTargetEncryptionIvgenOutputReference>()!;
        }

        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"libvirt.volume.VolumeTargetEncryptionSecretOutputReference\"}")]
        public virtual libvirt.Volume.VolumeTargetEncryptionSecretOutputReference Secret
        {
            get => GetInstanceProperty<libvirt.Volume.VolumeTargetEncryptionSecretOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cipherInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.volume.VolumeTargetEncryptionCipher\"}]}}", isOptional: true)]
        public virtual object? CipherInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "formatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ivgenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.volume.VolumeTargetEncryptionIvgen\"}]}}", isOptional: true)]
        public virtual object? IvgenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.volume.VolumeTargetEncryptionSecret\"}]}}", isOptional: true)]
        public virtual object? SecretInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Format
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.volume.VolumeTargetEncryption\"}]}}", isOptional: true)]
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
                        case libvirt.Volume.IVolumeTargetEncryption cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Volume.IVolumeTargetEncryption).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
