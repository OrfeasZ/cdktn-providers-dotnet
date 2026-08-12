using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMulticloudOmHubMulticloudResources
{
    [JsiiInterface(nativeType: typeof(IDataOciMulticloudOmHubMulticloudResourcesConfig), fullyQualifiedName: "oci.dataOciMulticloudOmHubMulticloudResources.DataOciMulticloudOmHubMulticloudResourcesConfig")]
    public interface IDataOciMulticloudOmHubMulticloudResourcesConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/multicloud_om_hub_multicloud_resources#compartment_id DataOciMulticloudOmHubMulticloudResources#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompartmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/multicloud_om_hub_multicloud_resources#external_location DataOciMulticloudOmHubMulticloudResources#external_location}.</summary>
        [JsiiProperty(name: "externalLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExternalLocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/multicloud_om_hub_multicloud_resources#filter DataOciMulticloudOmHubMulticloudResources#filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciMulticloudOmHubMulticloudResources.IDataOciMulticloudOmHubMulticloudResourcesFilter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciMulticloudOmHubMulticloudResources.DataOciMulticloudOmHubMulticloudResourcesFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/multicloud_om_hub_multicloud_resources#id DataOciMulticloudOmHubMulticloudResources#id}.</summary>
        /// <remarks>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/multicloud_om_hub_multicloud_resources#limit DataOciMulticloudOmHubMulticloudResources#limit}.</summary>
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Limit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/multicloud_om_hub_multicloud_resources#resource_anchor_id DataOciMulticloudOmHubMulticloudResources#resource_anchor_id}.</summary>
        [JsiiProperty(name: "resourceAnchorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceAnchorId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/multicloud_om_hub_multicloud_resources#resource_type DataOciMulticloudOmHubMulticloudResources#resource_type}.</summary>
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/multicloud_om_hub_multicloud_resources#subscription_id DataOciMulticloudOmHubMulticloudResources#subscription_id}.</summary>
        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubscriptionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/multicloud_om_hub_multicloud_resources#subscription_service_name DataOciMulticloudOmHubMulticloudResources#subscription_service_name}.</summary>
        [JsiiProperty(name: "subscriptionServiceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubscriptionServiceName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciMulticloudOmHubMulticloudResourcesConfig), fullyQualifiedName: "oci.dataOciMulticloudOmHubMulticloudResources.DataOciMulticloudOmHubMulticloudResourcesConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciMulticloudOmHubMulticloudResources.IDataOciMulticloudOmHubMulticloudResourcesConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/multicloud_om_hub_multicloud_resources#compartment_id DataOciMulticloudOmHubMulticloudResources#compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompartmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/multicloud_om_hub_multicloud_resources#external_location DataOciMulticloudOmHubMulticloudResources#external_location}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "externalLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExternalLocation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/multicloud_om_hub_multicloud_resources#filter DataOciMulticloudOmHubMulticloudResources#filter}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciMulticloudOmHubMulticloudResources.IDataOciMulticloudOmHubMulticloudResourcesFilter" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciMulticloudOmHubMulticloudResources.DataOciMulticloudOmHubMulticloudResourcesFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Filter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/multicloud_om_hub_multicloud_resources#id DataOciMulticloudOmHubMulticloudResources#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/multicloud_om_hub_multicloud_resources#limit DataOciMulticloudOmHubMulticloudResources#limit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Limit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/multicloud_om_hub_multicloud_resources#resource_anchor_id DataOciMulticloudOmHubMulticloudResources#resource_anchor_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceAnchorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceAnchorId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/multicloud_om_hub_multicloud_resources#resource_type DataOciMulticloudOmHubMulticloudResources#resource_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/multicloud_om_hub_multicloud_resources#subscription_id DataOciMulticloudOmHubMulticloudResources#subscription_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubscriptionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/data-sources/multicloud_om_hub_multicloud_resources#subscription_service_name DataOciMulticloudOmHubMulticloudResources#subscription_service_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subscriptionServiceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubscriptionServiceName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
