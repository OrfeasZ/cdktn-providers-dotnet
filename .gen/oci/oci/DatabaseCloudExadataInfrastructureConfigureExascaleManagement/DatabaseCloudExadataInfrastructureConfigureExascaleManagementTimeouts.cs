using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudExadataInfrastructureConfigureExascaleManagement
{
    [JsiiByValue(fqn: "oci.databaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagementTimeouts")]
    public class DatabaseCloudExadataInfrastructureConfigureExascaleManagementTimeouts : oci.DatabaseCloudExadataInfrastructureConfigureExascaleManagement.IDatabaseCloudExadataInfrastructureConfigureExascaleManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure_configure_exascale_management#create DatabaseCloudExadataInfrastructureConfigureExascaleManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure_configure_exascale_management#delete DatabaseCloudExadataInfrastructureConfigureExascaleManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure_configure_exascale_management#update DatabaseCloudExadataInfrastructureConfigureExascaleManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
