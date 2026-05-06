using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AppmgmtControlMonitorPluginManagement
{
    [JsiiByValue(fqn: "oci.appmgmtControlMonitorPluginManagement.AppmgmtControlMonitorPluginManagementTimeouts")]
    public class AppmgmtControlMonitorPluginManagementTimeouts : oci.AppmgmtControlMonitorPluginManagement.IAppmgmtControlMonitorPluginManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/appmgmt_control_monitor_plugin_management#create AppmgmtControlMonitorPluginManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/appmgmt_control_monitor_plugin_management#delete AppmgmtControlMonitorPluginManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/appmgmt_control_monitor_plugin_management#update AppmgmtControlMonitorPluginManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
