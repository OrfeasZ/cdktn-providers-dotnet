using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMulticloudNetworkAnchor
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/multicloud_network_anchor oci_multicloud_network_anchor}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciMulticloudNetworkAnchor.DataOciMulticloudNetworkAnchor), fullyQualifiedName: "oci.dataOciMulticloudNetworkAnchor.DataOciMulticloudNetworkAnchor", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciMulticloudNetworkAnchor.DataOciMulticloudNetworkAnchorConfig\"}}]")]
    public class DataOciMulticloudNetworkAnchor : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/multicloud_network_anchor oci_multicloud_network_anchor} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciMulticloudNetworkAnchor(Constructs.Construct scope, string id, oci.DataOciMulticloudNetworkAnchor.IDataOciMulticloudNetworkAnchorConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciMulticloudNetworkAnchor.IDataOciMulticloudNetworkAnchorConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMulticloudNetworkAnchor(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMulticloudNetworkAnchor(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciMulticloudNetworkAnchor resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciMulticloudNetworkAnchor to import.</param>
        /// <param name="importFromId">The id of the existing DataOciMulticloudNetworkAnchor that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciMulticloudNetworkAnchor to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciMulticloudNetworkAnchor to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/multicloud_network_anchor#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciMulticloudNetworkAnchor that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciMulticloudNetworkAnchor to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciMulticloudNetworkAnchor.DataOciMulticloudNetworkAnchor), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetExternalLocation")]
        public virtual void ResetExternalLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.DataOciMulticloudNetworkAnchor.DataOciMulticloudNetworkAnchor))!;

        [JsiiProperty(name: "cloudServiceProviderMetadataItem", typeJson: "{\"fqn\":\"oci.dataOciMulticloudNetworkAnchor.DataOciMulticloudNetworkAnchorCloudServiceProviderMetadataItemList\"}")]
        public virtual oci.DataOciMulticloudNetworkAnchor.DataOciMulticloudNetworkAnchorCloudServiceProviderMetadataItemList CloudServiceProviderMetadataItem
        {
            get => GetInstanceProperty<oci.DataOciMulticloudNetworkAnchor.DataOciMulticloudNetworkAnchorCloudServiceProviderMetadataItemList>()!;
        }

        [JsiiProperty(name: "clusterPlacementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterPlacementGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkAnchorLifecycleState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkAnchorLifecycleState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ociMetadataItem", typeJson: "{\"fqn\":\"oci.dataOciMulticloudNetworkAnchor.DataOciMulticloudNetworkAnchorOciMetadataItemList\"}")]
        public virtual oci.DataOciMulticloudNetworkAnchor.DataOciMulticloudNetworkAnchorOciMetadataItemList OciMetadataItem
        {
            get => GetInstanceProperty<oci.DataOciMulticloudNetworkAnchor.DataOciMulticloudNetworkAnchorOciMetadataItemList>()!;
        }

        [JsiiProperty(name: "resourceAnchorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceAnchorId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "setupMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SetupMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalLocationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExternalLocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkAnchorIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkAnchorIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subscriptionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubscriptionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subscriptionServiceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubscriptionServiceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "externalLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalLocation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkAnchorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkAnchorId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subscriptionServiceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionServiceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
