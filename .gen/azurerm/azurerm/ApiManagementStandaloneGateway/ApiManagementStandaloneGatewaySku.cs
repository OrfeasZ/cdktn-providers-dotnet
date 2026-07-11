using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementStandaloneGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagementStandaloneGateway.ApiManagementStandaloneGatewaySku")]
    public class ApiManagementStandaloneGatewaySku : azurerm.ApiManagementStandaloneGateway.IApiManagementStandaloneGatewaySku
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/api_management_standalone_gateway#name ApiManagementStandaloneGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/api_management_standalone_gateway#capacity ApiManagementStandaloneGateway#capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Capacity
        {
            get;
            set;
        }
    }
}
