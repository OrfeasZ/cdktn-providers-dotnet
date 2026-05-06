using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMonitoringAlarms
{
    [JsiiClass(nativeType: typeof(oci.DataOciMonitoringAlarms.DataOciMonitoringAlarmsAlarmsOutputReference), fullyQualifiedName: "oci.dataOciMonitoringAlarms.DataOciMonitoringAlarmsAlarmsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMonitoringAlarmsAlarmsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMonitoringAlarmsAlarmsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMonitoringAlarmsAlarmsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMonitoringAlarmsAlarmsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "alarmSummary", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AlarmSummary
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Body
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

        [JsiiProperty(name: "destinations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Destinations
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "evaluationSlackDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EvaluationSlackDuration
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

        [JsiiProperty(name: "isEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isNotificationsPerMetricDimensionEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsNotificationsPerMetricDimensionEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "messageFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MessageFormat
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metricCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricCompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metricCompartmentIdInSubtree", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable MetricCompartmentIdInSubtree
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notificationTitle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotificationTitle
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notificationVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotificationVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "overrides", typeJson: "{\"fqn\":\"oci.dataOciMonitoringAlarms.DataOciMonitoringAlarmsAlarmsOverridesList\"}")]
        public virtual oci.DataOciMonitoringAlarms.DataOciMonitoringAlarmsAlarmsOverridesList Overrides
        {
            get => GetInstanceProperty<oci.DataOciMonitoringAlarms.DataOciMonitoringAlarmsAlarmsOverridesList>()!;
        }

        [JsiiProperty(name: "pendingDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PendingDuration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Query
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "repeatNotificationDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepeatNotificationDuration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resolution", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Resolution
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ruleName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuleName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "severity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Severity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "suppression", typeJson: "{\"fqn\":\"oci.dataOciMonitoringAlarms.DataOciMonitoringAlarmsAlarmsSuppressionList\"}")]
        public virtual oci.DataOciMonitoringAlarms.DataOciMonitoringAlarmsAlarmsSuppressionList Suppression
        {
            get => GetInstanceProperty<oci.DataOciMonitoringAlarms.DataOciMonitoringAlarmsAlarmsSuppressionList>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMonitoringAlarms.DataOciMonitoringAlarmsAlarms\"}", isOptional: true)]
        public virtual oci.DataOciMonitoringAlarms.IDataOciMonitoringAlarmsAlarms? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMonitoringAlarms.IDataOciMonitoringAlarmsAlarms?>();
            set => SetInstanceProperty(value);
        }
    }
}
