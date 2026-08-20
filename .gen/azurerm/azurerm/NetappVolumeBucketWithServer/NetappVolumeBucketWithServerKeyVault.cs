using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeBucketWithServer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerKeyVault")]
    public class NetappVolumeBucketWithServerKeyVault : azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerKeyVault
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/netapp_volume_bucket_with_server#certificate_key_vault_uri NetappVolumeBucketWithServer#certificate_key_vault_uri}.</summary>
        [JsiiProperty(name: "certificateKeyVaultUri", typeJson: "{\"primitive\":\"string\"}")]
        public string CertificateKeyVaultUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/netapp_volume_bucket_with_server#certificate_name NetappVolumeBucketWithServer#certificate_name}.</summary>
        [JsiiProperty(name: "certificateName", typeJson: "{\"primitive\":\"string\"}")]
        public string CertificateName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/netapp_volume_bucket_with_server#credentials_key_vault_uri NetappVolumeBucketWithServer#credentials_key_vault_uri}.</summary>
        [JsiiProperty(name: "credentialsKeyVaultUri", typeJson: "{\"primitive\":\"string\"}")]
        public string CredentialsKeyVaultUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/netapp_volume_bucket_with_server#credentials_secret_name NetappVolumeBucketWithServer#credentials_secret_name}.</summary>
        [JsiiProperty(name: "credentialsSecretName", typeJson: "{\"primitive\":\"string\"}")]
        public string CredentialsSecretName
        {
            get;
            set;
        }
    }
}
