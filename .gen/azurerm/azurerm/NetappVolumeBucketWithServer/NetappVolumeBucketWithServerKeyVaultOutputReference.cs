using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeBucketWithServer
{
    [JsiiClass(nativeType: typeof(azurerm.NetappVolumeBucketWithServer.NetappVolumeBucketWithServerKeyVaultOutputReference), fullyQualifiedName: "azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerKeyVaultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class NetappVolumeBucketWithServerKeyVaultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public NetappVolumeBucketWithServerKeyVaultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected NetappVolumeBucketWithServerKeyVaultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetappVolumeBucketWithServerKeyVaultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateKeyVaultUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateKeyVaultUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialsKeyVaultUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CredentialsKeyVaultUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialsSecretNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CredentialsSecretNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "certificateKeyVaultUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateKeyVaultUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificateName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "credentialsKeyVaultUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CredentialsKeyVaultUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "credentialsSecretName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CredentialsSecretName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerKeyVault\"}", isOptional: true)]
        public virtual azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerKeyVault? InternalValue
        {
            get => GetInstanceProperty<azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerKeyVault?>();
            set => SetInstanceProperty(value);
        }
    }
}
