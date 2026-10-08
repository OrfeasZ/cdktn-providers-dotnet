using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSubsettingPolicySubsettingRule
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/data_safe_subsetting_policy_subsetting_rule oci_data_safe_subsetting_policy_subsetting_rule}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSubsettingPolicySubsettingRule.DataOciDataSafeSubsettingPolicySubsettingRule), fullyQualifiedName: "oci.dataOciDataSafeSubsettingPolicySubsettingRule.DataOciDataSafeSubsettingPolicySubsettingRule", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDataSafeSubsettingPolicySubsettingRule.DataOciDataSafeSubsettingPolicySubsettingRuleConfig\"}}]")]
    public class DataOciDataSafeSubsettingPolicySubsettingRule : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/data_safe_subsetting_policy_subsetting_rule oci_data_safe_subsetting_policy_subsetting_rule} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDataSafeSubsettingPolicySubsettingRule(Constructs.Construct scope, string id, oci.DataOciDataSafeSubsettingPolicySubsettingRule.IDataOciDataSafeSubsettingPolicySubsettingRuleConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDataSafeSubsettingPolicySubsettingRule.IDataOciDataSafeSubsettingPolicySubsettingRuleConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSubsettingPolicySubsettingRule(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSubsettingPolicySubsettingRule(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDataSafeSubsettingPolicySubsettingRule resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDataSafeSubsettingPolicySubsettingRule to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDataSafeSubsettingPolicySubsettingRule that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDataSafeSubsettingPolicySubsettingRule to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDataSafeSubsettingPolicySubsettingRule to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/data_safe_subsetting_policy_subsetting_rule#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDataSafeSubsettingPolicySubsettingRule that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDataSafeSubsettingPolicySubsettingRule to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDataSafeSubsettingPolicySubsettingRule.DataOciDataSafeSubsettingPolicySubsettingRule), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDataSafeSubsettingPolicySubsettingRule.DataOciDataSafeSubsettingPolicySubsettingRule))!;

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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerTablesAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerTablesAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "relatedTablesPropagation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RelatedTablesPropagation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ruleCombinationMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuleCombinationMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scope", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSubsettingPolicySubsettingRule.DataOciDataSafeSubsettingPolicySubsettingRuleScopeList\"}")]
        public virtual oci.DataOciDataSafeSubsettingPolicySubsettingRule.DataOciDataSafeSubsettingPolicySubsettingRuleScopeList Scope
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSubsettingPolicySubsettingRule.DataOciDataSafeSubsettingPolicySubsettingRuleScopeList>()!;
        }

        [JsiiProperty(name: "subsetRuleEntry", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSubsettingPolicySubsettingRule.DataOciDataSafeSubsettingPolicySubsettingRuleSubsetRuleEntryList\"}")]
        public virtual oci.DataOciDataSafeSubsettingPolicySubsettingRule.DataOciDataSafeSubsettingPolicySubsettingRuleSubsetRuleEntryList SubsetRuleEntry
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSubsettingPolicySubsettingRule.DataOciDataSafeSubsettingPolicySubsettingRuleSubsetRuleEntryList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "subsettingPolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubsettingPolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subsettingRuleKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubsettingRuleKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "subsettingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubsettingPolicyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subsettingRuleKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubsettingRuleKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
