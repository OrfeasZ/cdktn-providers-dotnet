using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceIdentityConfiguration
{
    [JsiiByValue(fqn: "oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationUpstConfigurationDetails")]
    public class BdsBdsInstanceIdentityConfigurationUpstConfigurationDetails : oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationUpstConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#master_encryption_key_id BdsBdsInstanceIdentityConfiguration#master_encryption_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "masterEncryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MasterEncryptionKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#vault_id BdsBdsInstanceIdentityConfiguration#vault_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VaultId
        {
            get;
            set;
        }
    }
}
