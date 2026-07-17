using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsServiceendpointSonarcloud
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsServiceendpointSonarcloudTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsServiceendpointSonarcloud.DataAzuredevopsServiceendpointSonarcloudTimeouts")]
    public interface IDataAzuredevopsServiceendpointSonarcloudTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/serviceendpoint_sonarcloud#read DataAzuredevopsServiceendpointSonarcloud#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsServiceendpointSonarcloudTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsServiceendpointSonarcloud.DataAzuredevopsServiceendpointSonarcloudTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsServiceendpointSonarcloud.IDataAzuredevopsServiceendpointSonarcloudTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/serviceendpoint_sonarcloud#read DataAzuredevopsServiceendpointSonarcloud#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
