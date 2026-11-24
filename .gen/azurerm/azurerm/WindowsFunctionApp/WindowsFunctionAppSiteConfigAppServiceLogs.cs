using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsFunctionApp
{
    [JsiiByValue(fqn: "azurerm.windowsFunctionApp.WindowsFunctionAppSiteConfigAppServiceLogs")]
    public class WindowsFunctionAppSiteConfigAppServiceLogs : azurerm.WindowsFunctionApp.IWindowsFunctionAppSiteConfigAppServiceLogs
    {
        /// <summary>The amount of disk space to use for logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/windows_function_app#disk_quota_mb WindowsFunctionApp#disk_quota_mb}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "diskQuotaMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DiskQuotaMb
        {
            get;
            set;
        }

        /// <summary>The retention period for logs in days. Defaults to `0` (never delete).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/windows_function_app#retention_period_days WindowsFunctionApp#retention_period_days}
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
