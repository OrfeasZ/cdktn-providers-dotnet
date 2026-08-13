using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiClass(nativeType: typeof(stripe.SetupIntent.SetupIntentNextActionOutputReference), fullyQualifiedName: "stripe.setupIntent.SetupIntentNextActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SetupIntentNextActionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SetupIntentNextActionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SetupIntentNextActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SetupIntentNextActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "cashappHandleRedirectOrDisplayQrCode", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentNextActionCashappHandleRedirectOrDisplayQrCodeOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentNextActionCashappHandleRedirectOrDisplayQrCodeOutputReference CashappHandleRedirectOrDisplayQrCode
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentNextActionCashappHandleRedirectOrDisplayQrCodeOutputReference>()!;
        }

        [JsiiProperty(name: "pixDisplayQrCode", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentNextActionPixDisplayQrCodeOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentNextActionPixDisplayQrCodeOutputReference PixDisplayQrCode
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentNextActionPixDisplayQrCodeOutputReference>()!;
        }

        [JsiiProperty(name: "redirectToUrl", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentNextActionRedirectToUrlOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentNextActionRedirectToUrlOutputReference RedirectToUrl
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentNextActionRedirectToUrlOutputReference>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "upiHandleRedirectOrDisplayQrCode", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentNextActionUpiHandleRedirectOrDisplayQrCodeOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentNextActionUpiHandleRedirectOrDisplayQrCodeOutputReference UpiHandleRedirectOrDisplayQrCode
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentNextActionUpiHandleRedirectOrDisplayQrCodeOutputReference>()!;
        }

        [JsiiProperty(name: "useStripeSdk", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap UseStripeSdk
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "verifyWithMicrodeposits", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentNextActionVerifyWithMicrodepositsOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentNextActionVerifyWithMicrodepositsOutputReference VerifyWithMicrodeposits
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentNextActionVerifyWithMicrodepositsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentNextAction\"}", isOptional: true)]
        public virtual stripe.SetupIntent.ISetupIntentNextAction? InternalValue
        {
            get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentNextAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
