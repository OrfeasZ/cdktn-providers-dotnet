using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMulticloudExternalLocationsMetadata
{
    [JsiiInterface(nativeType: typeof(IDataOciMulticloudExternalLocationsMetadataConfig), fullyQualifiedName: "oci.dataOciMulticloudExternalLocationsMetadata.DataOciMulticloudExternalLocationsMetadataConfig")]
    public interface IDataOciMulticloudExternalLocationsMetadataConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/multicloud_external_locations_metadata#subscription_id DataOciMulticloudExternalLocationsMetadata#subscription_id}.</summary>
        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        string SubscriptionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/multicloud_external_locations_metadata#subscription_service_name DataOciMulticloudExternalLocationsMetadata#subscription_service_name}.</summary>
        [JsiiProperty(name: "subscriptionServiceName", typeJson: "{\"primitive\":\"string\"}")]
        string SubscriptionServiceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/multicloud_external_locations_metadata#cluster_placement_group_id DataOciMulticloudExternalLocationsMetadata#cluster_placement_group_id}.</summary>
        [JsiiProperty(name: "clusterPlacementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClusterPlacementGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/multicloud_external_locations_metadata#compartment_id DataOciMulticloudExternalLocationsMetadata#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompartmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/multicloud_external_locations_metadata#entity_type DataOciMulticloudExternalLocationsMetadata#entity_type}.</summary>
        [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EntityType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/multicloud_external_locations_metadata#external_location DataOciMulticloudExternalLocationsMetadata#external_location}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/multicloud_external_locations_metadata#filter DataOciMulticloudExternalLocationsMetadata#filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciMulticloudExternalLocationsMetadata.IDataOciMulticloudExternalLocationsMetadataFilter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciMulticloudExternalLocationsMetadata.DataOciMulticloudExternalLocationsMetadataFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/multicloud_external_locations_metadata#id DataOciMulticloudExternalLocationsMetadata#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/multicloud_external_locations_metadata#limit DataOciMulticloudExternalLocationsMetadata#limit}.</summary>
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Limit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/multicloud_external_locations_metadata#linked_compartment_id DataOciMulticloudExternalLocationsMetadata#linked_compartment_id}.</summary>
        [JsiiProperty(name: "linkedCompartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LinkedCompartmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/multicloud_external_locations_metadata#logical_zone DataOciMulticloudExternalLocationsMetadata#logical_zone}.</summary>
        [JsiiProperty(name: "logicalZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogicalZone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciMulticloudExternalLocationsMetadataConfig), fullyQualifiedName: "oci.dataOciMulticloudExternalLocationsMetadata.DataOciMulticloudExternalLocationsMetadataConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciMulticloudExternalLocationsMetadata.IDataOciMulticloudExternalLocationsMetadataConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/multicloud_external_locations_metadata#subscription_id DataOciMulticloudExternalLocationsMetadata#subscription_id}.</summary>
            [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubscriptionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/multicloud_external_locations_metadata#subscription_service_name DataOciMulticloudExternalLocationsMetadata#subscription_service_name}.</summary>
            [JsiiProperty(name: "subscriptionServiceName", typeJson: "{\"primitive\":\"string\"}")]
            public string SubscriptionServiceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/multicloud_external_locations_metadata#cluster_placement_group_id DataOciMulticloudExternalLocationsMetadata#cluster_placement_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clusterPlacementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClusterPlacementGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/multicloud_external_locations_metadata#compartment_id DataOciMulticloudExternalLocationsMetadata#compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompartmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/multicloud_external_locations_metadata#entity_type DataOciMulticloudExternalLocationsMetadata#entity_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EntityType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/multicloud_external_locations_metadata#external_location DataOciMulticloudExternalLocationsMetadata#external_location}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "externalLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExternalLocation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/multicloud_external_locations_metadata#filter DataOciMulticloudExternalLocationsMetadata#filter}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciMulticloudExternalLocationsMetadata.IDataOciMulticloudExternalLocationsMetadataFilter" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciMulticloudExternalLocationsMetadata.DataOciMulticloudExternalLocationsMetadataFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Filter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/multicloud_external_locations_metadata#id DataOciMulticloudExternalLocationsMetadata#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/multicloud_external_locations_metadata#limit DataOciMulticloudExternalLocationsMetadata#limit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Limit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/multicloud_external_locations_metadata#linked_compartment_id DataOciMulticloudExternalLocationsMetadata#linked_compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "linkedCompartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LinkedCompartmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/multicloud_external_locations_metadata#logical_zone DataOciMulticloudExternalLocationsMetadata#logical_zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logicalZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogicalZone
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
