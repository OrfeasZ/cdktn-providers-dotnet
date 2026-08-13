using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodOptionsPixMandateOptions), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsPixMandateOptions")]
    public interface ISetupIntentPaymentMethodOptionsPixMandateOptions
    {
        /// <summary>Amount to be charged for future payments.</summary>
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

        /// <summary>Determines if the amount includes the IOF tax.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#amount_includes_iof SetupIntent#amount_includes_iof}
        /// </remarks>
        [JsiiProperty(name: "amountIncludesIof", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AmountIncludesIof
        {
            get
            {
                return null;
            }
        }

        /// <summary>Type of amount.</summary>
        /// <remarks>
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

        /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#currency SetupIntent#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Currency
        {
            get
            {
                return null;
            }
        }

        /// <summary>Date when the mandate expires and no further payments will be charged, in `YYYY-MM-DD`.</summary>
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

        /// <summary>Schedule at which the future payments will be charged.</summary>
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

        /// <summary>Subscription name displayed to buyers in their bank app.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#reference SetupIntent#reference}
        /// </remarks>
        [JsiiProperty(name: "reference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Reference
        {
            get
            {
                return null;
            }
        }

        /// <summary>Start date of the mandate, in `YYYY-MM-DD`.</summary>
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

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodOptionsPixMandateOptions), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsPixMandateOptions")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodOptionsPixMandateOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Amount to be charged for future payments.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#amount SetupIntent#amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Amount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Determines if the amount includes the IOF tax.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#amount_includes_iof SetupIntent#amount_includes_iof}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amountIncludesIof", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AmountIncludesIof
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Type of amount.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#amount_type SetupIntent#amount_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AmountType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#currency SetupIntent#currency}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Currency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Date when the mandate expires and no further payments will be charged, in `YYYY-MM-DD`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#end_date SetupIntent#end_date}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndDate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Schedule at which the future payments will be charged.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#payment_schedule SetupIntent#payment_schedule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paymentSchedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PaymentSchedule
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Subscription name displayed to buyers in their bank app.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#reference SetupIntent#reference}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Reference
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Start date of the mandate, in `YYYY-MM-DD`.</summary>
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
