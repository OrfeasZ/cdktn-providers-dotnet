using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PostgresqlFlexibleServer
{
    [JsiiInterface(nativeType: typeof(IPostgresqlFlexibleServerCluster), fullyQualifiedName: "azurerm.postgresqlFlexibleServer.PostgresqlFlexibleServerCluster")]
    public interface IPostgresqlFlexibleServerCluster
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/postgresql_flexible_server#size PostgresqlFlexibleServer#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        double Size
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/postgresql_flexible_server#default_database_name PostgresqlFlexibleServer#default_database_name}.</summary>
        [JsiiProperty(name: "defaultDatabaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultDatabaseName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPostgresqlFlexibleServerCluster), fullyQualifiedName: "azurerm.postgresqlFlexibleServer.PostgresqlFlexibleServerCluster")]
        internal sealed class _Proxy : DeputyBase, azurerm.PostgresqlFlexibleServer.IPostgresqlFlexibleServerCluster
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/postgresql_flexible_server#size PostgresqlFlexibleServer#size}.</summary>
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
            public double Size
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/postgresql_flexible_server#default_database_name PostgresqlFlexibleServer#default_database_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultDatabaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultDatabaseName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
