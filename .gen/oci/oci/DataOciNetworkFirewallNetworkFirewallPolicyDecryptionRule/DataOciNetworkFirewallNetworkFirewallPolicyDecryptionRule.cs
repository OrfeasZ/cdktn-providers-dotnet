using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/network_firewall_network_firewall_policy_decryption_rule oci_network_firewall_network_firewall_policy_decryption_rule}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule.DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule), fullyQualifiedName: "oci.dataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule.DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule.DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRuleConfig\"}}]")]
    public class DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/network_firewall_network_firewall_policy_decryption_rule oci_network_firewall_network_firewall_policy_decryption_rule} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule(Constructs.Construct scope, string id, oci.DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule.IDataOciNetworkFirewallNetworkFirewallPolicyDecryptionRuleConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule.IDataOciNetworkFirewallNetworkFirewallPolicyDecryptionRuleConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule to import.</param>
        /// <param name="importFromId">The id of the existing DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/network_firewall_network_firewall_policy_decryption_rule#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule.DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule.DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule))!;

        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Action
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"oci.dataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule.DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRuleConditionList\"}")]
        public virtual oci.DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule.DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRuleConditionList Condition
        {
            get => GetInstanceProperty<oci.DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule.DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRuleConditionList>()!;
        }

        [JsiiProperty(name: "decryptionProfile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DecryptionProfile
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "position", typeJson: "{\"fqn\":\"oci.dataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule.DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRulePositionList\"}")]
        public virtual oci.DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule.DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRulePositionList Position
        {
            get => GetInstanceProperty<oci.DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRule.DataOciNetworkFirewallNetworkFirewallPolicyDecryptionRulePositionList>()!;
        }

        [JsiiProperty(name: "priorityOrder", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PriorityOrder
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Secret
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
        [JsiiProperty(name: "networkFirewallPolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkFirewallPolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkFirewallPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkFirewallPolicyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
