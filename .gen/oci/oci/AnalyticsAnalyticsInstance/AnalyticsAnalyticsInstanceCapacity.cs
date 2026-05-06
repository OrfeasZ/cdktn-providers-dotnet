using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AnalyticsAnalyticsInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceCapacity")]
    public class AnalyticsAnalyticsInstanceCapacity : oci.AnalyticsAnalyticsInstance.IAnalyticsAnalyticsInstanceCapacity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#capacity_type AnalyticsAnalyticsInstance#capacity_type}.</summary>
        [JsiiProperty(name: "capacityType", typeJson: "{\"primitive\":\"string\"}")]
        public string CapacityType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#capacity_value AnalyticsAnalyticsInstance#capacity_value}.</summary>
        [JsiiProperty(name: "capacityValue", typeJson: "{\"primitive\":\"number\"}")]
        public double CapacityValue
        {
            get;
            set;
        }
    }
}
