using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseVmCluster
{
    [JsiiByValue(fqn: "oci.databaseVmCluster.DatabaseVmClusterUpdateDetails")]
    public class DatabaseVmClusterUpdateDetails : oci.DatabaseVmCluster.IDatabaseVmClusterUpdateDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_vm_cluster#update_action DatabaseVmCluster#update_action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "updateAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpdateAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_vm_cluster#update_id DatabaseVmCluster#update_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "updateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpdateId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/database_vm_cluster#update_mode DatabaseVmCluster#update_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "updateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpdateMode
        {
            get;
            set;
        }
    }
}
