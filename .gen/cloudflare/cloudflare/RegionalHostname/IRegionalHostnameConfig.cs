using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.RegionalHostname
{
    [JsiiInterface(nativeType: typeof(IRegionalHostnameConfig), fullyQualifiedName: "cloudflare.regionalHostname.RegionalHostnameConfig")]
    public interface IRegionalHostnameConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>DNS hostname to be regionalized, must be a subdomain of the zone.</summary>
        /// <remarks>
        /// Wildcards are supported for one level, e.g <c>*.example.com</c>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/regional_hostname#hostname RegionalHostname#hostname}
        /// </remarks>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        string Hostname
        {
            get;
        }

        /// <summary>Identifying key for the region.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/regional_hostname#region_key RegionalHostname#region_key}
        /// </remarks>
        [JsiiProperty(name: "regionKey", typeJson: "{\"primitive\":\"string\"}")]
        string RegionKey
        {
            get;
        }

        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/regional_hostname#zone_id RegionalHostname#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        string ZoneId
        {
            get;
        }

        /// <summary>Configure which routing method to use for the regional hostname.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/regional_hostname#routing RegionalHostname#routing}
        /// </remarks>
        [JsiiProperty(name: "routing", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Routing
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRegionalHostnameConfig), fullyQualifiedName: "cloudflare.regionalHostname.RegionalHostnameConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.RegionalHostname.IRegionalHostnameConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>DNS hostname to be regionalized, must be a subdomain of the zone.</summary>
            /// <remarks>
            /// Wildcards are supported for one level, e.g <c>*.example.com</c>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/regional_hostname#hostname RegionalHostname#hostname}
            /// </remarks>
            [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
            public string Hostname
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Identifying key for the region.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/regional_hostname#region_key RegionalHostname#region_key}
            /// </remarks>
            [JsiiProperty(name: "regionKey", typeJson: "{\"primitive\":\"string\"}")]
            public string RegionKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/regional_hostname#zone_id RegionalHostname#zone_id}
            /// </remarks>
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string ZoneId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Configure which routing method to use for the regional hostname.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/regional_hostname#routing RegionalHostname#routing}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routing", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Routing
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
