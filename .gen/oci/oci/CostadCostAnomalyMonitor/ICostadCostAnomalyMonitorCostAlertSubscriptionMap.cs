using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CostadCostAnomalyMonitor
{
    [JsiiInterface(nativeType: typeof(ICostadCostAnomalyMonitorCostAlertSubscriptionMap), fullyQualifiedName: "oci.costadCostAnomalyMonitor.CostadCostAnomalyMonitorCostAlertSubscriptionMap")]
    public interface ICostadCostAnomalyMonitorCostAlertSubscriptionMap
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/costad_cost_anomaly_monitor#cost_alert_subscription_id CostadCostAnomalyMonitor#cost_alert_subscription_id}.</summary>
        [JsiiProperty(name: "costAlertSubscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CostAlertSubscriptionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/costad_cost_anomaly_monitor#operator CostadCostAnomalyMonitor#operator}.</summary>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Operator
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/costad_cost_anomaly_monitor#threshold_absolute_value CostadCostAnomalyMonitor#threshold_absolute_value}.</summary>
        [JsiiProperty(name: "thresholdAbsoluteValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThresholdAbsoluteValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/costad_cost_anomaly_monitor#threshold_relative_percent CostadCostAnomalyMonitor#threshold_relative_percent}.</summary>
        [JsiiProperty(name: "thresholdRelativePercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThresholdRelativePercent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICostadCostAnomalyMonitorCostAlertSubscriptionMap), fullyQualifiedName: "oci.costadCostAnomalyMonitor.CostadCostAnomalyMonitorCostAlertSubscriptionMap")]
        internal sealed class _Proxy : DeputyBase, oci.CostadCostAnomalyMonitor.ICostadCostAnomalyMonitorCostAlertSubscriptionMap
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/costad_cost_anomaly_monitor#cost_alert_subscription_id CostadCostAnomalyMonitor#cost_alert_subscription_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "costAlertSubscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CostAlertSubscriptionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/costad_cost_anomaly_monitor#operator CostadCostAnomalyMonitor#operator}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Operator
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/costad_cost_anomaly_monitor#threshold_absolute_value CostadCostAnomalyMonitor#threshold_absolute_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "thresholdAbsoluteValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThresholdAbsoluteValue
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/costad_cost_anomaly_monitor#threshold_relative_percent CostadCostAnomalyMonitor#threshold_relative_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "thresholdRelativePercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThresholdRelativePercent
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
