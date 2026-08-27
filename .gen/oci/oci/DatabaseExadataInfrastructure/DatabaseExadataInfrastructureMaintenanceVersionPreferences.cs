using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExadataInfrastructure
{
    [JsiiByValue(fqn: "oci.databaseExadataInfrastructure.DatabaseExadataInfrastructureMaintenanceVersionPreferences")]
    public class DatabaseExadataInfrastructureMaintenanceVersionPreferences : oci.DatabaseExadataInfrastructure.IDatabaseExadataInfrastructureMaintenanceVersionPreferences
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_exadata_infrastructure#reference_resource_id_for_image_updates DatabaseExadataInfrastructure#reference_resource_id_for_image_updates}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "referenceResourceIdForImageUpdates", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReferenceResourceIdForImageUpdates
        {
            get;
            set;
        }
    }
}
