using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCloudGuardDetectorRecipe
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/cloud_guard_detector_recipe oci_cloud_guard_detector_recipe}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciCloudGuardDetectorRecipe.DataOciCloudGuardDetectorRecipe), fullyQualifiedName: "oci.dataOciCloudGuardDetectorRecipe.DataOciCloudGuardDetectorRecipe", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciCloudGuardDetectorRecipe.DataOciCloudGuardDetectorRecipeConfig\"}}]")]
    public class DataOciCloudGuardDetectorRecipe : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/cloud_guard_detector_recipe oci_cloud_guard_detector_recipe} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciCloudGuardDetectorRecipe(Constructs.Construct scope, string id, oci.DataOciCloudGuardDetectorRecipe.IDataOciCloudGuardDetectorRecipeConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciCloudGuardDetectorRecipe.IDataOciCloudGuardDetectorRecipeConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCloudGuardDetectorRecipe(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCloudGuardDetectorRecipe(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciCloudGuardDetectorRecipe resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciCloudGuardDetectorRecipe to import.</param>
        /// <param name="importFromId">The id of the existing DataOciCloudGuardDetectorRecipe that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciCloudGuardDetectorRecipe to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciCloudGuardDetectorRecipe to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/cloud_guard_detector_recipe#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciCloudGuardDetectorRecipe that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciCloudGuardDetectorRecipe to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciCloudGuardDetectorRecipe.DataOciCloudGuardDetectorRecipe), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciCloudGuardDetectorRecipe.DataOciCloudGuardDetectorRecipe))!;

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

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "detector", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Detector
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "detectorRecipeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DetectorRecipeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "detectorRules", typeJson: "{\"fqn\":\"oci.dataOciCloudGuardDetectorRecipe.DataOciCloudGuardDetectorRecipeDetectorRulesList\"}")]
        public virtual oci.DataOciCloudGuardDetectorRecipe.DataOciCloudGuardDetectorRecipeDetectorRulesList DetectorRules
        {
            get => GetInstanceProperty<oci.DataOciCloudGuardDetectorRecipe.DataOciCloudGuardDetectorRecipeDetectorRulesList>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "effectiveDetectorRules", typeJson: "{\"fqn\":\"oci.dataOciCloudGuardDetectorRecipe.DataOciCloudGuardDetectorRecipeEffectiveDetectorRulesList\"}")]
        public virtual oci.DataOciCloudGuardDetectorRecipe.DataOciCloudGuardDetectorRecipeEffectiveDetectorRulesList EffectiveDetectorRules
        {
            get => GetInstanceProperty<oci.DataOciCloudGuardDetectorRecipe.DataOciCloudGuardDetectorRecipeEffectiveDetectorRulesList>()!;
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

        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Owner
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceDetectorRecipeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceDetectorRecipeId
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

        [JsiiProperty(name: "targetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TargetIds
        {
            get => GetInstanceProperty<string[]>()!;
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
        [JsiiProperty(name: "detectorRecipeIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DetectorRecipeIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "detectorRecipeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DetectorRecipeId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
