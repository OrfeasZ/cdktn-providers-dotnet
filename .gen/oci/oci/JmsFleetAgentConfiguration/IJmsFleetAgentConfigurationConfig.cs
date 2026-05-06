using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsFleetAgentConfiguration
{
    [JsiiInterface(nativeType: typeof(IJmsFleetAgentConfigurationConfig), fullyQualifiedName: "oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationConfig")]
    public interface IJmsFleetAgentConfigurationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#fleet_id JmsFleetAgentConfiguration#fleet_id}.</summary>
        [JsiiProperty(name: "fleetId", typeJson: "{\"primitive\":\"string\"}")]
        string FleetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#agent_polling_interval_in_minutes JmsFleetAgentConfiguration#agent_polling_interval_in_minutes}.</summary>
        [JsiiProperty(name: "agentPollingIntervalInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AgentPollingIntervalInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#id JmsFleetAgentConfiguration#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#is_capturing_ip_address_and_fqdn_enabled JmsFleetAgentConfiguration#is_capturing_ip_address_and_fqdn_enabled}.</summary>
        [JsiiProperty(name: "isCapturingIpAddressAndFqdnEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsCapturingIpAddressAndFqdnEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#is_collecting_managed_instance_metrics_enabled JmsFleetAgentConfiguration#is_collecting_managed_instance_metrics_enabled}.</summary>
        [JsiiProperty(name: "isCollectingManagedInstanceMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsCollectingManagedInstanceMetricsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#is_collecting_usernames_enabled JmsFleetAgentConfiguration#is_collecting_usernames_enabled}.</summary>
        [JsiiProperty(name: "isCollectingUsernamesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsCollectingUsernamesEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#is_libraries_scan_enabled JmsFleetAgentConfiguration#is_libraries_scan_enabled}.</summary>
        [JsiiProperty(name: "isLibrariesScanEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsLibrariesScanEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#java_usage_tracker_processing_frequency_in_minutes JmsFleetAgentConfiguration#java_usage_tracker_processing_frequency_in_minutes}.</summary>
        [JsiiProperty(name: "javaUsageTrackerProcessingFrequencyInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? JavaUsageTrackerProcessingFrequencyInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#jre_scan_frequency_in_minutes JmsFleetAgentConfiguration#jre_scan_frequency_in_minutes}.</summary>
        [JsiiProperty(name: "jreScanFrequencyInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? JreScanFrequencyInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>linux_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#linux_configuration JmsFleetAgentConfiguration#linux_configuration}
        /// </remarks>
        [JsiiProperty(name: "linuxConfiguration", typeJson: "{\"fqn\":\"oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationLinuxConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationLinuxConfiguration? LinuxConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>mac_os_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#mac_os_configuration JmsFleetAgentConfiguration#mac_os_configuration}
        /// </remarks>
        [JsiiProperty(name: "macOsConfiguration", typeJson: "{\"fqn\":\"oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationMacOsConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationMacOsConfiguration? MacOsConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#timeouts JmsFleetAgentConfiguration#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>windows_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#windows_configuration JmsFleetAgentConfiguration#windows_configuration}
        /// </remarks>
        [JsiiProperty(name: "windowsConfiguration", typeJson: "{\"fqn\":\"oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationWindowsConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationWindowsConfiguration? WindowsConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#work_request_validity_period_in_days JmsFleetAgentConfiguration#work_request_validity_period_in_days}.</summary>
        [JsiiProperty(name: "workRequestValidityPeriodInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WorkRequestValidityPeriodInDays
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IJmsFleetAgentConfigurationConfig), fullyQualifiedName: "oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationConfig")]
        internal sealed class _Proxy : DeputyBase, oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#fleet_id JmsFleetAgentConfiguration#fleet_id}.</summary>
            [JsiiProperty(name: "fleetId", typeJson: "{\"primitive\":\"string\"}")]
            public string FleetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#agent_polling_interval_in_minutes JmsFleetAgentConfiguration#agent_polling_interval_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "agentPollingIntervalInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AgentPollingIntervalInMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#id JmsFleetAgentConfiguration#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#is_capturing_ip_address_and_fqdn_enabled JmsFleetAgentConfiguration#is_capturing_ip_address_and_fqdn_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isCapturingIpAddressAndFqdnEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsCapturingIpAddressAndFqdnEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#is_collecting_managed_instance_metrics_enabled JmsFleetAgentConfiguration#is_collecting_managed_instance_metrics_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isCollectingManagedInstanceMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsCollectingManagedInstanceMetricsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#is_collecting_usernames_enabled JmsFleetAgentConfiguration#is_collecting_usernames_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isCollectingUsernamesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsCollectingUsernamesEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#is_libraries_scan_enabled JmsFleetAgentConfiguration#is_libraries_scan_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isLibrariesScanEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsLibrariesScanEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#java_usage_tracker_processing_frequency_in_minutes JmsFleetAgentConfiguration#java_usage_tracker_processing_frequency_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "javaUsageTrackerProcessingFrequencyInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? JavaUsageTrackerProcessingFrequencyInMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#jre_scan_frequency_in_minutes JmsFleetAgentConfiguration#jre_scan_frequency_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jreScanFrequencyInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? JreScanFrequencyInMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>linux_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#linux_configuration JmsFleetAgentConfiguration#linux_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "linuxConfiguration", typeJson: "{\"fqn\":\"oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationLinuxConfiguration\"}", isOptional: true)]
            public oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationLinuxConfiguration? LinuxConfiguration
            {
                get => GetInstanceProperty<oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationLinuxConfiguration?>();
            }

            /// <summary>mac_os_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#mac_os_configuration JmsFleetAgentConfiguration#mac_os_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "macOsConfiguration", typeJson: "{\"fqn\":\"oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationMacOsConfiguration\"}", isOptional: true)]
            public oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationMacOsConfiguration? MacOsConfiguration
            {
                get => GetInstanceProperty<oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationMacOsConfiguration?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#timeouts JmsFleetAgentConfiguration#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationTimeouts\"}", isOptional: true)]
            public oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationTimeouts?>();
            }

            /// <summary>windows_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#windows_configuration JmsFleetAgentConfiguration#windows_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "windowsConfiguration", typeJson: "{\"fqn\":\"oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationWindowsConfiguration\"}", isOptional: true)]
            public oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationWindowsConfiguration? WindowsConfiguration
            {
                get => GetInstanceProperty<oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationWindowsConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#work_request_validity_period_in_days JmsFleetAgentConfiguration#work_request_validity_period_in_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "workRequestValidityPeriodInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WorkRequestValidityPeriodInDays
            {
                get => GetInstanceProperty<double?>();
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
