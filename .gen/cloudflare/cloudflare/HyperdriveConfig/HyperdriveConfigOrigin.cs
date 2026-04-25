using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.HyperdriveConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.hyperdriveConfig.HyperdriveConfigOrigin")]
    public class HyperdriveConfigOrigin : cloudflare.HyperdriveConfig.IHyperdriveConfigOrigin
    {
        /// <summary>Set the name of your origin database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/hyperdrive_config#database HyperdriveConfig#database}
        /// </remarks>
        [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}")]
        public string Database
        {
            get;
            set;
        }

        /// <summary>Set the password needed to access your origin database. The API never returns this write-only value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/hyperdrive_config#password HyperdriveConfig#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>Specifies the URL scheme used to connect to your origin database. Available values: "postgres", "postgresql", "mysql".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/hyperdrive_config#scheme HyperdriveConfig#scheme}
        /// </remarks>
        [JsiiProperty(name: "scheme", typeJson: "{\"primitive\":\"string\"}")]
        public string Scheme
        {
            get;
            set;
        }

        /// <summary>Set the user of your origin database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/hyperdrive_config#user HyperdriveConfig#user}
        /// </remarks>
        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}")]
        public string User
        {
            get;
            set;
        }

        /// <summary>Defines the Client ID of the Access token to use when connecting to the origin database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/hyperdrive_config#access_client_id HyperdriveConfig#access_client_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessClientId
        {
            get;
            set;
        }

        /// <summary>Defines the Client Secret of the Access Token to use when connecting to the origin database.</summary>
        /// <remarks>
        /// The API never returns this write-only value.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/hyperdrive_config#access_client_secret HyperdriveConfig#access_client_secret}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessClientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessClientSecret
        {
            get;
            set;
        }

        /// <summary>Defines the host (hostname or IP) of your origin database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/hyperdrive_config#host HyperdriveConfig#host}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Host
        {
            get;
            set;
        }

        /// <summary>Defines the port of your origin database. Defaults to 5432 for PostgreSQL or 3306 for MySQL if not specified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/hyperdrive_config#port HyperdriveConfig#port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>The identifier of the Workers VPC Service to connect through.</summary>
        /// <remarks>
        /// Hyperdrive will egress through the specified VPC Service to reach the origin database.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/hyperdrive_config#service_id HyperdriveConfig#service_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceId
        {
            get;
            set;
        }
    }
}
