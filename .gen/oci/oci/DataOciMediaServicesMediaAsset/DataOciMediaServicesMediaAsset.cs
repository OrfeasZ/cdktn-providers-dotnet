using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMediaServicesMediaAsset
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/media_services_media_asset oci_media_services_media_asset}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciMediaServicesMediaAsset.DataOciMediaServicesMediaAsset), fullyQualifiedName: "oci.dataOciMediaServicesMediaAsset.DataOciMediaServicesMediaAsset", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciMediaServicesMediaAsset.DataOciMediaServicesMediaAssetConfig\"}}]")]
    public class DataOciMediaServicesMediaAsset : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/media_services_media_asset oci_media_services_media_asset} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciMediaServicesMediaAsset(Constructs.Construct scope, string id, oci.DataOciMediaServicesMediaAsset.IDataOciMediaServicesMediaAssetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciMediaServicesMediaAsset.IDataOciMediaServicesMediaAssetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMediaServicesMediaAsset(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMediaServicesMediaAsset(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciMediaServicesMediaAsset resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciMediaServicesMediaAsset to import.</param>
        /// <param name="importFromId">The id of the existing DataOciMediaServicesMediaAsset that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciMediaServicesMediaAsset to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciMediaServicesMediaAsset to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/media_services_media_asset#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciMediaServicesMediaAsset that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciMediaServicesMediaAsset to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciMediaServicesMediaAsset.DataOciMediaServicesMediaAsset), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciMediaServicesMediaAsset.DataOciMediaServicesMediaAsset))!;

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
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

        [JsiiProperty(name: "isLockOverride", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLockOverride
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "locks", typeJson: "{\"fqn\":\"oci.dataOciMediaServicesMediaAsset.DataOciMediaServicesMediaAssetLocksList\"}")]
        public virtual oci.DataOciMediaServicesMediaAsset.DataOciMediaServicesMediaAssetLocksList Locks
        {
            get => GetInstanceProperty<oci.DataOciMediaServicesMediaAsset.DataOciMediaServicesMediaAssetLocksList>()!;
        }

        [JsiiProperty(name: "masterMediaAssetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterMediaAssetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mediaAssetTags", typeJson: "{\"fqn\":\"oci.dataOciMediaServicesMediaAsset.DataOciMediaServicesMediaAssetMediaAssetTagsList\"}")]
        public virtual oci.DataOciMediaServicesMediaAsset.DataOciMediaServicesMediaAssetMediaAssetTagsList MediaAssetTags
        {
            get => GetInstanceProperty<oci.DataOciMediaServicesMediaAsset.DataOciMediaServicesMediaAssetMediaAssetTagsList>()!;
        }

        [JsiiProperty(name: "mediaWorkflowJobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MediaWorkflowJobId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.dataOciMediaServicesMediaAsset.DataOciMediaServicesMediaAssetMetadataList\"}")]
        public virtual oci.DataOciMediaServicesMediaAsset.DataOciMediaServicesMediaAssetMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DataOciMediaServicesMediaAsset.DataOciMediaServicesMediaAssetMetadataList>()!;
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectEtag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectEtag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentMediaAssetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentMediaAssetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "segmentRangeEndIndex", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SegmentRangeEndIndex
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "segmentRangeStartIndex", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SegmentRangeStartIndex
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceMediaWorkflowId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceMediaWorkflowId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceMediaWorkflowVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceMediaWorkflowVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
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

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "mediaAssetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MediaAssetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "mediaAssetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MediaAssetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
