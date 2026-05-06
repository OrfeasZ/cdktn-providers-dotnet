using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceLookup
{
    [JsiiByValue(fqn: "oci.logAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupTimeouts")]
    public class LogAnalyticsNamespaceLookupTimeouts : oci.LogAnalyticsNamespaceLookup.ILogAnalyticsNamespaceLookupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup#create LogAnalyticsNamespaceLookup#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup#delete LogAnalyticsNamespaceLookup#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
