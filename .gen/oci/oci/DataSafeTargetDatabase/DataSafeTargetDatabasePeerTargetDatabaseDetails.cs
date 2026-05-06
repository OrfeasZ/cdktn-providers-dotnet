using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeTargetDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetails")]
    public class DataSafeTargetDatabasePeerTargetDatabaseDetails : oci.DataSafeTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDetails
    {
        /// <summary>database_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#database_details DataSafeTargetDatabase#database_details}
        /// </remarks>
        [JsiiProperty(name: "databaseDetails", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetailsDatabaseDetails\"}")]
        public oci.DataSafeTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDetailsDatabaseDetails DatabaseDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#dataguard_association_id DataSafeTargetDatabase#dataguard_association_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataguardAssociationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataguardAssociationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#description DataSafeTargetDatabase#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#display_name DataSafeTargetDatabase#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }

        /// <summary>tls_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#tls_config DataSafeTargetDatabase#tls_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tlsConfig", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetailsTlsConfig\"}", isOptional: true)]
        public oci.DataSafeTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDetailsTlsConfig? TlsConfig
        {
            get;
            set;
        }
    }
}
