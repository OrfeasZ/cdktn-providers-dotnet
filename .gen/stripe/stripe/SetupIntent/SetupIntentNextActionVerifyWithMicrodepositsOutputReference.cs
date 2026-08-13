using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiClass(nativeType: typeof(stripe.SetupIntent.SetupIntentNextActionVerifyWithMicrodepositsOutputReference), fullyQualifiedName: "stripe.setupIntent.SetupIntentNextActionVerifyWithMicrodepositsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SetupIntentNextActionVerifyWithMicrodepositsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SetupIntentNextActionVerifyWithMicrodepositsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SetupIntentNextActionVerifyWithMicrodepositsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SetupIntentNextActionVerifyWithMicrodepositsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "arrivalDate", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ArrivalDate
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "hostedVerificationUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostedVerificationUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "microdepositType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MicrodepositType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentNextActionVerifyWithMicrodeposits\"}", isOptional: true)]
        public virtual stripe.SetupIntent.ISetupIntentNextActionVerifyWithMicrodeposits? InternalValue
        {
            get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentNextActionVerifyWithMicrodeposits?>();
            set => SetInstanceProperty(value);
        }
    }
}
