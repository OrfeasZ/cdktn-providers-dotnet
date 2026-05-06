using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsLogAnalyticsEntityType
{
    [JsiiInterface(nativeType: typeof(ILogAnalyticsLogAnalyticsEntityTypeProperties), fullyQualifiedName: "oci.logAnalyticsLogAnalyticsEntityType.LogAnalyticsLogAnalyticsEntityTypeProperties")]
    public interface ILogAnalyticsLogAnalyticsEntityTypeProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_entity_type#name LogAnalyticsLogAnalyticsEntityType#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_entity_type#description LogAnalyticsLogAnalyticsEntityType#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILogAnalyticsLogAnalyticsEntityTypeProperties), fullyQualifiedName: "oci.logAnalyticsLogAnalyticsEntityType.LogAnalyticsLogAnalyticsEntityTypeProperties")]
        internal sealed class _Proxy : DeputyBase, oci.LogAnalyticsLogAnalyticsEntityType.ILogAnalyticsLogAnalyticsEntityTypeProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_entity_type#name LogAnalyticsLogAnalyticsEntityType#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_entity_type#description LogAnalyticsLogAnalyticsEntityType#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
