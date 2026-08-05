using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DemandSignalOccMetricAlarm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.demandSignalOccMetricAlarm.DemandSignalOccMetricAlarmResourceConfiguration")]
    public class DemandSignalOccMetricAlarmResourceConfiguration : oci.DemandSignalOccMetricAlarm.IDemandSignalOccMetricAlarmResourceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/demand_signal_occ_metric_alarm#resource DemandSignalOccMetricAlarm#resource}.</summary>
        [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}")]
        public string Resource
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/demand_signal_occ_metric_alarm#usage_type DemandSignalOccMetricAlarm#usage_type}.</summary>
        [JsiiProperty(name: "usageType", typeJson: "{\"primitive\":\"string\"}")]
        public string UsageType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/demand_signal_occ_metric_alarm#compute_hw_generation DemandSignalOccMetricAlarm#compute_hw_generation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "computeHwGeneration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ComputeHwGeneration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/demand_signal_occ_metric_alarm#hw_generation DemandSignalOccMetricAlarm#hw_generation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hwGeneration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HwGeneration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/demand_signal_occ_metric_alarm#link_role DemandSignalOccMetricAlarm#link_role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "linkRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LinkRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/demand_signal_occ_metric_alarm#node_type DemandSignalOccMetricAlarm#node_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NodeType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/demand_signal_occ_metric_alarm#occ_metric_alarm_provider DemandSignalOccMetricAlarm#occ_metric_alarm_provider}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "occMetricAlarmProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OccMetricAlarmProvider
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/demand_signal_occ_metric_alarm#shape DemandSignalOccMetricAlarm#shape}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Shape
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/demand_signal_occ_metric_alarm#storage_type DemandSignalOccMetricAlarm#storage_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageType
        {
            get;
            set;
        }
    }
}
