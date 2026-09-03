using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiProject
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_project oci_generative_ai_project}.</summary>
    [JsiiClass(nativeType: typeof(oci.GenerativeAiProject.GenerativeAiProject), fullyQualifiedName: "oci.generativeAiProject.GenerativeAiProject", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectConfig\"}}]")]
    public class GenerativeAiProject : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_project oci_generative_ai_project} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public GenerativeAiProject(Constructs.Construct scope, string id, oci.GenerativeAiProject.IGenerativeAiProjectConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.GenerativeAiProject.IGenerativeAiProjectConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiProject(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiProject(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a GenerativeAiProject resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the GenerativeAiProject to import.</param>
        /// <param name="importFromId">The id of the existing GenerativeAiProject that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the GenerativeAiProject to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the GenerativeAiProject to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_project#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing GenerativeAiProject that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the GenerativeAiProject to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.GenerativeAiProject.GenerativeAiProject), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putConversationConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectConversationConfig\"}}]")]
        public virtual void PutConversationConfig(oci.GenerativeAiProject.IGenerativeAiProjectConversationConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiProject.IGenerativeAiProjectConversationConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLongTermMemoryConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectLongTermMemoryConfig\"}}]")]
        public virtual void PutLongTermMemoryConfig(oci.GenerativeAiProject.IGenerativeAiProjectLongTermMemoryConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiProject.IGenerativeAiProjectLongTermMemoryConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putShortTermMemoryOptimizationConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectShortTermMemoryOptimizationConfig\"}}]")]
        public virtual void PutShortTermMemoryOptimizationConfig(oci.GenerativeAiProject.IGenerativeAiProjectShortTermMemoryOptimizationConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiProject.IGenerativeAiProjectShortTermMemoryOptimizationConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.GenerativeAiProject.IGenerativeAiProjectTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiProject.IGenerativeAiProjectTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConversationConfig")]
        public virtual void ResetConversationConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
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

        [JsiiMethod(name: "resetLongTermMemoryConfig")]
        public virtual void ResetLongTermMemoryConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShortTermMemoryOptimizationConfig")]
        public virtual void ResetShortTermMemoryOptimizationConfig()
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
        = GetStaticProperty<string>(typeof(oci.GenerativeAiProject.GenerativeAiProject))!;

        [JsiiProperty(name: "conversationConfig", typeJson: "{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectConversationConfigOutputReference\"}")]
        public virtual oci.GenerativeAiProject.GenerativeAiProjectConversationConfigOutputReference ConversationConfig
        {
            get => GetInstanceProperty<oci.GenerativeAiProject.GenerativeAiProjectConversationConfigOutputReference>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "longTermMemoryConfig", typeJson: "{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectLongTermMemoryConfigOutputReference\"}")]
        public virtual oci.GenerativeAiProject.GenerativeAiProjectLongTermMemoryConfigOutputReference LongTermMemoryConfig
        {
            get => GetInstanceProperty<oci.GenerativeAiProject.GenerativeAiProjectLongTermMemoryConfigOutputReference>()!;
        }

        [JsiiProperty(name: "shortTermMemoryOptimizationConfig", typeJson: "{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectShortTermMemoryOptimizationConfigOutputReference\"}")]
        public virtual oci.GenerativeAiProject.GenerativeAiProjectShortTermMemoryOptimizationConfigOutputReference ShortTermMemoryOptimizationConfig
        {
            get => GetInstanceProperty<oci.GenerativeAiProject.GenerativeAiProjectShortTermMemoryOptimizationConfigOutputReference>()!;
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

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectTimeoutsOutputReference\"}")]
        public virtual oci.GenerativeAiProject.GenerativeAiProjectTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.GenerativeAiProject.GenerativeAiProjectTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "conversationConfigInput", typeJson: "{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectConversationConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiProject.IGenerativeAiProjectConversationConfig? ConversationConfigInput
        {
            get => GetInstanceProperty<oci.GenerativeAiProject.IGenerativeAiProjectConversationConfig?>();
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
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
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
        [JsiiProperty(name: "longTermMemoryConfigInput", typeJson: "{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectLongTermMemoryConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiProject.IGenerativeAiProjectLongTermMemoryConfig? LongTermMemoryConfigInput
        {
            get => GetInstanceProperty<oci.GenerativeAiProject.IGenerativeAiProjectLongTermMemoryConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shortTermMemoryOptimizationConfigInput", typeJson: "{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectShortTermMemoryOptimizationConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiProject.IGenerativeAiProjectShortTermMemoryOptimizationConfig? ShortTermMemoryOptimizationConfigInput
        {
            get => GetInstanceProperty<oci.GenerativeAiProject.IGenerativeAiProjectShortTermMemoryOptimizationConfig?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.GenerativeAiProject.IGenerativeAiProjectTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
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

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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
    }
}
