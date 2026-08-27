using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Eventhub
{
    [JsiiInterface(nativeType: typeof(IEventhubCaptureDescriptionDestination), fullyQualifiedName: "azurerm.eventhub.EventhubCaptureDescriptionDestination")]
    public interface IEventhubCaptureDescriptionDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventhub#archive_name_format Eventhub#archive_name_format}.</summary>
        [JsiiProperty(name: "archiveNameFormat", typeJson: "{\"primitive\":\"string\"}")]
        string ArchiveNameFormat
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventhub#blob_container_name Eventhub#blob_container_name}.</summary>
        [JsiiProperty(name: "blobContainerName", typeJson: "{\"primitive\":\"string\"}")]
        string BlobContainerName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventhub#name Eventhub#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventhub#storage_account_id Eventhub#storage_account_id}.</summary>
        [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}")]
        string StorageAccountId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventhub#storage_authentication_id Eventhub#storage_authentication_id}.</summary>
        [JsiiProperty(name: "storageAuthenticationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageAuthenticationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventhub#storage_authentication_type Eventhub#storage_authentication_type}.</summary>
        [JsiiProperty(name: "storageAuthenticationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageAuthenticationType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEventhubCaptureDescriptionDestination), fullyQualifiedName: "azurerm.eventhub.EventhubCaptureDescriptionDestination")]
        internal sealed class _Proxy : DeputyBase, azurerm.Eventhub.IEventhubCaptureDescriptionDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventhub#archive_name_format Eventhub#archive_name_format}.</summary>
            [JsiiProperty(name: "archiveNameFormat", typeJson: "{\"primitive\":\"string\"}")]
            public string ArchiveNameFormat
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventhub#blob_container_name Eventhub#blob_container_name}.</summary>
            [JsiiProperty(name: "blobContainerName", typeJson: "{\"primitive\":\"string\"}")]
            public string BlobContainerName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventhub#name Eventhub#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventhub#storage_account_id Eventhub#storage_account_id}.</summary>
            [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageAccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventhub#storage_authentication_id Eventhub#storage_authentication_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageAuthenticationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageAuthenticationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventhub#storage_authentication_type Eventhub#storage_authentication_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageAuthenticationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageAuthenticationType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
