using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementTaskRecord
{
    [JsiiByValue(fqn: "oci.fleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetailsVariablesInputVariables")]
    public class FleetAppsManagementTaskRecordDetailsExecutionDetailsVariablesInputVariables : oci.FleetAppsManagementTaskRecord.IFleetAppsManagementTaskRecordDetailsExecutionDetailsVariablesInputVariables
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_task_record#description FleetAppsManagementTaskRecord#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_task_record#name FleetAppsManagementTaskRecord#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_task_record#type FleetAppsManagementTaskRecord#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
