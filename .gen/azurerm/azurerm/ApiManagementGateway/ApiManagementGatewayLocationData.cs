using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagementGateway.ApiManagementGatewayLocationData")]
    public class ApiManagementGatewayLocationData : azurerm.ApiManagementGateway.IApiManagementGatewayLocationData
    {
        /// <summary>A canonical name for the geographic or physical location.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_gateway#name ApiManagementGateway#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>The city or locality where the resource is located.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_gateway#city ApiManagementGateway#city}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? City
        {
            get;
            set;
        }

        /// <summary>The district, state, or province where the resource is located.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_gateway#district ApiManagementGateway#district}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "district", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? District
        {
            get;
            set;
        }

        /// <summary>The country or region where the resource is located.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_gateway#region ApiManagementGateway#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }
    }
}
