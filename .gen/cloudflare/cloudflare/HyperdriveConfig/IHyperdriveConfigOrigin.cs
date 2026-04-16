using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.HyperdriveConfig
{
    [JsiiInterface(nativeType: typeof(IHyperdriveConfigOrigin), fullyQualifiedName: "cloudflare.hyperdriveConfig.HyperdriveConfigOrigin")]
    public interface IHyperdriveConfigOrigin
    {
        /// <summary>Set the name of your origin database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config#database HyperdriveConfig#database}
        /// </remarks>
        [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}")]
        string Database
        {
            get;
        }

        /// <summary>Defines the host (hostname or IP) of your origin database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config#host HyperdriveConfig#host}
        /// </remarks>
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
        string Host
        {
            get;
        }

        /// <summary>Set the password needed to access your origin database. The API never returns this write-only value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config#password HyperdriveConfig#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>Specifies the URL scheme used to connect to your origin database. Available values: "postgres", "postgresql", "mysql".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config#scheme HyperdriveConfig#scheme}
        /// </remarks>
        [JsiiProperty(name: "scheme", typeJson: "{\"primitive\":\"string\"}")]
        string Scheme
        {
            get;
        }

        /// <summary>Set the user of your origin database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config#user HyperdriveConfig#user}
        /// </remarks>
        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}")]
        string User
        {
            get;
        }

        /// <summary>Defines the Client ID of the Access token to use when connecting to the origin database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config#access_client_id HyperdriveConfig#access_client_id}
        /// </remarks>
        [JsiiProperty(name: "accessClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessClientId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines the Client Secret of the Access Token to use when connecting to the origin database.</summary>
        /// <remarks>
        /// The API never returns this write-only value.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config#access_client_secret HyperdriveConfig#access_client_secret}
        /// </remarks>
        [JsiiProperty(name: "accessClientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessClientSecret
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines the port of your origin database. Defaults to 5432 for PostgreSQL or 3306 for MySQL if not specified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config#port HyperdriveConfig#port}
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

        [JsiiTypeProxy(nativeType: typeof(IHyperdriveConfigOrigin), fullyQualifiedName: "cloudflare.hyperdriveConfig.HyperdriveConfigOrigin")]
        internal sealed class _Proxy : DeputyBase, cloudflare.HyperdriveConfig.IHyperdriveConfigOrigin
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Set the name of your origin database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config#database HyperdriveConfig#database}
            /// </remarks>
            [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}")]
            public string Database
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Defines the host (hostname or IP) of your origin database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config#host HyperdriveConfig#host}
            /// </remarks>
            [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
            public string Host
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Set the password needed to access your origin database. The API never returns this write-only value.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config#password HyperdriveConfig#password}
            /// </remarks>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Specifies the URL scheme used to connect to your origin database. Available values: "postgres", "postgresql", "mysql".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config#scheme HyperdriveConfig#scheme}
            /// </remarks>
            [JsiiProperty(name: "scheme", typeJson: "{\"primitive\":\"string\"}")]
            public string Scheme
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Set the user of your origin database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config#user HyperdriveConfig#user}
            /// </remarks>
            [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}")]
            public string User
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Defines the Client ID of the Access token to use when connecting to the origin database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config#access_client_id HyperdriveConfig#access_client_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessClientId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Defines the Client Secret of the Access Token to use when connecting to the origin database.</summary>
            /// <remarks>
            /// The API never returns this write-only value.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config#access_client_secret HyperdriveConfig#access_client_secret}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessClientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessClientSecret
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Defines the port of your origin database. Defaults to 5432 for PostgreSQL or 3306 for MySQL if not specified.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hyperdrive_config#port HyperdriveConfig#port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
