using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiClass(nativeType: typeof(stripe.PaymentIntent.PaymentIntentNextActionOutputReference), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentNextActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentIntentNextActionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentIntentNextActionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentIntentNextActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentIntentNextActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "alipayHandleRedirect", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionAlipayHandleRedirectOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionAlipayHandleRedirectOutputReference AlipayHandleRedirect
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionAlipayHandleRedirectOutputReference>()!;
        }

        [JsiiProperty(name: "boletoDisplayDetails", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionBoletoDisplayDetailsOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionBoletoDisplayDetailsOutputReference BoletoDisplayDetails
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionBoletoDisplayDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "cardAwaitNotification", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionCardAwaitNotificationOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionCardAwaitNotificationOutputReference CardAwaitNotification
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionCardAwaitNotificationOutputReference>()!;
        }

        [JsiiProperty(name: "cashappHandleRedirectOrDisplayQrCode", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionCashappHandleRedirectOrDisplayQrCodeOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionCashappHandleRedirectOrDisplayQrCodeOutputReference CashappHandleRedirectOrDisplayQrCode
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionCashappHandleRedirectOrDisplayQrCodeOutputReference>()!;
        }

        [JsiiProperty(name: "displayBankTransferInstructions", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionDisplayBankTransferInstructionsOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionDisplayBankTransferInstructionsOutputReference DisplayBankTransferInstructions
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionDisplayBankTransferInstructionsOutputReference>()!;
        }

        [JsiiProperty(name: "klarnaDisplayQrCode", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionKlarnaDisplayQrCodeOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionKlarnaDisplayQrCodeOutputReference KlarnaDisplayQrCode
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionKlarnaDisplayQrCodeOutputReference>()!;
        }

        [JsiiProperty(name: "konbiniDisplayDetails", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionKonbiniDisplayDetailsOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionKonbiniDisplayDetailsOutputReference KonbiniDisplayDetails
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionKonbiniDisplayDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "multibancoDisplayDetails", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionMultibancoDisplayDetailsOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionMultibancoDisplayDetailsOutputReference MultibancoDisplayDetails
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionMultibancoDisplayDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "oxxoDisplayDetails", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionOxxoDisplayDetailsOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionOxxoDisplayDetailsOutputReference OxxoDisplayDetails
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionOxxoDisplayDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "paynowDisplayQrCode", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionPaynowDisplayQrCodeOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionPaynowDisplayQrCodeOutputReference PaynowDisplayQrCode
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionPaynowDisplayQrCodeOutputReference>()!;
        }

        [JsiiProperty(name: "pixDisplayQrCode", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionPixDisplayQrCodeOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionPixDisplayQrCodeOutputReference PixDisplayQrCode
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionPixDisplayQrCodeOutputReference>()!;
        }

        [JsiiProperty(name: "promptpayDisplayQrCode", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionPromptpayDisplayQrCodeOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionPromptpayDisplayQrCodeOutputReference PromptpayDisplayQrCode
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionPromptpayDisplayQrCodeOutputReference>()!;
        }

        [JsiiProperty(name: "redirectToUrl", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionRedirectToUrlOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionRedirectToUrlOutputReference RedirectToUrl
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionRedirectToUrlOutputReference>()!;
        }

        [JsiiProperty(name: "swishHandleRedirectOrDisplayQrCode", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionSwishHandleRedirectOrDisplayQrCodeOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionSwishHandleRedirectOrDisplayQrCodeOutputReference SwishHandleRedirectOrDisplayQrCode
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionSwishHandleRedirectOrDisplayQrCodeOutputReference>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "upiHandleRedirectOrDisplayQrCode", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionUpiHandleRedirectOrDisplayQrCodeOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionUpiHandleRedirectOrDisplayQrCodeOutputReference UpiHandleRedirectOrDisplayQrCode
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionUpiHandleRedirectOrDisplayQrCodeOutputReference>()!;
        }

        [JsiiProperty(name: "useStripeSdk", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap UseStripeSdk
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "verifyWithMicrodeposits", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionVerifyWithMicrodepositsOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionVerifyWithMicrodepositsOutputReference VerifyWithMicrodeposits
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionVerifyWithMicrodepositsOutputReference>()!;
        }

        [JsiiProperty(name: "wechatPayDisplayQrCode", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionWechatPayDisplayQrCodeOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionWechatPayDisplayQrCodeOutputReference WechatPayDisplayQrCode
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionWechatPayDisplayQrCodeOutputReference>()!;
        }

        [JsiiProperty(name: "wechatPayRedirectToAndroidApp", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionWechatPayRedirectToAndroidAppOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionWechatPayRedirectToAndroidAppOutputReference WechatPayRedirectToAndroidApp
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionWechatPayRedirectToAndroidAppOutputReference>()!;
        }

        [JsiiProperty(name: "wechatPayRedirectToIosApp", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionWechatPayRedirectToIosAppOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionWechatPayRedirectToIosAppOutputReference WechatPayRedirectToIosApp
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionWechatPayRedirectToIosAppOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextAction\"}", isOptional: true)]
        public virtual stripe.PaymentIntent.IPaymentIntentNextAction? InternalValue
        {
            get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentNextAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
