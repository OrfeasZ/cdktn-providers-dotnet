using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsVault
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.kmsVault.KmsVaultExternalKeyManagerMetadata")]
    public class KmsVaultExternalKeyManagerMetadata : oci.KmsVault.IKmsVaultExternalKeyManagerMetadata
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#external_vault_endpoint_url KmsVault#external_vault_endpoint_url}.</summary>
        [JsiiProperty(name: "externalVaultEndpointUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string ExternalVaultEndpointUrl
        {
            get;
            set;
        }

        /// <summary>oauth_metadata block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#oauth_metadata KmsVault#oauth_metadata}
        /// </remarks>
        [JsiiProperty(name: "oauthMetadata", typeJson: "{\"fqn\":\"oci.kmsVault.KmsVaultExternalKeyManagerMetadataOauthMetadata\"}")]
        public oci.KmsVault.IKmsVaultExternalKeyManagerMetadataOauthMetadata OauthMetadata
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#private_endpoint_id KmsVault#private_endpoint_id}.</summary>
        [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public string PrivateEndpointId
        {
            get;
            set;
        }
    }
}
