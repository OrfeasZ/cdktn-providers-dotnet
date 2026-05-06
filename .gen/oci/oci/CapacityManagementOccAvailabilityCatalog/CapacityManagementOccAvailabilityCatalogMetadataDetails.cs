using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CapacityManagementOccAvailabilityCatalog
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.capacityManagementOccAvailabilityCatalog.CapacityManagementOccAvailabilityCatalogMetadataDetails")]
    public class CapacityManagementOccAvailabilityCatalogMetadataDetails : oci.CapacityManagementOccAvailabilityCatalog.ICapacityManagementOccAvailabilityCatalogMetadataDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/capacity_management_occ_availability_catalog#format_version CapacityManagementOccAvailabilityCatalog#format_version}.</summary>
        [JsiiProperty(name: "formatVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string FormatVersion
        {
            get;
            set;
        }
    }
}
