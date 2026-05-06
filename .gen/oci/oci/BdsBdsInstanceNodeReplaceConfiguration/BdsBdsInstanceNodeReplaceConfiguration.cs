using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceNodeReplaceConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_replace_configuration oci_bds_bds_instance_node_replace_configuration}.</summary>
    [JsiiClass(nativeType: typeof(oci.BdsBdsInstanceNodeReplaceConfiguration.BdsBdsInstanceNodeReplaceConfiguration), fullyQualifiedName: "oci.bdsBdsInstanceNodeReplaceConfiguration.BdsBdsInstanceNodeReplaceConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.bdsBdsInstanceNodeReplaceConfiguration.BdsBdsInstanceNodeReplaceConfigurationConfig\"}}]")]
    public class BdsBdsInstanceNodeReplaceConfiguration : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_replace_configuration oci_bds_bds_instance_node_replace_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public BdsBdsInstanceNodeReplaceConfiguration(Constructs.Construct scope, string id, oci.BdsBdsInstanceNodeReplaceConfiguration.IBdsBdsInstanceNodeReplaceConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.BdsBdsInstanceNodeReplaceConfiguration.IBdsBdsInstanceNodeReplaceConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BdsBdsInstanceNodeReplaceConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BdsBdsInstanceNodeReplaceConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a BdsBdsInstanceNodeReplaceConfiguration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the BdsBdsInstanceNodeReplaceConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing BdsBdsInstanceNodeReplaceConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the BdsBdsInstanceNodeReplaceConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the BdsBdsInstanceNodeReplaceConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_replace_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing BdsBdsInstanceNodeReplaceConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the BdsBdsInstanceNodeReplaceConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.BdsBdsInstanceNodeReplaceConfiguration.BdsBdsInstanceNodeReplaceConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putLevelTypeDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsBdsInstanceNodeReplaceConfiguration.BdsBdsInstanceNodeReplaceConfigurationLevelTypeDetails\"}}]")]
        public virtual void PutLevelTypeDetails(oci.BdsBdsInstanceNodeReplaceConfiguration.IBdsBdsInstanceNodeReplaceConfigurationLevelTypeDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsBdsInstanceNodeReplaceConfiguration.IBdsBdsInstanceNodeReplaceConfigurationLevelTypeDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsBdsInstanceNodeReplaceConfiguration.BdsBdsInstanceNodeReplaceConfigurationTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.BdsBdsInstanceNodeReplaceConfiguration.IBdsBdsInstanceNodeReplaceConfigurationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsBdsInstanceNodeReplaceConfiguration.IBdsBdsInstanceNodeReplaceConfigurationTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(oci.BdsBdsInstanceNodeReplaceConfiguration.BdsBdsInstanceNodeReplaceConfiguration))!;

        [JsiiProperty(name: "levelTypeDetails", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceNodeReplaceConfiguration.BdsBdsInstanceNodeReplaceConfigurationLevelTypeDetailsOutputReference\"}")]
        public virtual oci.BdsBdsInstanceNodeReplaceConfiguration.BdsBdsInstanceNodeReplaceConfigurationLevelTypeDetailsOutputReference LevelTypeDetails
        {
            get => GetInstanceProperty<oci.BdsBdsInstanceNodeReplaceConfiguration.BdsBdsInstanceNodeReplaceConfigurationLevelTypeDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceNodeReplaceConfiguration.BdsBdsInstanceNodeReplaceConfigurationTimeoutsOutputReference\"}")]
        public virtual oci.BdsBdsInstanceNodeReplaceConfiguration.BdsBdsInstanceNodeReplaceConfigurationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.BdsBdsInstanceNodeReplaceConfiguration.BdsBdsInstanceNodeReplaceConfigurationTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bdsInstanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BdsInstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterAdminPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterAdminPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "durationInMinutesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DurationInMinutesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "levelTypeDetailsInput", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceNodeReplaceConfiguration.BdsBdsInstanceNodeReplaceConfigurationLevelTypeDetails\"}", isOptional: true)]
        public virtual oci.BdsBdsInstanceNodeReplaceConfiguration.IBdsBdsInstanceNodeReplaceConfigurationLevelTypeDetails? LevelTypeDetailsInput
        {
            get => GetInstanceProperty<oci.BdsBdsInstanceNodeReplaceConfiguration.IBdsBdsInstanceNodeReplaceConfigurationLevelTypeDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetricTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.bdsBdsInstanceNodeReplaceConfiguration.BdsBdsInstanceNodeReplaceConfigurationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "bdsInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BdsInstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterAdminPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "durationInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DurationInMinutes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
