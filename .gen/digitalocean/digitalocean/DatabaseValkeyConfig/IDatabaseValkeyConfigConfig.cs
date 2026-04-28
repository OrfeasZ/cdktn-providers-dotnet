using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabaseValkeyConfig
{
    [JsiiInterface(nativeType: typeof(IDatabaseValkeyConfigConfig), fullyQualifiedName: "digitalocean.databaseValkeyConfig.DatabaseValkeyConfigConfig")]
    public interface IDatabaseValkeyConfigConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>A unique identifier for the database cluster.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#cluster_id DatabaseValkeyConfig#cluster_id}
        /// </remarks>
        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterId
        {
            get;
        }

        /// <summary>Determines default pub/sub channels' ACL for new users if ACL is not supplied.</summary>
        /// <remarks>
        /// When this option is not defined, all_channels is assumed to keep backward compatibility. This option doesn't affect Valkey configuration acl-pubsub-default.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#acl_channels_default DatabaseValkeyConfig#acl_channels_default}
        /// </remarks>
        [JsiiProperty(name: "aclChannelsDefault", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AclChannelsDefault
        {
            get
            {
                return null;
            }
        }

        /// <summary>Frequent RDB snapshots.</summary>
        /// <remarks>
        /// When enabled, Valkey will create frequent local RDB snapshots. When disabled, Valkey will only take RDB snapshots when a backup is created, based on the backup schedule. This setting is ignored when valkey_persistence is set to off.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#frequent_snapshots DatabaseValkeyConfig#frequent_snapshots}
        /// </remarks>
        [JsiiProperty(name: "frequentSnapshots", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FrequentSnapshots
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#id DatabaseValkeyConfig#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of IO threads used by Valkey. Must be between 1 and 32.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#io_threads DatabaseValkeyConfig#io_threads}
        /// </remarks>
        [JsiiProperty(name: "ioThreads", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IoThreads
        {
            get
            {
                return null;
            }
        }

        /// <summary>The decay time for Valkey's LFU cache eviction. Must be between 1 and 120.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#lfu_decay_time DatabaseValkeyConfig#lfu_decay_time}
        /// </remarks>
        [JsiiProperty(name: "lfuDecayTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LfuDecayTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>The log factor for Valkey's LFU (Least Frequently Used) cache eviction. Must be between 1 and 100.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#lfu_log_factor DatabaseValkeyConfig#lfu_log_factor}
        /// </remarks>
        [JsiiProperty(name: "lfuLogFactor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LfuLogFactor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set notify-keyspace-events option.</summary>
        /// <remarks>
        /// Requires at least K or E and accepts any combination of the following options. Setting the parameter to "" disables notifications.
        ///
        /// K — Keyspace events
        /// E — Keyevent events
        /// g — Generic commands (e.g. DEL, EXPIRE, RENAME, ...)
        /// $ — String commands
        /// l — List commands
        /// s — Set commands
        /// h — Hash commands
        /// z — Sorted set commands
        /// t — Stream commands
        /// d — Module key type events
        /// x — Expired events
        /// e — Evicted events
        /// m — Key miss events
        /// n — New key events
        /// A — Alias for "g$lshztxed"
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#notify_keyspace_events DatabaseValkeyConfig#notify_keyspace_events}
        /// </remarks>
        [JsiiProperty(name: "notifyKeyspaceEvents", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NotifyKeyspaceEvents
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of logical databases in the Valkey cluster. Must be between 1 and 128.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#number_of_databases DatabaseValkeyConfig#number_of_databases}
        /// </remarks>
        [JsiiProperty(name: "numberOfDatabases", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NumberOfDatabases
        {
            get
            {
                return null;
            }
        }

        /// <summary>When persistence is 'rdb', Valkey does RDB dumps each 10 minutes if any key is changed.</summary>
        /// <remarks>
        /// Also RDB dumps are done according to backup schedule for backup purposes. When persistence is 'off', no RDB dumps and backups are done, so data can be lost at any moment if service is restarted for any reason, or if service is powered off. Also service can't be forked.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#persistence DatabaseValkeyConfig#persistence}
        /// </remarks>
        [JsiiProperty(name: "persistence", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Persistence
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set output buffer limit for pub / sub clients in MB.</summary>
        /// <remarks>
        /// The value is the hard limit, the soft limit is 1/4 of the hard limit. When setting the limit, be mindful of the available memory in the selected service plan.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#pubsub_client_output_buffer_limit DatabaseValkeyConfig#pubsub_client_output_buffer_limit}
        /// </remarks>
        [JsiiProperty(name: "pubsubClientOutputBufferLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PubsubClientOutputBufferLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to enable SSL/TLS for connections to the Valkey cluster.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#ssl DatabaseValkeyConfig#ssl}
        /// </remarks>
        [JsiiProperty(name: "ssl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ssl
        {
            get
            {
                return null;
            }
        }

        /// <summary>The timeout (in seconds) for Valkey client connections.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#timeout DatabaseValkeyConfig#timeout}
        /// </remarks>
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Timeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Active expire effort.</summary>
        /// <remarks>
        /// Valkey reclaims expired keys both when accessed and in the background. The background process scans for expired keys to free memory. Increasing the active-expire-effort setting (default 1, max 10) uses more CPU to reclaim expired keys faster, reducing memory usage but potentially increasing latency.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#valkey_active_expire_effort DatabaseValkeyConfig#valkey_active_expire_effort}
        /// </remarks>
        [JsiiProperty(name: "valkeyActiveExpireEffort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ValkeyActiveExpireEffort
        {
            get
            {
                return null;
            }
        }

        /// <summary>A string specifying the desired eviction policy for a Caching or Valkey cluster.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#valkey_maxmemory_policy DatabaseValkeyConfig#valkey_maxmemory_policy}
        /// </remarks>
        [JsiiProperty(name: "valkeyMaxmemoryPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ValkeyMaxmemoryPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseValkeyConfigConfig), fullyQualifiedName: "digitalocean.databaseValkeyConfig.DatabaseValkeyConfigConfig")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DatabaseValkeyConfig.IDatabaseValkeyConfigConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A unique identifier for the database cluster.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#cluster_id DatabaseValkeyConfig#cluster_id}
            /// </remarks>
            [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Determines default pub/sub channels' ACL for new users if ACL is not supplied.</summary>
            /// <remarks>
            /// When this option is not defined, all_channels is assumed to keep backward compatibility. This option doesn't affect Valkey configuration acl-pubsub-default.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#acl_channels_default DatabaseValkeyConfig#acl_channels_default}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "aclChannelsDefault", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AclChannelsDefault
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Frequent RDB snapshots.</summary>
            /// <remarks>
            /// When enabled, Valkey will create frequent local RDB snapshots. When disabled, Valkey will only take RDB snapshots when a backup is created, based on the backup schedule. This setting is ignored when valkey_persistence is set to off.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#frequent_snapshots DatabaseValkeyConfig#frequent_snapshots}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "frequentSnapshots", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? FrequentSnapshots
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#id DatabaseValkeyConfig#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The number of IO threads used by Valkey. Must be between 1 and 32.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#io_threads DatabaseValkeyConfig#io_threads}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ioThreads", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IoThreads
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The decay time for Valkey's LFU cache eviction. Must be between 1 and 120.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#lfu_decay_time DatabaseValkeyConfig#lfu_decay_time}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lfuDecayTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LfuDecayTime
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The log factor for Valkey's LFU (Least Frequently Used) cache eviction. Must be between 1 and 100.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#lfu_log_factor DatabaseValkeyConfig#lfu_log_factor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lfuLogFactor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LfuLogFactor
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Set notify-keyspace-events option.</summary>
            /// <remarks>
            /// Requires at least K or E and accepts any combination of the following options. Setting the parameter to "" disables notifications.
            ///
            /// K — Keyspace events
            /// E — Keyevent events
            /// g — Generic commands (e.g. DEL, EXPIRE, RENAME, ...)
            /// $ — String commands
            /// l — List commands
            /// s — Set commands
            /// h — Hash commands
            /// z — Sorted set commands
            /// t — Stream commands
            /// d — Module key type events
            /// x — Expired events
            /// e — Evicted events
            /// m — Key miss events
            /// n — New key events
            /// A — Alias for "g$lshztxed"
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#notify_keyspace_events DatabaseValkeyConfig#notify_keyspace_events}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notifyKeyspaceEvents", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NotifyKeyspaceEvents
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The number of logical databases in the Valkey cluster. Must be between 1 and 128.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#number_of_databases DatabaseValkeyConfig#number_of_databases}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "numberOfDatabases", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NumberOfDatabases
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>When persistence is 'rdb', Valkey does RDB dumps each 10 minutes if any key is changed.</summary>
            /// <remarks>
            /// Also RDB dumps are done according to backup schedule for backup purposes. When persistence is 'off', no RDB dumps and backups are done, so data can be lost at any moment if service is restarted for any reason, or if service is powered off. Also service can't be forked.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#persistence DatabaseValkeyConfig#persistence}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "persistence", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Persistence
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Set output buffer limit for pub / sub clients in MB.</summary>
            /// <remarks>
            /// The value is the hard limit, the soft limit is 1/4 of the hard limit. When setting the limit, be mindful of the available memory in the selected service plan.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#pubsub_client_output_buffer_limit DatabaseValkeyConfig#pubsub_client_output_buffer_limit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pubsubClientOutputBufferLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PubsubClientOutputBufferLimit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Whether to enable SSL/TLS for connections to the Valkey cluster.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#ssl DatabaseValkeyConfig#ssl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ssl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Ssl
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The timeout (in seconds) for Valkey client connections.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#timeout DatabaseValkeyConfig#timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Timeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Active expire effort.</summary>
            /// <remarks>
            /// Valkey reclaims expired keys both when accessed and in the background. The background process scans for expired keys to free memory. Increasing the active-expire-effort setting (default 1, max 10) uses more CPU to reclaim expired keys faster, reducing memory usage but potentially increasing latency.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#valkey_active_expire_effort DatabaseValkeyConfig#valkey_active_expire_effort}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "valkeyActiveExpireEffort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ValkeyActiveExpireEffort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>A string specifying the desired eviction policy for a Caching or Valkey cluster.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_valkey_config#valkey_maxmemory_policy DatabaseValkeyConfig#valkey_maxmemory_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "valkeyMaxmemoryPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ValkeyMaxmemoryPolicy
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
