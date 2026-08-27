using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeBucket
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.netappVolumeBucket.NetappVolumeBucketKeyVault")]
    public class NetappVolumeBucketKeyVault : azurerm.NetappVolumeBucket.INetappVolumeBucketKeyVault
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_bucket#certificate_key_vault_uri NetappVolumeBucket#certificate_key_vault_uri}.</summary>
        [JsiiProperty(name: "certificateKeyVaultUri", typeJson: "{\"primitive\":\"string\"}")]
        public string CertificateKeyVaultUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_bucket#certificate_name NetappVolumeBucket#certificate_name}.</summary>
        [JsiiProperty(name: "certificateName", typeJson: "{\"primitive\":\"string\"}")]
        public string CertificateName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_bucket#credentials_key_vault_uri NetappVolumeBucket#credentials_key_vault_uri}.</summary>
        [JsiiProperty(name: "credentialsKeyVaultUri", typeJson: "{\"primitive\":\"string\"}")]
        public string CredentialsKeyVaultUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/netapp_volume_bucket#credentials_secret_name NetappVolumeBucket#credentials_secret_name}.</summary>
        [JsiiProperty(name: "credentialsSecretName", typeJson: "{\"primitive\":\"string\"}")]
        public string CredentialsSecretName
        {
            get;
            set;
        }
    }
}
