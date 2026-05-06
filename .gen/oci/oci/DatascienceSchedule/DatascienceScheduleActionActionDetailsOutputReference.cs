using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceSchedule
{
    [JsiiClass(nativeType: typeof(oci.DatascienceSchedule.DatascienceScheduleActionActionDetailsOutputReference), fullyQualifiedName: "oci.datascienceSchedule.DatascienceScheduleActionActionDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatascienceScheduleActionActionDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatascienceScheduleActionActionDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatascienceScheduleActionActionDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceScheduleActionActionDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCreateJobRunDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreateJobRunDetails\"}}]")]
        public virtual void PutCreateJobRunDetails(oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreateJobRunDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreateJobRunDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCreatePipelineRunDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetails\"}}]")]
        public virtual void PutCreatePipelineRunDetails(oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTriggerMlApplicationInstanceViewFlowDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetails\"}}]")]
        public virtual void PutTriggerMlApplicationInstanceViewFlowDetails(oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCreateJobRunDetails")]
        public virtual void ResetCreateJobRunDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreatePipelineRunDetails")]
        public virtual void ResetCreatePipelineRunDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMlApplicationInstanceViewId")]
        public virtual void ResetMlApplicationInstanceViewId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTriggerMlApplicationInstanceViewFlowDetails")]
        public virtual void ResetTriggerMlApplicationInstanceViewFlowDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "createJobRunDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreateJobRunDetailsOutputReference\"}")]
        public virtual oci.DatascienceSchedule.DatascienceScheduleActionActionDetailsCreateJobRunDetailsOutputReference CreateJobRunDetails
        {
            get => GetInstanceProperty<oci.DatascienceSchedule.DatascienceScheduleActionActionDetailsCreateJobRunDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "createPipelineRunDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsOutputReference\"}")]
        public virtual oci.DatascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsOutputReference CreatePipelineRunDetails
        {
            get => GetInstanceProperty<oci.DatascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "triggerMlApplicationInstanceViewFlowDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsOutputReference\"}")]
        public virtual oci.DatascienceSchedule.DatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsOutputReference TriggerMlApplicationInstanceViewFlowDetails
        {
            get => GetInstanceProperty<oci.DatascienceSchedule.DatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "createJobRunDetailsInput", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreateJobRunDetails\"}", isOptional: true)]
        public virtual oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreateJobRunDetails? CreateJobRunDetailsInput
        {
            get => GetInstanceProperty<oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreateJobRunDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createPipelineRunDetailsInput", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreatePipelineRunDetails\"}", isOptional: true)]
        public virtual oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetails? CreatePipelineRunDetailsInput
        {
            get => GetInstanceProperty<oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreatePipelineRunDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpActionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HttpActionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mlApplicationInstanceViewIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MlApplicationInstanceViewIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "triggerMlApplicationInstanceViewFlowDetailsInput", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetails\"}", isOptional: true)]
        public virtual oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetails? TriggerMlApplicationInstanceViewFlowDetailsInput
        {
            get => GetInstanceProperty<oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsTriggerMlApplicationInstanceViewFlowDetails?>();
        }

        [JsiiProperty(name: "httpActionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpActionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mlApplicationInstanceViewId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MlApplicationInstanceViewId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetails\"}", isOptional: true)]
        public virtual oci.DatascienceSchedule.IDatascienceScheduleActionActionDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatascienceSchedule.IDatascienceScheduleActionActionDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
