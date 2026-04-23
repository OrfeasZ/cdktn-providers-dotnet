using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminTelemetryPipeline
{
    [JsiiInterface(nativeType: typeof(IObservabilityadminTelemetryPipelineConfiguration), fullyQualifiedName: "aws.observabilityadminTelemetryPipeline.ObservabilityadminTelemetryPipelineConfiguration")]
    public interface IObservabilityadminTelemetryPipelineConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/observabilityadmin_telemetry_pipeline#body ObservabilityadminTelemetryPipeline#body}.</summary>
        [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}")]
        string Body
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IObservabilityadminTelemetryPipelineConfiguration), fullyQualifiedName: "aws.observabilityadminTelemetryPipeline.ObservabilityadminTelemetryPipelineConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ObservabilityadminTelemetryPipeline.IObservabilityadminTelemetryPipelineConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/observabilityadmin_telemetry_pipeline#body ObservabilityadminTelemetryPipeline#body}.</summary>
            [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}")]
            public string Body
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
