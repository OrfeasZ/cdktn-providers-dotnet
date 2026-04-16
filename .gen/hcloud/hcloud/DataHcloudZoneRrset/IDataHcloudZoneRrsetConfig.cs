using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.DataHcloudZoneRrset
{
    [JsiiInterface(nativeType: typeof(IDataHcloudZoneRrsetConfig), fullyQualifiedName: "hcloud.dataHcloudZoneRrset.DataHcloudZoneRrsetConfig")]
    public interface IDataHcloudZoneRrsetConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>ID or Name of the parent Zone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/data-sources/zone_rrset#zone DataHcloudZoneRrset#zone}
        /// </remarks>
        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}")]
        string Zone
        {
            get;
        }

        /// <summary>ID of the Zone RRSet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/data-sources/zone_rrset#id DataHcloudZoneRrset#id}
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

        /// <summary>Name of the Zone RRSet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/data-sources/zone_rrset#name DataHcloudZoneRrset#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Type of the Zone RRSet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/data-sources/zone_rrset#type DataHcloudZoneRrset#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filter results using a [Label Selector](https://docs.hetzner.cloud/reference/cloud#label-selector).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/data-sources/zone_rrset#with_selector DataHcloudZoneRrset#with_selector}
        /// </remarks>
        [JsiiProperty(name: "withSelector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WithSelector
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataHcloudZoneRrsetConfig), fullyQualifiedName: "hcloud.dataHcloudZoneRrset.DataHcloudZoneRrsetConfig")]
        internal sealed class _Proxy : DeputyBase, hcloud.DataHcloudZoneRrset.IDataHcloudZoneRrsetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID or Name of the parent Zone.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/data-sources/zone_rrset#zone DataHcloudZoneRrset#zone}
            /// </remarks>
            [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}")]
            public string Zone
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ID of the Zone RRSet.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/data-sources/zone_rrset#id DataHcloudZoneRrset#id}
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

            /// <summary>Name of the Zone RRSet.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/data-sources/zone_rrset#name DataHcloudZoneRrset#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Type of the Zone RRSet.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/data-sources/zone_rrset#type DataHcloudZoneRrset#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter results using a [Label Selector](https://docs.hetzner.cloud/reference/cloud#label-selector).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/data-sources/zone_rrset#with_selector DataHcloudZoneRrset#with_selector}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "withSelector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WithSelector
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
