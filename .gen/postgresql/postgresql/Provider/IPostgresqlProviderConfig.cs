using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace postgresql.Provider
{
    [JsiiInterface(nativeType: typeof(IPostgresqlProviderConfig), fullyQualifiedName: "postgresql.provider.PostgresqlProviderConfig")]
    public interface IPostgresqlProviderConfig
    {
        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#alias PostgresqlProvider#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>Use rds_iam instead of password authentication (see: https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.IAMDBAuth.html).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#aws_rds_iam_auth PostgresqlProvider#aws_rds_iam_auth}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "awsRdsIamAuth", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AwsRdsIamAuth
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS profile to use for IAM auth.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#aws_rds_iam_profile PostgresqlProvider#aws_rds_iam_profile}
        /// </remarks>
        [JsiiProperty(name: "awsRdsIamProfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AwsRdsIamProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS IAM role to assume for IAM auth.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#aws_rds_iam_provider_role_arn PostgresqlProvider#aws_rds_iam_provider_role_arn}
        /// </remarks>
        [JsiiProperty(name: "awsRdsIamProviderRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AwsRdsIamProviderRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS region to use for IAM auth.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#aws_rds_iam_region PostgresqlProvider#aws_rds_iam_region}
        /// </remarks>
        [JsiiProperty(name: "awsRdsIamRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AwsRdsIamRegion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Use MS Azure identity OAuth token (see: https://learn.microsoft.com/en-us/azure/postgresql/flexible-server/how-to-configure-sign-in-azure-ad-authentication).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#azure_identity_auth PostgresqlProvider#azure_identity_auth}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "azureIdentityAuth", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AzureIdentityAuth
        {
            get
            {
                return null;
            }
        }

        /// <summary>MS Azure tenant ID (see: https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs/data-sources/client_config.html).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#azure_tenant_id PostgresqlProvider#azure_tenant_id}
        /// </remarks>
        [JsiiProperty(name: "azureTenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AzureTenantId
        {
            get
            {
                return null;
            }
        }

        /// <summary>clientcert block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#clientcert PostgresqlProvider#clientcert}
        /// </remarks>
        [JsiiProperty(name: "clientcert", typeJson: "{\"fqn\":\"postgresql.provider.PostgresqlProviderClientcert\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        postgresql.Provider.IPostgresqlProviderClientcert? Clientcert
        {
            get
            {
                return null;
            }
        }

        /// <summary>Maximum wait for connection, in seconds. Zero or not specified means wait indefinitely.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#connect_timeout PostgresqlProvider#connect_timeout}
        /// </remarks>
        [JsiiProperty(name: "connectTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConnectTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the database to connect to in order to connect to (defaults to `postgres`).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#database PostgresqlProvider#database}
        /// </remarks>
        [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Database
        {
            get
            {
                return null;
            }
        }

        /// <summary>Database username associated to the connected user (for user name maps).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#database_username PostgresqlProvider#database_username}
        /// </remarks>
        [JsiiProperty(name: "databaseUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseUsername
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specify the expected version of PostgreSQL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#expected_version PostgresqlProvider#expected_version}
        /// </remarks>
        [JsiiProperty(name: "expectedVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExpectedVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Service account to impersonate when using GCP IAM authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#gcp_iam_impersonate_service_account PostgresqlProvider#gcp_iam_impersonate_service_account}
        /// </remarks>
        [JsiiProperty(name: "gcpIamImpersonateServiceAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GcpIamImpersonateServiceAccount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of PostgreSQL server address to connect to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#host PostgresqlProvider#host}
        /// </remarks>
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Host
        {
            get
            {
                return null;
            }
        }

        /// <summary>Maximum number of connections to establish to the database. Zero means unlimited.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#max_connections PostgresqlProvider#max_connections}
        /// </remarks>
        [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxConnections
        {
            get
            {
                return null;
            }
        }

        /// <summary>Password to be used if the PostgreSQL server demands password authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#password PostgresqlProvider#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Password
        {
            get
            {
                return null;
            }
        }

        /// <summary>The PostgreSQL port number to connect to at the server host, or socket file name extension for Unix-domain connections.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#port PostgresqlProvider#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#scheme PostgresqlProvider#scheme}.</summary>
        [JsiiProperty(name: "scheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Scheme
        {
            get
            {
                return null;
            }
        }

        /// <summary>This option determines whether or with what priority a secure SSL TCP/IP connection will be negotiated with the PostgreSQL server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#sslmode PostgresqlProvider#sslmode}
        /// </remarks>
        [JsiiProperty(name: "sslmode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Sslmode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#ssl_mode PostgresqlProvider#ssl_mode}.</summary>
        [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SslMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>The SSL server root certificate file path. The file must contain PEM encoded data.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#sslrootcert PostgresqlProvider#sslrootcert}
        /// </remarks>
        [JsiiProperty(name: "sslrootcert", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Sslrootcert
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specify if the user to connect as is a Postgres superuser or not.If not, some feature might be disabled (e.g.: Refreshing state password from Postgres).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#superuser PostgresqlProvider#superuser}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "superuser", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Superuser
        {
            get
            {
                return null;
            }
        }

        /// <summary>PostgreSQL user name to connect as.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#username PostgresqlProvider#username}
        /// </remarks>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Username
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPostgresqlProviderConfig), fullyQualifiedName: "postgresql.provider.PostgresqlProviderConfig")]
        internal sealed class _Proxy : DeputyBase, postgresql.Provider.IPostgresqlProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Alias name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#alias PostgresqlProvider#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Alias
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Use rds_iam instead of password authentication (see: https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.IAMDBAuth.html).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#aws_rds_iam_auth PostgresqlProvider#aws_rds_iam_auth}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsRdsIamAuth", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AwsRdsIamAuth
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>AWS profile to use for IAM auth.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#aws_rds_iam_profile PostgresqlProvider#aws_rds_iam_profile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsRdsIamProfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AwsRdsIamProfile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>AWS IAM role to assume for IAM auth.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#aws_rds_iam_provider_role_arn PostgresqlProvider#aws_rds_iam_provider_role_arn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsRdsIamProviderRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AwsRdsIamProviderRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>AWS region to use for IAM auth.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#aws_rds_iam_region PostgresqlProvider#aws_rds_iam_region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsRdsIamRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AwsRdsIamRegion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Use MS Azure identity OAuth token (see: https://learn.microsoft.com/en-us/azure/postgresql/flexible-server/how-to-configure-sign-in-azure-ad-authentication).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#azure_identity_auth PostgresqlProvider#azure_identity_auth}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureIdentityAuth", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AzureIdentityAuth
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>MS Azure tenant ID (see: https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs/data-sources/client_config.html).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#azure_tenant_id PostgresqlProvider#azure_tenant_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureTenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AzureTenantId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>clientcert block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#clientcert PostgresqlProvider#clientcert}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientcert", typeJson: "{\"fqn\":\"postgresql.provider.PostgresqlProviderClientcert\"}", isOptional: true)]
            public postgresql.Provider.IPostgresqlProviderClientcert? Clientcert
            {
                get => GetInstanceProperty<postgresql.Provider.IPostgresqlProviderClientcert?>();
            }

            /// <summary>Maximum wait for connection, in seconds. Zero or not specified means wait indefinitely.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#connect_timeout PostgresqlProvider#connect_timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConnectTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The name of the database to connect to in order to connect to (defaults to `postgres`).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#database PostgresqlProvider#database}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Database
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Database username associated to the connected user (for user name maps).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#database_username PostgresqlProvider#database_username}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "databaseUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseUsername
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specify the expected version of PostgreSQL.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#expected_version PostgresqlProvider#expected_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expectedVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExpectedVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Service account to impersonate when using GCP IAM authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#gcp_iam_impersonate_service_account PostgresqlProvider#gcp_iam_impersonate_service_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gcpIamImpersonateServiceAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GcpIamImpersonateServiceAccount
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of PostgreSQL server address to connect to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#host PostgresqlProvider#host}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Host
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Maximum number of connections to establish to the database. Zero means unlimited.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#max_connections PostgresqlProvider#max_connections}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxConnections
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Password to be used if the PostgreSQL server demands password authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#password PostgresqlProvider#password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Password
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The PostgreSQL port number to connect to at the server host, or socket file name extension for Unix-domain connections.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#port PostgresqlProvider#port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#scheme PostgresqlProvider#scheme}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Scheme
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>This option determines whether or with what priority a secure SSL TCP/IP connection will be negotiated with the PostgreSQL server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#sslmode PostgresqlProvider#sslmode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sslmode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Sslmode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#ssl_mode PostgresqlProvider#ssl_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SslMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The SSL server root certificate file path. The file must contain PEM encoded data.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#sslrootcert PostgresqlProvider#sslrootcert}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sslrootcert", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Sslrootcert
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specify if the user to connect as is a Postgres superuser or not.If not, some feature might be disabled (e.g.: Refreshing state password from Postgres).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#superuser PostgresqlProvider#superuser}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "superuser", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Superuser
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>PostgreSQL user name to connect as.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#username PostgresqlProvider#username}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Username
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
