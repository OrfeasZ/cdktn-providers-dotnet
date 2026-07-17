using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsGitRepositoryFile
{
    [JsiiByValue(fqn: "azuredevops.dataAzuredevopsGitRepositoryFile.DataAzuredevopsGitRepositoryFileTimeouts")]
    public class DataAzuredevopsGitRepositoryFileTimeouts : azuredevops.DataAzuredevopsGitRepositoryFile.IDataAzuredevopsGitRepositoryFileTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/git_repository_file#read DataAzuredevopsGitRepositoryFile#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
