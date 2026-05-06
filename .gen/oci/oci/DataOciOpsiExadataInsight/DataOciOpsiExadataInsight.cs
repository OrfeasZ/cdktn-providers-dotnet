using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOpsiExadataInsight
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_exadata_insight oci_opsi_exadata_insight}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciOpsiExadataInsight.DataOciOpsiExadataInsight), fullyQualifiedName: "oci.dataOciOpsiExadataInsight.DataOciOpsiExadataInsight", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciOpsiExadataInsight.DataOciOpsiExadataInsightConfig\"}}]")]
    public class DataOciOpsiExadataInsight : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_exadata_insight oci_opsi_exadata_insight} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciOpsiExadataInsight(Constructs.Construct scope, string id, oci.DataOciOpsiExadataInsight.IDataOciOpsiExadataInsightConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciOpsiExadataInsight.IDataOciOpsiExadataInsightConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOpsiExadataInsight(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOpsiExadataInsight(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciOpsiExadataInsight resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciOpsiExadataInsight to import.</param>
        /// <param name="importFromId">The id of the existing DataOciOpsiExadataInsight that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciOpsiExadataInsight to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciOpsiExadataInsight to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/opsi_exadata_insight#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciOpsiExadataInsight that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciOpsiExadataInsight to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciOpsiExadataInsight.DataOciOpsiExadataInsight), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciOpsiExadataInsight.DataOciOpsiExadataInsight))!;

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

        [JsiiProperty(name: "enterpriseManagerBridgeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnterpriseManagerBridgeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enterpriseManagerEntityDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnterpriseManagerEntityDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enterpriseManagerEntityIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnterpriseManagerEntityIdentifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enterpriseManagerEntityName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnterpriseManagerEntityName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enterpriseManagerEntityType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnterpriseManagerEntityType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enterpriseManagerIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnterpriseManagerIdentifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "entitySource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntitySource
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "exadataDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExadataDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "exadataInfraId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExadataInfraId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "exadataInfraResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExadataInfraResourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "exadataName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExadataName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "exadataRackType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExadataRackType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "exadataShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExadataShape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "exadataType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExadataType
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

        [JsiiProperty(name: "isAutoSyncEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutoSyncEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isVirtualizedExadata", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsVirtualizedExadata
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "memberVmClusterDetails", typeJson: "{\"fqn\":\"oci.dataOciOpsiExadataInsight.DataOciOpsiExadataInsightMemberVmClusterDetailsList\"}")]
        public virtual oci.DataOciOpsiExadataInsight.DataOciOpsiExadataInsightMemberVmClusterDetailsList MemberVmClusterDetails
        {
            get => GetInstanceProperty<oci.DataOciOpsiExadataInsight.DataOciOpsiExadataInsightMemberVmClusterDetailsList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
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
        [JsiiProperty(name: "exadataInsightIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExadataInsightIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "exadataInsightId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExadataInsightId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
