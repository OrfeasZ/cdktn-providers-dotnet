using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DynatraceTagRules
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dynatrace_tag_rules azurerm_dynatrace_tag_rules}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DynatraceTagRules.DynatraceTagRules), fullyQualifiedName: "azurerm.dynatraceTagRules.DynatraceTagRules", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dynatraceTagRules.DynatraceTagRulesConfig\"}}]")]
    public class DynatraceTagRules : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dynatrace_tag_rules azurerm_dynatrace_tag_rules} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DynatraceTagRules(Constructs.Construct scope, string id, azurerm.DynatraceTagRules.IDynatraceTagRulesConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DynatraceTagRules.IDynatraceTagRulesConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DynatraceTagRules(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DynatraceTagRules(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DynatraceTagRules resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DynatraceTagRules to import.</param>
        /// <param name="importFromId">The id of the existing DynatraceTagRules that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DynatraceTagRules to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DynatraceTagRules to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dynatrace_tag_rules#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DynatraceTagRules that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DynatraceTagRules to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.DynatraceTagRules.DynatraceTagRules), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putLogRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dynatraceTagRules.DynatraceTagRulesLogRule\"}}]")]
        public virtual void PutLogRule(azurerm.DynatraceTagRules.IDynatraceTagRulesLogRule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DynatraceTagRules.IDynatraceTagRulesLogRule)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMetricRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dynatraceTagRules.DynatraceTagRulesMetricRule\"}}]")]
        public virtual void PutMetricRule(azurerm.DynatraceTagRules.IDynatraceTagRulesMetricRule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DynatraceTagRules.IDynatraceTagRulesMetricRule)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dynatraceTagRules.DynatraceTagRulesTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DynatraceTagRules.IDynatraceTagRulesTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DynatraceTagRules.IDynatraceTagRulesTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogRule")]
        public virtual void ResetLogRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetricRule")]
        public virtual void ResetMetricRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(azurerm.DynatraceTagRules.DynatraceTagRules))!;

        [JsiiProperty(name: "logRule", typeJson: "{\"fqn\":\"azurerm.dynatraceTagRules.DynatraceTagRulesLogRuleOutputReference\"}")]
        public virtual azurerm.DynatraceTagRules.DynatraceTagRulesLogRuleOutputReference LogRule
        {
            get => GetInstanceProperty<azurerm.DynatraceTagRules.DynatraceTagRulesLogRuleOutputReference>()!;
        }

        [JsiiProperty(name: "metricRule", typeJson: "{\"fqn\":\"azurerm.dynatraceTagRules.DynatraceTagRulesMetricRuleOutputReference\"}")]
        public virtual azurerm.DynatraceTagRules.DynatraceTagRulesMetricRuleOutputReference MetricRule
        {
            get => GetInstanceProperty<azurerm.DynatraceTagRules.DynatraceTagRulesMetricRuleOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dynatraceTagRules.DynatraceTagRulesTimeoutsOutputReference\"}")]
        public virtual azurerm.DynatraceTagRules.DynatraceTagRulesTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DynatraceTagRules.DynatraceTagRulesTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logRuleInput", typeJson: "{\"fqn\":\"azurerm.dynatraceTagRules.DynatraceTagRulesLogRule\"}", isOptional: true)]
        public virtual azurerm.DynatraceTagRules.IDynatraceTagRulesLogRule? LogRuleInput
        {
            get => GetInstanceProperty<azurerm.DynatraceTagRules.IDynatraceTagRulesLogRule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricRuleInput", typeJson: "{\"fqn\":\"azurerm.dynatraceTagRules.DynatraceTagRulesMetricRule\"}", isOptional: true)]
        public virtual azurerm.DynatraceTagRules.IDynatraceTagRulesMetricRule? MetricRuleInput
        {
            get => GetInstanceProperty<azurerm.DynatraceTagRules.IDynatraceTagRulesMetricRule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitorIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MonitorIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.DynatraceTagRules.IDynatraceTagRulesTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.dynatraceTagRules.DynatraceTagRulesTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "monitorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MonitorId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
