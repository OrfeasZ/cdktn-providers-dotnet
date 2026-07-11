using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Eventhub
{
    [JsiiClass(nativeType: typeof(azurerm.Eventhub.EventhubRetentionDescriptionOutputReference), fullyQualifiedName: "azurerm.eventhub.EventhubRetentionDescriptionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EventhubRetentionDescriptionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EventhubRetentionDescriptionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EventhubRetentionDescriptionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EventhubRetentionDescriptionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetRetentionTimeInHours")]
        public virtual void ResetRetentionTimeInHours()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTombstoneRetentionTimeInHours")]
        public virtual void ResetTombstoneRetentionTimeInHours()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "cleanupPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CleanupPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionTimeInHoursInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RetentionTimeInHoursInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tombstoneRetentionTimeInHoursInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TombstoneRetentionTimeInHoursInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "cleanupPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CleanupPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retentionTimeInHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetentionTimeInHours
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tombstoneRetentionTimeInHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TombstoneRetentionTimeInHours
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.eventhub.EventhubRetentionDescription\"}", isOptional: true)]
        public virtual azurerm.Eventhub.IEventhubRetentionDescription? InternalValue
        {
            get => GetInstanceProperty<azurerm.Eventhub.IEventhubRetentionDescription?>();
            set => SetInstanceProperty(value);
        }
    }
}
