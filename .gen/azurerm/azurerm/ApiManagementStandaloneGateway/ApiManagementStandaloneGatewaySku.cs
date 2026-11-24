using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementStandaloneGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagementStandaloneGateway.ApiManagementStandaloneGatewaySku")]
    public class ApiManagementStandaloneGatewaySku : azurerm.ApiManagementStandaloneGateway.IApiManagementStandaloneGatewaySku
    {
        /// <summary>The name of the SKU.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_standalone_gateway#name ApiManagementStandaloneGateway#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>The number of deployed units of the SKU.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_standalone_gateway#capacity ApiManagementStandaloneGateway#capacity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "capacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Capacity
        {
            get;
            set;
        }
    }
}
