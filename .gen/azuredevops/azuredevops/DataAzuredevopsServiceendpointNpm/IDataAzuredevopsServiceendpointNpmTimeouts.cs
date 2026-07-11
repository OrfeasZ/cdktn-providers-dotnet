using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsServiceendpointNpm
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsServiceendpointNpmTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsServiceendpointNpm.DataAzuredevopsServiceendpointNpmTimeouts")]
    public interface IDataAzuredevopsServiceendpointNpmTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/serviceendpoint_npm#read DataAzuredevopsServiceendpointNpm#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsServiceendpointNpmTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsServiceendpointNpm.DataAzuredevopsServiceendpointNpmTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsServiceendpointNpm.IDataAzuredevopsServiceendpointNpmTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/serviceendpoint_npm#read DataAzuredevopsServiceendpointNpm#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
