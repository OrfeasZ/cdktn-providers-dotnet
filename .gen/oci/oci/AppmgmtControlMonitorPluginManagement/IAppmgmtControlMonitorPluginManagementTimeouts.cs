using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AppmgmtControlMonitorPluginManagement
{
    [JsiiInterface(nativeType: typeof(IAppmgmtControlMonitorPluginManagementTimeouts), fullyQualifiedName: "oci.appmgmtControlMonitorPluginManagement.AppmgmtControlMonitorPluginManagementTimeouts")]
    public interface IAppmgmtControlMonitorPluginManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/appmgmt_control_monitor_plugin_management#create AppmgmtControlMonitorPluginManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/appmgmt_control_monitor_plugin_management#delete AppmgmtControlMonitorPluginManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/appmgmt_control_monitor_plugin_management#update AppmgmtControlMonitorPluginManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmgmtControlMonitorPluginManagementTimeouts), fullyQualifiedName: "oci.appmgmtControlMonitorPluginManagement.AppmgmtControlMonitorPluginManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.AppmgmtControlMonitorPluginManagement.IAppmgmtControlMonitorPluginManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/appmgmt_control_monitor_plugin_management#create AppmgmtControlMonitorPluginManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/appmgmt_control_monitor_plugin_management#delete AppmgmtControlMonitorPluginManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/appmgmt_control_monitor_plugin_management#update AppmgmtControlMonitorPluginManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
