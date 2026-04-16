using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesisanalyticsv2Application
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesisanalyticsv2Application.Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationEncryptionConfiguration")]
    public class Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationEncryptionConfiguration : aws.Kinesisanalyticsv2Application.IKinesisanalyticsv2ApplicationApplicationConfigurationApplicationEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/kinesisanalyticsv2_application#key_type Kinesisanalyticsv2Application#key_type}.</summary>
        [JsiiProperty(name: "keyType", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/kinesisanalyticsv2_application#key_id Kinesisanalyticsv2Application#key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyId
        {
            get;
            set;
        }
    }
}
