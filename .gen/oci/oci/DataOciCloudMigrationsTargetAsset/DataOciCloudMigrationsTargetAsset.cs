using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCloudMigrationsTargetAsset
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/cloud_migrations_target_asset oci_cloud_migrations_target_asset}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAsset), fullyQualifiedName: "oci.dataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAsset", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetConfig\"}}]")]
    public class DataOciCloudMigrationsTargetAsset : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/cloud_migrations_target_asset oci_cloud_migrations_target_asset} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciCloudMigrationsTargetAsset(Constructs.Construct scope, string id, oci.DataOciCloudMigrationsTargetAsset.IDataOciCloudMigrationsTargetAssetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciCloudMigrationsTargetAsset.IDataOciCloudMigrationsTargetAssetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCloudMigrationsTargetAsset(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCloudMigrationsTargetAsset(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciCloudMigrationsTargetAsset resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciCloudMigrationsTargetAsset to import.</param>
        /// <param name="importFromId">The id of the existing DataOciCloudMigrationsTargetAsset that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciCloudMigrationsTargetAsset to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciCloudMigrationsTargetAsset to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/cloud_migrations_target_asset#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciCloudMigrationsTargetAsset that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciCloudMigrationsTargetAsset to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAsset), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAsset))!;

        [JsiiProperty(name: "blockVolumesPerformance", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BlockVolumesPerformance
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compatibilityMessages", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetCompatibilityMessagesList\"}")]
        public virtual oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetCompatibilityMessagesList CompatibilityMessages
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetCompatibilityMessagesList>()!;
        }

        [JsiiProperty(name: "createdResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "estimatedCost", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetEstimatedCostList\"}")]
        public virtual oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetEstimatedCostList EstimatedCost
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetEstimatedCostList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isExcludedFromExecution", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsExcludedFromExecution
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "migrationAsset", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetMigrationAssetList\"}")]
        public virtual oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetMigrationAssetList MigrationAsset
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetMigrationAssetList>()!;
        }

        [JsiiProperty(name: "migrationPlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MigrationPlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "msLicense", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MsLicense
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preferredShapeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreferredShapeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recommendedSpec", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetRecommendedSpecList\"}")]
        public virtual oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetRecommendedSpecList RecommendedSpec
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetRecommendedSpecList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "testSpec", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetTestSpecList\"}")]
        public virtual oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetTestSpecList TestSpec
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetTestSpecList>()!;
        }

        [JsiiProperty(name: "timeAssessed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAssessed
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "userSpec", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetUserSpecList\"}")]
        public virtual oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetUserSpecList UserSpec
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetUserSpecList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetAssetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetAssetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "targetAssetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetAssetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
