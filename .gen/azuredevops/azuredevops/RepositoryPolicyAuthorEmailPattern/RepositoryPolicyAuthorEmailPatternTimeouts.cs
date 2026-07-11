using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.RepositoryPolicyAuthorEmailPattern
{
    [JsiiByValue(fqn: "azuredevops.repositoryPolicyAuthorEmailPattern.RepositoryPolicyAuthorEmailPatternTimeouts")]
    public class RepositoryPolicyAuthorEmailPatternTimeouts : azuredevops.RepositoryPolicyAuthorEmailPattern.IRepositoryPolicyAuthorEmailPatternTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/repository_policy_author_email_pattern#create RepositoryPolicyAuthorEmailPattern#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/repository_policy_author_email_pattern#delete RepositoryPolicyAuthorEmailPattern#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/repository_policy_author_email_pattern#read RepositoryPolicyAuthorEmailPattern#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/repository_policy_author_email_pattern#update RepositoryPolicyAuthorEmailPattern#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
