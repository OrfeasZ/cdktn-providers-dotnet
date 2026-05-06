using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CapacityManagementOccAvailabilityCatalog
{
    [JsiiInterface(nativeType: typeof(ICapacityManagementOccAvailabilityCatalogMetadataDetails), fullyQualifiedName: "oci.capacityManagementOccAvailabilityCatalog.CapacityManagementOccAvailabilityCatalogMetadataDetails")]
    public interface ICapacityManagementOccAvailabilityCatalogMetadataDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_availability_catalog#format_version CapacityManagementOccAvailabilityCatalog#format_version}.</summary>
        [JsiiProperty(name: "formatVersion", typeJson: "{\"primitive\":\"string\"}")]
        string FormatVersion
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICapacityManagementOccAvailabilityCatalogMetadataDetails), fullyQualifiedName: "oci.capacityManagementOccAvailabilityCatalog.CapacityManagementOccAvailabilityCatalogMetadataDetails")]
        internal sealed class _Proxy : DeputyBase, oci.CapacityManagementOccAvailabilityCatalog.ICapacityManagementOccAvailabilityCatalogMetadataDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_availability_catalog#format_version CapacityManagementOccAvailabilityCatalog#format_version}.</summary>
            [JsiiProperty(name: "formatVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string FormatVersion
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
