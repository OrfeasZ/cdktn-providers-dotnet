using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PostgresqlFlexibleServer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.postgresqlFlexibleServer.PostgresqlFlexibleServerIdentity")]
    public class PostgresqlFlexibleServerIdentity : azurerm.PostgresqlFlexibleServer.IPostgresqlFlexibleServerIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/postgresql_flexible_server#type PostgresqlFlexibleServer#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/postgresql_flexible_server#identity_ids PostgresqlFlexibleServer#identity_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IdentityIds
        {
            get;
            set;
        }
    }
}
