using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVolumeBackupPolicyAssignment
{
    [JsiiByValue(fqn: "oci.coreVolumeBackupPolicyAssignment.CoreVolumeBackupPolicyAssignmentTimeouts")]
    public class CoreVolumeBackupPolicyAssignmentTimeouts : oci.CoreVolumeBackupPolicyAssignment.ICoreVolumeBackupPolicyAssignmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_backup_policy_assignment#create CoreVolumeBackupPolicyAssignment#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_backup_policy_assignment#delete CoreVolumeBackupPolicyAssignment#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume_backup_policy_assignment#update CoreVolumeBackupPolicyAssignment#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
