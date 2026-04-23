using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    [JsiiByValue(fqn: "aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration")]
    public class EmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration : aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#remote_write_url EmrserverlessApplication#remote_write_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "remoteWriteUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RemoteWriteUrl
        {
            get;
            set;
        }
    }
}
