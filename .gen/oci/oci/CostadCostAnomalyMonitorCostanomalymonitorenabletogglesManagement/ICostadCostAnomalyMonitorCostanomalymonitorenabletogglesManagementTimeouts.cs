using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CostadCostAnomalyMonitorCostanomalymonitorenabletogglesManagement
{
    [JsiiInterface(nativeType: typeof(ICostadCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts), fullyQualifiedName: "oci.costadCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.CostadCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts")]
    public interface ICostadCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/costad_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#create CostadCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/costad_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#delete CostadCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/costad_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#update CostadCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICostadCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts), fullyQualifiedName: "oci.costadCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.CostadCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.CostadCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.ICostadCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/costad_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#create CostadCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/costad_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#delete CostadCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/costad_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#update CostadCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
