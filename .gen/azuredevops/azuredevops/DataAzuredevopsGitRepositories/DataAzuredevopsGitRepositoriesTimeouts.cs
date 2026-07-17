using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsGitRepositories
{
    [JsiiByValue(fqn: "azuredevops.dataAzuredevopsGitRepositories.DataAzuredevopsGitRepositoriesTimeouts")]
    public class DataAzuredevopsGitRepositoriesTimeouts : azuredevops.DataAzuredevopsGitRepositories.IDataAzuredevopsGitRepositoriesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/git_repositories#read DataAzuredevopsGitRepositories#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
