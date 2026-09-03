using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagedInstanceSwitchSnapChannelManagementTimeouts), fullyQualifiedName: "oci.osManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementTimeouts")]
    public interface IOsManagementHubManagedInstanceSwitchSnapChannelManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/os_management_hub_managed_instance_switch_snap_channel_management#create OsManagementHubManagedInstanceSwitchSnapChannelManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/os_management_hub_managed_instance_switch_snap_channel_management#delete OsManagementHubManagedInstanceSwitchSnapChannelManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/os_management_hub_managed_instance_switch_snap_channel_management#update OsManagementHubManagedInstanceSwitchSnapChannelManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagedInstanceSwitchSnapChannelManagementTimeouts), fullyQualifiedName: "oci.osManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/os_management_hub_managed_instance_switch_snap_channel_management#create OsManagementHubManagedInstanceSwitchSnapChannelManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/os_management_hub_managed_instance_switch_snap_channel_management#delete OsManagementHubManagedInstanceSwitchSnapChannelManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/os_management_hub_managed_instance_switch_snap_channel_management#update OsManagementHubManagedInstanceSwitchSnapChannelManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
