using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FunctionAppFlexConsumption
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsMicrosoft")]
    public class FunctionAppFlexConsumptionAuthSettingsMicrosoft : azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsMicrosoft
    {
        /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#client_id FunctionAppFlexConsumption#client_id}
        /// </remarks>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public string ClientId
        {
            get;
            set;
        }

        /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret_setting_name`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#client_secret FunctionAppFlexConsumption#client_secret}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientSecret
        {
            get;
            set;
        }

        /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#client_secret_setting_name FunctionAppFlexConsumption#client_secret_setting_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientSecretSettingName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientSecretSettingName
        {
            get;
            set;
        }

        /// <summary>The list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, `wl.basic` is used as the default scope.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#oauth_scopes FunctionAppFlexConsumption#oauth_scopes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oauthScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? OauthScopes
        {
            get;
            set;
        }
    }
}
