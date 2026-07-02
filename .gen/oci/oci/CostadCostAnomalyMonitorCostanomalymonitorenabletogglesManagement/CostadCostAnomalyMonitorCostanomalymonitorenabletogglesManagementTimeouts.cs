using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CostadCostAnomalyMonitorCostanomalymonitorenabletogglesManagement
{
    [JsiiByValue(fqn: "oci.costadCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.CostadCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts")]
    public class CostadCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts : oci.CostadCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.ICostadCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/costad_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#create CostadCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/costad_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#delete CostadCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/costad_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#update CostadCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
