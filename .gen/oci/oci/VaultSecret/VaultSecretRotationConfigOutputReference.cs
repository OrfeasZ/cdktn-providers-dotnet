using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VaultSecret
{
    [JsiiClass(nativeType: typeof(oci.VaultSecret.VaultSecretRotationConfigOutputReference), fullyQualifiedName: "oci.vaultSecret.VaultSecretRotationConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VaultSecretRotationConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VaultSecretRotationConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VaultSecretRotationConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VaultSecretRotationConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTargetSystemDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.vaultSecret.VaultSecretRotationConfigTargetSystemDetails\"}}]")]
        public virtual void PutTargetSystemDetails(oci.VaultSecret.IVaultSecretRotationConfigTargetSystemDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.VaultSecret.IVaultSecretRotationConfigTargetSystemDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetIsScheduledRotationEnabled")]
        public virtual void ResetIsScheduledRotationEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRotationInterval")]
        public virtual void ResetRotationInterval()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "targetSystemDetails", typeJson: "{\"fqn\":\"oci.vaultSecret.VaultSecretRotationConfigTargetSystemDetailsOutputReference\"}")]
        public virtual oci.VaultSecret.VaultSecretRotationConfigTargetSystemDetailsOutputReference TargetSystemDetails
        {
            get => GetInstanceProperty<oci.VaultSecret.VaultSecretRotationConfigTargetSystemDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "isScheduledRotationEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsScheduledRotationEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rotationIntervalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RotationIntervalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetSystemDetailsInput", typeJson: "{\"fqn\":\"oci.vaultSecret.VaultSecretRotationConfigTargetSystemDetails\"}", isOptional: true)]
        public virtual oci.VaultSecret.IVaultSecretRotationConfigTargetSystemDetails? TargetSystemDetailsInput
        {
            get => GetInstanceProperty<oci.VaultSecret.IVaultSecretRotationConfigTargetSystemDetails?>();
        }

        [JsiiProperty(name: "isScheduledRotationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsScheduledRotationEnabled
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

        [JsiiProperty(name: "rotationInterval", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RotationInterval
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.vaultSecret.VaultSecretRotationConfig\"}", isOptional: true)]
        public virtual oci.VaultSecret.IVaultSecretRotationConfig? InternalValue
        {
            get => GetInstanceProperty<oci.VaultSecret.IVaultSecretRotationConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
