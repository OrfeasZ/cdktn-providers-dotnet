using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringDiscoveryJob
{
    [JsiiByValue(fqn: "oci.stackMonitoringDiscoveryJob.StackMonitoringDiscoveryJobDiscoveryDetailsTags")]
    public class StackMonitoringDiscoveryJobDiscoveryDetailsTags : oci.StackMonitoringDiscoveryJob.IStackMonitoringDiscoveryJobDiscoveryDetailsTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#properties_map StackMonitoringDiscoveryJob#properties_map}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "propertiesMap", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? PropertiesMap
        {
            get;
            set;
        }
    }
}
