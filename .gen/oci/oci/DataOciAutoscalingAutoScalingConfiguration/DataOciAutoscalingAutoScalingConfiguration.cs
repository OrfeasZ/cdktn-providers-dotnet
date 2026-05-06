using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciAutoscalingAutoScalingConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/autoscaling_auto_scaling_configuration oci_autoscaling_auto_scaling_configuration}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciAutoscalingAutoScalingConfiguration.DataOciAutoscalingAutoScalingConfiguration), fullyQualifiedName: "oci.dataOciAutoscalingAutoScalingConfiguration.DataOciAutoscalingAutoScalingConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciAutoscalingAutoScalingConfiguration.DataOciAutoscalingAutoScalingConfigurationConfig\"}}]")]
    public class DataOciAutoscalingAutoScalingConfiguration : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/autoscaling_auto_scaling_configuration oci_autoscaling_auto_scaling_configuration} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciAutoscalingAutoScalingConfiguration(Constructs.Construct scope, string id, oci.DataOciAutoscalingAutoScalingConfiguration.IDataOciAutoscalingAutoScalingConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciAutoscalingAutoScalingConfiguration.IDataOciAutoscalingAutoScalingConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAutoscalingAutoScalingConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAutoscalingAutoScalingConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciAutoscalingAutoScalingConfiguration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciAutoscalingAutoScalingConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing DataOciAutoscalingAutoScalingConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciAutoscalingAutoScalingConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciAutoscalingAutoScalingConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/autoscaling_auto_scaling_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciAutoscalingAutoScalingConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciAutoscalingAutoScalingConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciAutoscalingAutoScalingConfiguration.DataOciAutoscalingAutoScalingConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciAutoscalingAutoScalingConfiguration.DataOciAutoscalingAutoScalingConfiguration))!;

        [JsiiProperty(name: "autoScalingResources", typeJson: "{\"fqn\":\"oci.dataOciAutoscalingAutoScalingConfiguration.DataOciAutoscalingAutoScalingConfigurationAutoScalingResourcesList\"}")]
        public virtual oci.DataOciAutoscalingAutoScalingConfiguration.DataOciAutoscalingAutoScalingConfigurationAutoScalingResourcesList AutoScalingResources
        {
            get => GetInstanceProperty<oci.DataOciAutoscalingAutoScalingConfiguration.DataOciAutoscalingAutoScalingConfigurationAutoScalingResourcesList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "coolDownInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CoolDownInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "maxResourceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxResourceCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minResourceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinResourceCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "policies", typeJson: "{\"fqn\":\"oci.dataOciAutoscalingAutoScalingConfiguration.DataOciAutoscalingAutoScalingConfigurationPoliciesList\"}")]
        public virtual oci.DataOciAutoscalingAutoScalingConfiguration.DataOciAutoscalingAutoScalingConfigurationPoliciesList Policies
        {
            get => GetInstanceProperty<oci.DataOciAutoscalingAutoScalingConfiguration.DataOciAutoscalingAutoScalingConfigurationPoliciesList>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoScalingConfigurationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutoScalingConfigurationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "autoScalingConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoScalingConfigurationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
