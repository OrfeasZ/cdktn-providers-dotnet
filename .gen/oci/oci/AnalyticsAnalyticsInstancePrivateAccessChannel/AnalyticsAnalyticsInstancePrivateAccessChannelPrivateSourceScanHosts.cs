using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AnalyticsAnalyticsInstancePrivateAccessChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.analyticsAnalyticsInstancePrivateAccessChannel.AnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceScanHosts")]
    public class AnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceScanHosts : oci.AnalyticsAnalyticsInstancePrivateAccessChannel.IAnalyticsAnalyticsInstancePrivateAccessChannelPrivateSourceScanHosts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#scan_hostname AnalyticsAnalyticsInstancePrivateAccessChannel#scan_hostname}.</summary>
        [JsiiProperty(name: "scanHostname", typeJson: "{\"primitive\":\"string\"}")]
        public string ScanHostname
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#scan_port AnalyticsAnalyticsInstancePrivateAccessChannel#scan_port}.</summary>
        [JsiiProperty(name: "scanPort", typeJson: "{\"primitive\":\"number\"}")]
        public double ScanPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_private_access_channel#description AnalyticsAnalyticsInstancePrivateAccessChannel#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }
    }
}
