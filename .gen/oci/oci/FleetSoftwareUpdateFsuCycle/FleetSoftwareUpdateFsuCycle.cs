using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetSoftwareUpdateFsuCycle
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle oci_fleet_software_update_fsu_cycle}.</summary>
    [JsiiClass(nativeType: typeof(oci.FleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycle), fullyQualifiedName: "oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycle", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleConfig\"}}]")]
    public class FleetSoftwareUpdateFsuCycle : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle oci_fleet_software_update_fsu_cycle} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public FleetSoftwareUpdateFsuCycle(Constructs.Construct scope, string id, oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetSoftwareUpdateFsuCycle(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetSoftwareUpdateFsuCycle(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a FleetSoftwareUpdateFsuCycle resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the FleetSoftwareUpdateFsuCycle to import.</param>
        /// <param name="importFromId">The id of the existing FleetSoftwareUpdateFsuCycle that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the FleetSoftwareUpdateFsuCycle to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the FleetSoftwareUpdateFsuCycle to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_cycle#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing FleetSoftwareUpdateFsuCycle that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the FleetSoftwareUpdateFsuCycle to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.FleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycle), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putApplyActionSchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleApplyActionSchedule\"}}]")]
        public virtual void PutApplyActionSchedule(oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleApplyActionSchedule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleApplyActionSchedule)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBatchingStrategy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleBatchingStrategy\"}}]")]
        public virtual void PutBatchingStrategy(oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleBatchingStrategy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleBatchingStrategy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDiagnosticsCollection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleDiagnosticsCollection\"}}]")]
        public virtual void PutDiagnosticsCollection(oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleDiagnosticsCollection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleDiagnosticsCollection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGoalVersionDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetails\"}}]")]
        public virtual void PutGoalVersionDetails(oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleGoalVersionDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleGoalVersionDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStageActionSchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleStageActionSchedule\"}}]")]
        public virtual void PutStageActionSchedule(oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleStageActionSchedule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleStageActionSchedule)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpgradeDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleUpgradeDetails\"}}]")]
        public virtual void PutUpgradeDetails(oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleUpgradeDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleUpgradeDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApplyActionSchedule")]
        public virtual void ResetApplyActionSchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBatchingStrategy")]
        public virtual void ResetBatchingStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDiagnosticsCollection")]
        public virtual void ResetDiagnosticsCollection()
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

        [JsiiMethod(name: "resetIsIgnoreMissingPatches")]
        public virtual void ResetIsIgnoreMissingPatches()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsIgnorePatches")]
        public virtual void ResetIsIgnorePatches()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsKeepPlacement")]
        public virtual void ResetIsKeepPlacement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxDrainTimeoutInSeconds")]
        public virtual void ResetMaxDrainTimeoutInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStageActionSchedule")]
        public virtual void ResetStageActionSchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpgradeDetails")]
        public virtual void ResetUpgradeDetails()
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
        = GetStaticProperty<string>(typeof(oci.FleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycle))!;

        [JsiiProperty(name: "applyActionSchedule", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleApplyActionScheduleOutputReference\"}")]
        public virtual oci.FleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleApplyActionScheduleOutputReference ApplyActionSchedule
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleApplyActionScheduleOutputReference>()!;
        }

        [JsiiProperty(name: "batchingStrategy", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleBatchingStrategyOutputReference\"}")]
        public virtual oci.FleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleBatchingStrategyOutputReference BatchingStrategy
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleBatchingStrategyOutputReference>()!;
        }

        [JsiiProperty(name: "collectionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CollectionType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "diagnosticsCollection", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleDiagnosticsCollectionOutputReference\"}")]
        public virtual oci.FleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleDiagnosticsCollectionOutputReference DiagnosticsCollection
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleDiagnosticsCollectionOutputReference>()!;
        }

        [JsiiProperty(name: "executingFsuActionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutingFsuActionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "goalVersionDetails", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetailsOutputReference\"}")]
        public virtual oci.FleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetailsOutputReference GoalVersionDetails
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "lastCompletedAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastCompletedAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastCompletedActionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastCompletedActionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nextActionToExecute", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleNextActionToExecuteList\"}")]
        public virtual oci.FleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleNextActionToExecuteList NextActionToExecute
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleNextActionToExecuteList>()!;
        }

        [JsiiProperty(name: "rollbackCycleState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RollbackCycleState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stageActionSchedule", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleStageActionScheduleOutputReference\"}")]
        public virtual oci.FleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleStageActionScheduleOutputReference StageActionSchedule
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleStageActionScheduleOutputReference>()!;
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

        [JsiiProperty(name: "timeFinished", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeFinished
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleTimeoutsOutputReference\"}")]
        public virtual oci.FleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "upgradeDetails", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleUpgradeDetailsOutputReference\"}")]
        public virtual oci.FleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleUpgradeDetailsOutputReference UpgradeDetails
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleUpgradeDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applyActionScheduleInput", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleApplyActionSchedule\"}", isOptional: true)]
        public virtual oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleApplyActionSchedule? ApplyActionScheduleInput
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleApplyActionSchedule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "batchingStrategyInput", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleBatchingStrategy\"}", isOptional: true)]
        public virtual oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleBatchingStrategy? BatchingStrategyInput
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleBatchingStrategy?>();
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
        [JsiiProperty(name: "diagnosticsCollectionInput", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleDiagnosticsCollection\"}", isOptional: true)]
        public virtual oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleDiagnosticsCollection? DiagnosticsCollectionInput
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleDiagnosticsCollection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
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
        [JsiiProperty(name: "fsuCollectionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FsuCollectionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "goalVersionDetailsInput", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleGoalVersionDetails\"}", isOptional: true)]
        public virtual oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleGoalVersionDetails? GoalVersionDetailsInput
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleGoalVersionDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isIgnoreMissingPatchesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? IsIgnoreMissingPatchesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isIgnorePatchesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsIgnorePatchesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isKeepPlacementInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsKeepPlacementInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxDrainTimeoutInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxDrainTimeoutInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stageActionScheduleInput", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleStageActionSchedule\"}", isOptional: true)]
        public virtual oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleStageActionSchedule? StageActionScheduleInput
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleStageActionSchedule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "upgradeDetailsInput", typeJson: "{\"fqn\":\"oci.fleetSoftwareUpdateFsuCycle.FleetSoftwareUpdateFsuCycleUpgradeDetails\"}", isOptional: true)]
        public virtual oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleUpgradeDetails? UpgradeDetailsInput
        {
            get => GetInstanceProperty<oci.FleetSoftwareUpdateFsuCycle.IFleetSoftwareUpdateFsuCycleUpgradeDetails?>();
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

        [JsiiProperty(name: "fsuCollectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FsuCollectionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isIgnoreMissingPatches", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IsIgnoreMissingPatches
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isIgnorePatches", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsIgnorePatches
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "isKeepPlacement", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsKeepPlacement
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "maxDrainTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxDrainTimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
