using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement
{
    [JsiiInterface(nativeType: typeof(IBudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts), fullyQualifiedName: "oci.budgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts")]
    public interface IBudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/budget_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#create BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/budget_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#delete BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/budget_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#update BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts), fullyQualifiedName: "oci.budgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.IBudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/budget_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#create BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/budget_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#delete BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/budget_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#update BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
