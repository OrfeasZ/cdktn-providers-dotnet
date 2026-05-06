using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoredResource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.stackMonitoringMonitoredResource.StackMonitoringMonitoredResourceAliases")]
    public class StackMonitoringMonitoredResourceAliases : oci.StackMonitoringMonitoredResource.IStackMonitoringMonitoredResourceAliases
    {
        /// <summary>credential block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource#credential StackMonitoringMonitoredResource#credential}
        /// </remarks>
        [JsiiProperty(name: "credential", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResource.StackMonitoringMonitoredResourceAliasesCredential\"}")]
        public oci.StackMonitoringMonitoredResource.IStackMonitoringMonitoredResourceAliasesCredential Credential
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resource#name StackMonitoringMonitoredResource#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
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
