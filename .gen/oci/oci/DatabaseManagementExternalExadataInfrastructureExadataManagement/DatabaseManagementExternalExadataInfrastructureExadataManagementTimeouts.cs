using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalExadataInfrastructureExadataManagement
{
    [JsiiByValue(fqn: "oci.databaseManagementExternalExadataInfrastructureExadataManagement.DatabaseManagementExternalExadataInfrastructureExadataManagementTimeouts")]
    public class DatabaseManagementExternalExadataInfrastructureExadataManagementTimeouts : oci.DatabaseManagementExternalExadataInfrastructureExadataManagement.IDatabaseManagementExternalExadataInfrastructureExadataManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_exadata_infrastructure_exadata_management#create DatabaseManagementExternalExadataInfrastructureExadataManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_exadata_infrastructure_exadata_management#delete DatabaseManagementExternalExadataInfrastructureExadataManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_exadata_infrastructure_exadata_management#update DatabaseManagementExternalExadataInfrastructureExadataManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
