using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiInterface(nativeType: typeof(IDisasterRecoveryDrProtectionGroupMembersBlockVolumeAttachAndMountOperationsMounts), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeAttachAndMountOperationsMounts")]
    public interface IDisasterRecoveryDrProtectionGroupMembersBlockVolumeAttachAndMountOperationsMounts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#mount_point DisasterRecoveryDrProtectionGroup#mount_point}.</summary>
        [JsiiProperty(name: "mountPoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MountPoint
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDisasterRecoveryDrProtectionGroupMembersBlockVolumeAttachAndMountOperationsMounts), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBlockVolumeAttachAndMountOperationsMounts")]
        internal sealed class _Proxy : DeputyBase, oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBlockVolumeAttachAndMountOperationsMounts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#mount_point DisasterRecoveryDrProtectionGroup#mount_point}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mountPoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MountPoint
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
