using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusAnomalyDetector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForest")]
    public class PrometheusAnomalyDetectorConfigurationRandomCutForest : aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForest
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/prometheus_anomaly_detector#query PrometheusAnomalyDetector#query}.</summary>
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        public string Query
        {
            get;
            set;
        }

        private object? _ignoreNearExpectedFromAbove;

        /// <summary>ignore_near_expected_from_above block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/prometheus_anomaly_detector#ignore_near_expected_from_above PrometheusAnomalyDetector#ignore_near_expected_from_above}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAbove" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ignoreNearExpectedFromAbove", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAbove\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IgnoreNearExpectedFromAbove
        {
            get => _ignoreNearExpectedFromAbove;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAbove[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromAbove).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ignoreNearExpectedFromAbove = value;
            }
        }

        private object? _ignoreNearExpectedFromBelow;

        /// <summary>ignore_near_expected_from_below block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/prometheus_anomaly_detector#ignore_near_expected_from_below PrometheusAnomalyDetector#ignore_near_expected_from_below}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelow" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ignoreNearExpectedFromBelow", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusAnomalyDetector.PrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelow\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IgnoreNearExpectedFromBelow
        {
            get => _ignoreNearExpectedFromBelow;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelow[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.PrometheusAnomalyDetector.IPrometheusAnomalyDetectorConfigurationRandomCutForestIgnoreNearExpectedFromBelow).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ignoreNearExpectedFromBelow = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/prometheus_anomaly_detector#sample_size PrometheusAnomalyDetector#sample_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sampleSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SampleSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/prometheus_anomaly_detector#shingle_size PrometheusAnomalyDetector#shingle_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shingleSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ShingleSize
        {
            get;
            set;
        }
    }
}
