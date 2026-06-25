using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BudgetCostAnomalyEvent
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/budget_cost_anomaly_event oci_budget_cost_anomaly_event}.</summary>
    [JsiiClass(nativeType: typeof(oci.BudgetCostAnomalyEvent.BudgetCostAnomalyEvent), fullyQualifiedName: "oci.budgetCostAnomalyEvent.BudgetCostAnomalyEvent", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.budgetCostAnomalyEvent.BudgetCostAnomalyEventConfig\"}}]")]
    public class BudgetCostAnomalyEvent : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/budget_cost_anomaly_event oci_budget_cost_anomaly_event} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public BudgetCostAnomalyEvent(Constructs.Construct scope, string id, oci.BudgetCostAnomalyEvent.IBudgetCostAnomalyEventConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.BudgetCostAnomalyEvent.IBudgetCostAnomalyEventConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BudgetCostAnomalyEvent(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BudgetCostAnomalyEvent(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a BudgetCostAnomalyEvent resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the BudgetCostAnomalyEvent to import.</param>
        /// <param name="importFromId">The id of the existing BudgetCostAnomalyEvent that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the BudgetCostAnomalyEvent to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the BudgetCostAnomalyEvent to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/budget_cost_anomaly_event#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing BudgetCostAnomalyEvent that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the BudgetCostAnomalyEvent to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.BudgetCostAnomalyEvent.BudgetCostAnomalyEvent), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.budgetCostAnomalyEvent.BudgetCostAnomalyEventTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.BudgetCostAnomalyEvent.IBudgetCostAnomalyEventTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BudgetCostAnomalyEvent.IBudgetCostAnomalyEventTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFeedbackResponse")]
        public virtual void ResetFeedbackResponse()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(oci.BudgetCostAnomalyEvent.BudgetCostAnomalyEvent))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "costAnomalyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CostAnomalyName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "costImpact", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CostImpact
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "costMonitorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CostMonitorId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "costMonitorName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CostMonitorName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "costMonitorType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CostMonitorType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "costVariancePercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CostVariancePercentage
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "rootCauseDetail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootCauseDetail
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

        [JsiiProperty(name: "targetResourceFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetResourceFilter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeAnomalyEventDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAnomalyEventDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.budgetCostAnomalyEvent.BudgetCostAnomalyEventTimeoutsOutputReference\"}")]
        public virtual oci.BudgetCostAnomalyEvent.BudgetCostAnomalyEventTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.BudgetCostAnomalyEvent.BudgetCostAnomalyEventTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "costAnomalyEventIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CostAnomalyEventIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "feedbackResponseInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FeedbackResponseInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.BudgetCostAnomalyEvent.IBudgetCostAnomalyEventTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.budgetCostAnomalyEvent.BudgetCostAnomalyEventTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "costAnomalyEventId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CostAnomalyEventId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "feedbackResponse", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FeedbackResponse
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
