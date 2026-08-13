using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusAnomalyDetector
{
    [JsiiInterface(nativeType: typeof(IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelow), fullyQualifiedName: "aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelow")]
    public interface IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/prometheus_anomaly_detector#amount PrometheusAnomalyDetector#amount}.</summary>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Amount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/prometheus_anomaly_detector#ratio PrometheusAnomalyDetector#ratio}.</summary>
        [JsiiProperty(name: "ratio", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Ratio
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelow), fullyQualifiedName: "aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelow")]
        internal sealed class _Proxy : DeputyBase, aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/prometheus_anomaly_detector#amount PrometheusAnomalyDetector#amount}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Amount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/prometheus_anomaly_detector#ratio PrometheusAnomalyDetector#ratio}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ratio", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Ratio
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
