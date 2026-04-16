using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminTelemetryPipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.observabilityadminTelemetryPipeline.ObservabilityadminTelemetryPipelineConfiguration")]
    public class ObservabilityadminTelemetryPipelineConfiguration : aws.ObservabilityadminTelemetryPipeline.IObservabilityadminTelemetryPipelineConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/observabilityadmin_telemetry_pipeline#body ObservabilityadminTelemetryPipeline#body}.</summary>
        [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}")]
        public string Body
        {
            get;
            set;
        }
    }
}
