using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageAccountStaticWebsite
{
    [JsiiInterface(nativeType: typeof(IDataAzurermStorageAccountStaticWebsiteTimeouts), fullyQualifiedName: "azurerm.dataAzurermStorageAccountStaticWebsite.DataAzurermStorageAccountStaticWebsiteTimeouts")]
    public interface IDataAzurermStorageAccountStaticWebsiteTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.11.0/docs/data-sources/storage_account_static_website#read DataAzurermStorageAccountStaticWebsite#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermStorageAccountStaticWebsiteTimeouts), fullyQualifiedName: "azurerm.dataAzurermStorageAccountStaticWebsite.DataAzurermStorageAccountStaticWebsiteTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermStorageAccountStaticWebsite.IDataAzurermStorageAccountStaticWebsiteTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.11.0/docs/data-sources/storage_account_static_website#read DataAzurermStorageAccountStaticWebsite#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
