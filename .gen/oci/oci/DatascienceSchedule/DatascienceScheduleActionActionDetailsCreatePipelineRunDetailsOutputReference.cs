using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceSchedule
{
    [JsiiClass(nativeType: typeof(oci.DatascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsOutputReference), fullyQualifiedName: "oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConfigurationOverrideDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsConfigurationOverrideDetails\"}}]")]
        public virtual void PutConfigurationOverrideDetails(oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsConfigurationOverrideDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsConfigurationOverrideDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogConfigurationOverrideDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsLogConfigurationOverrideDetails\"}}]")]
        public virtual void PutLogConfigurationOverrideDetails(oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsLogConfigurationOverrideDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsLogConfigurationOverrideDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStepOverrideDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetails\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStepOverrideDetails(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetails[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetails).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetails).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCompartmentId")]
        public virtual void ResetCompartmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfigurationOverrideDetails")]
        public virtual void ResetConfigurationOverrideDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
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

        [JsiiMethod(name: "resetLogConfigurationOverrideDetails")]
        public virtual void ResetLogConfigurationOverrideDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPipelineId")]
        public virtual void ResetPipelineId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProjectId")]
        public virtual void ResetProjectId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepOverrideDetails")]
        public virtual void ResetStepOverrideDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSystemTags")]
        public virtual void ResetSystemTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "configurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsConfigurationOverrideDetailsOutputReference\"}")]
        public virtual oci.DatascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsConfigurationOverrideDetailsOutputReference ConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DatascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsConfigurationOverrideDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "logConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsLogConfigurationOverrideDetailsOutputReference\"}")]
        public virtual oci.DatascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsLogConfigurationOverrideDetailsOutputReference LogConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DatascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsLogConfigurationOverrideDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "stepOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsList\"}")]
        public virtual oci.DatascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsList StepOverrideDetails
        {
            get => GetInstanceProperty<oci.DatascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetailsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationOverrideDetailsInput", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsConfigurationOverrideDetails\"}", isOptional: true)]
        public virtual oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsConfigurationOverrideDetails? ConfigurationOverrideDetailsInput
        {
            get => GetInstanceProperty<oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsConfigurationOverrideDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
        [JsiiProperty(name: "logConfigurationOverrideDetailsInput", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsLogConfigurationOverrideDetails\"}", isOptional: true)]
        public virtual oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsLogConfigurationOverrideDetails? LogConfigurationOverrideDetailsInput
        {
            get => GetInstanceProperty<oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetailsLogConfigurationOverrideDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pipelineIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PipelineIdInput
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
        [JsiiProperty(name: "stepOverrideDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsStepOverrideDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StepOverrideDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "systemTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? SystemTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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

        [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PipelineId
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

        [JsiiProperty(name: "systemTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> SystemTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetails\"}", isOptional: true)]
        public virtual oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
