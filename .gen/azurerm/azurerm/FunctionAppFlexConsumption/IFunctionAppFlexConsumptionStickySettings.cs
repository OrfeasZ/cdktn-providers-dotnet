using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FunctionAppFlexConsumption
{
    [JsiiInterface(nativeType: typeof(IFunctionAppFlexConsumptionStickySettings), fullyQualifiedName: "azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionStickySettings")]
    public interface IFunctionAppFlexConsumptionStickySettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/function_app_flex_consumption#app_setting_names FunctionAppFlexConsumption#app_setting_names}.</summary>
        [JsiiProperty(name: "appSettingNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AppSettingNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/function_app_flex_consumption#connection_string_names FunctionAppFlexConsumption#connection_string_names}.</summary>
        [JsiiProperty(name: "connectionStringNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ConnectionStringNames
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionAppFlexConsumptionStickySettings), fullyQualifiedName: "azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionStickySettings")]
        internal sealed class _Proxy : DeputyBase, azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionStickySettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/function_app_flex_consumption#app_setting_names FunctionAppFlexConsumption#app_setting_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "appSettingNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AppSettingNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/function_app_flex_consumption#connection_string_names FunctionAppFlexConsumption#connection_string_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectionStringNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ConnectionStringNames
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
