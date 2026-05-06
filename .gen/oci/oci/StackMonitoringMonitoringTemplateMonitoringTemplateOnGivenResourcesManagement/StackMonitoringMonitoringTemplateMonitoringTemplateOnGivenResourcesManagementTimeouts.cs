using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagement
{
    [JsiiByValue(fqn: "oci.stackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagement.StackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagementTimeouts")]
    public class StackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagementTimeouts : oci.StackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagement.IStackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_monitoring_template_on_given_resources_management#create StackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_monitoring_template_on_given_resources_management#delete StackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_monitoring_template_on_given_resources_management#update StackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
