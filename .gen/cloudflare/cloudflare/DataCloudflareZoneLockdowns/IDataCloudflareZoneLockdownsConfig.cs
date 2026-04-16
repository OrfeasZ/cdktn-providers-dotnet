using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZoneLockdowns
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareZoneLockdownsConfig), fullyQualifiedName: "cloudflare.dataCloudflareZoneLockdowns.DataCloudflareZoneLockdownsConfig")]
    public interface IDataCloudflareZoneLockdownsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Defines an identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_lockdowns#zone_id DataCloudflareZoneLockdowns#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        string ZoneId
        {
            get;
        }

        /// <summary>The timestamp of when the rule was created.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_lockdowns#created_on DataCloudflareZoneLockdowns#created_on}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_lockdowns#description DataCloudflareZoneLockdowns#description}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_lockdowns#description_search DataCloudflareZoneLockdowns#description_search}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_lockdowns#ip DataCloudflareZoneLockdowns#ip}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_lockdowns#ip_range_search DataCloudflareZoneLockdowns#ip_range_search}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_lockdowns#ip_search DataCloudflareZoneLockdowns#ip_search}
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

        /// <summary>Max items to fetch, default: 1000.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_lockdowns#max_items DataCloudflareZoneLockdowns#max_items}
        /// </remarks>
        [JsiiProperty(name: "maxItems", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxItems
        {
            get
            {
                return null;
            }
        }

        /// <summary>The timestamp of when the rule was last modified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_lockdowns#modified_on DataCloudflareZoneLockdowns#modified_on}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_lockdowns#priority DataCloudflareZoneLockdowns#priority}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_lockdowns#uri_search DataCloudflareZoneLockdowns#uri_search}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareZoneLockdownsConfig), fullyQualifiedName: "cloudflare.dataCloudflareZoneLockdowns.DataCloudflareZoneLockdownsConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareZoneLockdowns.IDataCloudflareZoneLockdownsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines an identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_lockdowns#zone_id DataCloudflareZoneLockdowns#zone_id}
            /// </remarks>
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string ZoneId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The timestamp of when the rule was created.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_lockdowns#created_on DataCloudflareZoneLockdowns#created_on}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createdOn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CreatedOn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A string to search for in the description of existing rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_lockdowns#description DataCloudflareZoneLockdowns#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A string to search for in the description of existing rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_lockdowns#description_search DataCloudflareZoneLockdowns#description_search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "descriptionSearch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DescriptionSearch
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A single IP address to search for in existing rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_lockdowns#ip DataCloudflareZoneLockdowns#ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ip
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A single IP address range to search for in existing rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_lockdowns#ip_range_search DataCloudflareZoneLockdowns#ip_range_search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipRangeSearch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpRangeSearch
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A single IP address to search for in existing rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_lockdowns#ip_search DataCloudflareZoneLockdowns#ip_search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipSearch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpSearch
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Max items to fetch, default: 1000.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_lockdowns#max_items DataCloudflareZoneLockdowns#max_items}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxItems", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxItems
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The timestamp of when the rule was last modified.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_lockdowns#modified_on DataCloudflareZoneLockdowns#modified_on}
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_lockdowns#priority DataCloudflareZoneLockdowns#priority}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>A single URI to search for in the list of URLs of existing rules.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zone_lockdowns#uri_search DataCloudflareZoneLockdowns#uri_search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uriSearch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UriSearch
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
