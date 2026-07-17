using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsServiceendpointAzurecr
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsServiceendpointAzurecrTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsServiceendpointAzurecr.DataAzuredevopsServiceendpointAzurecrTimeouts")]
    public interface IDataAzuredevopsServiceendpointAzurecrTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/serviceendpoint_azurecr#read DataAzuredevopsServiceendpointAzurecr#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsServiceendpointAzurecrTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsServiceendpointAzurecr.DataAzuredevopsServiceendpointAzurecrTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsServiceendpointAzurecr.IDataAzuredevopsServiceendpointAzurecrTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/serviceendpoint_azurecr#read DataAzuredevopsServiceendpointAzurecr#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
