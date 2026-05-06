using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubSoftwareSource
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubSoftwareSourceCustomSoftwareSourceFilter), fullyQualifiedName: "oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilter")]
    public interface IOsManagementHubSoftwareSourceCustomSoftwareSourceFilter
    {
        /// <summary>module_stream_profile_filters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source#module_stream_profile_filters OsManagementHubSoftwareSource#module_stream_profile_filters}
        /// </remarks>
        [JsiiProperty(name: "moduleStreamProfileFilters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterModuleStreamProfileFilters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ModuleStreamProfileFilters
        {
            get
            {
                return null;
            }
        }

        /// <summary>package_filters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source#package_filters OsManagementHubSoftwareSource#package_filters}
        /// </remarks>
        [JsiiProperty(name: "packageFilters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageFilters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PackageFilters
        {
            get
            {
                return null;
            }
        }

        /// <summary>package_group_filters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source#package_group_filters OsManagementHubSoftwareSource#package_group_filters}
        /// </remarks>
        [JsiiProperty(name: "packageGroupFilters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageGroupFilters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PackageGroupFilters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubSoftwareSourceCustomSoftwareSourceFilter), fullyQualifiedName: "oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilter")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubSoftwareSource.IOsManagementHubSoftwareSourceCustomSoftwareSourceFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>module_stream_profile_filters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source#module_stream_profile_filters OsManagementHubSoftwareSource#module_stream_profile_filters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "moduleStreamProfileFilters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterModuleStreamProfileFilters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ModuleStreamProfileFilters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>package_filters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source#package_filters OsManagementHubSoftwareSource#package_filters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "packageFilters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageFilters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PackageFilters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>package_group_filters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source#package_group_filters OsManagementHubSoftwareSource#package_group_filters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "packageGroupFilters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageGroupFilters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PackageGroupFilters
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
