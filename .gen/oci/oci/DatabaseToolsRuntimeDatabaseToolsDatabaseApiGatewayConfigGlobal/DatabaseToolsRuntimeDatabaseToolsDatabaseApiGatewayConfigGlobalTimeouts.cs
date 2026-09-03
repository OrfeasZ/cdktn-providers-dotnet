using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal
{
    [JsiiByValue(fqn: "oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalTimeouts")]
    public class DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalTimeouts : oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#create DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#delete DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#update DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
