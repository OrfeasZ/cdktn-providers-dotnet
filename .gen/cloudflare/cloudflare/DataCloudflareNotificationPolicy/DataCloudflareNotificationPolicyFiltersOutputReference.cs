using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareNotificationPolicy
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareNotificationPolicy.DataCloudflareNotificationPolicyFiltersOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareNotificationPolicy.DataCloudflareNotificationPolicyFiltersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareNotificationPolicyFiltersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareNotificationPolicyFiltersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareNotificationPolicyFiltersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareNotificationPolicyFiltersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Actions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "affectedAsns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AffectedAsns
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "affectedComponents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AffectedComponents
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "affectedLocations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AffectedLocations
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "airportCode", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AirportCode
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "alertTriggerPreferences", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AlertTriggerPreferences
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "alertTriggerPreferencesValue", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AlertTriggerPreferencesValue
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Enabled
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Environment
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "event", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Event
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "eventSource", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EventSource
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "eventType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EventType
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "groupBy", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] GroupBy
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "healthCheckId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] HealthCheckId
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "incidentImpact", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IncidentImpact
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "inputId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] InputId
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "insightClass", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] InsightClass
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "limit", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Limit
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "logoTag", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LogoTag
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "megabitsPerSecond", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] MegabitsPerSecond
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "newHealth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NewHealth
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "newStatus", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NewStatus
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "packetsPerSecond", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PacketsPerSecond
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "poolId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PoolId
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "popNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PopNames
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "product", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Product
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ProjectId
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Protocol
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "queryTag", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] QueryTag
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "requestsPerSecond", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RequestsPerSecond
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "selectors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Selectors
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "services", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Services
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "slo", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Slo
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Status
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "targetHostname", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TargetHostname
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "targetIp", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TargetIp
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "targetZoneName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TargetZoneName
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "trafficExclusions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TrafficExclusions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tunnelId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TunnelId
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tunnelName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TunnelName
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Type
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "where", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Where
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Zones
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareNotificationPolicy.DataCloudflareNotificationPolicyFilters\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareNotificationPolicy.IDataCloudflareNotificationPolicyFilters? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareNotificationPolicy.IDataCloudflareNotificationPolicyFilters?>();
            set => SetInstanceProperty(value);
        }
    }
}
