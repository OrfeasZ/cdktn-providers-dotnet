using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseToolsRuntimeDatabaseToolsConnectionPropertySet.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProvider")]
    public class DatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProvider : oci.DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet.IDatabaseToolsRuntimeDatabaseToolsConnectionPropertySetIdentityProvider
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#type DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/database_tools_runtime_database_tools_connection_property_set#configs DatabaseToolsRuntimeDatabaseToolsConnectionPropertySet#configs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Configs
        {
            get;
            set;
        }
    }
}
