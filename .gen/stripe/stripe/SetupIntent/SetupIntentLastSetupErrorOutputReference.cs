using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiClass(nativeType: typeof(stripe.SetupIntent.SetupIntentLastSetupErrorOutputReference), fullyQualifiedName: "stripe.setupIntent.SetupIntentLastSetupErrorOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SetupIntentLastSetupErrorOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SetupIntentLastSetupErrorOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SetupIntentLastSetupErrorOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SetupIntentLastSetupErrorOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "adviceCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdviceCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "charge", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Charge
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Code
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "declineCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeclineCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "docUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DocUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Message
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkAdviceCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkAdviceCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkDeclineCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkDeclineCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "param", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Param
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "paymentIntent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentIntent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "paymentMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "paymentMethodType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentMethodType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestLogUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestLogUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "setupIntent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SetupIntent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Source
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentLastSetupError\"}", isOptional: true)]
        public virtual stripe.SetupIntent.ISetupIntentLastSetupError? InternalValue
        {
            get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentLastSetupError?>();
            set => SetInstanceProperty(value);
        }
    }
}
