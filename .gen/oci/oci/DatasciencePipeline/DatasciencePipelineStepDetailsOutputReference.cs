using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipeline
{
    [JsiiClass(nativeType: typeof(oci.DatasciencePipeline.DatasciencePipelineStepDetailsOutputReference), fullyQualifiedName: "oci.datasciencePipeline.DatasciencePipelineStepDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DatasciencePipelineStepDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DatasciencePipelineStepDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasciencePipelineStepDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasciencePipelineStepDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putStepConfigurationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepConfigurationDetails\"}}]")]
        public virtual void PutStepConfigurationDetails(oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepConfigurationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepConfigurationDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStepContainerConfigurationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepContainerConfigurationDetails\"}}]")]
        public virtual void PutStepContainerConfigurationDetails(oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepContainerConfigurationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepContainerConfigurationDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStepDataflowConfigurationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepDataflowConfigurationDetails\"}}]")]
        public virtual void PutStepDataflowConfigurationDetails(oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepDataflowConfigurationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepDataflowConfigurationDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStepInfrastructureConfigurationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepInfrastructureConfigurationDetails\"}}]")]
        public virtual void PutStepInfrastructureConfigurationDetails(oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepInfrastructureConfigurationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepInfrastructureConfigurationDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStepParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepParameters\"}}]")]
        public virtual void PutStepParameters(oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStepStorageMountConfigurationDetailsList", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepStorageMountConfigurationDetailsListStruct\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStepStorageMountConfigurationDetailsList(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepStorageMountConfigurationDetailsListStruct[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepStorageMountConfigurationDetailsListStruct).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepStorageMountConfigurationDetailsListStruct).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApplicationId")]
        public virtual void ResetApplicationId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDependsOn")]
        public virtual void ResetDependsOn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsArtifactUploaded")]
        public virtual void ResetIsArtifactUploaded()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJobId")]
        public virtual void ResetJobId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepConfigurationDetails")]
        public virtual void ResetStepConfigurationDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepContainerConfigurationDetails")]
        public virtual void ResetStepContainerConfigurationDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepDataflowConfigurationDetails")]
        public virtual void ResetStepDataflowConfigurationDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepInfrastructureConfigurationDetails")]
        public virtual void ResetStepInfrastructureConfigurationDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepParameters")]
        public virtual void ResetStepParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepRunName")]
        public virtual void ResetStepRunName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepStorageMountConfigurationDetailsList")]
        public virtual void ResetStepStorageMountConfigurationDetailsList()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "stepConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepConfigurationDetailsOutputReference\"}")]
        public virtual oci.DatasciencePipeline.DatasciencePipelineStepDetailsStepConfigurationDetailsOutputReference StepConfigurationDetails
        {
            get => GetInstanceProperty<oci.DatasciencePipeline.DatasciencePipelineStepDetailsStepConfigurationDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "stepContainerConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepContainerConfigurationDetailsOutputReference\"}")]
        public virtual oci.DatasciencePipeline.DatasciencePipelineStepDetailsStepContainerConfigurationDetailsOutputReference StepContainerConfigurationDetails
        {
            get => GetInstanceProperty<oci.DatasciencePipeline.DatasciencePipelineStepDetailsStepContainerConfigurationDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "stepDataflowConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepDataflowConfigurationDetailsOutputReference\"}")]
        public virtual oci.DatasciencePipeline.DatasciencePipelineStepDetailsStepDataflowConfigurationDetailsOutputReference StepDataflowConfigurationDetails
        {
            get => GetInstanceProperty<oci.DatasciencePipeline.DatasciencePipelineStepDetailsStepDataflowConfigurationDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "stepInfrastructureConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepInfrastructureConfigurationDetailsOutputReference\"}")]
        public virtual oci.DatasciencePipeline.DatasciencePipelineStepDetailsStepInfrastructureConfigurationDetailsOutputReference StepInfrastructureConfigurationDetails
        {
            get => GetInstanceProperty<oci.DatasciencePipeline.DatasciencePipelineStepDetailsStepInfrastructureConfigurationDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "stepParameters", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepParametersOutputReference\"}")]
        public virtual oci.DatasciencePipeline.DatasciencePipelineStepDetailsStepParametersOutputReference StepParameters
        {
            get => GetInstanceProperty<oci.DatasciencePipeline.DatasciencePipelineStepDetailsStepParametersOutputReference>()!;
        }

        [JsiiProperty(name: "stepStorageMountConfigurationDetailsList", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepStorageMountConfigurationDetailsListStructList\"}")]
        public virtual oci.DatasciencePipeline.DatasciencePipelineStepDetailsStepStorageMountConfigurationDetailsListStructList StepStorageMountConfigurationDetailsList
        {
            get => GetInstanceProperty<oci.DatasciencePipeline.DatasciencePipelineStepDetailsStepStorageMountConfigurationDetailsListStructList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApplicationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dependsOnInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DependsOnInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isArtifactUploadedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsArtifactUploadedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JobIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepConfigurationDetailsInput", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepConfigurationDetails\"}", isOptional: true)]
        public virtual oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepConfigurationDetails? StepConfigurationDetailsInput
        {
            get => GetInstanceProperty<oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepConfigurationDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepContainerConfigurationDetailsInput", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepContainerConfigurationDetails\"}", isOptional: true)]
        public virtual oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepContainerConfigurationDetails? StepContainerConfigurationDetailsInput
        {
            get => GetInstanceProperty<oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepContainerConfigurationDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepDataflowConfigurationDetailsInput", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepDataflowConfigurationDetails\"}", isOptional: true)]
        public virtual oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepDataflowConfigurationDetails? StepDataflowConfigurationDetailsInput
        {
            get => GetInstanceProperty<oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepDataflowConfigurationDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepInfrastructureConfigurationDetailsInput", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepInfrastructureConfigurationDetails\"}", isOptional: true)]
        public virtual oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepInfrastructureConfigurationDetails? StepInfrastructureConfigurationDetailsInput
        {
            get => GetInstanceProperty<oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepInfrastructureConfigurationDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StepNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepParametersInput", typeJson: "{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepParameters\"}", isOptional: true)]
        public virtual oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepParameters? StepParametersInput
        {
            get => GetInstanceProperty<oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepRunNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StepRunNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepStorageMountConfigurationDetailsListInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetailsStepStorageMountConfigurationDetailsListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StepStorageMountConfigurationDetailsListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StepTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DependsOn
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isArtifactUploaded", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsArtifactUploaded
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

        [JsiiProperty(name: "jobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StepName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stepRunName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StepRunName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stepType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StepType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.datasciencePipeline.DatasciencePipelineStepDetails\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatasciencePipeline.IDatasciencePipelineStepDetails cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatasciencePipeline.IDatasciencePipelineStepDetails).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
