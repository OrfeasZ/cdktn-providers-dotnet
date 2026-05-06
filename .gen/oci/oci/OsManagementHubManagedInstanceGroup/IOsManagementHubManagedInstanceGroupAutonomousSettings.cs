using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceGroup
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagedInstanceGroupAutonomousSettings), fullyQualifiedName: "oci.osManagementHubManagedInstanceGroup.OsManagementHubManagedInstanceGroupAutonomousSettings")]
    public interface IOsManagementHubManagedInstanceGroupAutonomousSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group#is_data_collection_authorized OsManagementHubManagedInstanceGroup#is_data_collection_authorized}.</summary>
        [JsiiProperty(name: "isDataCollectionAuthorized", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsDataCollectionAuthorized
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagedInstanceGroupAutonomousSettings), fullyQualifiedName: "oci.osManagementHubManagedInstanceGroup.OsManagementHubManagedInstanceGroupAutonomousSettings")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagedInstanceGroup.IOsManagementHubManagedInstanceGroupAutonomousSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group#is_data_collection_authorized OsManagementHubManagedInstanceGroup#is_data_collection_authorized}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isDataCollectionAuthorized", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsDataCollectionAuthorized
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
