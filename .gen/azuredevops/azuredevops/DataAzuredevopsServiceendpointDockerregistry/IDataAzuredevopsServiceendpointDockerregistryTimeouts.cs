using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsServiceendpointDockerregistry
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsServiceendpointDockerregistryTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsServiceendpointDockerregistry.DataAzuredevopsServiceendpointDockerregistryTimeouts")]
    public interface IDataAzuredevopsServiceendpointDockerregistryTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/serviceendpoint_dockerregistry#read DataAzuredevopsServiceendpointDockerregistry#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsServiceendpointDockerregistryTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsServiceendpointDockerregistry.DataAzuredevopsServiceendpointDockerregistryTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsServiceendpointDockerregistry.IDataAzuredevopsServiceendpointDockerregistryTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/serviceendpoint_dockerregistry#read DataAzuredevopsServiceendpointDockerregistry#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
