using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiInterface(nativeType: typeof(IDisasterRecoveryDrProtectionGroupMembersCommonDestinationKey), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersCommonDestinationKey")]
    public interface IDisasterRecoveryDrProtectionGroupMembersCommonDestinationKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#encryption_key_id DisasterRecoveryDrProtectionGroup#encryption_key_id}.</summary>
        [JsiiProperty(name: "encryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptionKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#vault_id DisasterRecoveryDrProtectionGroup#vault_id}.</summary>
        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VaultId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDisasterRecoveryDrProtectionGroupMembersCommonDestinationKey), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersCommonDestinationKey")]
        internal sealed class _Proxy : DeputyBase, oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersCommonDestinationKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#encryption_key_id DisasterRecoveryDrProtectionGroup#encryption_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptionKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#vault_id DisasterRecoveryDrProtectionGroup#vault_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VaultId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
