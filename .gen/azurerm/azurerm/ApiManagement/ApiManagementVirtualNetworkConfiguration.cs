using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagement
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagement.ApiManagementVirtualNetworkConfiguration")]
    public class ApiManagementVirtualNetworkConfiguration : azurerm.ApiManagement.IApiManagementVirtualNetworkConfiguration
    {
        /// <summary>The ID of the subnet that will be used for the API Management.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#subnet_id ApiManagement#subnet_id}
        /// </remarks>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }
    }
}
