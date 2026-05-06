using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOsManagementHubManagedInstanceAvailablePackages
{
    [JsiiInterface(nativeType: typeof(IDataOciOsManagementHubManagedInstanceAvailablePackagesFilter), fullyQualifiedName: "oci.dataOciOsManagementHubManagedInstanceAvailablePackages.DataOciOsManagementHubManagedInstanceAvailablePackagesFilter")]
    public interface IDataOciOsManagementHubManagedInstanceAvailablePackagesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_managed_instance_available_packages#name DataOciOsManagementHubManagedInstanceAvailablePackages#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_managed_instance_available_packages#values DataOciOsManagementHubManagedInstanceAvailablePackages#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_managed_instance_available_packages#regex DataOciOsManagementHubManagedInstanceAvailablePackages#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciOsManagementHubManagedInstanceAvailablePackagesFilter), fullyQualifiedName: "oci.dataOciOsManagementHubManagedInstanceAvailablePackages.DataOciOsManagementHubManagedInstanceAvailablePackagesFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciOsManagementHubManagedInstanceAvailablePackages.IDataOciOsManagementHubManagedInstanceAvailablePackagesFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_managed_instance_available_packages#name DataOciOsManagementHubManagedInstanceAvailablePackages#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_managed_instance_available_packages#values DataOciOsManagementHubManagedInstanceAvailablePackages#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_managed_instance_available_packages#regex DataOciOsManagementHubManagedInstanceAvailablePackages#regex}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
