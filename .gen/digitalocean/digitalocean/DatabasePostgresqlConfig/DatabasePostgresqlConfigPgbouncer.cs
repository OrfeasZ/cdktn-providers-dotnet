using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabasePostgresqlConfig
{
    [JsiiByValue(fqn: "digitalocean.databasePostgresqlConfig.DatabasePostgresqlConfigPgbouncer")]
    public class DatabasePostgresqlConfigPgbouncer : digitalocean.DatabasePostgresqlConfig.IDatabasePostgresqlConfigPgbouncer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#autodb_idle_timeout DatabasePostgresqlConfig#autodb_idle_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autodbIdleTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutodbIdleTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#autodb_max_db_connections DatabasePostgresqlConfig#autodb_max_db_connections}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autodbMaxDbConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutodbMaxDbConnections
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#autodb_pool_mode DatabasePostgresqlConfig#autodb_pool_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autodbPoolMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutodbPoolMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#autodb_pool_size DatabasePostgresqlConfig#autodb_pool_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autodbPoolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutodbPoolSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#ignore_startup_parameters DatabasePostgresqlConfig#ignore_startup_parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ignoreStartupParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IgnoreStartupParameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#min_pool_size DatabasePostgresqlConfig#min_pool_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minPoolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinPoolSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#server_idle_timeout DatabasePostgresqlConfig#server_idle_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serverIdleTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ServerIdleTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#server_lifetime DatabasePostgresqlConfig#server_lifetime}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serverLifetime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ServerLifetime
        {
            get;
            set;
        }

        private object? _serverResetQueryAlways;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_postgresql_config#server_reset_query_always DatabasePostgresqlConfig#server_reset_query_always}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serverResetQueryAlways", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ServerResetQueryAlways
        {
            get => _serverResetQueryAlways;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _serverResetQueryAlways = value;
            }
        }
    }
}
