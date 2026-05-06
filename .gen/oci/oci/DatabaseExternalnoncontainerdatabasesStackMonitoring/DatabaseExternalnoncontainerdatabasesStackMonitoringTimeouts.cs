using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExternalnoncontainerdatabasesStackMonitoring
{
    [JsiiByValue(fqn: "oci.databaseExternalnoncontainerdatabasesStackMonitoring.DatabaseExternalnoncontainerdatabasesStackMonitoringTimeouts")]
    public class DatabaseExternalnoncontainerdatabasesStackMonitoringTimeouts : oci.DatabaseExternalnoncontainerdatabasesStackMonitoring.IDatabaseExternalnoncontainerdatabasesStackMonitoringTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_externalnoncontainerdatabases_stack_monitoring#create DatabaseExternalnoncontainerdatabasesStackMonitoring#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_externalnoncontainerdatabases_stack_monitoring#delete DatabaseExternalnoncontainerdatabasesStackMonitoring#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_externalnoncontainerdatabases_stack_monitoring#update DatabaseExternalnoncontainerdatabasesStackMonitoring#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
