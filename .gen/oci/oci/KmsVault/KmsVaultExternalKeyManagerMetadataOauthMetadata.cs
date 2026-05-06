using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsVault
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.kmsVault.KmsVaultExternalKeyManagerMetadataOauthMetadata")]
    public class KmsVaultExternalKeyManagerMetadataOauthMetadata : oci.KmsVault.IKmsVaultExternalKeyManagerMetadataOauthMetadata
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#client_app_id KmsVault#client_app_id}.</summary>
        [JsiiProperty(name: "clientAppId", typeJson: "{\"primitive\":\"string\"}")]
        public string ClientAppId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#client_app_secret KmsVault#client_app_secret}.</summary>
        [JsiiProperty(name: "clientAppSecret", typeJson: "{\"primitive\":\"string\"}")]
        public string ClientAppSecret
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#idcs_account_name_url KmsVault#idcs_account_name_url}.</summary>
        [JsiiProperty(name: "idcsAccountNameUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string IdcsAccountNameUrl
        {
            get;
            set;
        }
    }
}
