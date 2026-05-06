using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalDbSystemStackMonitoringsManagement
{
    [JsiiByValue(fqn: "oci.databaseManagementExternalDbSystemStackMonitoringsManagement.DatabaseManagementExternalDbSystemStackMonitoringsManagementTimeouts")]
    public class DatabaseManagementExternalDbSystemStackMonitoringsManagementTimeouts : oci.DatabaseManagementExternalDbSystemStackMonitoringsManagement.IDatabaseManagementExternalDbSystemStackMonitoringsManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_stack_monitorings_management#create DatabaseManagementExternalDbSystemStackMonitoringsManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_stack_monitorings_management#delete DatabaseManagementExternalDbSystemStackMonitoringsManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_stack_monitorings_management#update DatabaseManagementExternalDbSystemStackMonitoringsManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
