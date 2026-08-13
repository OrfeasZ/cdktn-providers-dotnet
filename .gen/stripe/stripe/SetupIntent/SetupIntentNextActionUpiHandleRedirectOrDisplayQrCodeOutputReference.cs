using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiClass(nativeType: typeof(stripe.SetupIntent.SetupIntentNextActionUpiHandleRedirectOrDisplayQrCodeOutputReference), fullyQualifiedName: "stripe.setupIntent.SetupIntentNextActionUpiHandleRedirectOrDisplayQrCodeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SetupIntentNextActionUpiHandleRedirectOrDisplayQrCodeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SetupIntentNextActionUpiHandleRedirectOrDisplayQrCodeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SetupIntentNextActionUpiHandleRedirectOrDisplayQrCodeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SetupIntentNextActionUpiHandleRedirectOrDisplayQrCodeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "hostedInstructionsUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostedInstructionsUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "qrCode", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentNextActionUpiHandleRedirectOrDisplayQrCodeQrCodeOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentNextActionUpiHandleRedirectOrDisplayQrCodeQrCodeOutputReference QrCode
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentNextActionUpiHandleRedirectOrDisplayQrCodeQrCodeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentNextActionUpiHandleRedirectOrDisplayQrCode\"}", isOptional: true)]
        public virtual stripe.SetupIntent.ISetupIntentNextActionUpiHandleRedirectOrDisplayQrCode? InternalValue
        {
            get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentNextActionUpiHandleRedirectOrDisplayQrCode?>();
            set => SetInstanceProperty(value);
        }
    }
}
