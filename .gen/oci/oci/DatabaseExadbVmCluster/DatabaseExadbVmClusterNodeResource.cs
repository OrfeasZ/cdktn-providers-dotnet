using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExadbVmCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseExadbVmCluster.DatabaseExadbVmClusterNodeResource")]
    public class DatabaseExadbVmClusterNodeResource : oci.DatabaseExadbVmCluster.IDatabaseExadbVmClusterNodeResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadb_vm_cluster#node_name DatabaseExadbVmCluster#node_name}.</summary>
        [JsiiProperty(name: "nodeName", typeJson: "{\"primitive\":\"string\"}")]
        public string NodeName
        {
            get;
            set;
        }
    }
}
