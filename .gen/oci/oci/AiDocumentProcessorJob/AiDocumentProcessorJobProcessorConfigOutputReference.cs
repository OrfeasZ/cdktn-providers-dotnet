using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiDocumentProcessorJob
{
    [JsiiClass(nativeType: typeof(oci.AiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigOutputReference), fullyQualifiedName: "oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AiDocumentProcessorJobProcessorConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AiDocumentProcessorJobProcessorConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiDocumentProcessorJobProcessorConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiDocumentProcessorJobProcessorConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFeatures", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigFeatures\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFeatures(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfigFeatures[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfigFeatures).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfigFeatures).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNormalizationFields", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigNormalizationFields\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNormalizationFields(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfigNormalizationFields[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfigNormalizationFields).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfigNormalizationFields).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDocumentType")]
        public virtual void ResetDocumentType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsZipOutputEnabled")]
        public virtual void ResetIsZipOutputEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLanguage")]
        public virtual void ResetLanguage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModelId")]
        public virtual void ResetModelId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNormalizationFields")]
        public virtual void ResetNormalizationFields()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "features", typeJson: "{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigFeaturesList\"}")]
        public virtual oci.AiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigFeaturesList Features
        {
            get => GetInstanceProperty<oci.AiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigFeaturesList>()!;
        }

        [JsiiProperty(name: "normalizationFields", typeJson: "{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigNormalizationFieldsList\"}")]
        public virtual oci.AiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigNormalizationFieldsList NormalizationFields
        {
            get => GetInstanceProperty<oci.AiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigNormalizationFieldsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "documentTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DocumentTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "featuresInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigFeatures\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FeaturesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isZipOutputEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsZipOutputEnabledInput
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
        [JsiiProperty(name: "modelIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "normalizationFieldsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigNormalizationFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NormalizationFieldsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "processorTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProcessorTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "documentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DocumentType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isZipOutputEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsZipOutputEnabled
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

        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "processorType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProcessorType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfig\"}", isOptional: true)]
        public virtual oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfig? InternalValue
        {
            get => GetInstanceProperty<oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
