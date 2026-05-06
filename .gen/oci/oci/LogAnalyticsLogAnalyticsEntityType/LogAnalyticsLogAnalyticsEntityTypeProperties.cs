using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsLogAnalyticsEntityType
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.logAnalyticsLogAnalyticsEntityType.LogAnalyticsLogAnalyticsEntityTypeProperties")]
    public class LogAnalyticsLogAnalyticsEntityTypeProperties : oci.LogAnalyticsLogAnalyticsEntityType.ILogAnalyticsLogAnalyticsEntityTypeProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_entity_type#name LogAnalyticsLogAnalyticsEntityType#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_log_analytics_entity_type#description LogAnalyticsLogAnalyticsEntityType#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }
    }
}
