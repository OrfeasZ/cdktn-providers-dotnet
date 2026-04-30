using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    [JsiiInterface(nativeType: typeof(IEmrserverlessApplicationMonitoringConfigurationManagedPersistenceMonitoringConfiguration), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationManagedPersistenceMonitoringConfiguration")]
    public interface IEmrserverlessApplicationMonitoringConfigurationManagedPersistenceMonitoringConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#enabled EmrserverlessApplication#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#encryption_key_arn EmrserverlessApplication#encryption_key_arn}.</summary>
        [JsiiProperty(name: "encryptionKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptionKeyArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrserverlessApplicationMonitoringConfigurationManagedPersistenceMonitoringConfiguration), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationManagedPersistenceMonitoringConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationManagedPersistenceMonitoringConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#enabled EmrserverlessApplication#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#encryption_key_arn EmrserverlessApplication#encryption_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptionKeyArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
