using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppEnvironmentCertificate
{
    [JsiiClass(nativeType: typeof(azurerm.ContainerAppEnvironmentCertificate.ContainerAppEnvironmentCertificateCertificateKeyVaultOutputReference), fullyQualifiedName: "azurerm.containerAppEnvironmentCertificate.ContainerAppEnvironmentCertificateCertificateKeyVaultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ContainerAppEnvironmentCertificateCertificateKeyVaultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ContainerAppEnvironmentCertificateCertificateKeyVaultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ContainerAppEnvironmentCertificateCertificateKeyVaultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerAppEnvironmentCertificateCertificateKeyVaultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetIdentity")]
        public virtual void ResetIdentity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyVaultSecretIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyVaultSecretIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "identity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Identity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyVaultSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyVaultSecretId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.containerAppEnvironmentCertificate.ContainerAppEnvironmentCertificateCertificateKeyVault\"}", isOptional: true)]
        public virtual azurerm.ContainerAppEnvironmentCertificate.IContainerAppEnvironmentCertificateCertificateKeyVault? InternalValue
        {
            get => GetInstanceProperty<azurerm.ContainerAppEnvironmentCertificate.IContainerAppEnvironmentCertificateCertificateKeyVault?>();
            set => SetInstanceProperty(value);
        }
    }
}
