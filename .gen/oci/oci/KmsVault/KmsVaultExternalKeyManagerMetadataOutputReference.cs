using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsVault
{
    [JsiiClass(nativeType: typeof(oci.KmsVault.KmsVaultExternalKeyManagerMetadataOutputReference), fullyQualifiedName: "oci.kmsVault.KmsVaultExternalKeyManagerMetadataOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KmsVaultExternalKeyManagerMetadataOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KmsVaultExternalKeyManagerMetadataOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KmsVaultExternalKeyManagerMetadataOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KmsVaultExternalKeyManagerMetadataOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOauthMetadata", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.kmsVault.KmsVaultExternalKeyManagerMetadataOauthMetadata\"}}]")]
        public virtual void PutOauthMetadata(oci.KmsVault.IKmsVaultExternalKeyManagerMetadataOauthMetadata @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.KmsVault.IKmsVaultExternalKeyManagerMetadataOauthMetadata)}, new object[]{@value});
        }

        [JsiiProperty(name: "oauthMetadata", typeJson: "{\"fqn\":\"oci.kmsVault.KmsVaultExternalKeyManagerMetadataOauthMetadataOutputReference\"}")]
        public virtual oci.KmsVault.KmsVaultExternalKeyManagerMetadataOauthMetadataOutputReference OauthMetadata
        {
            get => GetInstanceProperty<oci.KmsVault.KmsVaultExternalKeyManagerMetadataOauthMetadataOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalVaultEndpointUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExternalVaultEndpointUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oauthMetadataInput", typeJson: "{\"fqn\":\"oci.kmsVault.KmsVaultExternalKeyManagerMetadataOauthMetadata\"}", isOptional: true)]
        public virtual oci.KmsVault.IKmsVaultExternalKeyManagerMetadataOauthMetadata? OauthMetadataInput
        {
            get => GetInstanceProperty<oci.KmsVault.IKmsVaultExternalKeyManagerMetadataOauthMetadata?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateEndpointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivateEndpointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "externalVaultEndpointUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalVaultEndpointUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateEndpointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.kmsVault.KmsVaultExternalKeyManagerMetadata\"}", isOptional: true)]
        public virtual oci.KmsVault.IKmsVaultExternalKeyManagerMetadata? InternalValue
        {
            get => GetInstanceProperty<oci.KmsVault.IKmsVaultExternalKeyManagerMetadata?>();
            set => SetInstanceProperty(value);
        }
    }
}
