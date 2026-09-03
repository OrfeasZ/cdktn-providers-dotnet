using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsLogAnalyticsEntityAssociationsAdd
{
    [JsiiByValue(fqn: "oci.logAnalyticsLogAnalyticsEntityAssociationsAdd.LogAnalyticsLogAnalyticsEntityAssociationsAddTimeouts")]
    public class LogAnalyticsLogAnalyticsEntityAssociationsAddTimeouts : oci.LogAnalyticsLogAnalyticsEntityAssociationsAdd.ILogAnalyticsLogAnalyticsEntityAssociationsAddTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/log_analytics_log_analytics_entity_associations_add#create LogAnalyticsLogAnalyticsEntityAssociationsAdd#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/log_analytics_log_analytics_entity_associations_add#delete LogAnalyticsLogAnalyticsEntityAssociationsAdd#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/log_analytics_log_analytics_entity_associations_add#update LogAnalyticsLogAnalyticsEntityAssociationsAdd#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
