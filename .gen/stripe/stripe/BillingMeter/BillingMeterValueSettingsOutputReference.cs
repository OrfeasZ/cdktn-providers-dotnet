using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingMeter
{
    [JsiiClass(nativeType: typeof(stripe.BillingMeter.BillingMeterValueSettingsOutputReference), fullyQualifiedName: "stripe.billingMeter.BillingMeterValueSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BillingMeterValueSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BillingMeterValueSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BillingMeterValueSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BillingMeterValueSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEventPayloadKey")]
        public virtual void ResetEventPayloadKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventPayloadKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventPayloadKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "eventPayloadKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventPayloadKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.billingMeter.BillingMeterValueSettings\"}", isOptional: true)]
        public virtual stripe.BillingMeter.IBillingMeterValueSettings? InternalValue
        {
            get => GetInstanceProperty<stripe.BillingMeter.IBillingMeterValueSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
