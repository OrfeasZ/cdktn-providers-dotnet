using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubDynamicSetRebootManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubDynamicSetRebootManagementWorkRequestDetails), fullyQualifiedName: "oci.osManagementHubDynamicSetRebootManagement.OsManagementHubDynamicSetRebootManagementWorkRequestDetails")]
    public interface IOsManagementHubDynamicSetRebootManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_dynamic_set_reboot_management#description OsManagementHubDynamicSetRebootManagement#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_dynamic_set_reboot_management#display_name OsManagementHubDynamicSetRebootManagement#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubDynamicSetRebootManagementWorkRequestDetails), fullyQualifiedName: "oci.osManagementHubDynamicSetRebootManagement.OsManagementHubDynamicSetRebootManagementWorkRequestDetails")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubDynamicSetRebootManagement.IOsManagementHubDynamicSetRebootManagementWorkRequestDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_dynamic_set_reboot_management#description OsManagementHubDynamicSetRebootManagement#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_dynamic_set_reboot_management#display_name OsManagementHubDynamicSetRebootManagement#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
