using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.RepositoryPolicyReservedNames
{
    [JsiiByValue(fqn: "azuredevops.repositoryPolicyReservedNames.RepositoryPolicyReservedNamesTimeouts")]
    public class RepositoryPolicyReservedNamesTimeouts : azuredevops.RepositoryPolicyReservedNames.IRepositoryPolicyReservedNamesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/repository_policy_reserved_names#create RepositoryPolicyReservedNames#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/repository_policy_reserved_names#delete RepositoryPolicyReservedNames#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/repository_policy_reserved_names#read RepositoryPolicyReservedNames#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/repository_policy_reserved_names#update RepositoryPolicyReservedNames#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
