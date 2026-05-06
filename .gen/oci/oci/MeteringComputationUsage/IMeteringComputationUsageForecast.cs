using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationUsage
{
    [JsiiInterface(nativeType: typeof(IMeteringComputationUsageForecast), fullyQualifiedName: "oci.meteringComputationUsage.MeteringComputationUsageForecast")]
    public interface IMeteringComputationUsageForecast
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage#time_forecast_ended MeteringComputationUsage#time_forecast_ended}.</summary>
        [JsiiProperty(name: "timeForecastEnded", typeJson: "{\"primitive\":\"string\"}")]
        string TimeForecastEnded
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage#forecast_type MeteringComputationUsage#forecast_type}.</summary>
        [JsiiProperty(name: "forecastType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ForecastType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage#time_forecast_started MeteringComputationUsage#time_forecast_started}.</summary>
        [JsiiProperty(name: "timeForecastStarted", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeForecastStarted
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMeteringComputationUsageForecast), fullyQualifiedName: "oci.meteringComputationUsage.MeteringComputationUsageForecast")]
        internal sealed class _Proxy : DeputyBase, oci.MeteringComputationUsage.IMeteringComputationUsageForecast
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage#time_forecast_ended MeteringComputationUsage#time_forecast_ended}.</summary>
            [JsiiProperty(name: "timeForecastEnded", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeForecastEnded
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage#forecast_type MeteringComputationUsage#forecast_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "forecastType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ForecastType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage#time_forecast_started MeteringComputationUsage#time_forecast_started}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeForecastStarted", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeForecastStarted
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
