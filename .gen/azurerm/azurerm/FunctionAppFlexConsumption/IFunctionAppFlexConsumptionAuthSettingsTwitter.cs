using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FunctionAppFlexConsumption
{
    [JsiiInterface(nativeType: typeof(IFunctionAppFlexConsumptionAuthSettingsTwitter), fullyQualifiedName: "azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsTwitter")]
    public interface IFunctionAppFlexConsumptionAuthSettingsTwitter
    {
        /// <summary>The OAuth 1.0a consumer key of the Twitter application used for sign-in.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#consumer_key FunctionAppFlexConsumption#consumer_key}
        /// </remarks>
        [JsiiProperty(name: "consumerKey", typeJson: "{\"primitive\":\"string\"}")]
        string ConsumerKey
        {
            get;
        }

        /// <summary>The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret_setting_name`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#consumer_secret FunctionAppFlexConsumption#consumer_secret}
        /// </remarks>
        [JsiiProperty(name: "consumerSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConsumerSecret
        {
            get
            {
                return null;
            }
        }

        /// <summary>The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#consumer_secret_setting_name FunctionAppFlexConsumption#consumer_secret_setting_name}
        /// </remarks>
        [JsiiProperty(name: "consumerSecretSettingName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConsumerSecretSettingName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionAppFlexConsumptionAuthSettingsTwitter), fullyQualifiedName: "azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAuthSettingsTwitter")]
        internal sealed class _Proxy : DeputyBase, azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAuthSettingsTwitter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The OAuth 1.0a consumer key of the Twitter application used for sign-in.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#consumer_key FunctionAppFlexConsumption#consumer_key}
            /// </remarks>
            [JsiiProperty(name: "consumerKey", typeJson: "{\"primitive\":\"string\"}")]
            public string ConsumerKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret_setting_name`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#consumer_secret FunctionAppFlexConsumption#consumer_secret}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "consumerSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConsumerSecret
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#consumer_secret_setting_name FunctionAppFlexConsumption#consumer_secret_setting_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "consumerSecretSettingName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConsumerSecretSettingName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
