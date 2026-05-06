using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeTargetDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataSafeTargetDatabase.DataSafeTargetDatabaseConnectionOption")]
    public class DataSafeTargetDatabaseConnectionOption : oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseConnectionOption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#connection_type DataSafeTargetDatabase#connection_type}.</summary>
        [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}")]
        public string ConnectionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#datasafe_private_endpoint_id DataSafeTargetDatabase#datasafe_private_endpoint_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "datasafePrivateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatasafePrivateEndpointId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#on_prem_connector_id DataSafeTargetDatabase#on_prem_connector_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onPremConnectorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OnPremConnectorId
        {
            get;
            set;
        }
    }
}
