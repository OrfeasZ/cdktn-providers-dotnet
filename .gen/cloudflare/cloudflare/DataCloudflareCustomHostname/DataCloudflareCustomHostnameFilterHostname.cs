using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareCustomHostname
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareCustomHostname.DataCloudflareCustomHostnameFilterHostname")]
    public class DataCloudflareCustomHostnameFilterHostname : cloudflare.DataCloudflareCustomHostname.IDataCloudflareCustomHostnameFilterHostname
    {
        /// <summary>Filters hostnames by a substring match on the hostname value.</summary>
        /// <remarks>
        /// This parameter cannot be used with the 'id', 'hostname', 'hostname.exact', or 'hostname.startsWith' parameters.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/data-sources/custom_hostname#contain DataCloudflareCustomHostname#contain}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "contain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Contain
        {
            get;
            set;
        }

        /// <summary>Fully qualified domain name to match against.</summary>
        /// <remarks>
        /// This parameter cannot be used with the 'id', 'hostname', 'hostname.contain', or 'hostname.startsWith' parameters.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/data-sources/custom_hostname#exact DataCloudflareCustomHostname#exact}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Exact
        {
            get;
            set;
        }

        /// <summary>Filters hostnames by a prefix match on the hostname value.</summary>
        /// <remarks>
        /// This parameter cannot be used with the 'id', 'hostname', 'hostname.exact', or 'hostname.contain' parameters.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/data-sources/custom_hostname#starts_with DataCloudflareCustomHostname#starts_with}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "startsWith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartsWith
        {
            get;
            set;
        }
    }
}
