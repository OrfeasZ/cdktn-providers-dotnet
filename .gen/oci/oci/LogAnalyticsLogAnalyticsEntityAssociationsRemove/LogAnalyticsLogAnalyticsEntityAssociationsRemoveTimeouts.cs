using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsLogAnalyticsEntityAssociationsRemove
{
    [JsiiByValue(fqn: "oci.logAnalyticsLogAnalyticsEntityAssociationsRemove.LogAnalyticsLogAnalyticsEntityAssociationsRemoveTimeouts")]
    public class LogAnalyticsLogAnalyticsEntityAssociationsRemoveTimeouts : oci.LogAnalyticsLogAnalyticsEntityAssociationsRemove.ILogAnalyticsLogAnalyticsEntityAssociationsRemoveTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/log_analytics_log_analytics_entity_associations_remove#create LogAnalyticsLogAnalyticsEntityAssociationsRemove#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/log_analytics_log_analytics_entity_associations_remove#delete LogAnalyticsLogAnalyticsEntityAssociationsRemove#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/log_analytics_log_analytics_entity_associations_remove#update LogAnalyticsLogAnalyticsEntityAssociationsRemove#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
