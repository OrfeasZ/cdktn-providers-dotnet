using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudExadataInfrastructure
{
    [JsiiByValue(fqn: "oci.databaseCloudExadataInfrastructure.DatabaseCloudExadataInfrastructureCustomerContacts")]
    public class DatabaseCloudExadataInfrastructureCustomerContacts : oci.DatabaseCloudExadataInfrastructure.IDatabaseCloudExadataInfrastructureCustomerContacts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#email DatabaseCloudExadataInfrastructure#email}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Email
        {
            get;
            set;
        }
    }
}
