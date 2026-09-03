using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagedInstanceSwitchSnapChannelManagementSnapDetails), fullyQualifiedName: "oci.osManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementSnapDetails")]
    public interface IOsManagementHubManagedInstanceSwitchSnapChannelManagementSnapDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/os_management_hub_managed_instance_switch_snap_channel_management#name OsManagementHubManagedInstanceSwitchSnapChannelManagement#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/os_management_hub_managed_instance_switch_snap_channel_management#channel OsManagementHubManagedInstanceSwitchSnapChannelManagement#channel}.</summary>
        [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Channel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagedInstanceSwitchSnapChannelManagementSnapDetails), fullyQualifiedName: "oci.osManagementHubManagedInstanceSwitchSnapChannelManagement.OsManagementHubManagedInstanceSwitchSnapChannelManagementSnapDetails")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagedInstanceSwitchSnapChannelManagement.IOsManagementHubManagedInstanceSwitchSnapChannelManagementSnapDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/os_management_hub_managed_instance_switch_snap_channel_management#name OsManagementHubManagedInstanceSwitchSnapChannelManagement#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/os_management_hub_managed_instance_switch_snap_channel_management#channel OsManagementHubManagedInstanceSwitchSnapChannelManagement#channel}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Channel
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
