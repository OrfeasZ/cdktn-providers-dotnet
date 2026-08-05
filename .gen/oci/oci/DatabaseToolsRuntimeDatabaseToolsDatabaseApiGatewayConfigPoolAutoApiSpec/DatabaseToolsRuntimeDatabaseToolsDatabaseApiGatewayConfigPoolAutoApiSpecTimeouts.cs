using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec
{
    [JsiiByValue(fqn: "oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpecTimeouts")]
    public class DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpecTimeouts : oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpecTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#create DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#delete DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool_auto_api_spec#update DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolAutoApiSpec#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
