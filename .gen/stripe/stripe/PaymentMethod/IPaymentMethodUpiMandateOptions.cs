using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodUpiMandateOptions), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodUpiMandateOptions")]
    public interface IPaymentMethodUpiMandateOptions
    {
        /// <summary>Amount to be charged for future payments.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#amount PaymentMethod#amount}
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

        /// <summary>One of `fixed` or `maximum`.</summary>
        /// <remarks>
        /// If <c>fixed</c>, the <c>amount</c> param refers to the exact amount to be charged in future payments. If <c>maximum</c>, the amount charged can be up to the value passed for the <c>amount</c> param.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#amount_type PaymentMethod#amount_type}
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

        /// <summary>A description of the mandate or subscription that is meant to be displayed to the customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#description PaymentMethod#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>End date of the mandate or subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#end_date PaymentMethod#end_date}
        /// </remarks>
        [JsiiProperty(name: "endDate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? EndDate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodUpiMandateOptions), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodUpiMandateOptions")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodUpiMandateOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Amount to be charged for future payments.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#amount PaymentMethod#amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Amount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>One of `fixed` or `maximum`.</summary>
            /// <remarks>
            /// If <c>fixed</c>, the <c>amount</c> param refers to the exact amount to be charged in future payments. If <c>maximum</c>, the amount charged can be up to the value passed for the <c>amount</c> param.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#amount_type PaymentMethod#amount_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AmountType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A description of the mandate or subscription that is meant to be displayed to the customer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#description PaymentMethod#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>End date of the mandate or subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#end_date PaymentMethod#end_date}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endDate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? EndDate
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
