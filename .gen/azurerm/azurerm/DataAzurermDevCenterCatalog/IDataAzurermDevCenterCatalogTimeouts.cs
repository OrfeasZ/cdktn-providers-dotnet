using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDevCenterCatalog
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDevCenterCatalogTimeouts), fullyQualifiedName: "azurerm.dataAzurermDevCenterCatalog.DataAzurermDevCenterCatalogTimeouts")]
    public interface IDataAzurermDevCenterCatalogTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/dev_center_catalog#read DataAzurermDevCenterCatalog#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDevCenterCatalogTimeouts), fullyQualifiedName: "azurerm.dataAzurermDevCenterCatalog.DataAzurermDevCenterCatalogTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDevCenterCatalog.IDataAzurermDevCenterCatalogTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/dev_center_catalog#read DataAzurermDevCenterCatalog#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
