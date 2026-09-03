using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FunctionAppFlexConsumption
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionAlwaysReady")]
    public class FunctionAppFlexConsumptionAlwaysReady : azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionAlwaysReady
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#name FunctionAppFlexConsumption#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/function_app_flex_consumption#instance_count FunctionAppFlexConsumption#instance_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InstanceCount
        {
            get;
            set;
        }
    }
}
