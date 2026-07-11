using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FunctionAppFlexConsumption
{
    [JsiiInterface(nativeType: typeof(IFunctionAppFlexConsumptionSiteConfigScmIpRestrictionHeaders), fullyQualifiedName: "azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigScmIpRestrictionHeaders")]
    public interface IFunctionAppFlexConsumptionSiteConfigScmIpRestrictionHeaders
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/function_app_flex_consumption#x_azure_fdid FunctionAppFlexConsumption#x_azure_fdid}.</summary>
        [JsiiProperty(name: "xAzureFdid", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? XAzureFdid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/function_app_flex_consumption#x_fd_health_probe FunctionAppFlexConsumption#x_fd_health_probe}.</summary>
        [JsiiProperty(name: "xFdHealthProbe", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? XFdHealthProbe
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/function_app_flex_consumption#x_forwarded_for FunctionAppFlexConsumption#x_forwarded_for}.</summary>
        [JsiiProperty(name: "xForwardedFor", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? XForwardedFor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/function_app_flex_consumption#x_forwarded_host FunctionAppFlexConsumption#x_forwarded_host}.</summary>
        [JsiiProperty(name: "xForwardedHost", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? XForwardedHost
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionAppFlexConsumptionSiteConfigScmIpRestrictionHeaders), fullyQualifiedName: "azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigScmIpRestrictionHeaders")]
        internal sealed class _Proxy : DeputyBase, azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigScmIpRestrictionHeaders
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/function_app_flex_consumption#x_azure_fdid FunctionAppFlexConsumption#x_azure_fdid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "xAzureFdid", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? XAzureFdid
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/function_app_flex_consumption#x_fd_health_probe FunctionAppFlexConsumption#x_fd_health_probe}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "xFdHealthProbe", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? XFdHealthProbe
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/function_app_flex_consumption#x_forwarded_for FunctionAppFlexConsumption#x_forwarded_for}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "xForwardedFor", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? XForwardedFor
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/function_app_flex_consumption#x_forwarded_host FunctionAppFlexConsumption#x_forwarded_host}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "xForwardedHost", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? XForwardedHost
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
