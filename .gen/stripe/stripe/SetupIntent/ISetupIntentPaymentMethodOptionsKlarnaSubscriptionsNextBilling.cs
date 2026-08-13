using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodOptionsKlarnaSubscriptionsNextBilling), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarnaSubscriptionsNextBilling")]
    public interface ISetupIntentPaymentMethodOptionsKlarnaSubscriptionsNextBilling
    {
        /// <summary>The amount of the next charge for the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#amount SetupIntent#amount}
        /// </remarks>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
        double Amount
        {
            get;
        }

        /// <summary>The date of the next charge for the subscription in YYYY-MM-DD format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#date SetupIntent#date}
        /// </remarks>
        [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"string\"}")]
        string Date
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodOptionsKlarnaSubscriptionsNextBilling), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarnaSubscriptionsNextBilling")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarnaSubscriptionsNextBilling
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The amount of the next charge for the subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#amount SetupIntent#amount}
            /// </remarks>
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
            public double Amount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The date of the next charge for the subscription in YYYY-MM-DD format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#date SetupIntent#date}
            /// </remarks>
            [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"string\"}")]
            public string Date
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
