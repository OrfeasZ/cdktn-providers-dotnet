using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.ManagedDisk
{
    [JsiiClass(nativeType: typeof(azurestack.ManagedDisk.ManagedDiskEncryptionOutputReference), fullyQualifiedName: "azurestack.managedDisk.ManagedDiskEncryptionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ManagedDiskEncryptionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ManagedDiskEncryptionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ManagedDiskEncryptionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ManagedDiskEncryptionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDiskEncryptionKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.managedDisk.ManagedDiskEncryptionDiskEncryptionKey\"}}]")]
        public virtual void PutDiskEncryptionKey(azurestack.ManagedDisk.IManagedDiskEncryptionDiskEncryptionKey @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.ManagedDisk.IManagedDiskEncryptionDiskEncryptionKey)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKeyEncryptionKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.managedDisk.ManagedDiskEncryptionKeyEncryptionKey\"}}]")]
        public virtual void PutKeyEncryptionKey(azurestack.ManagedDisk.IManagedDiskEncryptionKeyEncryptionKey @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.ManagedDisk.IManagedDiskEncryptionKeyEncryptionKey)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDiskEncryptionKey")]
        public virtual void ResetDiskEncryptionKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyEncryptionKey")]
        public virtual void ResetKeyEncryptionKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "diskEncryptionKey", typeJson: "{\"fqn\":\"azurestack.managedDisk.ManagedDiskEncryptionDiskEncryptionKeyOutputReference\"}")]
        public virtual azurestack.ManagedDisk.ManagedDiskEncryptionDiskEncryptionKeyOutputReference DiskEncryptionKey
        {
            get => GetInstanceProperty<azurestack.ManagedDisk.ManagedDiskEncryptionDiskEncryptionKeyOutputReference>()!;
        }

        [JsiiProperty(name: "keyEncryptionKey", typeJson: "{\"fqn\":\"azurestack.managedDisk.ManagedDiskEncryptionKeyEncryptionKeyOutputReference\"}")]
        public virtual azurestack.ManagedDisk.ManagedDiskEncryptionKeyEncryptionKeyOutputReference KeyEncryptionKey
        {
            get => GetInstanceProperty<azurestack.ManagedDisk.ManagedDiskEncryptionKeyEncryptionKeyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "diskEncryptionKeyInput", typeJson: "{\"fqn\":\"azurestack.managedDisk.ManagedDiskEncryptionDiskEncryptionKey\"}", isOptional: true)]
        public virtual azurestack.ManagedDisk.IManagedDiskEncryptionDiskEncryptionKey? DiskEncryptionKeyInput
        {
            get => GetInstanceProperty<azurestack.ManagedDisk.IManagedDiskEncryptionDiskEncryptionKey?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyEncryptionKeyInput", typeJson: "{\"fqn\":\"azurestack.managedDisk.ManagedDiskEncryptionKeyEncryptionKey\"}", isOptional: true)]
        public virtual azurestack.ManagedDisk.IManagedDiskEncryptionKeyEncryptionKey? KeyEncryptionKeyInput
        {
            get => GetInstanceProperty<azurestack.ManagedDisk.IManagedDiskEncryptionKeyEncryptionKey?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Enabled
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurestack.managedDisk.ManagedDiskEncryption\"}", isOptional: true)]
        public virtual azurestack.ManagedDisk.IManagedDiskEncryption? InternalValue
        {
            get => GetInstanceProperty<azurestack.ManagedDisk.IManagedDiskEncryption?>();
            set => SetInstanceProperty(value);
        }
    }
}
