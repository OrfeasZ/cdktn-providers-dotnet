using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciStackMonitoringBaselineableMetricsEvaluate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataOciStackMonitoringBaselineableMetricsEvaluate.DataOciStackMonitoringBaselineableMetricsEvaluateItems")]
    public class DataOciStackMonitoringBaselineableMetricsEvaluateItems : oci.DataOciStackMonitoringBaselineableMetricsEvaluate.IDataOciStackMonitoringBaselineableMetricsEvaluateItems
    {
        private object _evaluationDataPoints;

        /// <summary>evaluation_data_points block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/stack_monitoring_baselineable_metrics_evaluate#evaluation_data_points DataOciStackMonitoringBaselineableMetricsEvaluate#evaluation_data_points}
        /// </remarks>
        [JsiiProperty(name: "evaluationDataPoints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciStackMonitoringBaselineableMetricsEvaluate.DataOciStackMonitoringBaselineableMetricsEvaluateItemsEvaluationDataPoints\"},\"kind\":\"array\"}}]}}")]
        public object EvaluationDataPoints
        {
            get => _evaluationDataPoints;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DataOciStackMonitoringBaselineableMetricsEvaluate.IDataOciStackMonitoringBaselineableMetricsEvaluateItemsEvaluationDataPoints[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciStackMonitoringBaselineableMetricsEvaluate.IDataOciStackMonitoringBaselineableMetricsEvaluateItemsEvaluationDataPoints).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciStackMonitoringBaselineableMetricsEvaluate.IDataOciStackMonitoringBaselineableMetricsEvaluateItemsEvaluationDataPoints).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _evaluationDataPoints = value;
            }
        }

        private object _trainingDataPoints;

        /// <summary>training_data_points block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/stack_monitoring_baselineable_metrics_evaluate#training_data_points DataOciStackMonitoringBaselineableMetricsEvaluate#training_data_points}
        /// </remarks>
        [JsiiProperty(name: "trainingDataPoints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciStackMonitoringBaselineableMetricsEvaluate.DataOciStackMonitoringBaselineableMetricsEvaluateItemsTrainingDataPoints\"},\"kind\":\"array\"}}]}}")]
        public object TrainingDataPoints
        {
            get => _trainingDataPoints;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DataOciStackMonitoringBaselineableMetricsEvaluate.IDataOciStackMonitoringBaselineableMetricsEvaluateItemsTrainingDataPoints[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciStackMonitoringBaselineableMetricsEvaluate.IDataOciStackMonitoringBaselineableMetricsEvaluateItemsTrainingDataPoints).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciStackMonitoringBaselineableMetricsEvaluate.IDataOciStackMonitoringBaselineableMetricsEvaluateItemsTrainingDataPoints).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _trainingDataPoints = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/stack_monitoring_baselineable_metrics_evaluate#dimensions DataOciStackMonitoringBaselineableMetricsEvaluate#dimensions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dimensions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Dimensions
        {
            get;
            set;
        }
    }
}
