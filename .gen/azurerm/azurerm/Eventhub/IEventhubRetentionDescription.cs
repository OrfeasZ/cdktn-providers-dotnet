using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Eventhub
{
    [JsiiInterface(nativeType: typeof(IEventhubRetentionDescription), fullyQualifiedName: "azurerm.eventhub.EventhubRetentionDescription")]
    public interface IEventhubRetentionDescription
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/eventhub#cleanup_policy Eventhub#cleanup_policy}.</summary>
        [JsiiProperty(name: "cleanupPolicy", typeJson: "{\"primitive\":\"string\"}")]
        string CleanupPolicy
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/eventhub#retention_time_in_hours Eventhub#retention_time_in_hours}.</summary>
        [JsiiProperty(name: "retentionTimeInHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetentionTimeInHours
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/eventhub#tombstone_retention_time_in_hours Eventhub#tombstone_retention_time_in_hours}.</summary>
        [JsiiProperty(name: "tombstoneRetentionTimeInHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TombstoneRetentionTimeInHours
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEventhubRetentionDescription), fullyQualifiedName: "azurerm.eventhub.EventhubRetentionDescription")]
        internal sealed class _Proxy : DeputyBase, azurerm.Eventhub.IEventhubRetentionDescription
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/eventhub#cleanup_policy Eventhub#cleanup_policy}.</summary>
            [JsiiProperty(name: "cleanupPolicy", typeJson: "{\"primitive\":\"string\"}")]
            public string CleanupPolicy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/eventhub#retention_time_in_hours Eventhub#retention_time_in_hours}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retentionTimeInHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetentionTimeInHours
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/eventhub#tombstone_retention_time_in_hours Eventhub#tombstone_retention_time_in_hours}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tombstoneRetentionTimeInHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TombstoneRetentionTimeInHours
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
