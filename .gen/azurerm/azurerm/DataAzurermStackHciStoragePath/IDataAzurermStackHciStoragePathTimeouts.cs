using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStackHciStoragePath
{
    [JsiiInterface(nativeType: typeof(IDataAzurermStackHciStoragePathTimeouts), fullyQualifiedName: "azurerm.dataAzurermStackHciStoragePath.DataAzurermStackHciStoragePathTimeouts")]
    public interface IDataAzurermStackHciStoragePathTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/data-sources/stack_hci_storage_path#read DataAzurermStackHciStoragePath#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermStackHciStoragePathTimeouts), fullyQualifiedName: "azurerm.dataAzurermStackHciStoragePath.DataAzurermStackHciStoragePathTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermStackHciStoragePath.IDataAzurermStackHciStoragePathTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/data-sources/stack_hci_storage_path#read DataAzurermStackHciStoragePath#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
