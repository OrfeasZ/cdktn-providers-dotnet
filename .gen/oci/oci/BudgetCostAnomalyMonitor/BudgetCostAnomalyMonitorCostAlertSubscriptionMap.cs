using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BudgetCostAnomalyMonitor
{
    [JsiiByValue(fqn: "oci.budgetCostAnomalyMonitor.BudgetCostAnomalyMonitorCostAlertSubscriptionMap")]
    public class BudgetCostAnomalyMonitorCostAlertSubscriptionMap : oci.BudgetCostAnomalyMonitor.IBudgetCostAnomalyMonitorCostAlertSubscriptionMap
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/budget_cost_anomaly_monitor#cost_alert_subscription_id BudgetCostAnomalyMonitor#cost_alert_subscription_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "costAlertSubscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CostAlertSubscriptionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/budget_cost_anomaly_monitor#operator BudgetCostAnomalyMonitor#operator}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Operator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/budget_cost_anomaly_monitor#threshold_absolute_value BudgetCostAnomalyMonitor#threshold_absolute_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "thresholdAbsoluteValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThresholdAbsoluteValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/budget_cost_anomaly_monitor#threshold_relative_percent BudgetCostAnomalyMonitor#threshold_relative_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "thresholdRelativePercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThresholdRelativePercent
        {
            get;
            set;
        }
    }
}
