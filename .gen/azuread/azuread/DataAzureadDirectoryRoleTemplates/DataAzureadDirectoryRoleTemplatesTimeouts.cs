using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadDirectoryRoleTemplates
{
    [JsiiByValue(fqn: "azuread.dataAzureadDirectoryRoleTemplates.DataAzureadDirectoryRoleTemplatesTimeouts")]
    public class DataAzureadDirectoryRoleTemplatesTimeouts : azuread.DataAzureadDirectoryRoleTemplates.IDataAzureadDirectoryRoleTemplatesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/directory_role_templates#read DataAzureadDirectoryRoleTemplates#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
