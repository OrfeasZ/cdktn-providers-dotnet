using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareCustomHostname
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareCustomHostnameFilter), fullyQualifiedName: "cloudflare.dataCloudflareCustomHostname.DataCloudflareCustomHostnameFilter")]
    public interface IDataCloudflareCustomHostnameFilter
    {
        /// <summary>Direction to order hostnames. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/custom_hostname#direction DataCloudflareCustomHostname#direction}
        /// </remarks>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Fully qualified domain name to match against. This parameter cannot be used with the 'id' parameter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/custom_hostname#hostname DataCloudflareCustomHostname#hostname}
        /// </remarks>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Hostname
        {
            get
            {
                return null;
            }
        }

        /// <summary>Hostname ID to match against.</summary>
        /// <remarks>
        /// This ID was generated and returned during the initial custom_hostname creation. This parameter cannot be used with the 'hostname' parameter.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/custom_hostname#id DataCloudflareCustomHostname#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Field to order hostnames by. Available values: "ssl", "ssl_status".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/custom_hostname#order DataCloudflareCustomHostname#order}
        /// </remarks>
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Order
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to filter hostnames based on if they have SSL enabled. Available values: 0, 1.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/custom_hostname#ssl DataCloudflareCustomHostname#ssl}
        /// </remarks>
        [JsiiProperty(name: "ssl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Ssl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareCustomHostnameFilter), fullyQualifiedName: "cloudflare.dataCloudflareCustomHostname.DataCloudflareCustomHostnameFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareCustomHostname.IDataCloudflareCustomHostnameFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Direction to order hostnames. Available values: "asc", "desc".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/custom_hostname#direction DataCloudflareCustomHostname#direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Fully qualified domain name to match against. This parameter cannot be used with the 'id' parameter.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/custom_hostname#hostname DataCloudflareCustomHostname#hostname}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Hostname
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Hostname ID to match against.</summary>
            /// <remarks>
            /// This ID was generated and returned during the initial custom_hostname creation. This parameter cannot be used with the 'hostname' parameter.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/custom_hostname#id DataCloudflareCustomHostname#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Field to order hostnames by. Available values: "ssl", "ssl_status".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/custom_hostname#order DataCloudflareCustomHostname#order}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Order
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether to filter hostnames based on if they have SSL enabled. Available values: 0, 1.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/custom_hostname#ssl DataCloudflareCustomHostname#ssl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ssl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Ssl
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
