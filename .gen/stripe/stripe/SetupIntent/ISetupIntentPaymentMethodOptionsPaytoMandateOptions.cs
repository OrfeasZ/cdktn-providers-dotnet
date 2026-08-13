using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodOptionsPaytoMandateOptions), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsPaytoMandateOptions")]
    public interface ISetupIntentPaymentMethodOptionsPaytoMandateOptions
    {
        /// <summary>Amount that will be collected. It is required when `amount_type` is `fixed`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#amount SetupIntent#amount}
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

        /// <summary>The type of amount that will be collected.</summary>
        /// <remarks>
        /// The amount charged must be exact or up to the value of <c>amount</c> param for <c>fixed</c> or <c>maximum</c> type respectively. Defaults to <c>maximum</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#amount_type SetupIntent#amount_type}
        /// </remarks>
        [JsiiProperty(name: "amountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AmountType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Date, in YYYY-MM-DD format, after which payments will not be collected. Defaults to no end date.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#end_date SetupIntent#end_date}
        /// </remarks>
        [JsiiProperty(name: "endDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndDate
        {
            get
            {
                return null;
            }
        }

        /// <summary>The periodicity at which payments will be collected. Defaults to `adhoc`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#payment_schedule SetupIntent#payment_schedule}
        /// </remarks>
        [JsiiProperty(name: "paymentSchedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PaymentSchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of payments that will be made during a payment period.</summary>
        /// <remarks>
        /// Defaults to 1 except for when <c>payment_schedule</c> is <c>adhoc</c>. In that case, it defaults to no limit.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#payments_per_period SetupIntent#payments_per_period}
        /// </remarks>
        [JsiiProperty(name: "paymentsPerPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PaymentsPerPeriod
        {
            get
            {
                return null;
            }
        }

        /// <summary>The purpose for which payments are made. Has a default value based on your merchant category code.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#purpose SetupIntent#purpose}
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

        /// <summary>Date, in YYYY-MM-DD format, from which payments will be collected. Defaults to confirmation time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#start_date SetupIntent#start_date}
        /// </remarks>
        [JsiiProperty(name: "startDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartDate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodOptionsPaytoMandateOptions), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsPaytoMandateOptions")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodOptionsPaytoMandateOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Amount that will be collected. It is required when `amount_type` is `fixed`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#amount SetupIntent#amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Amount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The type of amount that will be collected.</summary>
            /// <remarks>
            /// The amount charged must be exact or up to the value of <c>amount</c> param for <c>fixed</c> or <c>maximum</c> type respectively. Defaults to <c>maximum</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#amount_type SetupIntent#amount_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AmountType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Date, in YYYY-MM-DD format, after which payments will not be collected. Defaults to no end date.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#end_date SetupIntent#end_date}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndDate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The periodicity at which payments will be collected. Defaults to `adhoc`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#payment_schedule SetupIntent#payment_schedule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paymentSchedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PaymentSchedule
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The number of payments that will be made during a payment period.</summary>
            /// <remarks>
            /// Defaults to 1 except for when <c>payment_schedule</c> is <c>adhoc</c>. In that case, it defaults to no limit.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#payments_per_period SetupIntent#payments_per_period}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paymentsPerPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PaymentsPerPeriod
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The purpose for which payments are made. Has a default value based on your merchant category code.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#purpose SetupIntent#purpose}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "purpose", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Purpose
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Date, in YYYY-MM-DD format, from which payments will be collected. Defaults to confirmation time.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#start_date SetupIntent#start_date}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "startDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartDate
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
