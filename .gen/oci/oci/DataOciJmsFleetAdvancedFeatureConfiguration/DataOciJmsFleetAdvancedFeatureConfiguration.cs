using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsFleetAdvancedFeatureConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_advanced_feature_configuration oci_jms_fleet_advanced_feature_configuration}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfiguration), fullyQualifiedName: "oci.dataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfigurationConfig\"}}]")]
    public class DataOciJmsFleetAdvancedFeatureConfiguration : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_advanced_feature_configuration oci_jms_fleet_advanced_feature_configuration} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciJmsFleetAdvancedFeatureConfiguration(Constructs.Construct scope, string id, oci.DataOciJmsFleetAdvancedFeatureConfiguration.IDataOciJmsFleetAdvancedFeatureConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciJmsFleetAdvancedFeatureConfiguration.IDataOciJmsFleetAdvancedFeatureConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsFleetAdvancedFeatureConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsFleetAdvancedFeatureConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciJmsFleetAdvancedFeatureConfiguration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciJmsFleetAdvancedFeatureConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing DataOciJmsFleetAdvancedFeatureConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciJmsFleetAdvancedFeatureConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciJmsFleetAdvancedFeatureConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/jms_fleet_advanced_feature_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciJmsFleetAdvancedFeatureConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciJmsFleetAdvancedFeatureConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfiguration))!;

        [JsiiProperty(name: "advancedUsageTracking", typeJson: "{\"fqn\":\"oci.dataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfigurationAdvancedUsageTrackingList\"}")]
        public virtual oci.DataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfigurationAdvancedUsageTrackingList AdvancedUsageTracking
        {
            get => GetInstanceProperty<oci.DataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfigurationAdvancedUsageTrackingList>()!;
        }

        [JsiiProperty(name: "analyticBucketName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AnalyticBucketName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "analyticNamespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AnalyticNamespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cryptoEventAnalysis", typeJson: "{\"fqn\":\"oci.dataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfigurationCryptoEventAnalysisList\"}")]
        public virtual oci.DataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfigurationCryptoEventAnalysisList CryptoEventAnalysis
        {
            get => GetInstanceProperty<oci.DataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfigurationCryptoEventAnalysisList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "javaMigrationAnalysis", typeJson: "{\"fqn\":\"oci.dataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfigurationJavaMigrationAnalysisList\"}")]
        public virtual oci.DataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfigurationJavaMigrationAnalysisList JavaMigrationAnalysis
        {
            get => GetInstanceProperty<oci.DataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfigurationJavaMigrationAnalysisList>()!;
        }

        [JsiiProperty(name: "jfrRecording", typeJson: "{\"fqn\":\"oci.dataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfigurationJfrRecordingList\"}")]
        public virtual oci.DataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfigurationJfrRecordingList JfrRecording
        {
            get => GetInstanceProperty<oci.DataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfigurationJfrRecordingList>()!;
        }

        [JsiiProperty(name: "lcm", typeJson: "{\"fqn\":\"oci.dataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfigurationLcmList\"}")]
        public virtual oci.DataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfigurationLcmList Lcm
        {
            get => GetInstanceProperty<oci.DataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfigurationLcmList>()!;
        }

        [JsiiProperty(name: "performanceTuningAnalysis", typeJson: "{\"fqn\":\"oci.dataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfigurationPerformanceTuningAnalysisList\"}")]
        public virtual oci.DataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfigurationPerformanceTuningAnalysisList PerformanceTuningAnalysis
        {
            get => GetInstanceProperty<oci.DataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfigurationPerformanceTuningAnalysisList>()!;
        }

        [JsiiProperty(name: "timeLastModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastModified
        {
            get => GetInstanceProperty<string>()!;
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
