using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciStackMonitoringBaselineableMetricsEvaluate
{
    [JsiiInterface(nativeType: typeof(IDataOciStackMonitoringBaselineableMetricsEvaluateItemsTrainingDataPoints), fullyQualifiedName: "oci.dataOciStackMonitoringBaselineableMetricsEvaluate.DataOciStackMonitoringBaselineableMetricsEvaluateItemsTrainingDataPoints")]
    public interface IDataOciStackMonitoringBaselineableMetricsEvaluateItemsTrainingDataPoints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/stack_monitoring_baselineable_metrics_evaluate#timestamp DataOciStackMonitoringBaselineableMetricsEvaluate#timestamp}.</summary>
        [JsiiProperty(name: "timestamp", typeJson: "{\"primitive\":\"string\"}")]
        string Timestamp
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/stack_monitoring_baselineable_metrics_evaluate#value DataOciStackMonitoringBaselineableMetricsEvaluate#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        double Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciStackMonitoringBaselineableMetricsEvaluateItemsTrainingDataPoints), fullyQualifiedName: "oci.dataOciStackMonitoringBaselineableMetricsEvaluate.DataOciStackMonitoringBaselineableMetricsEvaluateItemsTrainingDataPoints")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciStackMonitoringBaselineableMetricsEvaluate.IDataOciStackMonitoringBaselineableMetricsEvaluateItemsTrainingDataPoints
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/stack_monitoring_baselineable_metrics_evaluate#timestamp DataOciStackMonitoringBaselineableMetricsEvaluate#timestamp}.</summary>
            [JsiiProperty(name: "timestamp", typeJson: "{\"primitive\":\"string\"}")]
            public string Timestamp
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/stack_monitoring_baselineable_metrics_evaluate#value DataOciStackMonitoringBaselineableMetricsEvaluate#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
            public double Value
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
