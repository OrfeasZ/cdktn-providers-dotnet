using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousVmClusterKmsManagement
{
    [JsiiByValue(fqn: "oci.databaseAutonomousVmClusterKmsManagement.DatabaseAutonomousVmClusterKmsManagementTimeouts")]
    public class DatabaseAutonomousVmClusterKmsManagementTimeouts : oci.DatabaseAutonomousVmClusterKmsManagement.IDatabaseAutonomousVmClusterKmsManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/database_autonomous_vm_cluster_kms_management#create DatabaseAutonomousVmClusterKmsManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/database_autonomous_vm_cluster_kms_management#delete DatabaseAutonomousVmClusterKmsManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/database_autonomous_vm_cluster_kms_management#update DatabaseAutonomousVmClusterKmsManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
