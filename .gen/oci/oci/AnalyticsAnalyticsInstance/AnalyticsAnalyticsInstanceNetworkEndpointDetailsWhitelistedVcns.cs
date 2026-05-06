using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AnalyticsAnalyticsInstance
{
    [JsiiByValue(fqn: "oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceNetworkEndpointDetailsWhitelistedVcns")]
    public class AnalyticsAnalyticsInstanceNetworkEndpointDetailsWhitelistedVcns : oci.AnalyticsAnalyticsInstance.IAnalyticsAnalyticsInstanceNetworkEndpointDetailsWhitelistedVcns
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#id AnalyticsAnalyticsInstance#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#whitelisted_ips AnalyticsAnalyticsInstance#whitelisted_ips}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "whitelistedIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? WhitelistedIps
        {
            get;
            set;
        }
    }
}
