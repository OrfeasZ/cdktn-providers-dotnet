using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiDocumentModel
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_model oci_ai_document_model}.</summary>
    [JsiiClass(nativeType: typeof(oci.AiDocumentModel.AiDocumentModel), fullyQualifiedName: "oci.aiDocumentModel.AiDocumentModel", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelConfig\"}}]")]
    public class AiDocumentModel : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_model oci_ai_document_model} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AiDocumentModel(Constructs.Construct scope, string id, oci.AiDocumentModel.IAiDocumentModelConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.AiDocumentModel.IAiDocumentModelConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiDocumentModel(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiDocumentModel(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a AiDocumentModel resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the AiDocumentModel to import.</param>
        /// <param name="importFromId">The id of the existing AiDocumentModel that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the AiDocumentModel to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the AiDocumentModel to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_model#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing AiDocumentModel that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the AiDocumentModel to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.AiDocumentModel.AiDocumentModel), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putComponentModels", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelComponentModels\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutComponentModels(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.AiDocumentModel.IAiDocumentModelComponentModels[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AiDocumentModel.IAiDocumentModelComponentModels).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AiDocumentModel.IAiDocumentModelComponentModels).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLocks", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelLocks\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLocks(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.AiDocumentModel.IAiDocumentModelLocks[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AiDocumentModel.IAiDocumentModelLocks).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AiDocumentModel.IAiDocumentModelLocks).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putModelSubType", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelModelSubType\"}}]")]
        public virtual void PutModelSubType(oci.AiDocumentModel.IAiDocumentModelModelSubType @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AiDocumentModel.IAiDocumentModelModelSubType)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTestingDataset", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelTestingDataset\"}}]")]
        public virtual void PutTestingDataset(oci.AiDocumentModel.IAiDocumentModelTestingDataset @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AiDocumentModel.IAiDocumentModelTestingDataset)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.AiDocumentModel.IAiDocumentModelTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AiDocumentModel.IAiDocumentModelTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTrainingDataset", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelTrainingDataset\"}}]")]
        public virtual void PutTrainingDataset(oci.AiDocumentModel.IAiDocumentModelTrainingDataset @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AiDocumentModel.IAiDocumentModelTrainingDataset)}, new object[]{@value});
        }

        [JsiiMethod(name: "putValidationDataset", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelValidationDataset\"}}]")]
        public virtual void PutValidationDataset(oci.AiDocumentModel.IAiDocumentModelValidationDataset @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AiDocumentModel.IAiDocumentModelValidationDataset)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetComponentModels")]
        public virtual void ResetComponentModels()
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

        [JsiiMethod(name: "resetInferenceUnits")]
        public virtual void ResetInferenceUnits()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsQuickMode")]
        public virtual void ResetIsQuickMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLanguage")]
        public virtual void ResetLanguage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocks")]
        public virtual void ResetLocks()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxTrainingTimeInHours")]
        public virtual void ResetMaxTrainingTimeInHours()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModelId")]
        public virtual void ResetModelId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModelSubType")]
        public virtual void ResetModelSubType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModelVersion")]
        public virtual void ResetModelVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTestingDataset")]
        public virtual void ResetTestingDataset()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrainingDataset")]
        public virtual void ResetTrainingDataset()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetValidationDataset")]
        public virtual void ResetValidationDataset()
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
        = GetStaticProperty<string>(typeof(oci.AiDocumentModel.AiDocumentModel))!;

        [JsiiProperty(name: "componentModels", typeJson: "{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelComponentModelsList\"}")]
        public virtual oci.AiDocumentModel.AiDocumentModelComponentModelsList ComponentModels
        {
            get => GetInstanceProperty<oci.AiDocumentModel.AiDocumentModelComponentModelsList>()!;
        }

        [JsiiProperty(name: "isComposedModel", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsComposedModel
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Labels
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locks", typeJson: "{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelLocksList\"}")]
        public virtual oci.AiDocumentModel.AiDocumentModelLocksList Locks
        {
            get => GetInstanceProperty<oci.AiDocumentModel.AiDocumentModelLocksList>()!;
        }

        [JsiiProperty(name: "metrics", typeJson: "{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelMetricsList\"}")]
        public virtual oci.AiDocumentModel.AiDocumentModelMetricsList Metrics
        {
            get => GetInstanceProperty<oci.AiDocumentModel.AiDocumentModelMetricsList>()!;
        }

        [JsiiProperty(name: "modelSubType", typeJson: "{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelModelSubTypeOutputReference\"}")]
        public virtual oci.AiDocumentModel.AiDocumentModelModelSubTypeOutputReference ModelSubType
        {
            get => GetInstanceProperty<oci.AiDocumentModel.AiDocumentModelModelSubTypeOutputReference>()!;
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

        [JsiiProperty(name: "tenancyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "testingDataset", typeJson: "{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelTestingDatasetOutputReference\"}")]
        public virtual oci.AiDocumentModel.AiDocumentModelTestingDatasetOutputReference TestingDataset
        {
            get => GetInstanceProperty<oci.AiDocumentModel.AiDocumentModelTestingDatasetOutputReference>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelTimeoutsOutputReference\"}")]
        public virtual oci.AiDocumentModel.AiDocumentModelTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.AiDocumentModel.AiDocumentModelTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "trainedTimeInHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TrainedTimeInHours
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "trainingDataset", typeJson: "{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelTrainingDatasetOutputReference\"}")]
        public virtual oci.AiDocumentModel.AiDocumentModelTrainingDatasetOutputReference TrainingDataset
        {
            get => GetInstanceProperty<oci.AiDocumentModel.AiDocumentModelTrainingDatasetOutputReference>()!;
        }

        [JsiiProperty(name: "validationDataset", typeJson: "{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelValidationDatasetOutputReference\"}")]
        public virtual oci.AiDocumentModel.AiDocumentModelValidationDatasetOutputReference ValidationDataset
        {
            get => GetInstanceProperty<oci.AiDocumentModel.AiDocumentModelValidationDatasetOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "componentModelsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelComponentModels\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ComponentModelsInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "inferenceUnitsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InferenceUnitsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isQuickModeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsQuickModeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "languageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LanguageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locksInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelLocks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LocksInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxTrainingTimeInHoursInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxTrainingTimeInHoursInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelSubTypeInput", typeJson: "{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelModelSubType\"}", isOptional: true)]
        public virtual oci.AiDocumentModel.IAiDocumentModelModelSubType? ModelSubTypeInput
        {
            get => GetInstanceProperty<oci.AiDocumentModel.IAiDocumentModelModelSubType?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "testingDatasetInput", typeJson: "{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelTestingDataset\"}", isOptional: true)]
        public virtual oci.AiDocumentModel.IAiDocumentModelTestingDataset? TestingDatasetInput
        {
            get => GetInstanceProperty<oci.AiDocumentModel.IAiDocumentModelTestingDataset?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trainingDatasetInput", typeJson: "{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelTrainingDataset\"}", isOptional: true)]
        public virtual oci.AiDocumentModel.IAiDocumentModelTrainingDataset? TrainingDatasetInput
        {
            get => GetInstanceProperty<oci.AiDocumentModel.IAiDocumentModelTrainingDataset?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "validationDatasetInput", typeJson: "{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelValidationDataset\"}", isOptional: true)]
        public virtual oci.AiDocumentModel.IAiDocumentModelValidationDataset? ValidationDatasetInput
        {
            get => GetInstanceProperty<oci.AiDocumentModel.IAiDocumentModelValidationDataset?>();
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

        [JsiiProperty(name: "inferenceUnits", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InferenceUnits
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isQuickMode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsQuickMode
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

        [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Language
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxTrainingTimeInHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxTrainingTimeInHours
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelVersion
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
