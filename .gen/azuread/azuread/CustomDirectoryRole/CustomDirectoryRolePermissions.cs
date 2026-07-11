using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.CustomDirectoryRole
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuread.customDirectoryRole.CustomDirectoryRolePermissions")]
    public class CustomDirectoryRolePermissions : azuread.CustomDirectoryRole.ICustomDirectoryRolePermissions
    {
        /// <summary>Set of tasks that can be performed on a resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/custom_directory_role#allowed_resource_actions CustomDirectoryRole#allowed_resource_actions}
        /// </remarks>
        [JsiiProperty(name: "allowedResourceActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AllowedResourceActions
        {
            get;
            set;
        }
    }
}
