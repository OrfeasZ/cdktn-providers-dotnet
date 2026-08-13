using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FunctionAppFlexConsumption
{
    [JsiiByValue(fqn: "azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionStickySettings")]
    public class FunctionAppFlexConsumptionStickySettings : azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionStickySettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#app_setting_names FunctionAppFlexConsumption#app_setting_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "appSettingNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AppSettingNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/function_app_flex_consumption#connection_string_names FunctionAppFlexConsumption#connection_string_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionStringNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ConnectionStringNames
        {
            get;
            set;
        }
    }
}
