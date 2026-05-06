using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciStackMonitoringBaselineableMetricsEvaluate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataOciStackMonitoringBaselineableMetricsEvaluate.DataOciStackMonitoringBaselineableMetricsEvaluateItemsEvaluationDataPoints")]
    public class DataOciStackMonitoringBaselineableMetricsEvaluateItemsEvaluationDataPoints : oci.DataOciStackMonitoringBaselineableMetricsEvaluate.IDataOciStackMonitoringBaselineableMetricsEvaluateItemsEvaluationDataPoints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/stack_monitoring_baselineable_metrics_evaluate#timestamp DataOciStackMonitoringBaselineableMetricsEvaluate#timestamp}.</summary>
        [JsiiProperty(name: "timestamp", typeJson: "{\"primitive\":\"string\"}")]
        public string Timestamp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/stack_monitoring_baselineable_metrics_evaluate#value DataOciStackMonitoringBaselineableMetricsEvaluate#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        public double Value
        {
            get;
            set;
        }
    }
}
