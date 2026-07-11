using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadDirectoryRoles
{
    [JsiiByValue(fqn: "azuread.dataAzureadDirectoryRoles.DataAzureadDirectoryRolesTimeouts")]
    public class DataAzureadDirectoryRolesTimeouts : azuread.DataAzureadDirectoryRoles.IDataAzureadDirectoryRolesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/directory_roles#read DataAzureadDirectoryRoles#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
