using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement
{
    [JsiiByValue(fqn: "oci.stackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement.StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagementTimeouts")]
    public class StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagementTimeouts : oci.StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement.IStackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension_metric_extension_on_given_resources_management#create StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension_metric_extension_on_given_resources_management#delete StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension_metric_extension_on_given_resources_management#update StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
