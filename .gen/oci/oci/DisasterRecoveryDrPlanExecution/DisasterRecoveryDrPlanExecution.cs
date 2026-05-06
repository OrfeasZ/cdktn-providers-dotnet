using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrPlanExecution
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_plan_execution oci_disaster_recovery_dr_plan_execution}.</summary>
    [JsiiClass(nativeType: typeof(oci.DisasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecution), fullyQualifiedName: "oci.disasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecution", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.disasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionConfig\"}}]")]
    public class DisasterRecoveryDrPlanExecution : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_plan_execution oci_disaster_recovery_dr_plan_execution} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DisasterRecoveryDrPlanExecution(Constructs.Construct scope, string id, oci.DisasterRecoveryDrPlanExecution.IDisasterRecoveryDrPlanExecutionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DisasterRecoveryDrPlanExecution.IDisasterRecoveryDrPlanExecutionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DisasterRecoveryDrPlanExecution(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DisasterRecoveryDrPlanExecution(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DisasterRecoveryDrPlanExecution resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DisasterRecoveryDrPlanExecution to import.</param>
        /// <param name="importFromId">The id of the existing DisasterRecoveryDrPlanExecution that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DisasterRecoveryDrPlanExecution to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DisasterRecoveryDrPlanExecution to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/disaster_recovery_dr_plan_execution#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DisasterRecoveryDrPlanExecution that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DisasterRecoveryDrPlanExecution to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DisasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecution), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putExecutionOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.disasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionExecutionOptions\"}}]")]
        public virtual void PutExecutionOptions(oci.DisasterRecoveryDrPlanExecution.IDisasterRecoveryDrPlanExecutionExecutionOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DisasterRecoveryDrPlanExecution.IDisasterRecoveryDrPlanExecutionExecutionOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.disasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DisasterRecoveryDrPlanExecution.IDisasterRecoveryDrPlanExecutionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DisasterRecoveryDrPlanExecution.IDisasterRecoveryDrPlanExecutionTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
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
        = GetStaticProperty<string>(typeof(oci.DisasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecution))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "drProtectionGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DrProtectionGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "executionDurationInSec", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExecutionDurationInSec
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "executionOptions", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionExecutionOptionsOutputReference\"}")]
        public virtual oci.DisasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionExecutionOptionsOutputReference ExecutionOptions
        {
            get => GetInstanceProperty<oci.DisasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionExecutionOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "groupExecutions", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionGroupExecutionsList\"}")]
        public virtual oci.DisasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionGroupExecutionsList GroupExecutions
        {
            get => GetInstanceProperty<oci.DisasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionGroupExecutionsList>()!;
        }

        [JsiiProperty(name: "lifeCycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifeCycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logLocation", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionLogLocationList\"}")]
        public virtual oci.DisasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionLogLocationList LogLocation
        {
            get => GetInstanceProperty<oci.DisasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionLogLocationList>()!;
        }

        [JsiiProperty(name: "peerDrProtectionGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerDrProtectionGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerRegion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "planExecutionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlanExecutionType
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

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeEnded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeEnded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionTimeoutsOutputReference\"}")]
        public virtual oci.DisasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DisasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionOptionsInput", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionExecutionOptions\"}", isOptional: true)]
        public virtual oci.DisasterRecoveryDrPlanExecution.IDisasterRecoveryDrPlanExecutionExecutionOptions? ExecutionOptionsInput
        {
            get => GetInstanceProperty<oci.DisasterRecoveryDrPlanExecution.IDisasterRecoveryDrPlanExecutionExecutionOptions?>();
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
        [JsiiProperty(name: "planIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlanIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.disasterRecoveryDrPlanExecution.DisasterRecoveryDrPlanExecutionTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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

        [JsiiProperty(name: "planId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlanId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
