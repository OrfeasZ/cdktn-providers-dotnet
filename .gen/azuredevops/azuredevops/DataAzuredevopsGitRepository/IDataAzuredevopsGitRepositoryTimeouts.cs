using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsGitRepository
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsGitRepositoryTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsGitRepository.DataAzuredevopsGitRepositoryTimeouts")]
    public interface IDataAzuredevopsGitRepositoryTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/git_repository#read DataAzuredevopsGitRepository#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsGitRepositoryTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsGitRepository.DataAzuredevopsGitRepositoryTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsGitRepository.IDataAzuredevopsGitRepositoryTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/git_repository#read DataAzuredevopsGitRepository#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
