using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DemandSignalOccMetricAlarm
{
    [JsiiByValue(fqn: "oci.demandSignalOccMetricAlarm.DemandSignalOccMetricAlarmTimeouts")]
    public class DemandSignalOccMetricAlarmTimeouts : oci.DemandSignalOccMetricAlarm.IDemandSignalOccMetricAlarmTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/demand_signal_occ_metric_alarm#create DemandSignalOccMetricAlarm#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/demand_signal_occ_metric_alarm#delete DemandSignalOccMetricAlarm#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/demand_signal_occ_metric_alarm#update DemandSignalOccMetricAlarm#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
