using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AnalyticsAnalyticsInstance
{
    [JsiiInterface(nativeType: typeof(IAnalyticsAnalyticsInstanceCapacity), fullyQualifiedName: "oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceCapacity")]
    public interface IAnalyticsAnalyticsInstanceCapacity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#capacity_type AnalyticsAnalyticsInstance#capacity_type}.</summary>
        [JsiiProperty(name: "capacityType", typeJson: "{\"primitive\":\"string\"}")]
        string CapacityType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#capacity_value AnalyticsAnalyticsInstance#capacity_value}.</summary>
        [JsiiProperty(name: "capacityValue", typeJson: "{\"primitive\":\"number\"}")]
        double CapacityValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAnalyticsAnalyticsInstanceCapacity), fullyQualifiedName: "oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceCapacity")]
        internal sealed class _Proxy : DeputyBase, oci.AnalyticsAnalyticsInstance.IAnalyticsAnalyticsInstanceCapacity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#capacity_type AnalyticsAnalyticsInstance#capacity_type}.</summary>
            [JsiiProperty(name: "capacityType", typeJson: "{\"primitive\":\"string\"}")]
            public string CapacityType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance#capacity_value AnalyticsAnalyticsInstance#capacity_value}.</summary>
            [JsiiProperty(name: "capacityValue", typeJson: "{\"primitive\":\"number\"}")]
            public double CapacityValue
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
