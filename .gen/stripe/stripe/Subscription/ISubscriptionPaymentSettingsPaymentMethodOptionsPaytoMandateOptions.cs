using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionPaymentSettingsPaymentMethodOptionsPaytoMandateOptions), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsPaytoMandateOptions")]
    public interface ISubscriptionPaymentSettingsPaymentMethodOptionsPaytoMandateOptions
    {
        /// <summary>The maximum amount that can be collected in a single invoice.</summary>
        /// <remarks>
        /// If you don't specify a maximum, then there is no limit.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#amount Subscription#amount}
        /// </remarks>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Amount
        {
            get
            {
                return null;
            }
        }

        /// <summary>The purpose for which payments are made. Has a default value based on your merchant category code.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#purpose Subscription#purpose}
        /// </remarks>
        [JsiiProperty(name: "purpose", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Purpose
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionPaymentSettingsPaymentMethodOptionsPaytoMandateOptions), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsPaytoMandateOptions")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsPaytoMandateOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The maximum amount that can be collected in a single invoice.</summary>
            /// <remarks>
            /// If you don't specify a maximum, then there is no limit.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#amount Subscription#amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Amount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The purpose for which payments are made. Has a default value based on your merchant category code.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#purpose Subscription#purpose}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "purpose", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Purpose
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
