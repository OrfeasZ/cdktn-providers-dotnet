using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.NotificationPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.notificationPolicy.NotificationPolicyConfig")]
    public class NotificationPolicyConfig : cloudflare.NotificationPolicy.INotificationPolicyConfig
    {
        /// <summary>The account id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#account_id NotificationPolicy#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public string AccountId
        {
            get;
            set;
        }

        /// <summary>Refers to which event will trigger a Notification dispatch.</summary>
        /// <remarks>
        /// You can use the endpoint to get available alert types which then will give you a list of possible values.
        /// Available values: "abuse_report_alert", "access_custom_certificate_expiration_type", "advanced_ddos_attack_l4_alert", "advanced_ddos_attack_l7_alert", "advanced_http_alert_error", "bgp_hijack_notification", "billing_usage_alert", "block_notification_block_removed", "block_notification_new_block", "block_notification_review_rejected", "bot_traffic_basic_alert", "brand_protection_alert", "brand_protection_digest", "clickhouse_alert_fw_anomaly", "clickhouse_alert_fw_ent_anomaly", "cloudforce_one_request_notification", "custom_analytics", "custom_bot_detection_alert", "custom_ssl_certificate_event_type", "dedicated_ssl_certificate_event_type", "device_connectivity_anomaly_alert", "dos_attack_l4", "dos_attack_l7", "expiring_service_token_alert", "failing_logpush_job_disabled_alert", "fbm_auto_advertisement", "fbm_dosd_attack", "fbm_volumetric_attack", "health_check_status_notification", "hostname_aop_custom_certificate_expiration_type", "http_alert_edge_error", "http_alert_origin_error", "image_notification", "image_resizing_notification", "incident_alert", "load_balancing_health_alert", "load_balancing_pool_enablement_alert", "logo_match_alert", "magic_tunnel_health_check_event", "magic_wan_tunnel_health", "maintenance_event_notification", "mtls_certificate_store_certificate_expiration_type", "pages_event_alert", "radar_notification", "real_origin_monitoring", "scriptmonitor_alert_new_code_change_detections", "scriptmonitor_alert_new_hosts", "scriptmonitor_alert_new_malicious_hosts", "scriptmonitor_alert_new_malicious_scripts", "scriptmonitor_alert_new_malicious_url", "scriptmonitor_alert_new_max_length_resource_url", "scriptmonitor_alert_new_resources", "secondary_dns_all_primaries_failing", "secondary_dns_primaries_failing", "secondary_dns_warning", "secondary_dns_zone_successfully_updated", "secondary_dns_zone_validation_warning", "security_insights_alert", "sentinel_alert", "stream_live_notifications", "synthetic_test_latency_alert", "synthetic_test_low_availability_alert", "traffic_anomalies_alert", "tunnel_health_event", "tunnel_update_event", "universal_ssl_event_type", "web_analytics_metrics_update", "zone_aop_custom_certificate_expiration_type".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#alert_type NotificationPolicy#alert_type}
        /// </remarks>
        [JsiiProperty(name: "alertType", typeJson: "{\"primitive\":\"string\"}")]
        public string AlertType
        {
            get;
            set;
        }

        /// <summary>List of IDs that will be used when dispatching a notification.</summary>
        /// <remarks>
        /// IDs for email type will be the email address.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#mechanisms NotificationPolicy#mechanisms}
        /// </remarks>
        [JsiiProperty(name: "mechanisms", typeJson: "{\"fqn\":\"cloudflare.notificationPolicy.NotificationPolicyMechanisms\"}")]
        public cloudflare.NotificationPolicy.INotificationPolicyMechanisms Mechanisms
        {
            get;
            set;
        }

        /// <summary>Name of the policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#name NotificationPolicy#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Optional specification of how often to re-alert from the same incident, not support on all alert types.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#alert_interval NotificationPolicy#alert_interval}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alertInterval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AlertInterval
        {
            get;
            set;
        }

        /// <summary>Optional description for the Notification policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#description NotificationPolicy#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        private object? _enabled;

        /// <summary>Whether or not the Notification policy is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#enabled NotificationPolicy#enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>Optional filters that allow you to be alerted only on a subset of events for that alert type based on some criteria.</summary>
        /// <remarks>
        /// This is only available for select alert types. See alert type documentation for more details.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#filters NotificationPolicy#filters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filters", typeJson: "{\"fqn\":\"cloudflare.notificationPolicy.NotificationPolicyFilters\"}", isOptional: true)]
        public cloudflare.NotificationPolicy.INotificationPolicyFilters? Filters
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
