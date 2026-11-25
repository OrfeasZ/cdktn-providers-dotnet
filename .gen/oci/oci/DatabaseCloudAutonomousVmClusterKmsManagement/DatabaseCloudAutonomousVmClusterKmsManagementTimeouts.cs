using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudAutonomousVmClusterKmsManagement
{
    [JsiiByValue(fqn: "oci.databaseCloudAutonomousVmClusterKmsManagement.DatabaseCloudAutonomousVmClusterKmsManagementTimeouts")]
    public class DatabaseCloudAutonomousVmClusterKmsManagementTimeouts : oci.DatabaseCloudAutonomousVmClusterKmsManagement.IDatabaseCloudAutonomousVmClusterKmsManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/database_cloud_autonomous_vm_cluster_kms_management#create DatabaseCloudAutonomousVmClusterKmsManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/database_cloud_autonomous_vm_cluster_kms_management#delete DatabaseCloudAutonomousVmClusterKmsManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/database_cloud_autonomous_vm_cluster_kms_management#update DatabaseCloudAutonomousVmClusterKmsManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
