using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareCustomHostname
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareCustomHostname.DataCloudflareCustomHostnameFilter")]
    public class DataCloudflareCustomHostnameFilter : cloudflare.DataCloudflareCustomHostname.IDataCloudflareCustomHostnameFilter
    {
        /// <summary>Filter by the certificate authority that issued the SSL certificate. Available values: "google", "lets_encrypt", "ssl_com".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/custom_hostname#certificate_authority DataCloudflareCustomHostname#certificate_authority}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "certificateAuthority", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateAuthority
        {
            get;
            set;
        }

        /// <summary>Filter by custom origin server name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/custom_hostname#custom_origin_server DataCloudflareCustomHostname#custom_origin_server}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customOriginServer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomOriginServer
        {
            get;
            set;
        }

        /// <summary>Direction to order hostnames. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/custom_hostname#direction DataCloudflareCustomHostname#direction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/custom_hostname#hostname DataCloudflareCustomHostname#hostname}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostname", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCustomHostname.DataCloudflareCustomHostnameFilterHostname\"}", isOptional: true)]
        public cloudflare.DataCloudflareCustomHostname.IDataCloudflareCustomHostnameFilterHostname? Hostname
        {
            get;
            set;
        }

        /// <summary>Filter by the hostname's activation status.</summary>
        /// <remarks>
        /// Available values: "active", "pending", "active_redeploying", "moved", "pending_deletion", "deleted", "pending_blocked", "pending_migration", "pending_provisioned", "test_pending", "test_active", "test_active_apex", "test_blocked", "test_failed", "provisioned", "blocked".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/custom_hostname#hostname_status DataCloudflareCustomHostname#hostname_status}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostnameStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostnameStatus
        {
            get;
            set;
        }

        /// <summary>Hostname ID to match against.</summary>
        /// <remarks>
        /// This ID was generated and returned during the initial custom_hostname creation. This parameter cannot be used with the 'hostname' parameter.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/custom_hostname#id DataCloudflareCustomHostname#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Field to order hostnames by. Available values: "ssl", "ssl_status".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/custom_hostname#order DataCloudflareCustomHostname#order}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Order
        {
            get;
            set;
        }

        /// <summary>Whether to filter hostnames based on if they have SSL enabled. Available values: 0, 1.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/custom_hostname#ssl DataCloudflareCustomHostname#ssl}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ssl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Ssl
        {
            get;
            set;
        }

        /// <summary>Filter by SSL certificate status.</summary>
        /// <remarks>
        /// Available values: "initializing", "pending_validation", "deleted", "pending_issuance", "pending_deployment", "pending_deletion", "pending_expiration", "expired", "active", "initializing_timed_out", "validation_timed_out", "issuance_timed_out", "deployment_timed_out", "deletion_timed_out", "pending_cleanup", "staging_deployment", "staging_active", "deactivating", "inactive", "backup_issued", "holding_deployment".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/custom_hostname#ssl_status DataCloudflareCustomHostname#ssl_status}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sslStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslStatus
        {
            get;
            set;
        }

        private object? _wildcard;

        /// <summary>Filter by whether the custom hostname is a wildcard hostname.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/custom_hostname#wildcard DataCloudflareCustomHostname#wildcard}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "wildcard", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Wildcard
        {
            get => _wildcard;
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
                _wildcard = value;
            }
        }
    }
}
