using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlManagedInstanceStartStopSchedule
{
    [JsiiByValue(fqn: "azurerm.mssqlManagedInstanceStartStopSchedule.MssqlManagedInstanceStartStopScheduleTimeouts")]
    public class MssqlManagedInstanceStartStopScheduleTimeouts : azurerm.MssqlManagedInstanceStartStopSchedule.IMssqlManagedInstanceStartStopScheduleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_instance_start_stop_schedule#create MssqlManagedInstanceStartStopSchedule#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_instance_start_stop_schedule#delete MssqlManagedInstanceStartStopSchedule#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_instance_start_stop_schedule#read MssqlManagedInstanceStartStopSchedule#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mssql_managed_instance_start_stop_schedule#update MssqlManagedInstanceStartStopSchedule#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
