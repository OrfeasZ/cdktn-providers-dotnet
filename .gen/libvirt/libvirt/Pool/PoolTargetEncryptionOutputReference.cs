using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiClass(nativeType: typeof(libvirt.Pool.PoolTargetEncryptionOutputReference), fullyQualifiedName: "libvirt.pool.PoolTargetEncryptionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PoolTargetEncryptionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PoolTargetEncryptionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PoolTargetEncryptionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PoolTargetEncryptionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCipher", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.pool.PoolTargetEncryptionCipher\"}}]")]
        public virtual void PutCipher(libvirt.Pool.IPoolTargetEncryptionCipher @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Pool.IPoolTargetEncryptionCipher)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIvgen", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.pool.PoolTargetEncryptionIvgen\"}}]")]
        public virtual void PutIvgen(libvirt.Pool.IPoolTargetEncryptionIvgen @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Pool.IPoolTargetEncryptionIvgen)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecret", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.pool.PoolTargetEncryptionSecret\"}}]")]
        public virtual void PutSecret(libvirt.Pool.IPoolTargetEncryptionSecret @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Pool.IPoolTargetEncryptionSecret)}, new object[]{@value});
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

        [JsiiProperty(name: "cipher", typeJson: "{\"fqn\":\"libvirt.pool.PoolTargetEncryptionCipherOutputReference\"}")]
        public virtual libvirt.Pool.PoolTargetEncryptionCipherOutputReference Cipher
        {
            get => GetInstanceProperty<libvirt.Pool.PoolTargetEncryptionCipherOutputReference>()!;
        }

        [JsiiProperty(name: "ivgen", typeJson: "{\"fqn\":\"libvirt.pool.PoolTargetEncryptionIvgenOutputReference\"}")]
        public virtual libvirt.Pool.PoolTargetEncryptionIvgenOutputReference Ivgen
        {
            get => GetInstanceProperty<libvirt.Pool.PoolTargetEncryptionIvgenOutputReference>()!;
        }

        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"libvirt.pool.PoolTargetEncryptionSecretOutputReference\"}")]
        public virtual libvirt.Pool.PoolTargetEncryptionSecretOutputReference Secret
        {
            get => GetInstanceProperty<libvirt.Pool.PoolTargetEncryptionSecretOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Pool.IPoolTargetEncryptionCipher" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cipherInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolTargetEncryptionCipher\"}]}}", isOptional: true)]
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

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Pool.IPoolTargetEncryptionIvgen" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ivgenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolTargetEncryptionIvgen\"}]}}", isOptional: true)]
        public virtual object? IvgenInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Pool.IPoolTargetEncryptionSecret" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolTargetEncryptionSecret\"}]}}", isOptional: true)]
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

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Pool.IPoolTargetEncryption" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolTargetEncryption\"}]}}", isOptional: true)]
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
                        case libvirt.Pool.IPoolTargetEncryption cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Pool.IPoolTargetEncryption).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
