using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringConfig
{
    [JsiiByValue(fqn: "oci.stackMonitoringConfig.StackMonitoringConfigUserGroups")]
    public class StackMonitoringConfigUserGroups : oci.StackMonitoringConfig.IStackMonitoringConfigUserGroups
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_config#domain StackMonitoringConfig#domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Domain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_config#name StackMonitoringConfig#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_config#stack_monitoring_role StackMonitoringConfig#stack_monitoring_role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stackMonitoringRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StackMonitoringRole
        {
            get;
            set;
        }
    }
}
