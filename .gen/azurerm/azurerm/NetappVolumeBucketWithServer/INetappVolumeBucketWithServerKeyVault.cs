using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeBucketWithServer
{
    [JsiiInterface(nativeType: typeof(INetappVolumeBucketWithServerKeyVault), fullyQualifiedName: "azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerKeyVault")]
    public interface INetappVolumeBucketWithServerKeyVault
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/netapp_volume_bucket_with_server#certificate_key_vault_uri NetappVolumeBucketWithServer#certificate_key_vault_uri}.</summary>
        [JsiiProperty(name: "certificateKeyVaultUri", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateKeyVaultUri
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/netapp_volume_bucket_with_server#certificate_name NetappVolumeBucketWithServer#certificate_name}.</summary>
        [JsiiProperty(name: "certificateName", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/netapp_volume_bucket_with_server#credentials_key_vault_uri NetappVolumeBucketWithServer#credentials_key_vault_uri}.</summary>
        [JsiiProperty(name: "credentialsKeyVaultUri", typeJson: "{\"primitive\":\"string\"}")]
        string CredentialsKeyVaultUri
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/netapp_volume_bucket_with_server#credentials_secret_name NetappVolumeBucketWithServer#credentials_secret_name}.</summary>
        [JsiiProperty(name: "credentialsSecretName", typeJson: "{\"primitive\":\"string\"}")]
        string CredentialsSecretName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetappVolumeBucketWithServerKeyVault), fullyQualifiedName: "azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerKeyVault")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerKeyVault
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/netapp_volume_bucket_with_server#certificate_key_vault_uri NetappVolumeBucketWithServer#certificate_key_vault_uri}.</summary>
            [JsiiProperty(name: "certificateKeyVaultUri", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateKeyVaultUri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/netapp_volume_bucket_with_server#certificate_name NetappVolumeBucketWithServer#certificate_name}.</summary>
            [JsiiProperty(name: "certificateName", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/netapp_volume_bucket_with_server#credentials_key_vault_uri NetappVolumeBucketWithServer#credentials_key_vault_uri}.</summary>
            [JsiiProperty(name: "credentialsKeyVaultUri", typeJson: "{\"primitive\":\"string\"}")]
            public string CredentialsKeyVaultUri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/netapp_volume_bucket_with_server#credentials_secret_name NetappVolumeBucketWithServer#credentials_secret_name}.</summary>
            [JsiiProperty(name: "credentialsSecretName", typeJson: "{\"primitive\":\"string\"}")]
            public string CredentialsSecretName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
