using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDrgNatPolicyDrgNatRule
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule oci_core_drg_nat_policy_drg_nat_rule}.</summary>
    [JsiiClass(nativeType: typeof(oci.CoreDrgNatPolicyDrgNatRule.CoreDrgNatPolicyDrgNatRule), fullyQualifiedName: "oci.coreDrgNatPolicyDrgNatRule.CoreDrgNatPolicyDrgNatRule", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.coreDrgNatPolicyDrgNatRule.CoreDrgNatPolicyDrgNatRuleConfig\"}}]")]
    public class CoreDrgNatPolicyDrgNatRule : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule oci_core_drg_nat_policy_drg_nat_rule} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CoreDrgNatPolicyDrgNatRule(Constructs.Construct scope, string id, oci.CoreDrgNatPolicyDrgNatRule.ICoreDrgNatPolicyDrgNatRuleConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.CoreDrgNatPolicyDrgNatRule.ICoreDrgNatPolicyDrgNatRuleConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreDrgNatPolicyDrgNatRule(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreDrgNatPolicyDrgNatRule(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a CoreDrgNatPolicyDrgNatRule resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CoreDrgNatPolicyDrgNatRule to import.</param>
        /// <param name="importFromId">The id of the existing CoreDrgNatPolicyDrgNatRule that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CoreDrgNatPolicyDrgNatRule to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CoreDrgNatPolicyDrgNatRule to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/core_drg_nat_policy_drg_nat_rule#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CoreDrgNatPolicyDrgNatRule that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CoreDrgNatPolicyDrgNatRule to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.CoreDrgNatPolicyDrgNatRule.CoreDrgNatPolicyDrgNatRule), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreDrgNatPolicyDrgNatRule.CoreDrgNatPolicyDrgNatRuleTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.CoreDrgNatPolicyDrgNatRule.ICoreDrgNatPolicyDrgNatRuleTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreDrgNatPolicyDrgNatRule.ICoreDrgNatPolicyDrgNatRuleTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOriginalDestination")]
        public virtual void ResetOriginalDestination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOriginalSource")]
        public virtual void ResetOriginalSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTranslatedDestination")]
        public virtual void ResetTranslatedDestination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTranslatedSource")]
        public virtual void ResetTranslatedSource()
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
        = GetStaticProperty<string>(typeof(oci.CoreDrgNatPolicyDrgNatRule.CoreDrgNatPolicyDrgNatRule))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.coreDrgNatPolicyDrgNatRule.CoreDrgNatPolicyDrgNatRuleTimeoutsOutputReference\"}")]
        public virtual oci.CoreDrgNatPolicyDrgNatRule.CoreDrgNatPolicyDrgNatRuleTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.CoreDrgNatPolicyDrgNatRule.CoreDrgNatPolicyDrgNatRuleTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "drgNatPolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DrgNatPolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "drgNatRulePriorityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DrgNatRulePriorityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originalDestinationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OriginalDestinationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originalSourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OriginalSourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.CoreDrgNatPolicyDrgNatRule.ICoreDrgNatPolicyDrgNatRuleTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.coreDrgNatPolicyDrgNatRule.CoreDrgNatPolicyDrgNatRuleTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "translatedDestinationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TranslatedDestinationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "translatedSourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TranslatedSourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "drgNatPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DrgNatPolicyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "drgNatRulePriority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DrgNatRulePriority
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "originalDestination", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginalDestination
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "originalSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginalSource
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "translatedDestination", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TranslatedDestination
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "translatedSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TranslatedSource
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
