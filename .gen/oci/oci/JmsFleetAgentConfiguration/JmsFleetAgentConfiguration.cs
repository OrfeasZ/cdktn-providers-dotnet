using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsFleetAgentConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration oci_jms_fleet_agent_configuration}.</summary>
    [JsiiClass(nativeType: typeof(oci.JmsFleetAgentConfiguration.JmsFleetAgentConfiguration), fullyQualifiedName: "oci.jmsFleetAgentConfiguration.JmsFleetAgentConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationConfig\"}}]")]
    public class JmsFleetAgentConfiguration : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration oci_jms_fleet_agent_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public JmsFleetAgentConfiguration(Constructs.Construct scope, string id, oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected JmsFleetAgentConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected JmsFleetAgentConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a JmsFleetAgentConfiguration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the JmsFleetAgentConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing JmsFleetAgentConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the JmsFleetAgentConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the JmsFleetAgentConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing JmsFleetAgentConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the JmsFleetAgentConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.JmsFleetAgentConfiguration.JmsFleetAgentConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putLinuxConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationLinuxConfiguration\"}}]")]
        public virtual void PutLinuxConfiguration(oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationLinuxConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationLinuxConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMacOsConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationMacOsConfiguration\"}}]")]
        public virtual void PutMacOsConfiguration(oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationMacOsConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationMacOsConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWindowsConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationWindowsConfiguration\"}}]")]
        public virtual void PutWindowsConfiguration(oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationWindowsConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationWindowsConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAgentPollingIntervalInMinutes")]
        public virtual void ResetAgentPollingIntervalInMinutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsCapturingIpAddressAndFqdnEnabled")]
        public virtual void ResetIsCapturingIpAddressAndFqdnEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsCollectingManagedInstanceMetricsEnabled")]
        public virtual void ResetIsCollectingManagedInstanceMetricsEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsCollectingUsernamesEnabled")]
        public virtual void ResetIsCollectingUsernamesEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsLibrariesScanEnabled")]
        public virtual void ResetIsLibrariesScanEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJavaUsageTrackerProcessingFrequencyInMinutes")]
        public virtual void ResetJavaUsageTrackerProcessingFrequencyInMinutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJreScanFrequencyInMinutes")]
        public virtual void ResetJreScanFrequencyInMinutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLinuxConfiguration")]
        public virtual void ResetLinuxConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMacOsConfiguration")]
        public virtual void ResetMacOsConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWindowsConfiguration")]
        public virtual void ResetWindowsConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkRequestValidityPeriodInDays")]
        public virtual void ResetWorkRequestValidityPeriodInDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(oci.JmsFleetAgentConfiguration.JmsFleetAgentConfiguration))!;

        [JsiiProperty(name: "linuxConfiguration", typeJson: "{\"fqn\":\"oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationLinuxConfigurationOutputReference\"}")]
        public virtual oci.JmsFleetAgentConfiguration.JmsFleetAgentConfigurationLinuxConfigurationOutputReference LinuxConfiguration
        {
            get => GetInstanceProperty<oci.JmsFleetAgentConfiguration.JmsFleetAgentConfigurationLinuxConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "macOsConfiguration", typeJson: "{\"fqn\":\"oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationMacOsConfigurationOutputReference\"}")]
        public virtual oci.JmsFleetAgentConfiguration.JmsFleetAgentConfigurationMacOsConfigurationOutputReference MacOsConfiguration
        {
            get => GetInstanceProperty<oci.JmsFleetAgentConfiguration.JmsFleetAgentConfigurationMacOsConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "timeLastModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastModified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationTimeoutsOutputReference\"}")]
        public virtual oci.JmsFleetAgentConfiguration.JmsFleetAgentConfigurationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.JmsFleetAgentConfiguration.JmsFleetAgentConfigurationTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "windowsConfiguration", typeJson: "{\"fqn\":\"oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationWindowsConfigurationOutputReference\"}")]
        public virtual oci.JmsFleetAgentConfiguration.JmsFleetAgentConfigurationWindowsConfigurationOutputReference WindowsConfiguration
        {
            get => GetInstanceProperty<oci.JmsFleetAgentConfiguration.JmsFleetAgentConfigurationWindowsConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "agentPollingIntervalInMinutesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AgentPollingIntervalInMinutesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fleetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FleetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isCapturingIpAddressAndFqdnEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsCapturingIpAddressAndFqdnEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isCollectingManagedInstanceMetricsEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsCollectingManagedInstanceMetricsEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isCollectingUsernamesEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsCollectingUsernamesEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isLibrariesScanEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsLibrariesScanEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "javaUsageTrackerProcessingFrequencyInMinutesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? JavaUsageTrackerProcessingFrequencyInMinutesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jreScanFrequencyInMinutesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? JreScanFrequencyInMinutesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "linuxConfigurationInput", typeJson: "{\"fqn\":\"oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationLinuxConfiguration\"}", isOptional: true)]
        public virtual oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationLinuxConfiguration? LinuxConfigurationInput
        {
            get => GetInstanceProperty<oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationLinuxConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "macOsConfigurationInput", typeJson: "{\"fqn\":\"oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationMacOsConfiguration\"}", isOptional: true)]
        public virtual oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationMacOsConfiguration? MacOsConfigurationInput
        {
            get => GetInstanceProperty<oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationMacOsConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "windowsConfigurationInput", typeJson: "{\"fqn\":\"oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationWindowsConfiguration\"}", isOptional: true)]
        public virtual oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationWindowsConfiguration? WindowsConfigurationInput
        {
            get => GetInstanceProperty<oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationWindowsConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workRequestValidityPeriodInDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WorkRequestValidityPeriodInDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "agentPollingIntervalInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AgentPollingIntervalInMinutes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fleetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FleetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isCapturingIpAddressAndFqdnEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsCapturingIpAddressAndFqdnEnabled
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "isCollectingManagedInstanceMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsCollectingManagedInstanceMetricsEnabled
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "isCollectingUsernamesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsCollectingUsernamesEnabled
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "isLibrariesScanEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsLibrariesScanEnabled
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "javaUsageTrackerProcessingFrequencyInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double JavaUsageTrackerProcessingFrequencyInMinutes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jreScanFrequencyInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double JreScanFrequencyInMinutes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workRequestValidityPeriodInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WorkRequestValidityPeriodInDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
