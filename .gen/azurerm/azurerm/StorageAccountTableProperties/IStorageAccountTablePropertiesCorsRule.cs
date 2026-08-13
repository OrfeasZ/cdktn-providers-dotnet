using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccountTableProperties
{
    [JsiiInterface(nativeType: typeof(IStorageAccountTablePropertiesCorsRule), fullyQualifiedName: "azurerm.storageAccountTableProperties.StorageAccountTablePropertiesCorsRule")]
    public interface IStorageAccountTablePropertiesCorsRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/storage_account_table_properties#allowed_headers StorageAccountTableProperties#allowed_headers}.</summary>
        [JsiiProperty(name: "allowedHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AllowedHeaders
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/storage_account_table_properties#allowed_methods StorageAccountTableProperties#allowed_methods}.</summary>
        [JsiiProperty(name: "allowedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AllowedMethods
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/storage_account_table_properties#allowed_origins StorageAccountTableProperties#allowed_origins}.</summary>
        [JsiiProperty(name: "allowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AllowedOrigins
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/storage_account_table_properties#exposed_headers StorageAccountTableProperties#exposed_headers}.</summary>
        [JsiiProperty(name: "exposedHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ExposedHeaders
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/storage_account_table_properties#max_age_in_seconds StorageAccountTableProperties#max_age_in_seconds}.</summary>
        [JsiiProperty(name: "maxAgeInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        double MaxAgeInSeconds
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageAccountTablePropertiesCorsRule), fullyQualifiedName: "azurerm.storageAccountTableProperties.StorageAccountTablePropertiesCorsRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageAccountTableProperties.IStorageAccountTablePropertiesCorsRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/storage_account_table_properties#allowed_headers StorageAccountTableProperties#allowed_headers}.</summary>
            [JsiiProperty(name: "allowedHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AllowedHeaders
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/storage_account_table_properties#allowed_methods StorageAccountTableProperties#allowed_methods}.</summary>
            [JsiiProperty(name: "allowedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AllowedMethods
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/storage_account_table_properties#allowed_origins StorageAccountTableProperties#allowed_origins}.</summary>
            [JsiiProperty(name: "allowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AllowedOrigins
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/storage_account_table_properties#exposed_headers StorageAccountTableProperties#exposed_headers}.</summary>
            [JsiiProperty(name: "exposedHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ExposedHeaders
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/storage_account_table_properties#max_age_in_seconds StorageAccountTableProperties#max_age_in_seconds}.</summary>
            [JsiiProperty(name: "maxAgeInSeconds", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxAgeInSeconds
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
