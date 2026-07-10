using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareCustomHostname
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareCustomHostnameFilterHostname), fullyQualifiedName: "cloudflare.dataCloudflareCustomHostname.DataCloudflareCustomHostnameFilterHostname")]
    public interface IDataCloudflareCustomHostnameFilterHostname
    {
        /// <summary>Filters hostnames by a substring match on the hostname value.</summary>
        /// <remarks>
        /// This parameter cannot be used with the 'id', 'hostname', 'hostname.exact', or 'hostname.startsWith' parameters.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/data-sources/custom_hostname#contain DataCloudflareCustomHostname#contain}
        /// </remarks>
        [JsiiProperty(name: "contain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Contain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Fully qualified domain name to match against.</summary>
        /// <remarks>
        /// This parameter cannot be used with the 'id', 'hostname', 'hostname.contain', or 'hostname.startsWith' parameters.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/data-sources/custom_hostname#exact DataCloudflareCustomHostname#exact}
        /// </remarks>
        [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Exact
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filters hostnames by a prefix match on the hostname value.</summary>
        /// <remarks>
        /// This parameter cannot be used with the 'id', 'hostname', 'hostname.exact', or 'hostname.contain' parameters.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/data-sources/custom_hostname#starts_with DataCloudflareCustomHostname#starts_with}
        /// </remarks>
        [JsiiProperty(name: "startsWith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartsWith
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareCustomHostnameFilterHostname), fullyQualifiedName: "cloudflare.dataCloudflareCustomHostname.DataCloudflareCustomHostnameFilterHostname")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareCustomHostname.IDataCloudflareCustomHostnameFilterHostname
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
