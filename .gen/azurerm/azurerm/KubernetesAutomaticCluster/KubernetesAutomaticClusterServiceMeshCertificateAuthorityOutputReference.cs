using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesAutomaticCluster
{
    [JsiiClass(nativeType: typeof(azurerm.KubernetesAutomaticCluster.KubernetesAutomaticClusterServiceMeshCertificateAuthorityOutputReference), fullyQualifiedName: "azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterServiceMeshCertificateAuthorityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KubernetesAutomaticClusterServiceMeshCertificateAuthorityOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KubernetesAutomaticClusterServiceMeshCertificateAuthorityOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KubernetesAutomaticClusterServiceMeshCertificateAuthorityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesAutomaticClusterServiceMeshCertificateAuthorityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateChainObjectNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateChainObjectNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateObjectNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateObjectNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyObjectNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyObjectNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyVaultIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyVaultIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootCertificateObjectNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RootCertificateObjectNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "certificateChainObjectName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateChainObjectName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificateObjectName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateObjectName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyObjectName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyObjectName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyVaultId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rootCertificateObjectName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootCertificateObjectName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterServiceMeshCertificateAuthority\"}", isOptional: true)]
        public virtual azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterServiceMeshCertificateAuthority? InternalValue
        {
            get => GetInstanceProperty<azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterServiceMeshCertificateAuthority?>();
            set => SetInstanceProperty(value);
        }
    }
}
