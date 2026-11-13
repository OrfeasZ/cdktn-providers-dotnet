using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiClass(nativeType: typeof(stripe.SubscriptionSchedule.SubscriptionSchedulePauseSchedulesResumeStatusErrorOutputReference), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesResumeStatusErrorOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SubscriptionSchedulePauseSchedulesResumeStatusErrorOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SubscriptionSchedulePauseSchedulesResumeStatusErrorOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SubscriptionSchedulePauseSchedulesResumeStatusErrorOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SubscriptionSchedulePauseSchedulesResumeStatusErrorOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Code
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Message
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePauseSchedulesResumeStatusError\"}", isOptional: true)]
        public virtual stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesResumeStatusError? InternalValue
        {
            get => GetInstanceProperty<stripe.SubscriptionSchedule.ISubscriptionSchedulePauseSchedulesResumeStatusError?>();
            set => SetInstanceProperty(value);
        }
    }
}
