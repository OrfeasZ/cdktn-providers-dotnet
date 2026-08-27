using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Eventhub
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.eventhub.EventhubRetentionDescription")]
    public class EventhubRetentionDescription : azurerm.Eventhub.IEventhubRetentionDescription
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventhub#cleanup_policy Eventhub#cleanup_policy}.</summary>
        [JsiiProperty(name: "cleanupPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public string CleanupPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventhub#retention_time_in_hours Eventhub#retention_time_in_hours}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retentionTimeInHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetentionTimeInHours
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventhub#tombstone_retention_time_in_hours Eventhub#tombstone_retention_time_in_hours}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tombstoneRetentionTimeInHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TombstoneRetentionTimeInHours
        {
            get;
            set;
        }
    }
}
