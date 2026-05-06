using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceIdentityConfiguration
{
    [JsiiInterface(nativeType: typeof(IBdsBdsInstanceIdentityConfigurationUpstConfigurationDetails), fullyQualifiedName: "oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationUpstConfigurationDetails")]
    public interface IBdsBdsInstanceIdentityConfigurationUpstConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#master_encryption_key_id BdsBdsInstanceIdentityConfiguration#master_encryption_key_id}.</summary>
        [JsiiProperty(name: "masterEncryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MasterEncryptionKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#vault_id BdsBdsInstanceIdentityConfiguration#vault_id}.</summary>
        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VaultId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsBdsInstanceIdentityConfigurationUpstConfigurationDetails), fullyQualifiedName: "oci.bdsBdsInstanceIdentityConfiguration.BdsBdsInstanceIdentityConfigurationUpstConfigurationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.BdsBdsInstanceIdentityConfiguration.IBdsBdsInstanceIdentityConfigurationUpstConfigurationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#master_encryption_key_id BdsBdsInstanceIdentityConfiguration#master_encryption_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "masterEncryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MasterEncryptionKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_identity_configuration#vault_id BdsBdsInstanceIdentityConfiguration#vault_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VaultId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
