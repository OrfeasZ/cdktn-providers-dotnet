using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BudgetCostAnomalyMonitor
{
    [JsiiInterface(nativeType: typeof(IBudgetCostAnomalyMonitorCostAlertSubscriptionMap), fullyQualifiedName: "oci.budgetCostAnomalyMonitor.BudgetCostAnomalyMonitorCostAlertSubscriptionMap")]
    public interface IBudgetCostAnomalyMonitorCostAlertSubscriptionMap
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/budget_cost_anomaly_monitor#cost_alert_subscription_id BudgetCostAnomalyMonitor#cost_alert_subscription_id}.</summary>
        [JsiiProperty(name: "costAlertSubscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CostAlertSubscriptionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/budget_cost_anomaly_monitor#operator BudgetCostAnomalyMonitor#operator}.</summary>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Operator
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/budget_cost_anomaly_monitor#threshold_absolute_value BudgetCostAnomalyMonitor#threshold_absolute_value}.</summary>
        [JsiiProperty(name: "thresholdAbsoluteValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThresholdAbsoluteValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/budget_cost_anomaly_monitor#threshold_relative_percent BudgetCostAnomalyMonitor#threshold_relative_percent}.</summary>
        [JsiiProperty(name: "thresholdRelativePercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThresholdRelativePercent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBudgetCostAnomalyMonitorCostAlertSubscriptionMap), fullyQualifiedName: "oci.budgetCostAnomalyMonitor.BudgetCostAnomalyMonitorCostAlertSubscriptionMap")]
        internal sealed class _Proxy : DeputyBase, oci.BudgetCostAnomalyMonitor.IBudgetCostAnomalyMonitorCostAlertSubscriptionMap
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/budget_cost_anomaly_monitor#cost_alert_subscription_id BudgetCostAnomalyMonitor#cost_alert_subscription_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "costAlertSubscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CostAlertSubscriptionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/budget_cost_anomaly_monitor#operator BudgetCostAnomalyMonitor#operator}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Operator
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/budget_cost_anomaly_monitor#threshold_absolute_value BudgetCostAnomalyMonitor#threshold_absolute_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "thresholdAbsoluteValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThresholdAbsoluteValue
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/budget_cost_anomaly_monitor#threshold_relative_percent BudgetCostAnomalyMonitor#threshold_relative_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "thresholdRelativePercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThresholdRelativePercent
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
