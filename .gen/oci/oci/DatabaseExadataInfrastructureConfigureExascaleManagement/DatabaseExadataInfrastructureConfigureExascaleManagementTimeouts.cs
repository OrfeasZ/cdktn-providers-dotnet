using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExadataInfrastructureConfigureExascaleManagement
{
    [JsiiByValue(fqn: "oci.databaseExadataInfrastructureConfigureExascaleManagement.DatabaseExadataInfrastructureConfigureExascaleManagementTimeouts")]
    public class DatabaseExadataInfrastructureConfigureExascaleManagementTimeouts : oci.DatabaseExadataInfrastructureConfigureExascaleManagement.IDatabaseExadataInfrastructureConfigureExascaleManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure_configure_exascale_management#create DatabaseExadataInfrastructureConfigureExascaleManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure_configure_exascale_management#delete DatabaseExadataInfrastructureConfigureExascaleManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure_configure_exascale_management#update DatabaseExadataInfrastructureConfigureExascaleManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
