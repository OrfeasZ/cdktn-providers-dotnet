using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccountTableProperties
{
    [JsiiInterface(nativeType: typeof(IStorageAccountTablePropertiesLogging), fullyQualifiedName: "azurerm.storageAccountTableProperties.StorageAccountTablePropertiesLogging")]
    public interface IStorageAccountTablePropertiesLogging
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_account_table_properties#delete StorageAccountTableProperties#delete}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "delete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Delete
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_account_table_properties#read StorageAccountTableProperties#read}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "read", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Read
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_account_table_properties#version StorageAccountTableProperties#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        string Version
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_account_table_properties#write StorageAccountTableProperties#write}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "write", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Write
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_account_table_properties#retention_policy_days StorageAccountTableProperties#retention_policy_days}.</summary>
        [JsiiProperty(name: "retentionPolicyDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetentionPolicyDays
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageAccountTablePropertiesLogging), fullyQualifiedName: "azurerm.storageAccountTableProperties.StorageAccountTablePropertiesLogging")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageAccountTableProperties.IStorageAccountTablePropertiesLogging
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_account_table_properties#delete StorageAccountTableProperties#delete}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "delete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Delete
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_account_table_properties#read StorageAccountTableProperties#read}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "read", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Read
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_account_table_properties#version StorageAccountTableProperties#version}.</summary>
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
            public string Version
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_account_table_properties#write StorageAccountTableProperties#write}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "write", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Write
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/storage_account_table_properties#retention_policy_days StorageAccountTableProperties#retention_policy_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retentionPolicyDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetentionPolicyDays
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
