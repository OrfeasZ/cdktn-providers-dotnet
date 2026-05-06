using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoredResource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.stackMonitoringMonitoredResource.StackMonitoringMonitoredResourceAdditionalAliasesCredential")]
    public class StackMonitoringMonitoredResourceAdditionalAliasesCredential : oci.StackMonitoringMonitoredResource.IStackMonitoringMonitoredResourceAdditionalAliasesCredential
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource#name StackMonitoringMonitoredResource#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource#service StackMonitoringMonitoredResource#service}.</summary>
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}")]
        public string Service
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource#source StackMonitoringMonitoredResource#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public string Source
        {
            get;
            set;
        }
    }
}
