using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusAnomalyDetector
{
    [JsiiByValue(fqn: "aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfiguration")]
    public class PrometheusAnomalyDetectorConfiguration : aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfiguration
    {
        private object? _randomCutForest;

        /// <summary>random_cut_forest block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/prometheus_anomaly_detector#random_cut_forest PrometheusAnomalyDetector#random_cut_forest}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForest" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "randomCutForest", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForest\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RandomCutForest
        {
            get => _randomCutForest;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForest[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForest).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _randomCutForest = value;
            }
        }
    }
}
