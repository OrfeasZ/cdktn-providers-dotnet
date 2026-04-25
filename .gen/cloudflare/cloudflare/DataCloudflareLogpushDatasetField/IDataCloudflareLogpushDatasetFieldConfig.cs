using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareLogpushDatasetField
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareLogpushDatasetFieldConfig), fullyQualifiedName: "cloudflare.dataCloudflareLogpushDatasetField.DataCloudflareLogpushDatasetFieldConfig")]
    public interface IDataCloudflareLogpushDatasetFieldConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The Account ID to use for this endpoint. Mutually exclusive with the Zone ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/logpush_dataset_field#account_id DataCloudflareLogpushDatasetField#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the dataset.</summary>
        /// <remarks>
        /// A list of supported datasets can be found on the <a href="https://developers.cloudflare.com/logs/reference/log-fields/">Developer Docs</a>.
        /// Available values: "access_requests", "audit_logs", "audit_logs_v2", "biso_user_actions", "casb_findings", "device_posture_results", "dex_application_tests", "dex_device_state_events", "dlp_forensic_copies", "dns_firewall_logs", "dns_logs", "email_security_alerts", "email_security_post_delivery_events", "firewall_events", "gateway_dns", "gateway_http", "gateway_network", "http_requests", "ipsec_logs", "magic_ids_detections", "mcp_portal_logs", "nel_reports", "network_analytics_logs", "page_shield_events", "sinkhole_http_logs", "spectrum_events", "ssh_logs", "warp_config_changes", "warp_toggle_changes", "workers_trace_events", "zaraz_events", "zero_trust_network_sessions".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/logpush_dataset_field#dataset_id DataCloudflareLogpushDatasetField#dataset_id}
        /// </remarks>
        [JsiiProperty(name: "datasetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatasetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Zone ID to use for this endpoint. Mutually exclusive with the Account ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/logpush_dataset_field#zone_id DataCloudflareLogpushDatasetField#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ZoneId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareLogpushDatasetFieldConfig), fullyQualifiedName: "cloudflare.dataCloudflareLogpushDatasetField.DataCloudflareLogpushDatasetFieldConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareLogpushDatasetField.IDataCloudflareLogpushDatasetFieldConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Account ID to use for this endpoint. Mutually exclusive with the Zone ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/logpush_dataset_field#account_id DataCloudflareLogpushDatasetField#account_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of the dataset.</summary>
            /// <remarks>
            /// A list of supported datasets can be found on the <a href="https://developers.cloudflare.com/logs/reference/log-fields/">Developer Docs</a>.
            /// Available values: "access_requests", "audit_logs", "audit_logs_v2", "biso_user_actions", "casb_findings", "device_posture_results", "dex_application_tests", "dex_device_state_events", "dlp_forensic_copies", "dns_firewall_logs", "dns_logs", "email_security_alerts", "email_security_post_delivery_events", "firewall_events", "gateway_dns", "gateway_http", "gateway_network", "http_requests", "ipsec_logs", "magic_ids_detections", "mcp_portal_logs", "nel_reports", "network_analytics_logs", "page_shield_events", "sinkhole_http_logs", "spectrum_events", "ssh_logs", "warp_config_changes", "warp_toggle_changes", "workers_trace_events", "zaraz_events", "zero_trust_network_sessions".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/logpush_dataset_field#dataset_id DataCloudflareLogpushDatasetField#dataset_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "datasetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatasetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Zone ID to use for this endpoint. Mutually exclusive with the Account ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/logpush_dataset_field#zone_id DataCloudflareLogpushDatasetField#zone_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ZoneId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
