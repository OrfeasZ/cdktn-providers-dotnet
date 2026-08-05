using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusAnomalyDetector
{
    [JsiiByValue(fqn: "aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelow")]
    public class PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelow : aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/prometheus_anomaly_detector#amount PrometheusAnomalyDetector#amount}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Amount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/prometheus_anomaly_detector#ratio PrometheusAnomalyDetector#ratio}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ratio", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Ratio
        {
            get;
            set;
        }
    }
}
