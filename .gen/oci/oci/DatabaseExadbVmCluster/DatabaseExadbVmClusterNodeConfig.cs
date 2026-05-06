using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExadbVmCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseExadbVmCluster.DatabaseExadbVmClusterNodeConfig")]
    public class DatabaseExadbVmClusterNodeConfig : oci.DatabaseExadbVmCluster.IDatabaseExadbVmClusterNodeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadb_vm_cluster#enabled_ecpu_count_per_node DatabaseExadbVmCluster#enabled_ecpu_count_per_node}.</summary>
        [JsiiProperty(name: "enabledEcpuCountPerNode", typeJson: "{\"primitive\":\"number\"}")]
        public double EnabledEcpuCountPerNode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadb_vm_cluster#total_ecpu_count_per_node DatabaseExadbVmCluster#total_ecpu_count_per_node}.</summary>
        [JsiiProperty(name: "totalEcpuCountPerNode", typeJson: "{\"primitive\":\"number\"}")]
        public double TotalEcpuCountPerNode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadb_vm_cluster#vm_file_system_storage_size_gbs_per_node DatabaseExadbVmCluster#vm_file_system_storage_size_gbs_per_node}.</summary>
        [JsiiProperty(name: "vmFileSystemStorageSizeGbsPerNode", typeJson: "{\"primitive\":\"number\"}")]
        public double VmFileSystemStorageSizeGbsPerNode
        {
            get;
            set;
        }
    }
}
