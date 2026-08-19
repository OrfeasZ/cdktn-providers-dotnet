using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudExadataInfrastructure
{
    [JsiiByValue(fqn: "oci.databaseCloudExadataInfrastructure.DatabaseCloudExadataInfrastructureMaintenanceVersionPreferences")]
    public class DatabaseCloudExadataInfrastructureMaintenanceVersionPreferences : oci.DatabaseCloudExadataInfrastructure.IDatabaseCloudExadataInfrastructureMaintenanceVersionPreferences
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_cloud_exadata_infrastructure#reference_resource_id_for_image_updates DatabaseCloudExadataInfrastructure#reference_resource_id_for_image_updates}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "referenceResourceIdForImageUpdates", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReferenceResourceIdForImageUpdates
        {
            get;
            set;
        }
    }
}
