using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LogpushJob
{
    [JsiiInterface(nativeType: typeof(ILogpushJobConfig), fullyQualifiedName: "cloudflare.logpushJob.LogpushJobConfig")]
    public interface ILogpushJobConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Uniquely identifies a resource (such as an s3 bucket) where data.</summary>
        /// <remarks>
        /// will be pushed. Additional configuration parameters supported by the destination may be included.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#destination_conf LogpushJob#destination_conf}
        /// </remarks>
        [JsiiProperty(name: "destinationConf", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationConf
        {
            get;
        }

        /// <summary>The Account ID to use for this endpoint. Mutually exclusive with the Zone ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#account_id LogpushJob#account_id}
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
        /// Available values: "access_requests", "audit_logs", "audit_logs_v2", "biso_user_actions", "casb_findings", "device_posture_results", "dex_application_tests", "dex_device_state_events", "dlp_forensic_copies", "dns_firewall_logs", "dns_logs", "email_security_alerts", "firewall_events", "gateway_dns", "gateway_http", "gateway_network", "http_requests", "ipsec_logs", "magic_ids_detections", "nel_reports", "network_analytics_logs", "page_shield_events", "sinkhole_http_logs", "spectrum_events", "ssh_logs", "warp_config_changes", "warp_toggle_changes", "workers_trace_events", "zaraz_events", "zero_trust_network_sessions".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#dataset LogpushJob#dataset}
        /// </remarks>
        [JsiiProperty(name: "dataset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Dataset
        {
            get
            {
                return null;
            }
        }

        /// <summary>Flag that indicates if the job is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#enabled LogpushJob#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>The filters to select the events to include and/or remove from your logs. For more information, refer to [Filters](https://developers.cloudflare.com/logs/reference/filters/).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#filter LogpushJob#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>This field is deprecated.</summary>
        /// <remarks>
        /// Please use <c>max_upload_*</c> parameters instead. . The frequency at which Cloudflare sends batches of logs to your destination. Setting frequency to high sends your logs in larger quantities of smaller files. Setting frequency to low sends logs in smaller quantities of larger files.
        /// Available values: "high", "low".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#frequency LogpushJob#frequency}
        /// </remarks>
        [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Frequency
        {
            get
            {
                return null;
            }
        }

        /// <summary>The kind parameter (optional) is used to differentiate between Logpush and Edge Log Delivery jobs (when supported by the dataset).</summary>
        /// <remarks>
        /// Available values: "", "edge".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#kind LogpushJob#kind}
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Kind
        {
            get
            {
                return null;
            }
        }

        /// <summary>This field is deprecated.</summary>
        /// <remarks>
        /// Use <c>output_options</c> instead. Configuration string. It specifies things like requested fields and timestamp formats. If migrating from the logpull api, copy the url (full url or just the query string) of your call here, and logpush will keep on making this call for you, setting start and end times appropriately.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#logpull_options LogpushJob#logpull_options}
        /// </remarks>
        [JsiiProperty(name: "logpullOptions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogpullOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>The maximum uncompressed file size of a batch of logs.</summary>
        /// <remarks>
        /// This setting value must be between <c>5 MB</c> and <c>1 GB</c>, or <c>0</c> to disable it. Note that you cannot set a minimum file size; this means that log files may be much smaller than this batch size.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#max_upload_bytes LogpushJob#max_upload_bytes}
        /// </remarks>
        [JsiiProperty(name: "maxUploadBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxUploadBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>The maximum interval in seconds for log batches.</summary>
        /// <remarks>
        /// This setting must be between 30 and 300 seconds (5 minutes), or <c>0</c> to disable it. Note that you cannot specify a minimum interval for log batches; this means that log files may be sent in shorter intervals than this.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#max_upload_interval_seconds LogpushJob#max_upload_interval_seconds}
        /// </remarks>
        [JsiiProperty(name: "maxUploadIntervalSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxUploadIntervalSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>The maximum number of log lines per batch.</summary>
        /// <remarks>
        /// This setting must be between 1000 and 1,000,000 lines, or <c>0</c> to disable it. Note that you cannot specify a minimum number of log lines per batch; this means that log files may contain many fewer lines than this.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#max_upload_records LogpushJob#max_upload_records}
        /// </remarks>
        [JsiiProperty(name: "maxUploadRecords", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxUploadRecords
        {
            get
            {
                return null;
            }
        }

        /// <summary>Optional human readable job name.</summary>
        /// <remarks>
        /// Not unique. Cloudflare suggests. that you set this to a meaningful string, like the domain name, to make it easier to identify your job.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#name LogpushJob#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>The structured replacement for `logpull_options`. When including this field, the `logpull_option` field will be ignored.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#output_options LogpushJob#output_options}
        /// </remarks>
        [JsiiProperty(name: "outputOptions", typeJson: "{\"fqn\":\"cloudflare.logpushJob.LogpushJobOutputOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.LogpushJob.ILogpushJobOutputOptions? OutputOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Ownership challenge token to prove destination ownership.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#ownership_challenge LogpushJob#ownership_challenge}
        /// </remarks>
        [JsiiProperty(name: "ownershipChallenge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OwnershipChallenge
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Zone ID to use for this endpoint. Mutually exclusive with the Account ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#zone_id LogpushJob#zone_id}
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

        [JsiiTypeProxy(nativeType: typeof(ILogpushJobConfig), fullyQualifiedName: "cloudflare.logpushJob.LogpushJobConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.LogpushJob.ILogpushJobConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Uniquely identifies a resource (such as an s3 bucket) where data.</summary>
            /// <remarks>
            /// will be pushed. Additional configuration parameters supported by the destination may be included.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#destination_conf LogpushJob#destination_conf}
            /// </remarks>
            [JsiiProperty(name: "destinationConf", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationConf
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The Account ID to use for this endpoint. Mutually exclusive with the Zone ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#account_id LogpushJob#account_id}
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
            /// Available values: "access_requests", "audit_logs", "audit_logs_v2", "biso_user_actions", "casb_findings", "device_posture_results", "dex_application_tests", "dex_device_state_events", "dlp_forensic_copies", "dns_firewall_logs", "dns_logs", "email_security_alerts", "firewall_events", "gateway_dns", "gateway_http", "gateway_network", "http_requests", "ipsec_logs", "magic_ids_detections", "nel_reports", "network_analytics_logs", "page_shield_events", "sinkhole_http_logs", "spectrum_events", "ssh_logs", "warp_config_changes", "warp_toggle_changes", "workers_trace_events", "zaraz_events", "zero_trust_network_sessions".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#dataset LogpushJob#dataset}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Dataset
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Flag that indicates if the job is enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#enabled LogpushJob#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The filters to select the events to include and/or remove from your logs. For more information, refer to [Filters](https://developers.cloudflare.com/logs/reference/filters/).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#filter LogpushJob#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Filter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>This field is deprecated.</summary>
            /// <remarks>
            /// Please use <c>max_upload_*</c> parameters instead. . The frequency at which Cloudflare sends batches of logs to your destination. Setting frequency to high sends your logs in larger quantities of smaller files. Setting frequency to low sends logs in smaller quantities of larger files.
            /// Available values: "high", "low".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#frequency LogpushJob#frequency}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Frequency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The kind parameter (optional) is used to differentiate between Logpush and Edge Log Delivery jobs (when supported by the dataset).</summary>
            /// <remarks>
            /// Available values: "", "edge".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#kind LogpushJob#kind}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Kind
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>This field is deprecated.</summary>
            /// <remarks>
            /// Use <c>output_options</c> instead. Configuration string. It specifies things like requested fields and timestamp formats. If migrating from the logpull api, copy the url (full url or just the query string) of your call here, and logpush will keep on making this call for you, setting start and end times appropriately.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#logpull_options LogpushJob#logpull_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logpullOptions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogpullOptions
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The maximum uncompressed file size of a batch of logs.</summary>
            /// <remarks>
            /// This setting value must be between <c>5 MB</c> and <c>1 GB</c>, or <c>0</c> to disable it. Note that you cannot set a minimum file size; this means that log files may be much smaller than this batch size.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#max_upload_bytes LogpushJob#max_upload_bytes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxUploadBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxUploadBytes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The maximum interval in seconds for log batches.</summary>
            /// <remarks>
            /// This setting must be between 30 and 300 seconds (5 minutes), or <c>0</c> to disable it. Note that you cannot specify a minimum interval for log batches; this means that log files may be sent in shorter intervals than this.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#max_upload_interval_seconds LogpushJob#max_upload_interval_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxUploadIntervalSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxUploadIntervalSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The maximum number of log lines per batch.</summary>
            /// <remarks>
            /// This setting must be between 1000 and 1,000,000 lines, or <c>0</c> to disable it. Note that you cannot specify a minimum number of log lines per batch; this means that log files may contain many fewer lines than this.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#max_upload_records LogpushJob#max_upload_records}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxUploadRecords", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxUploadRecords
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Optional human readable job name.</summary>
            /// <remarks>
            /// Not unique. Cloudflare suggests. that you set this to a meaningful string, like the domain name, to make it easier to identify your job.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#name LogpushJob#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The structured replacement for `logpull_options`. When including this field, the `logpull_option` field will be ignored.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#output_options LogpushJob#output_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "outputOptions", typeJson: "{\"fqn\":\"cloudflare.logpushJob.LogpushJobOutputOptions\"}", isOptional: true)]
            public cloudflare.LogpushJob.ILogpushJobOutputOptions? OutputOptions
            {
                get => GetInstanceProperty<cloudflare.LogpushJob.ILogpushJobOutputOptions?>();
            }

            /// <summary>Ownership challenge token to prove destination ownership.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#ownership_challenge LogpushJob#ownership_challenge}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ownershipChallenge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OwnershipChallenge
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Zone ID to use for this endpoint. Mutually exclusive with the Account ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/logpush_job#zone_id LogpushJob#zone_id}
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
