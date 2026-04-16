using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    [JsiiByValue(fqn: "aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationS3MonitoringConfiguration")]
    public class EmrserverlessApplicationMonitoringConfigurationS3MonitoringConfiguration : aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationS3MonitoringConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/emrserverless_application#encryption_key_arn EmrserverlessApplication#encryption_key_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EncryptionKeyArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/emrserverless_application#log_uri EmrserverlessApplication#log_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogUri
        {
            get;
            set;
        }
    }
}
