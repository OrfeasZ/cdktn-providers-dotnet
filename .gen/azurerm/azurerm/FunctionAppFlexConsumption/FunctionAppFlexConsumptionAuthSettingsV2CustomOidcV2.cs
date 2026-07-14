using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FunctionAppFlexConsumption
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsV2CustomOidcV2")]
    public class FunctionAppFlexConsumptionAuthSettingsV2CustomOidcV2 : azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsV2CustomOidcV2
    {
        /// <summary>The ID of the Client to use to authenticate with this Custom OIDC.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/function_app_flex_consumption#client_id FunctionAppFlexConsumption#client_id}
        /// </remarks>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public string ClientId
        {
            get;
            set;
        }

        /// <summary>The name of the Custom OIDC Authentication Provider.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/function_app_flex_consumption#name FunctionAppFlexConsumption#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>The endpoint that contains all the configuration endpoints for this Custom OIDC provider.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/function_app_flex_consumption#openid_configuration_endpoint FunctionAppFlexConsumption#openid_configuration_endpoint}
        /// </remarks>
        [JsiiProperty(name: "openidConfigurationEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string OpenidConfigurationEndpoint
        {
            get;
            set;
        }

        /// <summary>The name of the claim that contains the users name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/function_app_flex_consumption#name_claim_type FunctionAppFlexConsumption#name_claim_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nameClaimType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NameClaimType
        {
            get;
            set;
        }

        /// <summary>The list of the scopes that should be requested while authenticating.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/function_app_flex_consumption#scopes FunctionAppFlexConsumption#scopes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Scopes
        {
            get;
            set;
        }
    }
}
