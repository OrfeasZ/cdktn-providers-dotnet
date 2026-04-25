using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.NotificationPolicy
{
    [JsiiByValue(fqn: "cloudflare.notificationPolicy.NotificationPolicyFilters")]
    public class NotificationPolicyFilters : cloudflare.NotificationPolicy.INotificationPolicyFilters
    {
        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#actions NotificationPolicy#actions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Actions
        {
            get;
            set;
        }

        /// <summary>Used for configuring radar_notification.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#affected_asns NotificationPolicy#affected_asns}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "affectedAsns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AffectedAsns
        {
            get;
            set;
        }

        /// <summary>Used for configuring incident_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#affected_components NotificationPolicy#affected_components}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "affectedComponents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AffectedComponents
        {
            get;
            set;
        }

        /// <summary>Used for configuring radar_notification.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#affected_locations NotificationPolicy#affected_locations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "affectedLocations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AffectedLocations
        {
            get;
            set;
        }

        /// <summary>Used for configuring maintenance_event_notification.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#airport_code NotificationPolicy#airport_code}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "airportCode", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AirportCode
        {
            get;
            set;
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#alert_trigger_preferences NotificationPolicy#alert_trigger_preferences}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alertTriggerPreferences", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AlertTriggerPreferences
        {
            get;
            set;
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#alert_trigger_preferences_value NotificationPolicy#alert_trigger_preferences_value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alertTriggerPreferencesValue", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AlertTriggerPreferencesValue
        {
            get;
            set;
        }

        /// <summary>Used for configuring load_balancing_pool_enablement_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#enabled NotificationPolicy#enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Enabled
        {
            get;
            set;
        }

        /// <summary>Used for configuring pages_event_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#environment NotificationPolicy#environment}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Environment
        {
            get;
            set;
        }

        /// <summary>Used for configuring pages_event_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#event NotificationPolicy#event}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "event", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Event
        {
            get;
            set;
        }

        /// <summary>Used for configuring load_balancing_health_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#event_source NotificationPolicy#event_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eventSource", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? EventSource
        {
            get;
            set;
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#event_type NotificationPolicy#event_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eventType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? EventType
        {
            get;
            set;
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#group_by NotificationPolicy#group_by}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "groupBy", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? GroupBy
        {
            get;
            set;
        }

        /// <summary>Used for configuring health_check_status_notification.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#health_check_id NotificationPolicy#health_check_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? HealthCheckId
        {
            get;
            set;
        }

        /// <summary>Used for configuring incident_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#incident_impact NotificationPolicy#incident_impact}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "incidentImpact", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IncidentImpact
        {
            get;
            set;
        }

        /// <summary>Used for configuring stream_live_notifications.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#input_id NotificationPolicy#input_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inputId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? InputId
        {
            get;
            set;
        }

        /// <summary>Used for configuring security_insights_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#insight_class NotificationPolicy#insight_class}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "insightClass", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? InsightClass
        {
            get;
            set;
        }

        /// <summary>Used for configuring billing_usage_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#limit NotificationPolicy#limit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "limit", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Limit
        {
            get;
            set;
        }

        /// <summary>Used for configuring logo_match_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#logo_tag NotificationPolicy#logo_tag}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logoTag", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? LogoTag
        {
            get;
            set;
        }

        /// <summary>Used for configuring advanced_ddos_attack_l4_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#megabits_per_second NotificationPolicy#megabits_per_second}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "megabitsPerSecond", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? MegabitsPerSecond
        {
            get;
            set;
        }

        /// <summary>Used for configuring load_balancing_health_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#new_health NotificationPolicy#new_health}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "newHealth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NewHealth
        {
            get;
            set;
        }

        /// <summary>Used for configuring tunnel_health_event.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#new_status NotificationPolicy#new_status}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "newStatus", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NewStatus
        {
            get;
            set;
        }

        /// <summary>Used for configuring advanced_ddos_attack_l4_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#packets_per_second NotificationPolicy#packets_per_second}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "packetsPerSecond", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PacketsPerSecond
        {
            get;
            set;
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#pool_id NotificationPolicy#pool_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "poolId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PoolId
        {
            get;
            set;
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#pop_names NotificationPolicy#pop_names}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "popNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PopNames
        {
            get;
            set;
        }

        /// <summary>Used for configuring billing_usage_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#product NotificationPolicy#product}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "product", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Product
        {
            get;
            set;
        }

        /// <summary>Used for configuring pages_event_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#project_id NotificationPolicy#project_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "projectId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ProjectId
        {
            get;
            set;
        }

        /// <summary>Used for configuring advanced_ddos_attack_l4_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#protocol NotificationPolicy#protocol}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Protocol
        {
            get;
            set;
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#query_tag NotificationPolicy#query_tag}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryTag", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? QueryTag
        {
            get;
            set;
        }

        /// <summary>Used for configuring advanced_ddos_attack_l7_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#requests_per_second NotificationPolicy#requests_per_second}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestsPerSecond", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? RequestsPerSecond
        {
            get;
            set;
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#selectors NotificationPolicy#selectors}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "selectors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Selectors
        {
            get;
            set;
        }

        /// <summary>Used for configuring clickhouse_alert_fw_ent_anomaly.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#services NotificationPolicy#services}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "services", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Services
        {
            get;
            set;
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#slo NotificationPolicy#slo}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "slo", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Slo
        {
            get;
            set;
        }

        /// <summary>Used for configuring health_check_status_notification.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#status NotificationPolicy#status}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Status
        {
            get;
            set;
        }

        /// <summary>Used for configuring advanced_ddos_attack_l7_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#target_hostname NotificationPolicy#target_hostname}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetHostname", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TargetHostname
        {
            get;
            set;
        }

        /// <summary>Used for configuring advanced_ddos_attack_l4_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#target_ip NotificationPolicy#target_ip}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetIp", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TargetIp
        {
            get;
            set;
        }

        /// <summary>Used for configuring advanced_ddos_attack_l7_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#target_zone_name NotificationPolicy#target_zone_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetZoneName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TargetZoneName
        {
            get;
            set;
        }

        /// <summary>Used for configuring traffic_anomalies_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#traffic_exclusions NotificationPolicy#traffic_exclusions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trafficExclusions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TrafficExclusions
        {
            get;
            set;
        }

        /// <summary>Used for configuring tunnel_health_event.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#tunnel_id NotificationPolicy#tunnel_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tunnelId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TunnelId
        {
            get;
            set;
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#tunnel_name NotificationPolicy#tunnel_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tunnelName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TunnelName
        {
            get;
            set;
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#type NotificationPolicy#type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Type
        {
            get;
            set;
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#where NotificationPolicy#where}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "where", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Where
        {
            get;
            set;
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/notification_policy#zones NotificationPolicy#zones}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Zones
        {
            get;
            set;
        }
    }
}
