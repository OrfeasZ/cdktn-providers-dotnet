using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetSoftwareUpdateFsuCycle
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_software_update_fsu_cycle oci_fleet_software_update_fsu_cycle}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycle), fullyQualifiedName: "oci.dataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycle", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycleConfig\"}}]")]
    public class DataOciFleetSoftwareUpdateFsuCycle : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_software_update_fsu_cycle oci_fleet_software_update_fsu_cycle} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciFleetSoftwareUpdateFsuCycle(Constructs.Construct scope, string id, oci.DataOciFleetSoftwareUpdateFsuCycle.IDataOciFleetSoftwareUpdateFsuCycleConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciFleetSoftwareUpdateFsuCycle.IDataOciFleetSoftwareUpdateFsuCycleConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetSoftwareUpdateFsuCycle(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetSoftwareUpdateFsuCycle(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciFleetSoftwareUpdateFsuCycle resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciFleetSoftwareUpdateFsuCycle to import.</param>
        /// <param name="importFromId">The id of the existing DataOciFleetSoftwareUpdateFsuCycle that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciFleetSoftwareUpdateFsuCycle to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciFleetSoftwareUpdateFsuCycle to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_software_update_fsu_cycle#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciFleetSoftwareUpdateFsuCycle that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciFleetSoftwareUpdateFsuCycle to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycle), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycle))!;

        [JsiiProperty(name: "applyActionSchedule", typeJson: "{\"fqn\":\"oci.dataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycleApplyActionScheduleList\"}")]
        public virtual oci.DataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycleApplyActionScheduleList ApplyActionSchedule
        {
            get => GetInstanceProperty<oci.DataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycleApplyActionScheduleList>()!;
        }

        [JsiiProperty(name: "batchingStrategy", typeJson: "{\"fqn\":\"oci.dataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycleBatchingStrategyList\"}")]
        public virtual oci.DataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycleBatchingStrategyList BatchingStrategy
        {
            get => GetInstanceProperty<oci.DataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycleBatchingStrategyList>()!;
        }

        [JsiiProperty(name: "collectionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CollectionType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "diagnosticsCollection", typeJson: "{\"fqn\":\"oci.dataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycleDiagnosticsCollectionList\"}")]
        public virtual oci.DataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycleDiagnosticsCollectionList DiagnosticsCollection
        {
            get => GetInstanceProperty<oci.DataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycleDiagnosticsCollectionList>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "executingFsuActionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutingFsuActionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "fsuCollectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FsuCollectionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "goalVersionDetails", typeJson: "{\"fqn\":\"oci.dataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycleGoalVersionDetailsList\"}")]
        public virtual oci.DataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycleGoalVersionDetailsList GoalVersionDetails
        {
            get => GetInstanceProperty<oci.DataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycleGoalVersionDetailsList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isIgnoreMissingPatches", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IsIgnoreMissingPatches
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "isIgnorePatches", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsIgnorePatches
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isKeepPlacement", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsKeepPlacement
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "maxDrainTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxDrainTimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "nextActionToExecute", typeJson: "{\"fqn\":\"oci.dataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycleNextActionToExecuteList\"}")]
        public virtual oci.DataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycleNextActionToExecuteList NextActionToExecute
        {
            get => GetInstanceProperty<oci.DataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycleNextActionToExecuteList>()!;
        }

        [JsiiProperty(name: "rollbackCycleState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RollbackCycleState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stageActionSchedule", typeJson: "{\"fqn\":\"oci.dataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycleStageActionScheduleList\"}")]
        public virtual oci.DataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycleStageActionScheduleList StageActionSchedule
        {
            get => GetInstanceProperty<oci.DataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycleStageActionScheduleList>()!;
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

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "upgradeDetails", typeJson: "{\"fqn\":\"oci.dataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycleUpgradeDetailsList\"}")]
        public virtual oci.DataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycleUpgradeDetailsList UpgradeDetails
        {
            get => GetInstanceProperty<oci.DataOciFleetSoftwareUpdateFsuCycle.DataOciFleetSoftwareUpdateFsuCycleUpgradeDetailsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fsuCycleIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FsuCycleIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "fsuCycleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FsuCycleId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
