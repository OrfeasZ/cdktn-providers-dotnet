using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.NotificationPolicy
{
    [JsiiInterface(nativeType: typeof(INotificationPolicyFilters), fullyQualifiedName: "cloudflare.notificationPolicy.NotificationPolicyFilters")]
    public interface INotificationPolicyFilters
    {
        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#actions NotificationPolicy#actions}
        /// </remarks>
        [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Actions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring radar_notification.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#affected_asns NotificationPolicy#affected_asns}
        /// </remarks>
        [JsiiProperty(name: "affectedAsns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AffectedAsns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring incident_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#affected_components NotificationPolicy#affected_components}
        /// </remarks>
        [JsiiProperty(name: "affectedComponents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AffectedComponents
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring radar_notification.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#affected_locations NotificationPolicy#affected_locations}
        /// </remarks>
        [JsiiProperty(name: "affectedLocations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AffectedLocations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring maintenance_event_notification.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#airport_code NotificationPolicy#airport_code}
        /// </remarks>
        [JsiiProperty(name: "airportCode", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AirportCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#alert_trigger_preferences NotificationPolicy#alert_trigger_preferences}
        /// </remarks>
        [JsiiProperty(name: "alertTriggerPreferences", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AlertTriggerPreferences
        {
            get
            {
                return null;
            }
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#alert_trigger_preferences_value NotificationPolicy#alert_trigger_preferences_value}
        /// </remarks>
        [JsiiProperty(name: "alertTriggerPreferencesValue", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AlertTriggerPreferencesValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring load_balancing_pool_enablement_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#enabled NotificationPolicy#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring pages_event_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#environment NotificationPolicy#environment}
        /// </remarks>
        [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Environment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring pages_event_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#event NotificationPolicy#event}
        /// </remarks>
        [JsiiProperty(name: "event", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Event
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring load_balancing_health_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#event_source NotificationPolicy#event_source}
        /// </remarks>
        [JsiiProperty(name: "eventSource", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? EventSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#event_type NotificationPolicy#event_type}
        /// </remarks>
        [JsiiProperty(name: "eventType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? EventType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#group_by NotificationPolicy#group_by}
        /// </remarks>
        [JsiiProperty(name: "groupBy", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? GroupBy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring health_check_status_notification.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#health_check_id NotificationPolicy#health_check_id}
        /// </remarks>
        [JsiiProperty(name: "healthCheckId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? HealthCheckId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring incident_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#incident_impact NotificationPolicy#incident_impact}
        /// </remarks>
        [JsiiProperty(name: "incidentImpact", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IncidentImpact
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring stream_live_notifications.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#input_id NotificationPolicy#input_id}
        /// </remarks>
        [JsiiProperty(name: "inputId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? InputId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring security_insights_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#insight_class NotificationPolicy#insight_class}
        /// </remarks>
        [JsiiProperty(name: "insightClass", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? InsightClass
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring billing_usage_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#limit NotificationPolicy#limit}
        /// </remarks>
        [JsiiProperty(name: "limit", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Limit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring logo_match_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#logo_tag NotificationPolicy#logo_tag}
        /// </remarks>
        [JsiiProperty(name: "logoTag", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? LogoTag
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring advanced_ddos_attack_l4_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#megabits_per_second NotificationPolicy#megabits_per_second}
        /// </remarks>
        [JsiiProperty(name: "megabitsPerSecond", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? MegabitsPerSecond
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring load_balancing_health_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#new_health NotificationPolicy#new_health}
        /// </remarks>
        [JsiiProperty(name: "newHealth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NewHealth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring tunnel_health_event.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#new_status NotificationPolicy#new_status}
        /// </remarks>
        [JsiiProperty(name: "newStatus", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NewStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring advanced_ddos_attack_l4_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#packets_per_second NotificationPolicy#packets_per_second}
        /// </remarks>
        [JsiiProperty(name: "packetsPerSecond", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PacketsPerSecond
        {
            get
            {
                return null;
            }
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#pool_id NotificationPolicy#pool_id}
        /// </remarks>
        [JsiiProperty(name: "poolId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PoolId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#pop_names NotificationPolicy#pop_names}
        /// </remarks>
        [JsiiProperty(name: "popNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PopNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring billing_usage_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#product NotificationPolicy#product}
        /// </remarks>
        [JsiiProperty(name: "product", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Product
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring pages_event_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#project_id NotificationPolicy#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ProjectId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring advanced_ddos_attack_l4_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#protocol NotificationPolicy#protocol}
        /// </remarks>
        [JsiiProperty(name: "protocol", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Protocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#query_tag NotificationPolicy#query_tag}
        /// </remarks>
        [JsiiProperty(name: "queryTag", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? QueryTag
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring advanced_ddos_attack_l7_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#requests_per_second NotificationPolicy#requests_per_second}
        /// </remarks>
        [JsiiProperty(name: "requestsPerSecond", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? RequestsPerSecond
        {
            get
            {
                return null;
            }
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#selectors NotificationPolicy#selectors}
        /// </remarks>
        [JsiiProperty(name: "selectors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Selectors
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring clickhouse_alert_fw_ent_anomaly.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#services NotificationPolicy#services}
        /// </remarks>
        [JsiiProperty(name: "services", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Services
        {
            get
            {
                return null;
            }
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#slo NotificationPolicy#slo}
        /// </remarks>
        [JsiiProperty(name: "slo", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Slo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring health_check_status_notification.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#status NotificationPolicy#status}
        /// </remarks>
        [JsiiProperty(name: "status", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Status
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring advanced_ddos_attack_l7_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#target_hostname NotificationPolicy#target_hostname}
        /// </remarks>
        [JsiiProperty(name: "targetHostname", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TargetHostname
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring advanced_ddos_attack_l4_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#target_ip NotificationPolicy#target_ip}
        /// </remarks>
        [JsiiProperty(name: "targetIp", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TargetIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring advanced_ddos_attack_l7_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#target_zone_name NotificationPolicy#target_zone_name}
        /// </remarks>
        [JsiiProperty(name: "targetZoneName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TargetZoneName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring traffic_anomalies_alert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#traffic_exclusions NotificationPolicy#traffic_exclusions}
        /// </remarks>
        [JsiiProperty(name: "trafficExclusions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TrafficExclusions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Used for configuring tunnel_health_event.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#tunnel_id NotificationPolicy#tunnel_id}
        /// </remarks>
        [JsiiProperty(name: "tunnelId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TunnelId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#tunnel_name NotificationPolicy#tunnel_name}
        /// </remarks>
        [JsiiProperty(name: "tunnelName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TunnelName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#type NotificationPolicy#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#where NotificationPolicy#where}
        /// </remarks>
        [JsiiProperty(name: "where", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Where
        {
            get
            {
                return null;
            }
        }

        /// <summary>Usage depends on specific alert type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#zones NotificationPolicy#zones}
        /// </remarks>
        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Zones
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INotificationPolicyFilters), fullyQualifiedName: "cloudflare.notificationPolicy.NotificationPolicyFilters")]
        internal sealed class _Proxy : DeputyBase, cloudflare.NotificationPolicy.INotificationPolicyFilters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Usage depends on specific alert type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#actions NotificationPolicy#actions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Actions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring radar_notification.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#affected_asns NotificationPolicy#affected_asns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "affectedAsns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AffectedAsns
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring incident_alert.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#affected_components NotificationPolicy#affected_components}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "affectedComponents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AffectedComponents
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring radar_notification.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#affected_locations NotificationPolicy#affected_locations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "affectedLocations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AffectedLocations
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring maintenance_event_notification.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#airport_code NotificationPolicy#airport_code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "airportCode", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AirportCode
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Usage depends on specific alert type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#alert_trigger_preferences NotificationPolicy#alert_trigger_preferences}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alertTriggerPreferences", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AlertTriggerPreferences
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Usage depends on specific alert type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#alert_trigger_preferences_value NotificationPolicy#alert_trigger_preferences_value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alertTriggerPreferencesValue", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AlertTriggerPreferencesValue
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring load_balancing_pool_enablement_alert.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#enabled NotificationPolicy#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Enabled
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring pages_event_alert.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#environment NotificationPolicy#environment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Environment
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring pages_event_alert.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#event NotificationPolicy#event}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "event", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Event
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring load_balancing_health_alert.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#event_source NotificationPolicy#event_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eventSource", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? EventSource
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Usage depends on specific alert type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#event_type NotificationPolicy#event_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eventType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? EventType
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Usage depends on specific alert type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#group_by NotificationPolicy#group_by}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "groupBy", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? GroupBy
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring health_check_status_notification.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#health_check_id NotificationPolicy#health_check_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? HealthCheckId
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring incident_alert.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#incident_impact NotificationPolicy#incident_impact}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "incidentImpact", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IncidentImpact
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring stream_live_notifications.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#input_id NotificationPolicy#input_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inputId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? InputId
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring security_insights_alert.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#insight_class NotificationPolicy#insight_class}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "insightClass", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? InsightClass
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring billing_usage_alert.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#limit NotificationPolicy#limit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "limit", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Limit
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring logo_match_alert.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#logo_tag NotificationPolicy#logo_tag}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logoTag", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? LogoTag
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring advanced_ddos_attack_l4_alert.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#megabits_per_second NotificationPolicy#megabits_per_second}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "megabitsPerSecond", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? MegabitsPerSecond
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring load_balancing_health_alert.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#new_health NotificationPolicy#new_health}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "newHealth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NewHealth
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring tunnel_health_event.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#new_status NotificationPolicy#new_status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "newStatus", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NewStatus
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring advanced_ddos_attack_l4_alert.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#packets_per_second NotificationPolicy#packets_per_second}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "packetsPerSecond", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PacketsPerSecond
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Usage depends on specific alert type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#pool_id NotificationPolicy#pool_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "poolId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PoolId
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Usage depends on specific alert type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#pop_names NotificationPolicy#pop_names}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "popNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PopNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring billing_usage_alert.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#product NotificationPolicy#product}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "product", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Product
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring pages_event_alert.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#project_id NotificationPolicy#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ProjectId
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring advanced_ddos_attack_l4_alert.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#protocol NotificationPolicy#protocol}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protocol", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Protocol
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Usage depends on specific alert type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#query_tag NotificationPolicy#query_tag}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryTag", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? QueryTag
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring advanced_ddos_attack_l7_alert.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#requests_per_second NotificationPolicy#requests_per_second}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestsPerSecond", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? RequestsPerSecond
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Usage depends on specific alert type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#selectors NotificationPolicy#selectors}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "selectors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Selectors
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring clickhouse_alert_fw_ent_anomaly.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#services NotificationPolicy#services}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "services", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Services
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Usage depends on specific alert type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#slo NotificationPolicy#slo}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "slo", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Slo
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring health_check_status_notification.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#status NotificationPolicy#status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Status
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring advanced_ddos_attack_l7_alert.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#target_hostname NotificationPolicy#target_hostname}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetHostname", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TargetHostname
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring advanced_ddos_attack_l4_alert.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#target_ip NotificationPolicy#target_ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetIp", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TargetIp
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring advanced_ddos_attack_l7_alert.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#target_zone_name NotificationPolicy#target_zone_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetZoneName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TargetZoneName
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring traffic_anomalies_alert.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#traffic_exclusions NotificationPolicy#traffic_exclusions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trafficExclusions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TrafficExclusions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Used for configuring tunnel_health_event.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#tunnel_id NotificationPolicy#tunnel_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tunnelId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TunnelId
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Usage depends on specific alert type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#tunnel_name NotificationPolicy#tunnel_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tunnelName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TunnelName
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Usage depends on specific alert type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#type NotificationPolicy#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Type
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Usage depends on specific alert type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#where NotificationPolicy#where}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "where", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Where
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Usage depends on specific alert type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#zones NotificationPolicy#zones}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Zones
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
