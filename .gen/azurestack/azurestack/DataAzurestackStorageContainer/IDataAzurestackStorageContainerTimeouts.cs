using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackStorageContainer
{
    [JsiiInterface(nativeType: typeof(IDataAzurestackStorageContainerTimeouts), fullyQualifiedName: "azurestack.dataAzurestackStorageContainer.DataAzurestackStorageContainerTimeouts")]
    public interface IDataAzurestackStorageContainerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/storage_container#read DataAzurestackStorageContainer#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurestackStorageContainerTimeouts), fullyQualifiedName: "azurestack.dataAzurestackStorageContainer.DataAzurestackStorageContainerTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurestack.DataAzurestackStorageContainer.IDataAzurestackStorageContainerTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/storage_container#read DataAzurestackStorageContainer#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
