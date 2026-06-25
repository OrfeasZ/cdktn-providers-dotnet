using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig
{
    [JsiiByValue(fqn: "oci.databaseToolsDatabaseToolsDatabaseApiGatewayConfig.DatabaseToolsDatabaseToolsDatabaseApiGatewayConfigTimeouts")]
    public class DatabaseToolsDatabaseToolsDatabaseApiGatewayConfigTimeouts : oci.DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig.IDatabaseToolsDatabaseToolsDatabaseApiGatewayConfigTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_tools_database_tools_database_api_gateway_config#create DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_tools_database_tools_database_api_gateway_config#delete DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_tools_database_tools_database_api_gateway_config#update DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
