using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceGroupManageModuleStreamsManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagedInstanceGroupManageModuleStreamsManagementInstall), fullyQualifiedName: "oci.osManagementHubManagedInstanceGroupManageModuleStreamsManagement.OsManagementHubManagedInstanceGroupManageModuleStreamsManagementInstall")]
    public interface IOsManagementHubManagedInstanceGroupManageModuleStreamsManagementInstall
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_manage_module_streams_management#module_name OsManagementHubManagedInstanceGroupManageModuleStreamsManagement#module_name}.</summary>
        [JsiiProperty(name: "moduleName", typeJson: "{\"primitive\":\"string\"}")]
        string ModuleName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_manage_module_streams_management#profile_name OsManagementHubManagedInstanceGroupManageModuleStreamsManagement#profile_name}.</summary>
        [JsiiProperty(name: "profileName", typeJson: "{\"primitive\":\"string\"}")]
        string ProfileName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_manage_module_streams_management#stream_name OsManagementHubManagedInstanceGroupManageModuleStreamsManagement#stream_name}.</summary>
        [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}")]
        string StreamName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_manage_module_streams_management#software_source_id OsManagementHubManagedInstanceGroupManageModuleStreamsManagement#software_source_id}.</summary>
        [JsiiProperty(name: "softwareSourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SoftwareSourceId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagedInstanceGroupManageModuleStreamsManagementInstall), fullyQualifiedName: "oci.osManagementHubManagedInstanceGroupManageModuleStreamsManagement.OsManagementHubManagedInstanceGroupManageModuleStreamsManagementInstall")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagedInstanceGroupManageModuleStreamsManagement.IOsManagementHubManagedInstanceGroupManageModuleStreamsManagementInstall
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_manage_module_streams_management#module_name OsManagementHubManagedInstanceGroupManageModuleStreamsManagement#module_name}.</summary>
            [JsiiProperty(name: "moduleName", typeJson: "{\"primitive\":\"string\"}")]
            public string ModuleName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_manage_module_streams_management#profile_name OsManagementHubManagedInstanceGroupManageModuleStreamsManagement#profile_name}.</summary>
            [JsiiProperty(name: "profileName", typeJson: "{\"primitive\":\"string\"}")]
            public string ProfileName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_manage_module_streams_management#stream_name OsManagementHubManagedInstanceGroupManageModuleStreamsManagement#stream_name}.</summary>
            [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}")]
            public string StreamName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_manage_module_streams_management#software_source_id OsManagementHubManagedInstanceGroupManageModuleStreamsManagement#software_source_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "softwareSourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SoftwareSourceId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
