using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMonitoringAlarmSuppression
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/monitoring_alarm_suppression oci_monitoring_alarm_suppression}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciMonitoringAlarmSuppression.DataOciMonitoringAlarmSuppressionA), fullyQualifiedName: "oci.dataOciMonitoringAlarmSuppression.DataOciMonitoringAlarmSuppressionA", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciMonitoringAlarmSuppression.DataOciMonitoringAlarmSuppressionAConfig\"}}]")]
    public class DataOciMonitoringAlarmSuppressionA : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/monitoring_alarm_suppression oci_monitoring_alarm_suppression} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciMonitoringAlarmSuppressionA(Constructs.Construct scope, string id, oci.DataOciMonitoringAlarmSuppression.IDataOciMonitoringAlarmSuppressionAConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciMonitoringAlarmSuppression.IDataOciMonitoringAlarmSuppressionAConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMonitoringAlarmSuppressionA(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMonitoringAlarmSuppressionA(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciMonitoringAlarmSuppressionA resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciMonitoringAlarmSuppressionA to import.</param>
        /// <param name="importFromId">The id of the existing DataOciMonitoringAlarmSuppressionA that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciMonitoringAlarmSuppressionA to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciMonitoringAlarmSuppressionA to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/monitoring_alarm_suppression#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciMonitoringAlarmSuppressionA that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciMonitoringAlarmSuppressionA to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciMonitoringAlarmSuppression.DataOciMonitoringAlarmSuppressionA), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciMonitoringAlarmSuppression.DataOciMonitoringAlarmSuppressionA))!;

        [JsiiProperty(name: "alarmSuppressionTarget", typeJson: "{\"fqn\":\"oci.dataOciMonitoringAlarmSuppression.DataOciMonitoringAlarmSuppressionAlarmSuppressionTargetList\"}")]
        public virtual oci.DataOciMonitoringAlarmSuppression.DataOciMonitoringAlarmSuppressionAlarmSuppressionTargetList AlarmSuppressionTarget
        {
            get => GetInstanceProperty<oci.DataOciMonitoringAlarmSuppression.DataOciMonitoringAlarmSuppressionAlarmSuppressionTargetList>()!;
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

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dimensions", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Dimensions
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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

        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Level
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "suppressionConditions", typeJson: "{\"fqn\":\"oci.dataOciMonitoringAlarmSuppression.DataOciMonitoringAlarmSuppressionSuppressionConditionsList\"}")]
        public virtual oci.DataOciMonitoringAlarmSuppression.DataOciMonitoringAlarmSuppressionSuppressionConditionsList SuppressionConditions
        {
            get => GetInstanceProperty<oci.DataOciMonitoringAlarmSuppression.DataOciMonitoringAlarmSuppressionSuppressionConditionsList>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeSuppressFrom", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeSuppressFrom
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeSuppressUntil", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeSuppressUntil
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "alarmSuppressionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AlarmSuppressionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "alarmSuppressionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AlarmSuppressionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
