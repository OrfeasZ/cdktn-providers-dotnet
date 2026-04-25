using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZoneLockdown
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareZoneLockdownFilter), fullyQualifiedName: "cloudflare.dataCloudflareZoneLockdown.DataCloudflareZoneLockdownFilter")]
    public interface IDataCloudflareZoneLockdownFilter
    {
        /// <summary>The timestamp of when the rule was created.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone_lockdown#created_on DataCloudflareZoneLockdown#created_on}
        /// </remarks>
        [JsiiProperty(name: "createdOn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CreatedOn
        {
            get
            {
                return null;
            }
        }

        /// <summary>A string to search for in the description of existing rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone_lockdown#description DataCloudflareZoneLockdown#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>A string to search for in the description of existing rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone_lockdown#description_search DataCloudflareZoneLockdown#description_search}
        /// </remarks>
        [JsiiProperty(name: "descriptionSearch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DescriptionSearch
        {
            get
            {
                return null;
            }
        }

        /// <summary>A single IP address to search for in existing rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone_lockdown#ip DataCloudflareZoneLockdown#ip}
        /// </remarks>
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ip
        {
            get
            {
                return null;
            }
        }

        /// <summary>A single IP address range to search for in existing rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone_lockdown#ip_range_search DataCloudflareZoneLockdown#ip_range_search}
        /// </remarks>
        [JsiiProperty(name: "ipRangeSearch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpRangeSearch
        {
            get
            {
                return null;
            }
        }

        /// <summary>A single IP address to search for in existing rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone_lockdown#ip_search DataCloudflareZoneLockdown#ip_search}
        /// </remarks>
        [JsiiProperty(name: "ipSearch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpSearch
        {
            get
            {
                return null;
            }
        }

        /// <summary>The timestamp of when the rule was last modified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone_lockdown#modified_on DataCloudflareZoneLockdown#modified_on}
        /// </remarks>
        [JsiiProperty(name: "modifiedOn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ModifiedOn
        {
            get
            {
                return null;
            }
        }

        /// <summary>The priority of the rule to control the processing order.</summary>
        /// <remarks>
        /// A lower number indicates higher priority. If not provided, any rules with a configured priority will be processed before rules without a priority.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone_lockdown#priority DataCloudflareZoneLockdown#priority}
        /// </remarks>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>A single URI to search for in the list of URLs of existing rules.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone_lockdown#uri_search DataCloudflareZoneLockdown#uri_search}
        /// </remarks>
        [JsiiProperty(name: "uriSearch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UriSearch
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareZoneLockdownFilter), fullyQualifiedName: "cloudflare.dataCloudflareZoneLockdown.DataCloudflareZoneLockdownFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareZoneLockdown.IDataCloudflareZoneLockdownFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The timestamp of when the rule was created.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone_lockdown#created_on DataCloudflareZoneLockdown#created_on}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createdOn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CreatedOn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A string to search for in the description of existing rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone_lockdown#description DataCloudflareZoneLockdown#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A string to search for in the description of existing rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone_lockdown#description_search DataCloudflareZoneLockdown#description_search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "descriptionSearch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DescriptionSearch
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A single IP address to search for in existing rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone_lockdown#ip DataCloudflareZoneLockdown#ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ip
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A single IP address range to search for in existing rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone_lockdown#ip_range_search DataCloudflareZoneLockdown#ip_range_search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipRangeSearch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpRangeSearch
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A single IP address to search for in existing rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone_lockdown#ip_search DataCloudflareZoneLockdown#ip_search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipSearch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpSearch
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The timestamp of when the rule was last modified.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone_lockdown#modified_on DataCloudflareZoneLockdown#modified_on}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "modifiedOn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ModifiedOn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The priority of the rule to control the processing order.</summary>
            /// <remarks>
            /// A lower number indicates higher priority. If not provided, any rules with a configured priority will be processed before rules without a priority.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone_lockdown#priority DataCloudflareZoneLockdown#priority}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>A single URI to search for in the list of URLs of existing rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zone_lockdown#uri_search DataCloudflareZoneLockdown#uri_search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uriSearch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UriSearch
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
