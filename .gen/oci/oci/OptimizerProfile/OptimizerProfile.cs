using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OptimizerProfile
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile oci_optimizer_profile}.</summary>
    [JsiiClass(nativeType: typeof(oci.OptimizerProfile.OptimizerProfile), fullyQualifiedName: "oci.optimizerProfile.OptimizerProfile", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.optimizerProfile.OptimizerProfileConfig\"}}]")]
    public class OptimizerProfile : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile oci_optimizer_profile} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OptimizerProfile(Constructs.Construct scope, string id, oci.OptimizerProfile.IOptimizerProfileConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.OptimizerProfile.IOptimizerProfileConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OptimizerProfile(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OptimizerProfile(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a OptimizerProfile resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the OptimizerProfile to import.</param>
        /// <param name="importFromId">The id of the existing OptimizerProfile that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the OptimizerProfile to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the OptimizerProfile to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing OptimizerProfile that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the OptimizerProfile to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.OptimizerProfile.OptimizerProfile), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putLevelsConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.optimizerProfile.OptimizerProfileLevelsConfiguration\"}}]")]
        public virtual void PutLevelsConfiguration(oci.OptimizerProfile.IOptimizerProfileLevelsConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OptimizerProfile.IOptimizerProfileLevelsConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTargetCompartments", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.optimizerProfile.OptimizerProfileTargetCompartments\"}}]")]
        public virtual void PutTargetCompartments(oci.OptimizerProfile.IOptimizerProfileTargetCompartments @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OptimizerProfile.IOptimizerProfileTargetCompartments)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTargetTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.optimizerProfile.OptimizerProfileTargetTags\"}}]")]
        public virtual void PutTargetTags(oci.OptimizerProfile.IOptimizerProfileTargetTags @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OptimizerProfile.IOptimizerProfileTargetTags)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.optimizerProfile.OptimizerProfileTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.OptimizerProfile.IOptimizerProfileTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OptimizerProfile.IOptimizerProfileTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAggregationIntervalInDays")]
        public virtual void ResetAggregationIntervalInDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetCompartments")]
        public virtual void ResetTargetCompartments()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetTags")]
        public virtual void ResetTargetTags()
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
        = GetStaticProperty<string>(typeof(oci.OptimizerProfile.OptimizerProfile))!;

        [JsiiProperty(name: "levelsConfiguration", typeJson: "{\"fqn\":\"oci.optimizerProfile.OptimizerProfileLevelsConfigurationOutputReference\"}")]
        public virtual oci.OptimizerProfile.OptimizerProfileLevelsConfigurationOutputReference LevelsConfiguration
        {
            get => GetInstanceProperty<oci.OptimizerProfile.OptimizerProfileLevelsConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "targetCompartments", typeJson: "{\"fqn\":\"oci.optimizerProfile.OptimizerProfileTargetCompartmentsOutputReference\"}")]
        public virtual oci.OptimizerProfile.OptimizerProfileTargetCompartmentsOutputReference TargetCompartments
        {
            get => GetInstanceProperty<oci.OptimizerProfile.OptimizerProfileTargetCompartmentsOutputReference>()!;
        }

        [JsiiProperty(name: "targetTags", typeJson: "{\"fqn\":\"oci.optimizerProfile.OptimizerProfileTargetTagsOutputReference\"}")]
        public virtual oci.OptimizerProfile.OptimizerProfileTargetTagsOutputReference TargetTags
        {
            get => GetInstanceProperty<oci.OptimizerProfile.OptimizerProfileTargetTagsOutputReference>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.optimizerProfile.OptimizerProfileTimeoutsOutputReference\"}")]
        public virtual oci.OptimizerProfile.OptimizerProfileTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.OptimizerProfile.OptimizerProfileTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "aggregationIntervalInDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AggregationIntervalInDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "levelsConfigurationInput", typeJson: "{\"fqn\":\"oci.optimizerProfile.OptimizerProfileLevelsConfiguration\"}", isOptional: true)]
        public virtual oci.OptimizerProfile.IOptimizerProfileLevelsConfiguration? LevelsConfigurationInput
        {
            get => GetInstanceProperty<oci.OptimizerProfile.IOptimizerProfileLevelsConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetCompartmentsInput", typeJson: "{\"fqn\":\"oci.optimizerProfile.OptimizerProfileTargetCompartments\"}", isOptional: true)]
        public virtual oci.OptimizerProfile.IOptimizerProfileTargetCompartments? TargetCompartmentsInput
        {
            get => GetInstanceProperty<oci.OptimizerProfile.IOptimizerProfileTargetCompartments?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetTagsInput", typeJson: "{\"fqn\":\"oci.optimizerProfile.OptimizerProfileTargetTags\"}", isOptional: true)]
        public virtual oci.OptimizerProfile.IOptimizerProfileTargetTags? TargetTagsInput
        {
            get => GetInstanceProperty<oci.OptimizerProfile.IOptimizerProfileTargetTags?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.optimizerProfile.OptimizerProfileTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "aggregationIntervalInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AggregationIntervalInDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
