using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseToolsDatabaseToolsDatabaseApiGatewayConfig.DatabaseToolsDatabaseToolsDatabaseApiGatewayConfigLocks")]
    public class DatabaseToolsDatabaseToolsDatabaseApiGatewayConfigLocks : oci.DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig.IDatabaseToolsDatabaseToolsDatabaseApiGatewayConfigLocks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_tools_database_tools_database_api_gateway_config#type DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_tools_database_tools_database_api_gateway_config#message DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Message
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_tools_database_tools_database_api_gateway_config#related_resource_id DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#related_resource_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "relatedResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RelatedResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_tools_database_tools_database_api_gateway_config#time_created DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#time_created}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeCreated
        {
            get;
            set;
        }
    }
}
