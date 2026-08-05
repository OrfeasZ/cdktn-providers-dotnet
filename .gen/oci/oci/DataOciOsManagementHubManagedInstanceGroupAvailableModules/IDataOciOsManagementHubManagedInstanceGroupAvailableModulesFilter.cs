using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOsManagementHubManagedInstanceGroupAvailableModules
{
    [JsiiInterface(nativeType: typeof(IDataOciOsManagementHubManagedInstanceGroupAvailableModulesFilter), fullyQualifiedName: "oci.dataOciOsManagementHubManagedInstanceGroupAvailableModules.DataOciOsManagementHubManagedInstanceGroupAvailableModulesFilter")]
    public interface IDataOciOsManagementHubManagedInstanceGroupAvailableModulesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/data-sources/os_management_hub_managed_instance_group_available_modules#name DataOciOsManagementHubManagedInstanceGroupAvailableModules#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/data-sources/os_management_hub_managed_instance_group_available_modules#values DataOciOsManagementHubManagedInstanceGroupAvailableModules#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/data-sources/os_management_hub_managed_instance_group_available_modules#regex DataOciOsManagementHubManagedInstanceGroupAvailableModules#regex}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciOsManagementHubManagedInstanceGroupAvailableModulesFilter), fullyQualifiedName: "oci.dataOciOsManagementHubManagedInstanceGroupAvailableModules.DataOciOsManagementHubManagedInstanceGroupAvailableModulesFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciOsManagementHubManagedInstanceGroupAvailableModules.IDataOciOsManagementHubManagedInstanceGroupAvailableModulesFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/data-sources/os_management_hub_managed_instance_group_available_modules#name DataOciOsManagementHubManagedInstanceGroupAvailableModules#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/data-sources/os_management_hub_managed_instance_group_available_modules#values DataOciOsManagementHubManagedInstanceGroupAvailableModules#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/data-sources/os_management_hub_managed_instance_group_available_modules#regex DataOciOsManagementHubManagedInstanceGroupAvailableModules#regex}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
