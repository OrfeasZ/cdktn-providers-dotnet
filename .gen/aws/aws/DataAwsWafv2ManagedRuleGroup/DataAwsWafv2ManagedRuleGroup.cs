using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsWafv2ManagedRuleGroup
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/wafv2_managed_rule_group aws_wafv2_managed_rule_group}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsWafv2ManagedRuleGroup.DataAwsWafv2ManagedRuleGroup), fullyQualifiedName: "aws.dataAwsWafv2ManagedRuleGroup.DataAwsWafv2ManagedRuleGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsWafv2ManagedRuleGroup.DataAwsWafv2ManagedRuleGroupConfig\"}}]")]
    public class DataAwsWafv2ManagedRuleGroup : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/wafv2_managed_rule_group aws_wafv2_managed_rule_group} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsWafv2ManagedRuleGroup(Constructs.Construct scope, string id, aws.DataAwsWafv2ManagedRuleGroup.IDataAwsWafv2ManagedRuleGroupConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsWafv2ManagedRuleGroup.IDataAwsWafv2ManagedRuleGroupConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsWafv2ManagedRuleGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsWafv2ManagedRuleGroup(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAwsWafv2ManagedRuleGroup resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsWafv2ManagedRuleGroup to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsWafv2ManagedRuleGroup that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsWafv2ManagedRuleGroup to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsWafv2ManagedRuleGroup to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/wafv2_managed_rule_group#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsWafv2ManagedRuleGroup that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsWafv2ManagedRuleGroup to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.DataAwsWafv2ManagedRuleGroup.DataAwsWafv2ManagedRuleGroup), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersionName")]
        public virtual void ResetVersionName()
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
        = GetStaticProperty<string>(typeof(aws.DataAwsWafv2ManagedRuleGroup.DataAwsWafv2ManagedRuleGroup))!;

        [JsiiProperty(name: "availableLabels", typeJson: "{\"fqn\":\"aws.dataAwsWafv2ManagedRuleGroup.DataAwsWafv2ManagedRuleGroupAvailableLabelsList\"}")]
        public virtual aws.DataAwsWafv2ManagedRuleGroup.DataAwsWafv2ManagedRuleGroupAvailableLabelsList AvailableLabels
        {
            get => GetInstanceProperty<aws.DataAwsWafv2ManagedRuleGroup.DataAwsWafv2ManagedRuleGroupAvailableLabelsList>()!;
        }

        [JsiiProperty(name: "capacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Capacity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "consumedLabels", typeJson: "{\"fqn\":\"aws.dataAwsWafv2ManagedRuleGroup.DataAwsWafv2ManagedRuleGroupConsumedLabelsList\"}")]
        public virtual aws.DataAwsWafv2ManagedRuleGroup.DataAwsWafv2ManagedRuleGroupConsumedLabelsList ConsumedLabels
        {
            get => GetInstanceProperty<aws.DataAwsWafv2ManagedRuleGroup.DataAwsWafv2ManagedRuleGroupConsumedLabelsList>()!;
        }

        [JsiiProperty(name: "labelNamespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LabelNamespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rules", typeJson: "{\"fqn\":\"aws.dataAwsWafv2ManagedRuleGroup.DataAwsWafv2ManagedRuleGroupRulesList\"}")]
        public virtual aws.DataAwsWafv2ManagedRuleGroup.DataAwsWafv2ManagedRuleGroupRulesList Rules
        {
            get => GetInstanceProperty<aws.DataAwsWafv2ManagedRuleGroup.DataAwsWafv2ManagedRuleGroupRulesList>()!;
        }

        [JsiiProperty(name: "snsTopicArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SnsTopicArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scopeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScopeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vendorNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VendorNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scope
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vendorName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VendorName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "versionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
