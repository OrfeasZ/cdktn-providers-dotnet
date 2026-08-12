using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement
{
    [JsiiByValue(fqn: "oci.budgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts")]
    public class BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts : oci.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.IBudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/budget_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#create BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/budget_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#delete BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/budget_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#update BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
