using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsVaultReplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.kmsVaultReplication.KmsVaultReplicationReplicaVaultMetadata")]
    public class KmsVaultReplicationReplicaVaultMetadata : oci.KmsVaultReplication.IKmsVaultReplicationReplicaVaultMetadata
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault_replication#idcs_account_name_url KmsVaultReplication#idcs_account_name_url}.</summary>
        [JsiiProperty(name: "idcsAccountNameUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string IdcsAccountNameUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault_replication#private_endpoint_id KmsVaultReplication#private_endpoint_id}.</summary>
        [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public string PrivateEndpointId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault_replication#vault_type KmsVaultReplication#vault_type}.</summary>
        [JsiiProperty(name: "vaultType", typeJson: "{\"primitive\":\"string\"}")]
        public string VaultType
        {
            get;
            set;
        }
    }
}
