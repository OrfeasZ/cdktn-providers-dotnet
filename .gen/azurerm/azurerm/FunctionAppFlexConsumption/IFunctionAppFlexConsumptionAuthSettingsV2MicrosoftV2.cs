using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FunctionAppFlexConsumption
{
    [JsiiInterface(nativeType: typeof(IFunctionAppFlexConsumptionAuthSettingsV2MicrosoftV2), fullyQualifiedName: "azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsV2MicrosoftV2")]
    public interface IFunctionAppFlexConsumptionAuthSettingsV2MicrosoftV2
    {
        /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/function_app_flex_consumption#client_id FunctionAppFlexConsumption#client_id}
        /// </remarks>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        string ClientId
        {
            get;
        }

        /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/function_app_flex_consumption#client_secret_setting_name FunctionAppFlexConsumption#client_secret_setting_name}
        /// </remarks>
        [JsiiProperty(name: "clientSecretSettingName", typeJson: "{\"primitive\":\"string\"}")]
        string ClientSecretSettingName
        {
            get;
        }

        /// <summary>Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/function_app_flex_consumption#allowed_audiences FunctionAppFlexConsumption#allowed_audiences}
        /// </remarks>
        [JsiiProperty(name: "allowedAudiences", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedAudiences
        {
            get
            {
                return null;
            }
        }

        /// <summary>The list of Login scopes that will be requested as part of Microsoft Account authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/function_app_flex_consumption#login_scopes FunctionAppFlexConsumption#login_scopes}
        /// </remarks>
        [JsiiProperty(name: "loginScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? LoginScopes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionAppFlexConsumptionAuthSettingsV2MicrosoftV2), fullyQualifiedName: "azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsV2MicrosoftV2")]
        internal sealed class _Proxy : DeputyBase, azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsV2MicrosoftV2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/function_app_flex_consumption#client_id FunctionAppFlexConsumption#client_id}
            /// </remarks>
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/function_app_flex_consumption#client_secret_setting_name FunctionAppFlexConsumption#client_secret_setting_name}
            /// </remarks>
            [JsiiProperty(name: "clientSecretSettingName", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientSecretSettingName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/function_app_flex_consumption#allowed_audiences FunctionAppFlexConsumption#allowed_audiences}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedAudiences", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedAudiences
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The list of Login scopes that will be requested as part of Microsoft Account authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/function_app_flex_consumption#login_scopes FunctionAppFlexConsumption#login_scopes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loginScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? LoginScopes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
