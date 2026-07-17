using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsServiceendpointType
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsServiceendpointTypeTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsServiceendpointType.DataAzuredevopsServiceendpointTypeTimeouts")]
    public interface IDataAzuredevopsServiceendpointTypeTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/serviceendpoint_type#read DataAzuredevopsServiceendpointType#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsServiceendpointTypeTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsServiceendpointType.DataAzuredevopsServiceendpointTypeTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsServiceendpointType.IDataAzuredevopsServiceendpointTypeTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/serviceendpoint_type#read DataAzuredevopsServiceendpointType#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
