using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudVmCluster
{
    [JsiiByValue(fqn: "oci.databaseCloudVmCluster.DatabaseCloudVmClusterUpdateDetails")]
    public class DatabaseCloudVmClusterUpdateDetails : oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterUpdateDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_cloud_vm_cluster#update_action DatabaseCloudVmCluster#update_action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "updateAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpdateAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_cloud_vm_cluster#update_id DatabaseCloudVmCluster#update_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "updateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpdateId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_cloud_vm_cluster#update_mode DatabaseCloudVmCluster#update_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "updateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpdateMode
        {
            get;
            set;
        }
    }
}
