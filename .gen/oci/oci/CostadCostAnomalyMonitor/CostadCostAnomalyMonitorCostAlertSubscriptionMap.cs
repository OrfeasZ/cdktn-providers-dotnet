using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CostadCostAnomalyMonitor
{
    [JsiiByValue(fqn: "oci.costadCostAnomalyMonitor.CostadCostAnomalyMonitorCostAlertSubscriptionMap")]
    public class CostadCostAnomalyMonitorCostAlertSubscriptionMap : oci.CostadCostAnomalyMonitor.ICostadCostAnomalyMonitorCostAlertSubscriptionMap
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/costad_cost_anomaly_monitor#cost_alert_subscription_id CostadCostAnomalyMonitor#cost_alert_subscription_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "costAlertSubscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CostAlertSubscriptionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/costad_cost_anomaly_monitor#operator CostadCostAnomalyMonitor#operator}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Operator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/costad_cost_anomaly_monitor#threshold_absolute_value CostadCostAnomalyMonitor#threshold_absolute_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "thresholdAbsoluteValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThresholdAbsoluteValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/costad_cost_anomaly_monitor#threshold_relative_percent CostadCostAnomalyMonitor#threshold_relative_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "thresholdRelativePercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThresholdRelativePercent
        {
            get;
            set;
        }
    }
}
