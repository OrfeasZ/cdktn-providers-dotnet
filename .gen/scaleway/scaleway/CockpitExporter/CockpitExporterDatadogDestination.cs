using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.CockpitExporter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.cockpitExporter.CockpitExporterDatadogDestination")]
    public class CockpitExporterDatadogDestination : scaleway.CockpitExporter.ICockpitExporterDatadogDestination
    {
        /// <summary>Datadog API key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/cockpit_exporter#api_key CockpitExporter#api_key}
        /// </remarks>
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ApiKey
        {
            get;
            set;
        }

        /// <summary>Datadog endpoint URL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/cockpit_exporter#endpoint CockpitExporter#endpoint}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Endpoint
        {
            get;
            set;
        }
    }
}
