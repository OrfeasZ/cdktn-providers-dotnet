using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FunctionAppFlexConsumption
{
    [JsiiByValue(fqn: "azurerm.functionAppFlexConsumption.FunctionAppFlexConsumptionSiteConfigAppServiceLogs")]
    public class FunctionAppFlexConsumptionSiteConfigAppServiceLogs : azurerm.FunctionAppFlexConsumption.IFunctionAppFlexConsumptionSiteConfigAppServiceLogs
    {
        /// <summary>The amount of disk space to use for logs. Valid values are between `25` and `100`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/function_app_flex_consumption#disk_quota_mb FunctionAppFlexConsumption#disk_quota_mb}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "diskQuotaMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DiskQuotaMb
        {
            get;
            set;
        }

        /// <summary>The retention period for logs in days. Valid values are between `0` and `99999`. Defaults to `0` (never delete).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/function_app_flex_consumption#retention_period_days FunctionAppFlexConsumption#retention_period_days}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retentionPeriodDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetentionPeriodDays
        {
            get;
            set;
        }
    }
}
