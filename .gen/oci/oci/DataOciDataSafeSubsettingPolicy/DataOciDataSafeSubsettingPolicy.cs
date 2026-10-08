using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSubsettingPolicy
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/data_safe_subsetting_policy oci_data_safe_subsetting_policy}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSubsettingPolicy.DataOciDataSafeSubsettingPolicy), fullyQualifiedName: "oci.dataOciDataSafeSubsettingPolicy.DataOciDataSafeSubsettingPolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDataSafeSubsettingPolicy.DataOciDataSafeSubsettingPolicyConfig\"}}]")]
    public class DataOciDataSafeSubsettingPolicy : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/data_safe_subsetting_policy oci_data_safe_subsetting_policy} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDataSafeSubsettingPolicy(Constructs.Construct scope, string id, oci.DataOciDataSafeSubsettingPolicy.IDataOciDataSafeSubsettingPolicyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDataSafeSubsettingPolicy.IDataOciDataSafeSubsettingPolicyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSubsettingPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSubsettingPolicy(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDataSafeSubsettingPolicy resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDataSafeSubsettingPolicy to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDataSafeSubsettingPolicy that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDataSafeSubsettingPolicy to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDataSafeSubsettingPolicy to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/data_safe_subsetting_policy#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDataSafeSubsettingPolicy that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDataSafeSubsettingPolicy to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDataSafeSubsettingPolicy.DataOciDataSafeSubsettingPolicy), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDataSafeSubsettingPolicy.DataOciDataSafeSubsettingPolicy))!;

        [JsiiProperty(name: "checkType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CheckType
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

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "generateHealthReportTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GenerateHealthReportTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isRedoLoggingEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRedoLoggingEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isRefreshStatsEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRefreshStatsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "maskingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaskingPolicyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parallelDegree", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParallelDegree
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "postSubsettingScript", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PostSubsettingScript
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preSubsettingScript", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreSubsettingScript
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recompile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Recompile
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schemaSource", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSubsettingPolicy.DataOciDataSafeSubsettingPolicySchemaSourceList\"}")]
        public virtual oci.DataOciDataSafeSubsettingPolicy.DataOciDataSafeSubsettingPolicySchemaSourceList SchemaSource
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSubsettingPolicy.DataOciDataSafeSubsettingPolicySchemaSourceList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tablespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tablespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetCredentials", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSubsettingPolicy.DataOciDataSafeSubsettingPolicyTargetCredentialsList\"}")]
        public virtual oci.DataOciDataSafeSubsettingPolicy.DataOciDataSafeSubsettingPolicyTargetCredentialsList TargetCredentials
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSubsettingPolicy.DataOciDataSafeSubsettingPolicyTargetCredentialsList>()!;
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
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

        [JsiiProperty(name: "unrelatedTablesAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UnrelatedTablesAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "subsettingPolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubsettingPolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "subsettingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubsettingPolicyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
