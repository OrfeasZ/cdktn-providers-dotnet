using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadGroups
{
    [JsiiByValue(fqn: "azuread.dataAzureadGroups.DataAzureadGroupsTimeouts")]
    public class DataAzureadGroupsTimeouts : azuread.DataAzureadGroups.IDataAzureadGroupsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/groups#read DataAzureadGroups#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
