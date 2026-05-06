using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationQuery
{
    [JsiiInterface(nativeType: typeof(IMeteringComputationQueryQueryDefinitionReportQueryForecast), fullyQualifiedName: "oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionReportQueryForecast")]
    public interface IMeteringComputationQueryQueryDefinitionReportQueryForecast
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#time_forecast_ended MeteringComputationQuery#time_forecast_ended}.</summary>
        [JsiiProperty(name: "timeForecastEnded", typeJson: "{\"primitive\":\"string\"}")]
        string TimeForecastEnded
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#forecast_type MeteringComputationQuery#forecast_type}.</summary>
        [JsiiProperty(name: "forecastType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ForecastType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#time_forecast_started MeteringComputationQuery#time_forecast_started}.</summary>
        [JsiiProperty(name: "timeForecastStarted", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeForecastStarted
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMeteringComputationQueryQueryDefinitionReportQueryForecast), fullyQualifiedName: "oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionReportQueryForecast")]
        internal sealed class _Proxy : DeputyBase, oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinitionReportQueryForecast
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#time_forecast_ended MeteringComputationQuery#time_forecast_ended}.</summary>
            [JsiiProperty(name: "timeForecastEnded", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeForecastEnded
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#forecast_type MeteringComputationQuery#forecast_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "forecastType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ForecastType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#time_forecast_started MeteringComputationQuery#time_forecast_started}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeForecastStarted", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeForecastStarted
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
