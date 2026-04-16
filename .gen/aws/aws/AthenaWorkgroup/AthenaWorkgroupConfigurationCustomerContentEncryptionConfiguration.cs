using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AthenaWorkgroup
{
    [JsiiByValue(fqn: "aws.athenaWorkgroup.AthenaWorkgroupConfigurationCustomerContentEncryptionConfiguration")]
    public class AthenaWorkgroupConfigurationCustomerContentEncryptionConfiguration : aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationCustomerContentEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/athena_workgroup#kms_key AthenaWorkgroup#kms_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKey
        {
            get;
            set;
        }
    }
}
