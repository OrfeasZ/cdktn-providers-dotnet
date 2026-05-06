using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCrossConnect
{
    [JsiiClass(nativeType: typeof(oci.CoreCrossConnect.CoreCrossConnectMacsecPropertiesOutputReference), fullyQualifiedName: "oci.coreCrossConnect.CoreCrossConnectMacsecPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreCrossConnectMacsecPropertiesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreCrossConnectMacsecPropertiesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreCrossConnectMacsecPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreCrossConnectMacsecPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPrimaryKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreCrossConnect.CoreCrossConnectMacsecPropertiesPrimaryKey\"}}]")]
        public virtual void PutPrimaryKey(oci.CoreCrossConnect.ICoreCrossConnectMacsecPropertiesPrimaryKey @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreCrossConnect.ICoreCrossConnectMacsecPropertiesPrimaryKey)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEncryptionCipher")]
        public virtual void ResetEncryptionCipher()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsUnprotectedTrafficAllowed")]
        public virtual void ResetIsUnprotectedTrafficAllowed()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrimaryKey")]
        public virtual void ResetPrimaryKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "primaryKey", typeJson: "{\"fqn\":\"oci.coreCrossConnect.CoreCrossConnectMacsecPropertiesPrimaryKeyOutputReference\"}")]
        public virtual oci.CoreCrossConnect.CoreCrossConnectMacsecPropertiesPrimaryKeyOutputReference PrimaryKey
        {
            get => GetInstanceProperty<oci.CoreCrossConnect.CoreCrossConnectMacsecPropertiesPrimaryKeyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionCipherInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EncryptionCipherInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isUnprotectedTrafficAllowedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsUnprotectedTrafficAllowedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "primaryKeyInput", typeJson: "{\"fqn\":\"oci.coreCrossConnect.CoreCrossConnectMacsecPropertiesPrimaryKey\"}", isOptional: true)]
        public virtual oci.CoreCrossConnect.ICoreCrossConnectMacsecPropertiesPrimaryKey? PrimaryKeyInput
        {
            get => GetInstanceProperty<oci.CoreCrossConnect.ICoreCrossConnectMacsecPropertiesPrimaryKey?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "encryptionCipher", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EncryptionCipher
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isUnprotectedTrafficAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsUnprotectedTrafficAllowed
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

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreCrossConnect.CoreCrossConnectMacsecProperties\"}", isOptional: true)]
        public virtual oci.CoreCrossConnect.ICoreCrossConnectMacsecProperties? InternalValue
        {
            get => GetInstanceProperty<oci.CoreCrossConnect.ICoreCrossConnectMacsecProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
