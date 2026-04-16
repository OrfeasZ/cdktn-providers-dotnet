using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    [JsiiInterface(nativeType: typeof(IEmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration")]
    public interface IEmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/emrserverless_application#remote_write_url EmrserverlessApplication#remote_write_url}.</summary>
        [JsiiProperty(name: "remoteWriteUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RemoteWriteUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationPrometheusMonitoringConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/emrserverless_application#remote_write_url EmrserverlessApplication#remote_write_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "remoteWriteUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RemoteWriteUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
