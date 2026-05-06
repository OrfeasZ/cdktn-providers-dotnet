using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiInterface(nativeType: typeof(IDisasterRecoveryDrProtectionGroupMembersFileSystemOperations), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperations")]
    public interface IDisasterRecoveryDrProtectionGroupMembersFileSystemOperations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#export_path DisasterRecoveryDrProtectionGroup#export_path}.</summary>
        [JsiiProperty(name: "exportPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExportPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>mount_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#mount_details DisasterRecoveryDrProtectionGroup#mount_details}
        /// </remarks>
        [JsiiProperty(name: "mountDetails", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsMountDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersFileSystemOperationsMountDetails? MountDetails
        {
            get
            {
                return null;
            }
        }

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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#mount_target_id DisasterRecoveryDrProtectionGroup#mount_target_id}.</summary>
        [JsiiProperty(name: "mountTargetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MountTargetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>unmount_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#unmount_details DisasterRecoveryDrProtectionGroup#unmount_details}
        /// </remarks>
        [JsiiProperty(name: "unmountDetails", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsUnmountDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersFileSystemOperationsUnmountDetails? UnmountDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDisasterRecoveryDrProtectionGroupMembersFileSystemOperations), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperations")]
        internal sealed class _Proxy : DeputyBase, oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersFileSystemOperations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#export_path DisasterRecoveryDrProtectionGroup#export_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "exportPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExportPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>mount_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#mount_details DisasterRecoveryDrProtectionGroup#mount_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mountDetails", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsMountDetails\"}", isOptional: true)]
            public oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersFileSystemOperationsMountDetails? MountDetails
            {
                get => GetInstanceProperty<oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersFileSystemOperationsMountDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#mount_point DisasterRecoveryDrProtectionGroup#mount_point}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mountPoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MountPoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#mount_target_id DisasterRecoveryDrProtectionGroup#mount_target_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mountTargetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MountTargetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>unmount_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_protection_group#unmount_details DisasterRecoveryDrProtectionGroup#unmount_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unmountDetails", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersFileSystemOperationsUnmountDetails\"}", isOptional: true)]
            public oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersFileSystemOperationsUnmountDetails? UnmountDetails
            {
                get => GetInstanceProperty<oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersFileSystemOperationsUnmountDetails?>();
            }
        }
    }
}
