using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsServiceendpointTypes
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsServiceendpointTypesTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsServiceendpointTypes.DataAzuredevopsServiceendpointTypesTimeouts")]
    public interface IDataAzuredevopsServiceendpointTypesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/serviceendpoint_types#read DataAzuredevopsServiceendpointTypes#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsServiceendpointTypesTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsServiceendpointTypes.DataAzuredevopsServiceendpointTypesTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsServiceendpointTypes.IDataAzuredevopsServiceendpointTypesTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/serviceendpoint_types#read DataAzuredevopsServiceendpointTypes#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
