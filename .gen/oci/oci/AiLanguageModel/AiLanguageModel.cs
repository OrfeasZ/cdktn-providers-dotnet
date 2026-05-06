using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiLanguageModel
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model oci_ai_language_model}.</summary>
    [JsiiClass(nativeType: typeof(oci.AiLanguageModel.AiLanguageModel), fullyQualifiedName: "oci.aiLanguageModel.AiLanguageModel", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelConfig\"}}]")]
    public class AiLanguageModel : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model oci_ai_language_model} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AiLanguageModel(Constructs.Construct scope, string id, oci.AiLanguageModel.IAiLanguageModelConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.AiLanguageModel.IAiLanguageModelConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiLanguageModel(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiLanguageModel(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a AiLanguageModel resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the AiLanguageModel to import.</param>
        /// <param name="importFromId">The id of the existing AiLanguageModel that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the AiLanguageModel to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the AiLanguageModel to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing AiLanguageModel that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the AiLanguageModel to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.AiLanguageModel.AiLanguageModel), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putModelDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelModelDetails\"}}]")]
        public virtual void PutModelDetails(oci.AiLanguageModel.IAiLanguageModelModelDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AiLanguageModel.IAiLanguageModelModelDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTestStrategy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTestStrategy\"}}]")]
        public virtual void PutTestStrategy(oci.AiLanguageModel.IAiLanguageModelTestStrategy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AiLanguageModel.IAiLanguageModelTestStrategy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.AiLanguageModel.IAiLanguageModelTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AiLanguageModel.IAiLanguageModelTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTrainingDataset", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTrainingDataset\"}}]")]
        public virtual void PutTrainingDataset(oci.AiLanguageModel.IAiLanguageModelTrainingDataset @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AiLanguageModel.IAiLanguageModelTrainingDataset)}, new object[]{@value});
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

        [JsiiMethod(name: "resetTestStrategy")]
        public virtual void ResetTestStrategy()
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
        = GetStaticProperty<string>(typeof(oci.AiLanguageModel.AiLanguageModel))!;

        [JsiiProperty(name: "evaluationResults", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelEvaluationResultsList\"}")]
        public virtual oci.AiLanguageModel.AiLanguageModelEvaluationResultsList EvaluationResults
        {
            get => GetInstanceProperty<oci.AiLanguageModel.AiLanguageModelEvaluationResultsList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelDetails", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelModelDetailsOutputReference\"}")]
        public virtual oci.AiLanguageModel.AiLanguageModelModelDetailsOutputReference ModelDetails
        {
            get => GetInstanceProperty<oci.AiLanguageModel.AiLanguageModelModelDetailsOutputReference>()!;
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

        [JsiiProperty(name: "testStrategy", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTestStrategyOutputReference\"}")]
        public virtual oci.AiLanguageModel.AiLanguageModelTestStrategyOutputReference TestStrategy
        {
            get => GetInstanceProperty<oci.AiLanguageModel.AiLanguageModelTestStrategyOutputReference>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTimeoutsOutputReference\"}")]
        public virtual oci.AiLanguageModel.AiLanguageModelTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.AiLanguageModel.AiLanguageModelTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "trainingDataset", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTrainingDatasetOutputReference\"}")]
        public virtual oci.AiLanguageModel.AiLanguageModelTrainingDatasetOutputReference TrainingDataset
        {
            get => GetInstanceProperty<oci.AiLanguageModel.AiLanguageModelTrainingDatasetOutputReference>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
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
        [JsiiProperty(name: "modelDetailsInput", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelModelDetails\"}", isOptional: true)]
        public virtual oci.AiLanguageModel.IAiLanguageModelModelDetails? ModelDetailsInput
        {
            get => GetInstanceProperty<oci.AiLanguageModel.IAiLanguageModelModelDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "testStrategyInput", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTestStrategy\"}", isOptional: true)]
        public virtual oci.AiLanguageModel.IAiLanguageModelTestStrategy? TestStrategyInput
        {
            get => GetInstanceProperty<oci.AiLanguageModel.IAiLanguageModelTestStrategy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trainingDatasetInput", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTrainingDataset\"}", isOptional: true)]
        public virtual oci.AiLanguageModel.IAiLanguageModelTrainingDataset? TrainingDatasetInput
        {
            get => GetInstanceProperty<oci.AiLanguageModel.IAiLanguageModelTrainingDataset?>();
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

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
