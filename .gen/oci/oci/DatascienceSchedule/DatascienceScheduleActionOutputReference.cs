using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceSchedule
{
    [JsiiClass(nativeType: typeof(oci.DatascienceSchedule.DatascienceScheduleActionOutputReference), fullyQualifiedName: "oci.datascienceSchedule.DatascienceScheduleActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatascienceScheduleActionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatascienceScheduleActionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatascienceScheduleActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceScheduleActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putActionDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetails\"}}]")]
        public virtual void PutActionDetails(oci.DatascienceSchedule.IDatascienceScheduleActionActionDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceSchedule.IDatascienceScheduleActionActionDetails)}, new object[]{@value});
        }

        [JsiiProperty(name: "actionDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsOutputReference\"}")]
        public virtual oci.DatascienceSchedule.DatascienceScheduleActionActionDetailsOutputReference ActionDetails
        {
            get => GetInstanceProperty<oci.DatascienceSchedule.DatascienceScheduleActionActionDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionDetailsInput", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetails\"}", isOptional: true)]
        public virtual oci.DatascienceSchedule.IDatascienceScheduleActionActionDetails? ActionDetailsInput
        {
            get => GetInstanceProperty<oci.DatascienceSchedule.IDatascienceScheduleActionActionDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleAction\"}", isOptional: true)]
        public virtual oci.DatascienceSchedule.IDatascienceScheduleAction? InternalValue
        {
            get => GetInstanceProperty<oci.DatascienceSchedule.IDatascienceScheduleAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
