using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsFleetAgentConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_agent_configuration oci_jms_fleet_agent_configuration}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciJmsFleetAgentConfiguration.DataOciJmsFleetAgentConfiguration), fullyQualifiedName: "oci.dataOciJmsFleetAgentConfiguration.DataOciJmsFleetAgentConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciJmsFleetAgentConfiguration.DataOciJmsFleetAgentConfigurationConfig\"}}]")]
    public class DataOciJmsFleetAgentConfiguration : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_agent_configuration oci_jms_fleet_agent_configuration} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciJmsFleetAgentConfiguration(Constructs.Construct scope, string id, oci.DataOciJmsFleetAgentConfiguration.IDataOciJmsFleetAgentConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciJmsFleetAgentConfiguration.IDataOciJmsFleetAgentConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsFleetAgentConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsFleetAgentConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciJmsFleetAgentConfiguration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciJmsFleetAgentConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing DataOciJmsFleetAgentConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciJmsFleetAgentConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciJmsFleetAgentConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_agent_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciJmsFleetAgentConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciJmsFleetAgentConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciJmsFleetAgentConfiguration.DataOciJmsFleetAgentConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciJmsFleetAgentConfiguration.DataOciJmsFleetAgentConfiguration))!;

        [JsiiProperty(name: "agentPollingIntervalInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AgentPollingIntervalInMinutes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isCapturingIpAddressAndFqdnEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCapturingIpAddressAndFqdnEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isCollectingManagedInstanceMetricsEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCollectingManagedInstanceMetricsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isCollectingUsernamesEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCollectingUsernamesEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isLibrariesScanEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLibrariesScanEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "javaUsageTrackerProcessingFrequencyInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double JavaUsageTrackerProcessingFrequencyInMinutes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "jreScanFrequencyInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double JreScanFrequencyInMinutes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "linuxConfiguration", typeJson: "{\"fqn\":\"oci.dataOciJmsFleetAgentConfiguration.DataOciJmsFleetAgentConfigurationLinuxConfigurationList\"}")]
        public virtual oci.DataOciJmsFleetAgentConfiguration.DataOciJmsFleetAgentConfigurationLinuxConfigurationList LinuxConfiguration
        {
            get => GetInstanceProperty<oci.DataOciJmsFleetAgentConfiguration.DataOciJmsFleetAgentConfigurationLinuxConfigurationList>()!;
        }

        [JsiiProperty(name: "macOsConfiguration", typeJson: "{\"fqn\":\"oci.dataOciJmsFleetAgentConfiguration.DataOciJmsFleetAgentConfigurationMacOsConfigurationList\"}")]
        public virtual oci.DataOciJmsFleetAgentConfiguration.DataOciJmsFleetAgentConfigurationMacOsConfigurationList MacOsConfiguration
        {
            get => GetInstanceProperty<oci.DataOciJmsFleetAgentConfiguration.DataOciJmsFleetAgentConfigurationMacOsConfigurationList>()!;
        }

        [JsiiProperty(name: "timeLastModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastModified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "windowsConfiguration", typeJson: "{\"fqn\":\"oci.dataOciJmsFleetAgentConfiguration.DataOciJmsFleetAgentConfigurationWindowsConfigurationList\"}")]
        public virtual oci.DataOciJmsFleetAgentConfiguration.DataOciJmsFleetAgentConfigurationWindowsConfigurationList WindowsConfiguration
        {
            get => GetInstanceProperty<oci.DataOciJmsFleetAgentConfiguration.DataOciJmsFleetAgentConfigurationWindowsConfigurationList>()!;
        }

        [JsiiProperty(name: "workRequestValidityPeriodInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WorkRequestValidityPeriodInDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fleetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FleetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "fleetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FleetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
