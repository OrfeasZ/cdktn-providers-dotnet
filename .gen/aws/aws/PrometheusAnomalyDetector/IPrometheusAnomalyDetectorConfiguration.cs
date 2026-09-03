using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusAnomalyDetector
{
    [JsiiInterface(nativeType: typeof(IPrometheusAnomalyDetectorConfiguration), fullyQualifiedName: "aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfiguration")]
    public interface IPrometheusAnomalyDetectorConfiguration
    {
        /// <summary>random_cut_forest block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/prometheus_anomaly_detector#random_cut_forest PrometheusAnomalyDetector#random_cut_forest}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForest" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "randomCutForest", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForest\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RandomCutForest
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPrometheusAnomalyDetectorConfiguration), fullyQualifiedName: "aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>random_cut_forest block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/prometheus_anomaly_detector#random_cut_forest PrometheusAnomalyDetector#random_cut_forest}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForest" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "randomCutForest", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForest\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RandomCutForest
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
