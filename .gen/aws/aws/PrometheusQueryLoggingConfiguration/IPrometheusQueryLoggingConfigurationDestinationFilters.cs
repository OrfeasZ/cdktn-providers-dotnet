using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusQueryLoggingConfiguration
{
    [JsiiInterface(nativeType: typeof(IPrometheusQueryLoggingConfigurationDestinationFilters), fullyQualifiedName: "aws.prometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfigurationDestinationFilters")]
    public interface IPrometheusQueryLoggingConfigurationDestinationFilters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/prometheus_query_logging_configuration#qsp_threshold PrometheusQueryLoggingConfiguration#qsp_threshold}.</summary>
        [JsiiProperty(name: "qspThreshold", typeJson: "{\"primitive\":\"number\"}")]
        double QspThreshold
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPrometheusQueryLoggingConfigurationDestinationFilters), fullyQualifiedName: "aws.prometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfigurationDestinationFilters")]
        internal sealed class _Proxy : DeputyBase, aws.PrometheusQueryLoggingConfiguration.IPrometheusQueryLoggingConfigurationDestinationFilters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/prometheus_query_logging_configuration#qsp_threshold PrometheusQueryLoggingConfiguration#qsp_threshold}.</summary>
            [JsiiProperty(name: "qspThreshold", typeJson: "{\"primitive\":\"number\"}")]
            public double QspThreshold
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
