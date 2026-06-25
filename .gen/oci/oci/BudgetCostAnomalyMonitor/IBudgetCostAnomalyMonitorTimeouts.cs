using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BudgetCostAnomalyMonitor
{
    [JsiiInterface(nativeType: typeof(IBudgetCostAnomalyMonitorTimeouts), fullyQualifiedName: "oci.budgetCostAnomalyMonitor.BudgetCostAnomalyMonitorTimeouts")]
    public interface IBudgetCostAnomalyMonitorTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/budget_cost_anomaly_monitor#create BudgetCostAnomalyMonitor#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/budget_cost_anomaly_monitor#delete BudgetCostAnomalyMonitor#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/budget_cost_anomaly_monitor#update BudgetCostAnomalyMonitor#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBudgetCostAnomalyMonitorTimeouts), fullyQualifiedName: "oci.budgetCostAnomalyMonitor.BudgetCostAnomalyMonitorTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.BudgetCostAnomalyMonitor.IBudgetCostAnomalyMonitorTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/budget_cost_anomaly_monitor#create BudgetCostAnomalyMonitor#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/budget_cost_anomaly_monitor#delete BudgetCostAnomalyMonitor#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/budget_cost_anomaly_monitor#update BudgetCostAnomalyMonitor#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
