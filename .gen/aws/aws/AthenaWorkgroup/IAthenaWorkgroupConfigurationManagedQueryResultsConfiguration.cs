using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AthenaWorkgroup
{
    [JsiiInterface(nativeType: typeof(IAthenaWorkgroupConfigurationManagedQueryResultsConfiguration), fullyQualifiedName: "aws.athenaWorkgroup.AthenaWorkgroupConfigurationManagedQueryResultsConfiguration")]
    public interface IAthenaWorkgroupConfigurationManagedQueryResultsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/athena_workgroup#enabled AthenaWorkgroup#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>encryption_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/athena_workgroup#encryption_configuration AthenaWorkgroup#encryption_configuration}
        /// </remarks>
        [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationManagedQueryResultsConfigurationEncryptionConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationManagedQueryResultsConfigurationEncryptionConfiguration? EncryptionConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAthenaWorkgroupConfigurationManagedQueryResultsConfiguration), fullyQualifiedName: "aws.athenaWorkgroup.AthenaWorkgroupConfigurationManagedQueryResultsConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationManagedQueryResultsConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/athena_workgroup#enabled AthenaWorkgroup#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>encryption_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/athena_workgroup#encryption_configuration AthenaWorkgroup#encryption_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationManagedQueryResultsConfigurationEncryptionConfiguration\"}", isOptional: true)]
            public aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationManagedQueryResultsConfigurationEncryptionConfiguration? EncryptionConfiguration
            {
                get => GetInstanceProperty<aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationManagedQueryResultsConfigurationEncryptionConfiguration?>();
            }
        }
    }
}
