using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsServiceendpointGithub
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsServiceendpointGithubTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsServiceendpointGithub.DataAzuredevopsServiceendpointGithubTimeouts")]
    public interface IDataAzuredevopsServiceendpointGithubTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/serviceendpoint_github#read DataAzuredevopsServiceendpointGithub#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsServiceendpointGithubTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsServiceendpointGithub.DataAzuredevopsServiceendpointGithubTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsServiceendpointGithub.IDataAzuredevopsServiceendpointGithubTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/serviceendpoint_github#read DataAzuredevopsServiceendpointGithub#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
