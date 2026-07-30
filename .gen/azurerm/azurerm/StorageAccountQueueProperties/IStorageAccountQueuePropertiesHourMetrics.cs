using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccountQueueProperties
{
    [JsiiInterface(nativeType: typeof(IStorageAccountQueuePropertiesHourMetrics), fullyQualifiedName: "azurerm.storageAccountQueueProperties.StorageAccountQueuePropertiesHourMetrics")]
    public interface IStorageAccountQueuePropertiesHourMetrics
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/storage_account_queue_properties#version StorageAccountQueueProperties#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        string Version
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/storage_account_queue_properties#include_apis StorageAccountQueueProperties#include_apis}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "includeApis", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeApis
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/storage_account_queue_properties#retention_policy_days StorageAccountQueueProperties#retention_policy_days}.</summary>
        [JsiiProperty(name: "retentionPolicyDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetentionPolicyDays
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageAccountQueuePropertiesHourMetrics), fullyQualifiedName: "azurerm.storageAccountQueueProperties.StorageAccountQueuePropertiesHourMetrics")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageAccountQueueProperties.IStorageAccountQueuePropertiesHourMetrics
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/storage_account_queue_properties#version StorageAccountQueueProperties#version}.</summary>
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
            public string Version
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/storage_account_queue_properties#include_apis StorageAccountQueueProperties#include_apis}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "includeApis", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeApis
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/storage_account_queue_properties#retention_policy_days StorageAccountQueueProperties#retention_policy_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retentionPolicyDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetentionPolicyDays
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
