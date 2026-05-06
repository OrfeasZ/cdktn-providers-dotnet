using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AnalyticsAnalyticsInstancePrivateAccessChannel
{
    [JsiiByValue(fqn: "oci.analyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelTimeouts")]
    public class AnalyticsAnalyticsInstancePrivateAccessChannelTimeouts : oci.AnalyticsAnalyticsInstancePrivateAccessChannel.IAnalyticsAnalyticsInstancePrivateAccessChannelTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#create AnalyticsAnalyticsInstancePrivateAccessChannel#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#delete AnalyticsAnalyticsInstancePrivateAccessChannel#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#update AnalyticsAnalyticsInstancePrivateAccessChannel#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
