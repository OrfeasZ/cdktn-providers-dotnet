using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    [JsiiInterface(nativeType: typeof(IEmrserverlessApplicationMonitoringConfigurationS3MonitoringConfiguration), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationS3MonitoringConfiguration")]
    public interface IEmrserverlessApplicationMonitoringConfigurationS3MonitoringConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/emrserverless_application#encryption_key_arn EmrserverlessApplication#encryption_key_arn}.</summary>
        [JsiiProperty(name: "encryptionKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptionKeyArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/emrserverless_application#log_uri EmrserverlessApplication#log_uri}.</summary>
        [JsiiProperty(name: "logUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogUri
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrserverlessApplicationMonitoringConfigurationS3MonitoringConfiguration), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationS3MonitoringConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationS3MonitoringConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/emrserverless_application#encryption_key_arn EmrserverlessApplication#encryption_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptionKeyArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/emrserverless_application#log_uri EmrserverlessApplication#log_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogUri
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
