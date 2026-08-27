using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDisasterRecoveryAutomaticDrConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/disaster_recovery_automatic_dr_configuration oci_disaster_recovery_automatic_dr_configuration}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDisasterRecoveryAutomaticDrConfiguration.DataOciDisasterRecoveryAutomaticDrConfiguration), fullyQualifiedName: "oci.dataOciDisasterRecoveryAutomaticDrConfiguration.DataOciDisasterRecoveryAutomaticDrConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDisasterRecoveryAutomaticDrConfiguration.DataOciDisasterRecoveryAutomaticDrConfigurationConfig\"}}]")]
    public class DataOciDisasterRecoveryAutomaticDrConfiguration : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/disaster_recovery_automatic_dr_configuration oci_disaster_recovery_automatic_dr_configuration} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDisasterRecoveryAutomaticDrConfiguration(Constructs.Construct scope, string id, oci.DataOciDisasterRecoveryAutomaticDrConfiguration.IDataOciDisasterRecoveryAutomaticDrConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDisasterRecoveryAutomaticDrConfiguration.IDataOciDisasterRecoveryAutomaticDrConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDisasterRecoveryAutomaticDrConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDisasterRecoveryAutomaticDrConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDisasterRecoveryAutomaticDrConfiguration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDisasterRecoveryAutomaticDrConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDisasterRecoveryAutomaticDrConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDisasterRecoveryAutomaticDrConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDisasterRecoveryAutomaticDrConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/disaster_recovery_automatic_dr_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDisasterRecoveryAutomaticDrConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDisasterRecoveryAutomaticDrConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDisasterRecoveryAutomaticDrConfiguration.DataOciDisasterRecoveryAutomaticDrConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDisasterRecoveryAutomaticDrConfiguration.DataOciDisasterRecoveryAutomaticDrConfiguration))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultFailoverDrPlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultFailoverDrPlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultSwitchoverDrPlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultSwitchoverDrPlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "drProtectionGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DrProtectionGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastAutomaticDrExecutionSubmitDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastAutomaticDrExecutionSubmitDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastAutomaticDrExecutionSubmitStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastAutomaticDrExecutionSubmitStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "members", typeJson: "{\"fqn\":\"oci.dataOciDisasterRecoveryAutomaticDrConfiguration.DataOciDisasterRecoveryAutomaticDrConfigurationMembersList\"}")]
        public virtual oci.DataOciDisasterRecoveryAutomaticDrConfiguration.DataOciDisasterRecoveryAutomaticDrConfigurationMembersList Members
        {
            get => GetInstanceProperty<oci.DataOciDisasterRecoveryAutomaticDrConfiguration.DataOciDisasterRecoveryAutomaticDrConfigurationMembersList>()!;
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

        [JsiiProperty(name: "timeLastAutomaticDrExecutionSubmitAttempt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastAutomaticDrExecutionSubmitAttempt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "automaticDrConfigurationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutomaticDrConfigurationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "automaticDrConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutomaticDrConfigurationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
