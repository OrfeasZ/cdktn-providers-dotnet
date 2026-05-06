using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmTracesScheduledQuery
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query oci_apm_traces_scheduled_query}.</summary>
    [JsiiClass(nativeType: typeof(oci.ApmTracesScheduledQuery.ApmTracesScheduledQuery), fullyQualifiedName: "oci.apmTracesScheduledQuery.ApmTracesScheduledQuery", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryConfig\"}}]")]
    public class ApmTracesScheduledQuery : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query oci_apm_traces_scheduled_query} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ApmTracesScheduledQuery(Constructs.Construct scope, string id, oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApmTracesScheduledQuery(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApmTracesScheduledQuery(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ApmTracesScheduledQuery resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ApmTracesScheduledQuery to import.</param>
        /// <param name="importFromId">The id of the existing ApmTracesScheduledQuery that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ApmTracesScheduledQuery to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ApmTracesScheduledQuery to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ApmTracesScheduledQuery that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ApmTracesScheduledQuery to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.ApmTracesScheduledQuery.ApmTracesScheduledQuery), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putScheduledQueryProcessingConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfiguration\"}}]")]
        public virtual void PutScheduledQueryProcessingConfiguration(oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
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

        [JsiiMethod(name: "resetOpcDryRun")]
        public virtual void ResetOpcDryRun()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScheduledQueryDescription")]
        public virtual void ResetScheduledQueryDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScheduledQueryMaximumRuntimeInSeconds")]
        public virtual void ResetScheduledQueryMaximumRuntimeInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScheduledQueryName")]
        public virtual void ResetScheduledQueryName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScheduledQueryProcessingConfiguration")]
        public virtual void ResetScheduledQueryProcessingConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScheduledQueryProcessingSubType")]
        public virtual void ResetScheduledQueryProcessingSubType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScheduledQueryProcessingType")]
        public virtual void ResetScheduledQueryProcessingType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScheduledQueryRetentionCriteria")]
        public virtual void ResetScheduledQueryRetentionCriteria()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScheduledQueryRetentionPeriodInMs")]
        public virtual void ResetScheduledQueryRetentionPeriodInMs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScheduledQuerySchedule")]
        public virtual void ResetScheduledQuerySchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScheduledQueryText")]
        public virtual void ResetScheduledQueryText()
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
        = GetStaticProperty<string>(typeof(oci.ApmTracesScheduledQuery.ApmTracesScheduledQuery))!;

        [JsiiProperty(name: "scheduledQueryInstances", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryInstances
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledQueryNextRunInMs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryNextRunInMs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledQueryProcessingConfiguration", typeJson: "{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationOutputReference\"}")]
        public virtual oci.ApmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationOutputReference ScheduledQueryProcessingConfiguration
        {
            get => GetInstanceProperty<oci.ApmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationOutputReference>()!;
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryTimeoutsOutputReference\"}")]
        public virtual oci.ApmTracesScheduledQuery.ApmTracesScheduledQueryTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.ApmTracesScheduledQuery.ApmTracesScheduledQueryTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apmDomainIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApmDomainIdInput
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

        [JsiiOptional]
        [JsiiProperty(name: "opcDryRunInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OpcDryRunInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduledQueryDescriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScheduledQueryDescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduledQueryMaximumRuntimeInSecondsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScheduledQueryMaximumRuntimeInSecondsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduledQueryNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScheduledQueryNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduledQueryProcessingConfigurationInput", typeJson: "{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfiguration\"}", isOptional: true)]
        public virtual oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfiguration? ScheduledQueryProcessingConfigurationInput
        {
            get => GetInstanceProperty<oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduledQueryProcessingSubTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScheduledQueryProcessingSubTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduledQueryProcessingTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScheduledQueryProcessingTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduledQueryRetentionCriteriaInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScheduledQueryRetentionCriteriaInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduledQueryRetentionPeriodInMsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScheduledQueryRetentionPeriodInMsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduledQueryScheduleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScheduledQueryScheduleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduledQueryTextInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScheduledQueryTextInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "apmDomainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApmDomainId
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

        [JsiiProperty(name: "opcDryRun", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpcDryRun
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scheduledQueryDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryDescription
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scheduledQueryMaximumRuntimeInSeconds", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryMaximumRuntimeInSeconds
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scheduledQueryName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scheduledQueryProcessingSubType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryProcessingSubType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scheduledQueryProcessingType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryProcessingType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scheduledQueryRetentionCriteria", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryRetentionCriteria
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scheduledQueryRetentionPeriodInMs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryRetentionPeriodInMs
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scheduledQuerySchedule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQuerySchedule
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scheduledQueryText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledQueryText
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
