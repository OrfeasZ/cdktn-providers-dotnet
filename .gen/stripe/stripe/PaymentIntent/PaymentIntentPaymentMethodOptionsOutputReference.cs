using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiClass(nativeType: typeof(stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsOutputReference), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentIntentPaymentMethodOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentIntentPaymentMethodOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentIntentPaymentMethodOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentIntentPaymentMethodOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAcssDebit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsAcssDebit\"}}]")]
        public virtual void PutAcssDebit(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsAcssDebit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsAcssDebit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAffirm", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsAffirm\"}}]")]
        public virtual void PutAffirm(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsAffirm @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsAffirm)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAfterpayClearpay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsAfterpayClearpay\"}}]")]
        public virtual void PutAfterpayClearpay(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsAfterpayClearpay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsAfterpayClearpay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAlipay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsAlipay\"}}]")]
        public virtual void PutAlipay(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsAlipay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsAlipay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAlma", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsAlma\"}}]")]
        public virtual void PutAlma(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsAlma @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsAlma)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAmazonPay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsAmazonPay\"}}]")]
        public virtual void PutAmazonPay(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsAmazonPay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsAmazonPay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuBecsDebit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsAuBecsDebit\"}}]")]
        public virtual void PutAuBecsDebit(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsAuBecsDebit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsAuBecsDebit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBacsDebit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBacsDebit\"}}]")]
        public virtual void PutBacsDebit(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBacsDebit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBacsDebit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBancontact", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBancontact\"}}]")]
        public virtual void PutBancontact(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBancontact @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBancontact)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBillie", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBillie\"}}]")]
        public virtual void PutBillie(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBillie @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBillie)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBlik", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBlik\"}}]")]
        public virtual void PutBlik(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBlik @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBlik)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBoleto", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBoleto\"}}]")]
        public virtual void PutBoleto(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBoleto @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBoleto)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCard", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCard\"}}]")]
        public virtual void PutCard(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCard @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCard)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCardPresent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardPresent\"}}]")]
        public virtual void PutCardPresent(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardPresent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardPresent)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCashapp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCashapp\"}}]")]
        public virtual void PutCashapp(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCashapp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCashapp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCrypto", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCrypto\"}}]")]
        public virtual void PutCrypto(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCrypto @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCrypto)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomerBalance", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCustomerBalance\"}}]")]
        public virtual void PutCustomerBalance(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCustomerBalance @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCustomerBalance)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEps", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsEps\"}}]")]
        public virtual void PutEps(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsEps @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsEps)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFpx", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsFpx\"}}]")]
        public virtual void PutFpx(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsFpx @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsFpx)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGiropay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsGiropay\"}}]")]
        public virtual void PutGiropay(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsGiropay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsGiropay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGrabpay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsGrabpay\"}}]")]
        public virtual void PutGrabpay(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsGrabpay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsGrabpay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdeal", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsIdeal\"}}]")]
        public virtual void PutIdeal(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsIdeal @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsIdeal)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKakaoPay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKakaoPay\"}}]")]
        public virtual void PutKakaoPay(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsKakaoPay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsKakaoPay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKlarna", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKlarna\"}}]")]
        public virtual void PutKlarna(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsKlarna @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsKlarna)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKonbini", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKonbini\"}}]")]
        public virtual void PutKonbini(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsKonbini @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsKonbini)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKrCard", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKrCard\"}}]")]
        public virtual void PutKrCard(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsKrCard @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsKrCard)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMbWay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsMbWay\"}}]")]
        public virtual void PutMbWay(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsMbWay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsMbWay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMobilepay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsMobilepay\"}}]")]
        public virtual void PutMobilepay(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsMobilepay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsMobilepay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMultibanco", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsMultibanco\"}}]")]
        public virtual void PutMultibanco(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsMultibanco @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsMultibanco)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNaverPay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsNaverPay\"}}]")]
        public virtual void PutNaverPay(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsNaverPay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsNaverPay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNzBankAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsNzBankAccount\"}}]")]
        public virtual void PutNzBankAccount(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsNzBankAccount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsNzBankAccount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOxxo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsOxxo\"}}]")]
        public virtual void PutOxxo(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsOxxo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsOxxo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putP24", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsP24\"}}]")]
        public virtual void PutP24(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsP24 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsP24)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPayco", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsPayco\"}}]")]
        public virtual void PutPayco(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsPayco @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsPayco)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPaynow", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsPaynow\"}}]")]
        public virtual void PutPaynow(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsPaynow @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsPaynow)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPaypal", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsPaypal\"}}]")]
        public virtual void PutPaypal(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsPaypal @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsPaypal)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPayto", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsPayto\"}}]")]
        public virtual void PutPayto(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsPayto @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsPayto)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPix", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsPix\"}}]")]
        public virtual void PutPix(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsPix @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsPix)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPromptpay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsPromptpay\"}}]")]
        public virtual void PutPromptpay(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsPromptpay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsPromptpay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRevolutPay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsRevolutPay\"}}]")]
        public virtual void PutRevolutPay(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsRevolutPay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsRevolutPay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSamsungPay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsSamsungPay\"}}]")]
        public virtual void PutSamsungPay(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsSamsungPay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsSamsungPay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSatispay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsSatispay\"}}]")]
        public virtual void PutSatispay(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsSatispay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsSatispay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScalapay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsScalapay\"}}]")]
        public virtual void PutScalapay(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsScalapay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsScalapay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSepaDebit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsSepaDebit\"}}]")]
        public virtual void PutSepaDebit(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsSepaDebit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsSepaDebit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSofort", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsSofort\"}}]")]
        public virtual void PutSofort(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsSofort @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsSofort)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSwish", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsSwish\"}}]")]
        public virtual void PutSwish(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsSwish @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsSwish)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTwint", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsTwint\"}}]")]
        public virtual void PutTwint(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsTwint @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsTwint)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpi", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsUpi\"}}]")]
        public virtual void PutUpi(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsUpi @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsUpi)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUsBankAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsUsBankAccount\"}}]")]
        public virtual void PutUsBankAccount(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsUsBankAccount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsUsBankAccount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWechatPay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsWechatPay\"}}]")]
        public virtual void PutWechatPay(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsWechatPay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsWechatPay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putZip", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsZip\"}}]")]
        public virtual void PutZip(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsZip @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsZip)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcssDebit")]
        public virtual void ResetAcssDebit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAffirm")]
        public virtual void ResetAffirm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAfterpayClearpay")]
        public virtual void ResetAfterpayClearpay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAlipay")]
        public virtual void ResetAlipay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAlma")]
        public virtual void ResetAlma()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAmazonPay")]
        public virtual void ResetAmazonPay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuBecsDebit")]
        public virtual void ResetAuBecsDebit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBacsDebit")]
        public virtual void ResetBacsDebit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBancontact")]
        public virtual void ResetBancontact()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBillie")]
        public virtual void ResetBillie()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlik")]
        public virtual void ResetBlik()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBoleto")]
        public virtual void ResetBoleto()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCard")]
        public virtual void ResetCard()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCardPresent")]
        public virtual void ResetCardPresent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCashapp")]
        public virtual void ResetCashapp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCrypto")]
        public virtual void ResetCrypto()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomerBalance")]
        public virtual void ResetCustomerBalance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEps")]
        public virtual void ResetEps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFpx")]
        public virtual void ResetFpx()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGiropay")]
        public virtual void ResetGiropay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGrabpay")]
        public virtual void ResetGrabpay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdeal")]
        public virtual void ResetIdeal()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKakaoPay")]
        public virtual void ResetKakaoPay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKlarna")]
        public virtual void ResetKlarna()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKonbini")]
        public virtual void ResetKonbini()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKrCard")]
        public virtual void ResetKrCard()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMbWay")]
        public virtual void ResetMbWay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMobilepay")]
        public virtual void ResetMobilepay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMultibanco")]
        public virtual void ResetMultibanco()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNaverPay")]
        public virtual void ResetNaverPay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNzBankAccount")]
        public virtual void ResetNzBankAccount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOxxo")]
        public virtual void ResetOxxo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetP24")]
        public virtual void ResetP24()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPayco")]
        public virtual void ResetPayco()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPaynow")]
        public virtual void ResetPaynow()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPaypal")]
        public virtual void ResetPaypal()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPayto")]
        public virtual void ResetPayto()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPix")]
        public virtual void ResetPix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPromptpay")]
        public virtual void ResetPromptpay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRevolutPay")]
        public virtual void ResetRevolutPay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSamsungPay")]
        public virtual void ResetSamsungPay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSatispay")]
        public virtual void ResetSatispay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScalapay")]
        public virtual void ResetScalapay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSepaDebit")]
        public virtual void ResetSepaDebit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSofort")]
        public virtual void ResetSofort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSwish")]
        public virtual void ResetSwish()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTwint")]
        public virtual void ResetTwint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpi")]
        public virtual void ResetUpi()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsBankAccount")]
        public virtual void ResetUsBankAccount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWechatPay")]
        public virtual void ResetWechatPay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZip")]
        public virtual void ResetZip()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "acssDebit", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsAcssDebitOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsAcssDebitOutputReference AcssDebit
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsAcssDebitOutputReference>()!;
        }

        [JsiiProperty(name: "affirm", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsAffirmOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsAffirmOutputReference Affirm
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsAffirmOutputReference>()!;
        }

        [JsiiProperty(name: "afterpayClearpay", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsAfterpayClearpayOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsAfterpayClearpayOutputReference AfterpayClearpay
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsAfterpayClearpayOutputReference>()!;
        }

        [JsiiProperty(name: "alipay", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsAlipayOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsAlipayOutputReference Alipay
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsAlipayOutputReference>()!;
        }

        [JsiiProperty(name: "alma", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsAlmaOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsAlmaOutputReference Alma
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsAlmaOutputReference>()!;
        }

        [JsiiProperty(name: "amazonPay", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsAmazonPayOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsAmazonPayOutputReference AmazonPay
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsAmazonPayOutputReference>()!;
        }

        [JsiiProperty(name: "auBecsDebit", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsAuBecsDebitOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsAuBecsDebitOutputReference AuBecsDebit
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsAuBecsDebitOutputReference>()!;
        }

        [JsiiProperty(name: "bacsDebit", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBacsDebitOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsBacsDebitOutputReference BacsDebit
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsBacsDebitOutputReference>()!;
        }

        [JsiiProperty(name: "bancontact", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBancontactOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsBancontactOutputReference Bancontact
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsBancontactOutputReference>()!;
        }

        [JsiiProperty(name: "billie", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBillieOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsBillieOutputReference Billie
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsBillieOutputReference>()!;
        }

        [JsiiProperty(name: "blik", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBlikOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsBlikOutputReference Blik
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsBlikOutputReference>()!;
        }

        [JsiiProperty(name: "boleto", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBoletoOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsBoletoOutputReference Boleto
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsBoletoOutputReference>()!;
        }

        [JsiiProperty(name: "card", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsCardOutputReference Card
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsCardOutputReference>()!;
        }

        [JsiiProperty(name: "cardPresent", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardPresentOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsCardPresentOutputReference CardPresent
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsCardPresentOutputReference>()!;
        }

        [JsiiProperty(name: "cashapp", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCashappOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsCashappOutputReference Cashapp
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsCashappOutputReference>()!;
        }

        [JsiiProperty(name: "crypto", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCryptoOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsCryptoOutputReference Crypto
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsCryptoOutputReference>()!;
        }

        [JsiiProperty(name: "customerBalance", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCustomerBalanceOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsCustomerBalanceOutputReference CustomerBalance
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsCustomerBalanceOutputReference>()!;
        }

        [JsiiProperty(name: "eps", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsEpsOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsEpsOutputReference Eps
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsEpsOutputReference>()!;
        }

        [JsiiProperty(name: "fpx", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsFpxOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsFpxOutputReference Fpx
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsFpxOutputReference>()!;
        }

        [JsiiProperty(name: "giropay", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsGiropayOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsGiropayOutputReference Giropay
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsGiropayOutputReference>()!;
        }

        [JsiiProperty(name: "grabpay", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsGrabpayOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsGrabpayOutputReference Grabpay
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsGrabpayOutputReference>()!;
        }

        [JsiiProperty(name: "ideal", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsIdealOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsIdealOutputReference Ideal
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsIdealOutputReference>()!;
        }

        [JsiiProperty(name: "kakaoPay", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKakaoPayOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsKakaoPayOutputReference KakaoPay
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsKakaoPayOutputReference>()!;
        }

        [JsiiProperty(name: "klarna", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKlarnaOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsKlarnaOutputReference Klarna
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsKlarnaOutputReference>()!;
        }

        [JsiiProperty(name: "konbini", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKonbiniOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsKonbiniOutputReference Konbini
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsKonbiniOutputReference>()!;
        }

        [JsiiProperty(name: "krCard", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKrCardOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsKrCardOutputReference KrCard
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsKrCardOutputReference>()!;
        }

        [JsiiProperty(name: "mbWay", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsMbWayOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsMbWayOutputReference MbWay
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsMbWayOutputReference>()!;
        }

        [JsiiProperty(name: "mobilepay", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsMobilepayOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsMobilepayOutputReference Mobilepay
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsMobilepayOutputReference>()!;
        }

        [JsiiProperty(name: "multibanco", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsMultibancoOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsMultibancoOutputReference Multibanco
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsMultibancoOutputReference>()!;
        }

        [JsiiProperty(name: "naverPay", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsNaverPayOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsNaverPayOutputReference NaverPay
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsNaverPayOutputReference>()!;
        }

        [JsiiProperty(name: "nzBankAccount", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsNzBankAccountOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsNzBankAccountOutputReference NzBankAccount
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsNzBankAccountOutputReference>()!;
        }

        [JsiiProperty(name: "oxxo", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsOxxoOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsOxxoOutputReference Oxxo
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsOxxoOutputReference>()!;
        }

        [JsiiProperty(name: "p24", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsP24OutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsP24OutputReference P24
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsP24OutputReference>()!;
        }

        [JsiiProperty(name: "payco", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsPaycoOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsPaycoOutputReference Payco
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsPaycoOutputReference>()!;
        }

        [JsiiProperty(name: "paynow", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsPaynowOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsPaynowOutputReference Paynow
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsPaynowOutputReference>()!;
        }

        [JsiiProperty(name: "paypal", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsPaypalOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsPaypalOutputReference Paypal
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsPaypalOutputReference>()!;
        }

        [JsiiProperty(name: "payto", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsPaytoOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsPaytoOutputReference Payto
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsPaytoOutputReference>()!;
        }

        [JsiiProperty(name: "pix", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsPixOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsPixOutputReference Pix
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsPixOutputReference>()!;
        }

        [JsiiProperty(name: "promptpay", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsPromptpayOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsPromptpayOutputReference Promptpay
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsPromptpayOutputReference>()!;
        }

        [JsiiProperty(name: "revolutPay", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsRevolutPayOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsRevolutPayOutputReference RevolutPay
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsRevolutPayOutputReference>()!;
        }

        [JsiiProperty(name: "samsungPay", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsSamsungPayOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsSamsungPayOutputReference SamsungPay
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsSamsungPayOutputReference>()!;
        }

        [JsiiProperty(name: "satispay", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsSatispayOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsSatispayOutputReference Satispay
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsSatispayOutputReference>()!;
        }

        [JsiiProperty(name: "scalapay", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsScalapayOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsScalapayOutputReference Scalapay
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsScalapayOutputReference>()!;
        }

        [JsiiProperty(name: "sepaDebit", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsSepaDebitOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsSepaDebitOutputReference SepaDebit
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsSepaDebitOutputReference>()!;
        }

        [JsiiProperty(name: "sofort", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsSofortOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsSofortOutputReference Sofort
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsSofortOutputReference>()!;
        }

        [JsiiProperty(name: "swish", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsSwishOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsSwishOutputReference Swish
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsSwishOutputReference>()!;
        }

        [JsiiProperty(name: "twint", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsTwintOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsTwintOutputReference Twint
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsTwintOutputReference>()!;
        }

        [JsiiProperty(name: "upi", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsUpiOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsUpiOutputReference Upi
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsUpiOutputReference>()!;
        }

        [JsiiProperty(name: "usBankAccount", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsUsBankAccountOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsUsBankAccountOutputReference UsBankAccount
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsUsBankAccountOutputReference>()!;
        }

        [JsiiProperty(name: "wechatPay", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsWechatPayOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsWechatPayOutputReference WechatPay
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsWechatPayOutputReference>()!;
        }

        [JsiiProperty(name: "zip", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsZipOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsZipOutputReference Zip
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsZipOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsAcssDebit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acssDebitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsAcssDebit\"}]}}", isOptional: true)]
        public virtual object? AcssDebitInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsAffirm" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "affirmInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsAffirm\"}]}}", isOptional: true)]
        public virtual object? AffirmInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsAfterpayClearpay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "afterpayClearpayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsAfterpayClearpay\"}]}}", isOptional: true)]
        public virtual object? AfterpayClearpayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsAlipay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alipayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsAlipay\"}]}}", isOptional: true)]
        public virtual object? AlipayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsAlma" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "almaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsAlma\"}]}}", isOptional: true)]
        public virtual object? AlmaInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsAmazonPay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amazonPayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsAmazonPay\"}]}}", isOptional: true)]
        public virtual object? AmazonPayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsAuBecsDebit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "auBecsDebitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsAuBecsDebit\"}]}}", isOptional: true)]
        public virtual object? AuBecsDebitInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBacsDebit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bacsDebitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBacsDebit\"}]}}", isOptional: true)]
        public virtual object? BacsDebitInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBancontact" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bancontactInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBancontact\"}]}}", isOptional: true)]
        public virtual object? BancontactInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBillie" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billieInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBillie\"}]}}", isOptional: true)]
        public virtual object? BillieInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBlik" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blikInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBlik\"}]}}", isOptional: true)]
        public virtual object? BlikInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsBoleto" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "boletoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsBoleto\"}]}}", isOptional: true)]
        public virtual object? BoletoInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCard" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cardInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCard\"}]}}", isOptional: true)]
        public virtual object? CardInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCardPresent" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cardPresentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCardPresent\"}]}}", isOptional: true)]
        public virtual object? CardPresentInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCashapp" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cashappInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCashapp\"}]}}", isOptional: true)]
        public virtual object? CashappInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCrypto" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cryptoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCrypto\"}]}}", isOptional: true)]
        public virtual object? CryptoInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsCustomerBalance" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customerBalanceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsCustomerBalance\"}]}}", isOptional: true)]
        public virtual object? CustomerBalanceInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsEps" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "epsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsEps\"}]}}", isOptional: true)]
        public virtual object? EpsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsFpx" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fpxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsFpx\"}]}}", isOptional: true)]
        public virtual object? FpxInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsGiropay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "giropayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsGiropay\"}]}}", isOptional: true)]
        public virtual object? GiropayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsGrabpay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grabpayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsGrabpay\"}]}}", isOptional: true)]
        public virtual object? GrabpayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsIdeal" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idealInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsIdeal\"}]}}", isOptional: true)]
        public virtual object? IdealInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsKakaoPay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kakaoPayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKakaoPay\"}]}}", isOptional: true)]
        public virtual object? KakaoPayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsKlarna" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "klarnaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKlarna\"}]}}", isOptional: true)]
        public virtual object? KlarnaInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsKonbini" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "konbiniInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKonbini\"}]}}", isOptional: true)]
        public virtual object? KonbiniInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsKrCard" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "krCardInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKrCard\"}]}}", isOptional: true)]
        public virtual object? KrCardInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsMbWay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mbWayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsMbWay\"}]}}", isOptional: true)]
        public virtual object? MbWayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsMobilepay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mobilepayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsMobilepay\"}]}}", isOptional: true)]
        public virtual object? MobilepayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsMultibanco" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "multibancoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsMultibanco\"}]}}", isOptional: true)]
        public virtual object? MultibancoInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsNaverPay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "naverPayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsNaverPay\"}]}}", isOptional: true)]
        public virtual object? NaverPayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsNzBankAccount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nzBankAccountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsNzBankAccount\"}]}}", isOptional: true)]
        public virtual object? NzBankAccountInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsOxxo" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oxxoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsOxxo\"}]}}", isOptional: true)]
        public virtual object? OxxoInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsP24" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "p24Input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsP24\"}]}}", isOptional: true)]
        public virtual object? P24Input
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsPayco" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paycoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsPayco\"}]}}", isOptional: true)]
        public virtual object? PaycoInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsPaynow" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paynowInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsPaynow\"}]}}", isOptional: true)]
        public virtual object? PaynowInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsPaypal" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paypalInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsPaypal\"}]}}", isOptional: true)]
        public virtual object? PaypalInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsPayto" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paytoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsPayto\"}]}}", isOptional: true)]
        public virtual object? PaytoInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsPix" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pixInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsPix\"}]}}", isOptional: true)]
        public virtual object? PixInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsPromptpay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "promptpayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsPromptpay\"}]}}", isOptional: true)]
        public virtual object? PromptpayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsRevolutPay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "revolutPayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsRevolutPay\"}]}}", isOptional: true)]
        public virtual object? RevolutPayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsSamsungPay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "samsungPayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsSamsungPay\"}]}}", isOptional: true)]
        public virtual object? SamsungPayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsSatispay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "satispayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsSatispay\"}]}}", isOptional: true)]
        public virtual object? SatispayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsScalapay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scalapayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsScalapay\"}]}}", isOptional: true)]
        public virtual object? ScalapayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsSepaDebit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sepaDebitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsSepaDebit\"}]}}", isOptional: true)]
        public virtual object? SepaDebitInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsSofort" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sofortInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsSofort\"}]}}", isOptional: true)]
        public virtual object? SofortInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsSwish" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "swishInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsSwish\"}]}}", isOptional: true)]
        public virtual object? SwishInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsTwint" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "twintInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsTwint\"}]}}", isOptional: true)]
        public virtual object? TwintInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsUpi" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "upiInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsUpi\"}]}}", isOptional: true)]
        public virtual object? UpiInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsUsBankAccount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usBankAccountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsUsBankAccount\"}]}}", isOptional: true)]
        public virtual object? UsBankAccountInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsWechatPay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "wechatPayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsWechatPay\"}]}}", isOptional: true)]
        public virtual object? WechatPayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsZip" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "zipInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsZip\"}]}}", isOptional: true)]
        public virtual object? ZipInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptions" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptions\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.PaymentIntent.IPaymentIntentPaymentMethodOptions cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptions).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
