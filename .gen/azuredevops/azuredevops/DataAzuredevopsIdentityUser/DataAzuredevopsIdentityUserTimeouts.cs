using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsIdentityUser
{
    [JsiiByValue(fqn: "azuredevops.dataAzuredevopsIdentityUser.DataAzuredevopsIdentityUserTimeouts")]
    public class DataAzuredevopsIdentityUserTimeouts : azuredevops.DataAzuredevopsIdentityUser.IDataAzuredevopsIdentityUserTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/identity_user#read DataAzuredevopsIdentityUser#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
