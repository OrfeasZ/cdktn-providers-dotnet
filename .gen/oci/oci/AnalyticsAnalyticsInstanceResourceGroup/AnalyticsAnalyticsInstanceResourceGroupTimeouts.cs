using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AnalyticsAnalyticsInstanceResourceGroup
{
    [JsiiByValue(fqn: "oci.analyticsAnalyticsInstanceResourceGroup.AnalyticsAnalyticsInstanceResourceGroupTimeouts")]
    public class AnalyticsAnalyticsInstanceResourceGroupTimeouts : oci.AnalyticsAnalyticsInstanceResourceGroup.IAnalyticsAnalyticsInstanceResourceGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/analytics_analytics_instance_resource_group#create AnalyticsAnalyticsInstanceResourceGroup#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/analytics_analytics_instance_resource_group#delete AnalyticsAnalyticsInstanceResourceGroup#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/analytics_analytics_instance_resource_group#update AnalyticsAnalyticsInstanceResourceGroup#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
