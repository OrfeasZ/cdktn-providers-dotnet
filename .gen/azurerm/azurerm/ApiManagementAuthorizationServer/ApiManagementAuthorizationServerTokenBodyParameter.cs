using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementAuthorizationServer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagementAuthorizationServer.ApiManagementAuthorizationServerTokenBodyParameter")]
    public class ApiManagementAuthorizationServerTokenBodyParameter : azurerm.ApiManagementAuthorizationServer.IApiManagementAuthorizationServerTokenBodyParameter
    {
        /// <summary>The Name of the Parameter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#name ApiManagementAuthorizationServer#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>The Value of the Parameter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_authorization_server#value ApiManagementAuthorizationServer#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
