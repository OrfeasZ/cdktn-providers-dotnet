using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsGroupMembership
{
    [JsiiByValue(fqn: "azuredevops.dataAzuredevopsGroupMembership.DataAzuredevopsGroupMembershipTimeouts")]
    public class DataAzuredevopsGroupMembershipTimeouts : azuredevops.DataAzuredevopsGroupMembership.IDataAzuredevopsGroupMembershipTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/group_membership#read DataAzuredevopsGroupMembership#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
