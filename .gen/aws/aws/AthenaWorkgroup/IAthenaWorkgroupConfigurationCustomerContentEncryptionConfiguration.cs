using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AthenaWorkgroup
{
    [JsiiInterface(nativeType: typeof(IAthenaWorkgroupConfigurationCustomerContentEncryptionConfiguration), fullyQualifiedName: "aws.athenaWorkgroup.AthenaWorkgroupConfigurationCustomerContentEncryptionConfiguration")]
    public interface IAthenaWorkgroupConfigurationCustomerContentEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/athena_workgroup#kms_key AthenaWorkgroup#kms_key}.</summary>
        [JsiiProperty(name: "kmsKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAthenaWorkgroupConfigurationCustomerContentEncryptionConfiguration), fullyQualifiedName: "aws.athenaWorkgroup.AthenaWorkgroupConfigurationCustomerContentEncryptionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationCustomerContentEncryptionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/athena_workgroup#kms_key AthenaWorkgroup#kms_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
