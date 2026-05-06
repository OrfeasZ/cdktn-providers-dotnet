using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsVault
{
    [JsiiClass(nativeType: typeof(oci.KmsVault.KmsVaultExternalKeyManagerMetadataOauthMetadataOutputReference), fullyQualifiedName: "oci.kmsVault.KmsVaultExternalKeyManagerMetadataOauthMetadataOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KmsVaultExternalKeyManagerMetadataOauthMetadataOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KmsVaultExternalKeyManagerMetadataOauthMetadataOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KmsVaultExternalKeyManagerMetadataOauthMetadataOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KmsVaultExternalKeyManagerMetadataOauthMetadataOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientAppIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientAppIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientAppSecretInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientAppSecretInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idcsAccountNameUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdcsAccountNameUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "clientAppId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientAppId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientAppSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientAppSecret
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "idcsAccountNameUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsAccountNameUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.kmsVault.KmsVaultExternalKeyManagerMetadataOauthMetadata\"}", isOptional: true)]
        public virtual oci.KmsVault.IKmsVaultExternalKeyManagerMetadataOauthMetadata? InternalValue
        {
            get => GetInstanceProperty<oci.KmsVault.IKmsVaultExternalKeyManagerMetadataOauthMetadata?>();
            set => SetInstanceProperty(value);
        }
    }
}
