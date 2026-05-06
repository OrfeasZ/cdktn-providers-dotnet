using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudVmClusterIormConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseCloudVmClusterIormConfig.DatabaseCloudVmClusterIormConfigDbPlans")]
    public class DatabaseCloudVmClusterIormConfigDbPlans : oci.DatabaseCloudVmClusterIormConfig.IDatabaseCloudVmClusterIormConfigDbPlans
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster_iorm_config#db_name DatabaseCloudVmClusterIormConfig#db_name}.</summary>
        [JsiiProperty(name: "dbName", typeJson: "{\"primitive\":\"string\"}")]
        public string DbName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster_iorm_config#share DatabaseCloudVmClusterIormConfig#share}.</summary>
        [JsiiProperty(name: "share", typeJson: "{\"primitive\":\"number\"}")]
        public double Share
        {
            get;
            set;
        }
    }
}
