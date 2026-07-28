using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PostgresqlFlexibleServer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.postgresqlFlexibleServer.PostgresqlFlexibleServerCluster")]
    public class PostgresqlFlexibleServerCluster : azurerm.PostgresqlFlexibleServer.IPostgresqlFlexibleServerCluster
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/postgresql_flexible_server#size PostgresqlFlexibleServer#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public double Size
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/postgresql_flexible_server#default_database_name PostgresqlFlexibleServer#default_database_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultDatabaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultDatabaseName
        {
            get;
            set;
        }
    }
}
