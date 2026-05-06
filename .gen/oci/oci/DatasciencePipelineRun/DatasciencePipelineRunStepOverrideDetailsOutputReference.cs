using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipelineRun
{
    [JsiiClass(nativeType: typeof(oci.DatasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsOutputReference), fullyQualifiedName: "oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DatasciencePipelineRunStepOverrideDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DatasciencePipelineRunStepOverrideDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DatasciencePipelineRunStepOverrideDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasciencePipelineRunStepOverrideDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putStepConfigurationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepConfigurationDetails\"}}]")]
        public virtual void PutStepConfigurationDetails(oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepConfigurationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepConfigurationDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStepContainerConfigurationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepContainerConfigurationDetails\"}}]")]
        public virtual void PutStepContainerConfigurationDetails(oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepContainerConfigurationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepContainerConfigurationDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStepDataflowConfigurationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails\"}}]")]
        public virtual void PutStepDataflowConfigurationDetails(oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStepInfrastructureConfigurationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepInfrastructureConfigurationDetails\"}}]")]
        public virtual void PutStepInfrastructureConfigurationDetails(oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepInfrastructureConfigurationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepInfrastructureConfigurationDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStepStorageMountConfigurationDetailsList", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepStorageMountConfigurationDetailsListStruct\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStepStorageMountConfigurationDetailsList(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepStorageMountConfigurationDetailsListStruct[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepStorageMountConfigurationDetailsListStruct).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepStorageMountConfigurationDetailsListStruct).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
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

        [JsiiMethod(name: "resetStepStorageMountConfigurationDetailsList")]
        public virtual void ResetStepStorageMountConfigurationDetailsList()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "stepConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepConfigurationDetailsOutputReference\"}")]
        public virtual oci.DatasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepConfigurationDetailsOutputReference StepConfigurationDetails
        {
            get => GetInstanceProperty<oci.DatasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepConfigurationDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "stepContainerConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepContainerConfigurationDetailsOutputReference\"}")]
        public virtual oci.DatasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepContainerConfigurationDetailsOutputReference StepContainerConfigurationDetails
        {
            get => GetInstanceProperty<oci.DatasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepContainerConfigurationDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "stepDataflowConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsOutputReference\"}")]
        public virtual oci.DatasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsOutputReference StepDataflowConfigurationDetails
        {
            get => GetInstanceProperty<oci.DatasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "stepInfrastructureConfigurationDetails", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepInfrastructureConfigurationDetailsOutputReference\"}")]
        public virtual oci.DatasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepInfrastructureConfigurationDetailsOutputReference StepInfrastructureConfigurationDetails
        {
            get => GetInstanceProperty<oci.DatasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepInfrastructureConfigurationDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "stepStorageMountConfigurationDetailsList", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepStorageMountConfigurationDetailsListStructList\"}")]
        public virtual oci.DatasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepStorageMountConfigurationDetailsListStructList StepStorageMountConfigurationDetailsList
        {
            get => GetInstanceProperty<oci.DatasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepStorageMountConfigurationDetailsListStructList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepConfigurationDetailsInput", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepConfigurationDetails\"}", isOptional: true)]
        public virtual oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepConfigurationDetails? StepConfigurationDetailsInput
        {
            get => GetInstanceProperty<oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepConfigurationDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepContainerConfigurationDetailsInput", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepContainerConfigurationDetails\"}", isOptional: true)]
        public virtual oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepContainerConfigurationDetails? StepContainerConfigurationDetailsInput
        {
            get => GetInstanceProperty<oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepContainerConfigurationDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepDataflowConfigurationDetailsInput", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails\"}", isOptional: true)]
        public virtual oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails? StepDataflowConfigurationDetailsInput
        {
            get => GetInstanceProperty<oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepInfrastructureConfigurationDetailsInput", typeJson: "{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepInfrastructureConfigurationDetails\"}", isOptional: true)]
        public virtual oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepInfrastructureConfigurationDetails? StepInfrastructureConfigurationDetailsInput
        {
            get => GetInstanceProperty<oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetailsStepInfrastructureConfigurationDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StepNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepStorageMountConfigurationDetailsListInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetailsStepStorageMountConfigurationDetailsListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StepStorageMountConfigurationDetailsListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StepName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.datasciencePipelineRun.DatasciencePipelineRunStepOverrideDetails\"}]}}", isOptional: true)]
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
                        case oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetails cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatasciencePipelineRun.IDatasciencePipelineRunStepOverrideDetails).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
