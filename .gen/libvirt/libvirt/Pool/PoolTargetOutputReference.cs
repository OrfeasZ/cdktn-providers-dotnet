using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiClass(nativeType: typeof(libvirt.Pool.PoolTargetOutputReference), fullyQualifiedName: "libvirt.pool.PoolTargetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PoolTargetOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PoolTargetOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PoolTargetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PoolTargetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.pool.PoolTargetEncryption\"}}]")]
        public virtual void PutEncryption(libvirt.Pool.IPoolTargetEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Pool.IPoolTargetEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPermissions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.pool.PoolTargetPermissions\"}}]")]
        public virtual void PutPermissions(libvirt.Pool.IPoolTargetPermissions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Pool.IPoolTargetPermissions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimestamps", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.pool.PoolTargetTimestamps\"}}]")]
        public virtual void PutTimestamps(libvirt.Pool.IPoolTargetTimestamps @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Pool.IPoolTargetTimestamps)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEncryption")]
        public virtual void ResetEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPath")]
        public virtual void ResetPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPermissions")]
        public virtual void ResetPermissions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimestamps")]
        public virtual void ResetTimestamps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "encryption", typeJson: "{\"fqn\":\"libvirt.pool.PoolTargetEncryptionOutputReference\"}")]
        public virtual libvirt.Pool.PoolTargetEncryptionOutputReference Encryption
        {
            get => GetInstanceProperty<libvirt.Pool.PoolTargetEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "permissions", typeJson: "{\"fqn\":\"libvirt.pool.PoolTargetPermissionsOutputReference\"}")]
        public virtual libvirt.Pool.PoolTargetPermissionsOutputReference Permissions
        {
            get => GetInstanceProperty<libvirt.Pool.PoolTargetPermissionsOutputReference>()!;
        }

        [JsiiProperty(name: "timestamps", typeJson: "{\"fqn\":\"libvirt.pool.PoolTargetTimestampsOutputReference\"}")]
        public virtual libvirt.Pool.PoolTargetTimestampsOutputReference Timestamps
        {
            get => GetInstanceProperty<libvirt.Pool.PoolTargetTimestampsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolTargetEncryption\"}]}}", isOptional: true)]
        public virtual object? EncryptionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "permissionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolTargetPermissions\"}]}}", isOptional: true)]
        public virtual object? PermissionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timestampsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolTargetTimestamps\"}]}}", isOptional: true)]
        public virtual object? TimestampsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.pool.PoolTarget\"}]}}", isOptional: true)]
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
                        case libvirt.Pool.IPoolTarget cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Pool.IPoolTarget).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
