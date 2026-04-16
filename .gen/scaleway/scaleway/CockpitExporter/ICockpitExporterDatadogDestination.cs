using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.CockpitExporter
{
    [JsiiInterface(nativeType: typeof(ICockpitExporterDatadogDestination), fullyQualifiedName: "scaleway.cockpitExporter.CockpitExporterDatadogDestination")]
    public interface ICockpitExporterDatadogDestination
    {
        /// <summary>Datadog API key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/cockpit_exporter#api_key CockpitExporter#api_key}
        /// </remarks>
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}")]
        string ApiKey
        {
            get;
        }

        /// <summary>Datadog endpoint URL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/cockpit_exporter#endpoint CockpitExporter#endpoint}
        /// </remarks>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Endpoint
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICockpitExporterDatadogDestination), fullyQualifiedName: "scaleway.cockpitExporter.CockpitExporterDatadogDestination")]
        internal sealed class _Proxy : DeputyBase, scaleway.CockpitExporter.ICockpitExporterDatadogDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Datadog API key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/cockpit_exporter#api_key CockpitExporter#api_key}
            /// </remarks>
            [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Datadog endpoint URL.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/cockpit_exporter#endpoint CockpitExporter#endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Endpoint
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
