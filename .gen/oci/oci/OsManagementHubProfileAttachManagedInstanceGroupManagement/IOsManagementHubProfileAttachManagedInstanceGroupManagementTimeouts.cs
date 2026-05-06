using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubProfileAttachManagedInstanceGroupManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubProfileAttachManagedInstanceGroupManagementTimeouts), fullyQualifiedName: "oci.osManagementHubProfileAttachManagedInstanceGroupManagement.OsManagementHubProfileAttachManagedInstanceGroupManagementTimeouts")]
    public interface IOsManagementHubProfileAttachManagedInstanceGroupManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_attach_managed_instance_group_management#create OsManagementHubProfileAttachManagedInstanceGroupManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_attach_managed_instance_group_management#delete OsManagementHubProfileAttachManagedInstanceGroupManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_attach_managed_instance_group_management#update OsManagementHubProfileAttachManagedInstanceGroupManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubProfileAttachManagedInstanceGroupManagementTimeouts), fullyQualifiedName: "oci.osManagementHubProfileAttachManagedInstanceGroupManagement.OsManagementHubProfileAttachManagedInstanceGroupManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubProfileAttachManagedInstanceGroupManagement.IOsManagementHubProfileAttachManagedInstanceGroupManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_attach_managed_instance_group_management#create OsManagementHubProfileAttachManagedInstanceGroupManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_attach_managed_instance_group_management#delete OsManagementHubProfileAttachManagedInstanceGroupManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_attach_managed_instance_group_management#update OsManagementHubProfileAttachManagedInstanceGroupManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
