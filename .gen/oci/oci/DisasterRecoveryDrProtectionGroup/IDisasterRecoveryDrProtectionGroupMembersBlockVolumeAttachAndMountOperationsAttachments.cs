using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiInterface(nativeType: typeof(IDisasterRecoveryDrProtectionGroupMembersBlockVolumeAttachAndMountOperationsAttachments), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeAttachAndMountOperationsAttachments")]
    public interface IDisasterRecoveryDrProtectionGroupMembersBlockVolumeAttachAndMountOperationsAttachments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#block_volume_id DisasterRecoveryDrProtectionGroup#block_volume_id}.</summary>
        [JsiiProperty(name: "blockVolumeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BlockVolumeId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#volume_attachment_reference_instance_id DisasterRecoveryDrProtectionGroup#volume_attachment_reference_instance_id}.</summary>
        [JsiiProperty(name: "volumeAttachmentReferenceInstanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VolumeAttachmentReferenceInstanceId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDisasterRecoveryDrProtectionGroupMembersBlockVolumeAttachAndMountOperationsAttachments), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeAttachAndMountOperationsAttachments")]
        internal sealed class _Proxy : DeputyBase, oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBlockVolumeAttachAndMountOperationsAttachments
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#block_volume_id DisasterRecoveryDrProtectionGroup#block_volume_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "blockVolumeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BlockVolumeId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#volume_attachment_reference_instance_id DisasterRecoveryDrProtectionGroup#volume_attachment_reference_instance_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "volumeAttachmentReferenceInstanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VolumeAttachmentReferenceInstanceId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
