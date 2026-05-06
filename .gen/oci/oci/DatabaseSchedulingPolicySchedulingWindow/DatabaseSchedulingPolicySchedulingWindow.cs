using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseSchedulingPolicySchedulingWindow
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy_scheduling_window oci_database_scheduling_policy_scheduling_window}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindow), fullyQualifiedName: "oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindow", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowConfig\"}}]")]
    public class DatabaseSchedulingPolicySchedulingWindow : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy_scheduling_window oci_database_scheduling_policy_scheduling_window} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseSchedulingPolicySchedulingWindow(Constructs.Construct scope, string id, oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseSchedulingPolicySchedulingWindow(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseSchedulingPolicySchedulingWindow(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseSchedulingPolicySchedulingWindow resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseSchedulingPolicySchedulingWindow to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseSchedulingPolicySchedulingWindow that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseSchedulingPolicySchedulingWindow to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseSchedulingPolicySchedulingWindow to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduling_policy_scheduling_window#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseSchedulingPolicySchedulingWindow that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseSchedulingPolicySchedulingWindow to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindow), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWindowPreference", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreference\"}}]")]
        public virtual void PutWindowPreference(oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowWindowPreference @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowWindowPreference)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCompartmentId")]
        public virtual void ResetCompartmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(oci.DatabaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindow))!;

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeNextSchedulingWindowStarts", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeNextSchedulingWindowStarts
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowTimeoutsOutputReference\"}")]
        public virtual oci.DatabaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "windowPreference", typeJson: "{\"fqn\":\"oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreferenceOutputReference\"}")]
        public virtual oci.DatabaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreferenceOutputReference WindowPreference
        {
            get => GetInstanceProperty<oci.DatabaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreferenceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
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
        [JsiiProperty(name: "schedulingPolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SchedulingPolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "windowPreferenceInput", typeJson: "{\"fqn\":\"oci.databaseSchedulingPolicySchedulingWindow.DatabaseSchedulingPolicySchedulingWindowWindowPreference\"}", isOptional: true)]
        public virtual oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowWindowPreference? WindowPreferenceInput
        {
            get => GetInstanceProperty<oci.DatabaseSchedulingPolicySchedulingWindow.IDatabaseSchedulingPolicySchedulingWindowWindowPreference?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
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

        [JsiiProperty(name: "schedulingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchedulingPolicyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
