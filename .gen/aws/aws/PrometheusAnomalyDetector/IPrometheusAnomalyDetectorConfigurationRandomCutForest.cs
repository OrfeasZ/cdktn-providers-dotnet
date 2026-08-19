using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusAnomalyDetector
{
    [JsiiInterface(nativeType: typeof(IPrometheusAnomalyDetectorConfigurationRandomCutForest), fullyQualifiedName: "aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForest")]
    public interface IPrometheusAnomalyDetectorConfigurationRandomCutForest
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/prometheus_anomaly_detector#query PrometheusAnomalyDetector#query}.</summary>
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        string Query
        {
            get;
        }

        /// <summary>ignore_near_expected_from_above block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/prometheus_anomaly_detector#ignore_near_expected_from_above PrometheusAnomalyDetector#ignore_near_expected_from_above}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAbove" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ignoreNearExpectedFromAbove", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAbove\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IgnoreNearExpectedFromAbove
        {
            get
            {
                return null;
            }
        }

        /// <summary>ignore_near_expected_from_below block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/prometheus_anomaly_detector#ignore_near_expected_from_below PrometheusAnomalyDetector#ignore_near_expected_from_below}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelow" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ignoreNearExpectedFromBelow", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelow\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IgnoreNearExpectedFromBelow
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/prometheus_anomaly_detector#sample_size PrometheusAnomalyDetector#sample_size}.</summary>
        [JsiiProperty(name: "sampleSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SampleSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/prometheus_anomaly_detector#shingle_size PrometheusAnomalyDetector#shingle_size}.</summary>
        [JsiiProperty(name: "shingleSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ShingleSize
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPrometheusAnomalyDetectorConfigurationRandomCutForest), fullyQualifiedName: "aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForest")]
        internal sealed class _Proxy : DeputyBase, aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForest
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/prometheus_anomaly_detector#query PrometheusAnomalyDetector#query}.</summary>
            [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
            public string Query
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ignore_near_expected_from_above block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/prometheus_anomaly_detector#ignore_near_expected_from_above PrometheusAnomalyDetector#ignore_near_expected_from_above}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAbove" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ignoreNearExpectedFromAbove", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAbove\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IgnoreNearExpectedFromAbove
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ignore_near_expected_from_below block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/prometheus_anomaly_detector#ignore_near_expected_from_below PrometheusAnomalyDetector#ignore_near_expected_from_below}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelow" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ignoreNearExpectedFromBelow", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelow\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IgnoreNearExpectedFromBelow
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/prometheus_anomaly_detector#sample_size PrometheusAnomalyDetector#sample_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sampleSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SampleSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/prometheus_anomaly_detector#shingle_size PrometheusAnomalyDetector#shingle_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shingleSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ShingleSize
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
