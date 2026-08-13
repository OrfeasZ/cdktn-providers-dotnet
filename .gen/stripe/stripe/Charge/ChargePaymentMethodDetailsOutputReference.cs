using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Charge
{
    [JsiiClass(nativeType: typeof(stripe.Charge.ChargePaymentMethodDetailsOutputReference), fullyQualifiedName: "stripe.charge.ChargePaymentMethodDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ChargePaymentMethodDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ChargePaymentMethodDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ChargePaymentMethodDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ChargePaymentMethodDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "achCreditTransfer", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsAchCreditTransferOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsAchCreditTransferOutputReference AchCreditTransfer
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsAchCreditTransferOutputReference>()!;
        }

        [JsiiProperty(name: "achDebit", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsAchDebitOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsAchDebitOutputReference AchDebit
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsAchDebitOutputReference>()!;
        }

        [JsiiProperty(name: "acssDebit", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsAcssDebitOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsAcssDebitOutputReference AcssDebit
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsAcssDebitOutputReference>()!;
        }

        [JsiiProperty(name: "affirm", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsAffirmOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsAffirmOutputReference Affirm
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsAffirmOutputReference>()!;
        }

        [JsiiProperty(name: "afterpayClearpay", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsAfterpayClearpayOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsAfterpayClearpayOutputReference AfterpayClearpay
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsAfterpayClearpayOutputReference>()!;
        }

        [JsiiProperty(name: "alipay", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsAlipayOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsAlipayOutputReference Alipay
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsAlipayOutputReference>()!;
        }

        [JsiiProperty(name: "alma", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsAlmaOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsAlmaOutputReference Alma
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsAlmaOutputReference>()!;
        }

        [JsiiProperty(name: "amazonPay", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsAmazonPayOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsAmazonPayOutputReference AmazonPay
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsAmazonPayOutputReference>()!;
        }

        [JsiiProperty(name: "auBecsDebit", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsAuBecsDebitOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsAuBecsDebitOutputReference AuBecsDebit
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsAuBecsDebitOutputReference>()!;
        }

        [JsiiProperty(name: "bacsDebit", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsBacsDebitOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsBacsDebitOutputReference BacsDebit
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsBacsDebitOutputReference>()!;
        }

        [JsiiProperty(name: "bancontact", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsBancontactOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsBancontactOutputReference Bancontact
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsBancontactOutputReference>()!;
        }

        [JsiiProperty(name: "billie", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsBillieOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsBillieOutputReference Billie
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsBillieOutputReference>()!;
        }

        [JsiiProperty(name: "bizum", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsBizumOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsBizumOutputReference Bizum
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsBizumOutputReference>()!;
        }

        [JsiiProperty(name: "blik", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsBlikOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsBlikOutputReference Blik
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsBlikOutputReference>()!;
        }

        [JsiiProperty(name: "boleto", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsBoletoOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsBoletoOutputReference Boleto
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsBoletoOutputReference>()!;
        }

        [JsiiProperty(name: "card", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCardOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsCardOutputReference Card
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsCardOutputReference>()!;
        }

        [JsiiProperty(name: "cardPresent", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCardPresentOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsCardPresentOutputReference CardPresent
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsCardPresentOutputReference>()!;
        }

        [JsiiProperty(name: "cashapp", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCashappOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsCashappOutputReference Cashapp
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsCashappOutputReference>()!;
        }

        [JsiiProperty(name: "crypto", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCryptoOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsCryptoOutputReference Crypto
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsCryptoOutputReference>()!;
        }

        [JsiiProperty(name: "eps", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsEpsOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsEpsOutputReference Eps
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsEpsOutputReference>()!;
        }

        [JsiiProperty(name: "fpx", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsFpxOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsFpxOutputReference Fpx
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsFpxOutputReference>()!;
        }

        [JsiiProperty(name: "giropay", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsGiropayOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsGiropayOutputReference Giropay
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsGiropayOutputReference>()!;
        }

        [JsiiProperty(name: "grabpay", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsGrabpayOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsGrabpayOutputReference Grabpay
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsGrabpayOutputReference>()!;
        }

        [JsiiProperty(name: "ideal", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsIdealOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsIdealOutputReference Ideal
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsIdealOutputReference>()!;
        }

        [JsiiProperty(name: "interacPresent", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsInteracPresentOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsInteracPresentOutputReference InteracPresent
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsInteracPresentOutputReference>()!;
        }

        [JsiiProperty(name: "kakaoPay", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsKakaoPayOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsKakaoPayOutputReference KakaoPay
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsKakaoPayOutputReference>()!;
        }

        [JsiiProperty(name: "klarna", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsKlarnaOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsKlarnaOutputReference Klarna
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsKlarnaOutputReference>()!;
        }

        [JsiiProperty(name: "konbini", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsKonbiniOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsKonbiniOutputReference Konbini
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsKonbiniOutputReference>()!;
        }

        [JsiiProperty(name: "krCard", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsKrCardOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsKrCardOutputReference KrCard
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsKrCardOutputReference>()!;
        }

        [JsiiProperty(name: "link", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsLinkOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsLinkOutputReference Link
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsLinkOutputReference>()!;
        }

        [JsiiProperty(name: "mobilepay", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsMobilepayOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsMobilepayOutputReference Mobilepay
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsMobilepayOutputReference>()!;
        }

        [JsiiProperty(name: "multibanco", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsMultibancoOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsMultibancoOutputReference Multibanco
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsMultibancoOutputReference>()!;
        }

        [JsiiProperty(name: "naverPay", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsNaverPayOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsNaverPayOutputReference NaverPay
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsNaverPayOutputReference>()!;
        }

        [JsiiProperty(name: "nzBankAccount", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsNzBankAccountOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsNzBankAccountOutputReference NzBankAccount
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsNzBankAccountOutputReference>()!;
        }

        [JsiiProperty(name: "oxxo", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsOxxoOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsOxxoOutputReference Oxxo
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsOxxoOutputReference>()!;
        }

        [JsiiProperty(name: "p24", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsP24OutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsP24OutputReference P24
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsP24OutputReference>()!;
        }

        [JsiiProperty(name: "payco", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsPaycoOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsPaycoOutputReference Payco
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsPaycoOutputReference>()!;
        }

        [JsiiProperty(name: "paynow", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsPaynowOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsPaynowOutputReference Paynow
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsPaynowOutputReference>()!;
        }

        [JsiiProperty(name: "paypal", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsPaypalOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsPaypalOutputReference Paypal
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsPaypalOutputReference>()!;
        }

        [JsiiProperty(name: "payto", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsPaytoOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsPaytoOutputReference Payto
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsPaytoOutputReference>()!;
        }

        [JsiiProperty(name: "pix", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsPixOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsPixOutputReference Pix
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsPixOutputReference>()!;
        }

        [JsiiProperty(name: "promptpay", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsPromptpayOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsPromptpayOutputReference Promptpay
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsPromptpayOutputReference>()!;
        }

        [JsiiProperty(name: "revolutPay", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsRevolutPayOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsRevolutPayOutputReference RevolutPay
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsRevolutPayOutputReference>()!;
        }

        [JsiiProperty(name: "samsungPay", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsSamsungPayOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsSamsungPayOutputReference SamsungPay
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsSamsungPayOutputReference>()!;
        }

        [JsiiProperty(name: "satispay", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsSatispayOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsSatispayOutputReference Satispay
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsSatispayOutputReference>()!;
        }

        [JsiiProperty(name: "scalapay", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsScalapayOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsScalapayOutputReference Scalapay
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsScalapayOutputReference>()!;
        }

        [JsiiProperty(name: "sepaCreditTransfer", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsSepaCreditTransferOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsSepaCreditTransferOutputReference SepaCreditTransfer
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsSepaCreditTransferOutputReference>()!;
        }

        [JsiiProperty(name: "sepaDebit", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsSepaDebitOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsSepaDebitOutputReference SepaDebit
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsSepaDebitOutputReference>()!;
        }

        [JsiiProperty(name: "sofort", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsSofortOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsSofortOutputReference Sofort
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsSofortOutputReference>()!;
        }

        [JsiiProperty(name: "sunbit", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsSunbitOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsSunbitOutputReference Sunbit
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsSunbitOutputReference>()!;
        }

        [JsiiProperty(name: "swish", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsSwishOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsSwishOutputReference Swish
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsSwishOutputReference>()!;
        }

        [JsiiProperty(name: "twint", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsTwintOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsTwintOutputReference Twint
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsTwintOutputReference>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "upi", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsUpiOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsUpiOutputReference Upi
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsUpiOutputReference>()!;
        }

        [JsiiProperty(name: "usBankAccount", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsUsBankAccountOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsUsBankAccountOutputReference UsBankAccount
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsUsBankAccountOutputReference>()!;
        }

        [JsiiProperty(name: "wechatPay", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsWechatPayOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsWechatPayOutputReference WechatPay
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsWechatPayOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetails\"}", isOptional: true)]
        public virtual stripe.Charge.IChargePaymentMethodDetails? InternalValue
        {
            get => GetInstanceProperty<stripe.Charge.IChargePaymentMethodDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
