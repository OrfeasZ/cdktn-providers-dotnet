using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiClass(nativeType: typeof(stripe.SubscriptionSchedule.SubscriptionSchedulePauseSchedulesResumeStatusOutputReference), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesResumeStatusOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SubscriptionSchedulePauseSchedulesResumeStatusOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SubscriptionSchedulePauseSchedulesResumeStatusOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SubscriptionSchedulePauseSchedulesResumeStatusOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SubscriptionSchedulePauseSchedulesResumeStatusOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "error", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesResumeStatusErrorOutputReference\"}")]
        public virtual stripe.SubscriptionSchedule.SubscriptionSchedulePauseSchedulesResumeStatusErrorOutputReference Error
        {
            get => GetInstanceProperty<stripe.SubscriptionSchedule.SubscriptionSchedulePauseSchedulesResumeStatusErrorOutputReference>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesResumeStatus\"}", isOptional: true)]
        public virtual stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesResumeStatus? InternalValue
        {
            get => GetInstanceProperty<stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesResumeStatus?>();
            set => SetInstanceProperty(value);
        }
    }
}
