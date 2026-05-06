using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationQuery
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionReportQueryForecast")]
    public class MeteringComputationQueryQueryDefinitionReportQueryForecast : oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinitionReportQueryForecast
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#time_forecast_ended MeteringComputationQuery#time_forecast_ended}.</summary>
        [JsiiProperty(name: "timeForecastEnded", typeJson: "{\"primitive\":\"string\"}")]
        public string TimeForecastEnded
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#forecast_type MeteringComputationQuery#forecast_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "forecastType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ForecastType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_query#time_forecast_started MeteringComputationQuery#time_forecast_started}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeForecastStarted", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeForecastStarted
        {
            get;
            set;
        }
    }
}
