using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiInterface(nativeType: typeof(IDisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappings), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappings")]
    public interface IDisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappings
    {
        /// <summary>destination_encryption_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_encryption_key DisasterRecoveryDrProtectionGroup#destination_encryption_key}
        /// </remarks>
        [JsiiProperty(name: "destinationEncryptionKey", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsDestinationEncryptionKey\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsDestinationEncryptionKey? DestinationEncryptionKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#source_volume_id DisasterRecoveryDrProtectionGroup#source_volume_id}.</summary>
        [JsiiProperty(name: "sourceVolumeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceVolumeId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappings), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappings")]
        internal sealed class _Proxy : DeputyBase, oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>destination_encryption_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#destination_encryption_key DisasterRecoveryDrProtectionGroup#destination_encryption_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "destinationEncryptionKey", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsDestinationEncryptionKey\"}", isOptional: true)]
            public oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsDestinationEncryptionKey? DestinationEncryptionKey
            {
                get => GetInstanceProperty<oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersSourceVolumeToDestinationEncryptionKeyMappingsDestinationEncryptionKey?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#source_volume_id DisasterRecoveryDrProtectionGroup#source_volume_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceVolumeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceVolumeId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
