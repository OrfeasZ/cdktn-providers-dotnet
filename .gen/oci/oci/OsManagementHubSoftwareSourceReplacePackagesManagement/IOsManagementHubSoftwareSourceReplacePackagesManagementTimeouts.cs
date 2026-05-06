using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubSoftwareSourceReplacePackagesManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubSoftwareSourceReplacePackagesManagementTimeouts), fullyQualifiedName: "oci.osManagementHubSoftwareSourceReplacePackagesManagement.OsManagementHubSoftwareSourceReplacePackagesManagementTimeouts")]
    public interface IOsManagementHubSoftwareSourceReplacePackagesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_replace_packages_management#create OsManagementHubSoftwareSourceReplacePackagesManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_replace_packages_management#delete OsManagementHubSoftwareSourceReplacePackagesManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_replace_packages_management#update OsManagementHubSoftwareSourceReplacePackagesManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubSoftwareSourceReplacePackagesManagementTimeouts), fullyQualifiedName: "oci.osManagementHubSoftwareSourceReplacePackagesManagement.OsManagementHubSoftwareSourceReplacePackagesManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubSoftwareSourceReplacePackagesManagement.IOsManagementHubSoftwareSourceReplacePackagesManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_replace_packages_management#create OsManagementHubSoftwareSourceReplacePackagesManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_replace_packages_management#delete OsManagementHubSoftwareSourceReplacePackagesManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_replace_packages_management#update OsManagementHubSoftwareSourceReplacePackagesManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
