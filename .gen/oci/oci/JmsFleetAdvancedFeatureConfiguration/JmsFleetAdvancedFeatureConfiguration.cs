using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsFleetAdvancedFeatureConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration oci_jms_fleet_advanced_feature_configuration}.</summary>
    [JsiiClass(nativeType: typeof(oci.JmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfiguration), fullyQualifiedName: "oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationConfig\"}}]")]
    public class JmsFleetAdvancedFeatureConfiguration : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration oci_jms_fleet_advanced_feature_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public JmsFleetAdvancedFeatureConfiguration(Constructs.Construct scope, string id, oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected JmsFleetAdvancedFeatureConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected JmsFleetAdvancedFeatureConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a JmsFleetAdvancedFeatureConfiguration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the JmsFleetAdvancedFeatureConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing JmsFleetAdvancedFeatureConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the JmsFleetAdvancedFeatureConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the JmsFleetAdvancedFeatureConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_advanced_feature_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing JmsFleetAdvancedFeatureConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the JmsFleetAdvancedFeatureConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.JmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAdvancedUsageTracking", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationAdvancedUsageTracking\"}}]")]
        public virtual void PutAdvancedUsageTracking(oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationAdvancedUsageTracking @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationAdvancedUsageTracking)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCryptoEventAnalysis", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationCryptoEventAnalysis\"}}]")]
        public virtual void PutCryptoEventAnalysis(oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationCryptoEventAnalysis @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationCryptoEventAnalysis)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJavaMigrationAnalysis", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationJavaMigrationAnalysis\"}}]")]
        public virtual void PutJavaMigrationAnalysis(oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationJavaMigrationAnalysis @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationJavaMigrationAnalysis)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJfrRecording", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationJfrRecording\"}}]")]
        public virtual void PutJfrRecording(oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationJfrRecording @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationJfrRecording)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLcm", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcm\"}}]")]
        public virtual void PutLcm(oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcm @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcm)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPerformanceTuningAnalysis", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationPerformanceTuningAnalysis\"}}]")]
        public virtual void PutPerformanceTuningAnalysis(oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationPerformanceTuningAnalysis @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationPerformanceTuningAnalysis)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdvancedUsageTracking")]
        public virtual void ResetAdvancedUsageTracking()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAnalyticBucketName")]
        public virtual void ResetAnalyticBucketName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAnalyticNamespace")]
        public virtual void ResetAnalyticNamespace()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCryptoEventAnalysis")]
        public virtual void ResetCryptoEventAnalysis()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJavaMigrationAnalysis")]
        public virtual void ResetJavaMigrationAnalysis()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJfrRecording")]
        public virtual void ResetJfrRecording()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLcm")]
        public virtual void ResetLcm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPerformanceTuningAnalysis")]
        public virtual void ResetPerformanceTuningAnalysis()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(oci.JmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfiguration))!;

        [JsiiProperty(name: "advancedUsageTracking", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationAdvancedUsageTrackingOutputReference\"}")]
        public virtual oci.JmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationAdvancedUsageTrackingOutputReference AdvancedUsageTracking
        {
            get => GetInstanceProperty<oci.JmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationAdvancedUsageTrackingOutputReference>()!;
        }

        [JsiiProperty(name: "cryptoEventAnalysis", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationCryptoEventAnalysisOutputReference\"}")]
        public virtual oci.JmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationCryptoEventAnalysisOutputReference CryptoEventAnalysis
        {
            get => GetInstanceProperty<oci.JmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationCryptoEventAnalysisOutputReference>()!;
        }

        [JsiiProperty(name: "javaMigrationAnalysis", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationJavaMigrationAnalysisOutputReference\"}")]
        public virtual oci.JmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationJavaMigrationAnalysisOutputReference JavaMigrationAnalysis
        {
            get => GetInstanceProperty<oci.JmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationJavaMigrationAnalysisOutputReference>()!;
        }

        [JsiiProperty(name: "jfrRecording", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationJfrRecordingOutputReference\"}")]
        public virtual oci.JmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationJfrRecordingOutputReference JfrRecording
        {
            get => GetInstanceProperty<oci.JmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationJfrRecordingOutputReference>()!;
        }

        [JsiiProperty(name: "lcm", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmOutputReference\"}")]
        public virtual oci.JmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmOutputReference Lcm
        {
            get => GetInstanceProperty<oci.JmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmOutputReference>()!;
        }

        [JsiiProperty(name: "performanceTuningAnalysis", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationPerformanceTuningAnalysisOutputReference\"}")]
        public virtual oci.JmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationPerformanceTuningAnalysisOutputReference PerformanceTuningAnalysis
        {
            get => GetInstanceProperty<oci.JmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationPerformanceTuningAnalysisOutputReference>()!;
        }

        [JsiiProperty(name: "timeLastModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastModified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationTimeoutsOutputReference\"}")]
        public virtual oci.JmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.JmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "advancedUsageTrackingInput", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationAdvancedUsageTracking\"}", isOptional: true)]
        public virtual oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationAdvancedUsageTracking? AdvancedUsageTrackingInput
        {
            get => GetInstanceProperty<oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationAdvancedUsageTracking?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "analyticBucketNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AnalyticBucketNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "analyticNamespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AnalyticNamespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cryptoEventAnalysisInput", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationCryptoEventAnalysis\"}", isOptional: true)]
        public virtual oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationCryptoEventAnalysis? CryptoEventAnalysisInput
        {
            get => GetInstanceProperty<oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationCryptoEventAnalysis?>();
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
        [JsiiProperty(name: "javaMigrationAnalysisInput", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationJavaMigrationAnalysis\"}", isOptional: true)]
        public virtual oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationJavaMigrationAnalysis? JavaMigrationAnalysisInput
        {
            get => GetInstanceProperty<oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationJavaMigrationAnalysis?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jfrRecordingInput", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationJfrRecording\"}", isOptional: true)]
        public virtual oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationJfrRecording? JfrRecordingInput
        {
            get => GetInstanceProperty<oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationJfrRecording?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lcmInput", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcm\"}", isOptional: true)]
        public virtual oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcm? LcmInput
        {
            get => GetInstanceProperty<oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcm?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "performanceTuningAnalysisInput", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationPerformanceTuningAnalysis\"}", isOptional: true)]
        public virtual oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationPerformanceTuningAnalysis? PerformanceTuningAnalysisInput
        {
            get => GetInstanceProperty<oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationPerformanceTuningAnalysis?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "analyticBucketName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AnalyticBucketName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "analyticNamespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AnalyticNamespace
        {
            get => GetInstanceProperty<string>()!;
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
    }
}
