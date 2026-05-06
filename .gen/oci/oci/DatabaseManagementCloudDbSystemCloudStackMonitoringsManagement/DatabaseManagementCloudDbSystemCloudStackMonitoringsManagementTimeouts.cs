using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementCloudDbSystemCloudStackMonitoringsManagement
{
    [JsiiByValue(fqn: "oci.databaseManagementCloudDbSystemCloudStackMonitoringsManagement.DatabaseManagementCloudDbSystemCloudStackMonitoringsManagementTimeouts")]
    public class DatabaseManagementCloudDbSystemCloudStackMonitoringsManagementTimeouts : oci.DatabaseManagementCloudDbSystemCloudStackMonitoringsManagement.IDatabaseManagementCloudDbSystemCloudStackMonitoringsManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_stack_monitorings_management#create DatabaseManagementCloudDbSystemCloudStackMonitoringsManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_stack_monitorings_management#delete DatabaseManagementCloudDbSystemCloudStackMonitoringsManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_stack_monitorings_management#update DatabaseManagementCloudDbSystemCloudStackMonitoringsManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
