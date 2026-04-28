using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabasePostgresqlConfig
{
    [JsiiInterface(nativeType: typeof(IDatabasePostgresqlConfigTimescaledb), fullyQualifiedName: "digitalocean.databasePostgresqlConfig.DatabasePostgresqlConfigTimescaledb")]
    public interface IDatabasePostgresqlConfigTimescaledb
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#max_background_workers DatabasePostgresqlConfig#max_background_workers}.</summary>
        [JsiiProperty(name: "maxBackgroundWorkers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxBackgroundWorkers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabasePostgresqlConfigTimescaledb), fullyQualifiedName: "digitalocean.databasePostgresqlConfig.DatabasePostgresqlConfigTimescaledb")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DatabasePostgresqlConfig.IDatabasePostgresqlConfigTimescaledb
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#max_background_workers DatabasePostgresqlConfig#max_background_workers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxBackgroundWorkers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxBackgroundWorkers
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
