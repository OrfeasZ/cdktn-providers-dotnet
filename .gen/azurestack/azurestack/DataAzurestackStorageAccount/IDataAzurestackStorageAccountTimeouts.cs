using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackStorageAccount
{
    [JsiiInterface(nativeType: typeof(IDataAzurestackStorageAccountTimeouts), fullyQualifiedName: "azurestack.dataAzurestackStorageAccount.DataAzurestackStorageAccountTimeouts")]
    public interface IDataAzurestackStorageAccountTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/storage_account#read DataAzurestackStorageAccount#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurestackStorageAccountTimeouts), fullyQualifiedName: "azurestack.dataAzurestackStorageAccount.DataAzurestackStorageAccountTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurestack.DataAzurestackStorageAccount.IDataAzurestackStorageAccountTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/storage_account#read DataAzurestackStorageAccount#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
