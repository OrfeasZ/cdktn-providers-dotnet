using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermContainerAppEnvironmentStorage
{
    [JsiiInterface(nativeType: typeof(IDataAzurermContainerAppEnvironmentStorageTimeouts), fullyQualifiedName: "azurerm.dataAzurermContainerAppEnvironmentStorage.DataAzurermContainerAppEnvironmentStorageTimeouts")]
    public interface IDataAzurermContainerAppEnvironmentStorageTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/data-sources/container_app_environment_storage#read DataAzurermContainerAppEnvironmentStorage#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermContainerAppEnvironmentStorageTimeouts), fullyQualifiedName: "azurerm.dataAzurermContainerAppEnvironmentStorage.DataAzurermContainerAppEnvironmentStorageTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermContainerAppEnvironmentStorage.IDataAzurermContainerAppEnvironmentStorageTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/data-sources/container_app_environment_storage#read DataAzurermContainerAppEnvironmentStorage#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
