using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsGitRepositories
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsGitRepositoriesTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsGitRepositories.DataAzuredevopsGitRepositoriesTimeouts")]
    public interface IDataAzuredevopsGitRepositoriesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/git_repositories#read DataAzuredevopsGitRepositories#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsGitRepositoriesTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsGitRepositories.DataAzuredevopsGitRepositoriesTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsGitRepositories.IDataAzuredevopsGitRepositoriesTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/git_repositories#read DataAzuredevopsGitRepositories#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
