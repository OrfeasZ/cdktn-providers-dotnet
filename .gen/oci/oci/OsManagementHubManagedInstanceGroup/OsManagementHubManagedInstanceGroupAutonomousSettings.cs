using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceGroup
{
    [JsiiByValue(fqn: "oci.osManagementHubManagedInstanceGroup.OsManagementHubManagedInstanceGroupAutonomousSettings")]
    public class OsManagementHubManagedInstanceGroupAutonomousSettings : oci.OsManagementHubManagedInstanceGroup.IOsManagementHubManagedInstanceGroupAutonomousSettings
    {
        private object? _isDataCollectionAuthorized;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group#is_data_collection_authorized OsManagementHubManagedInstanceGroup#is_data_collection_authorized}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isDataCollectionAuthorized", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsDataCollectionAuthorized
        {
            get => _isDataCollectionAuthorized;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isDataCollectionAuthorized = value;
            }
        }
    }
}
