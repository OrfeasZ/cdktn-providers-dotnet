using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodFpx), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodFpx")]
    public interface IPaymentMethodFpx
    {
        /// <summary>The customer's bank, if provided.</summary>
        /// <remarks>
        /// Can be one of <c>affin_bank</c>, <c>agrobank</c>, <c>alliance_bank</c>, <c>ambank</c>, <c>bank_islam</c>, <c>bank_muamalat</c>, <c>bank_rakyat</c>, <c>bsn</c>, <c>cimb</c>, <c>hong_leong_bank</c>, <c>hsbc</c>, <c>kfh</c>, <c>maybank2u</c>, <c>ocbc</c>, <c>public_bank</c>, <c>rhb</c>, <c>standard_chartered</c>, <c>uob</c>, <c>deutsche_bank</c>, <c>maybank2e</c>, <c>pb_enterprise</c>, or <c>bank_of_china</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#bank PaymentMethod#bank}
        /// </remarks>
        [JsiiProperty(name: "bank", typeJson: "{\"primitive\":\"string\"}")]
        string Bank
        {
            get;
        }

        /// <summary>Account holder type, if provided. Can be one of `individual` or `company`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#account_holder_type PaymentMethod#account_holder_type}
        /// </remarks>
        [JsiiProperty(name: "accountHolderType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountHolderType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodFpx), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodFpx")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodFpx
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The customer's bank, if provided.</summary>
            /// <remarks>
            /// Can be one of <c>affin_bank</c>, <c>agrobank</c>, <c>alliance_bank</c>, <c>ambank</c>, <c>bank_islam</c>, <c>bank_muamalat</c>, <c>bank_rakyat</c>, <c>bsn</c>, <c>cimb</c>, <c>hong_leong_bank</c>, <c>hsbc</c>, <c>kfh</c>, <c>maybank2u</c>, <c>ocbc</c>, <c>public_bank</c>, <c>rhb</c>, <c>standard_chartered</c>, <c>uob</c>, <c>deutsche_bank</c>, <c>maybank2e</c>, <c>pb_enterprise</c>, or <c>bank_of_china</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#bank PaymentMethod#bank}
            /// </remarks>
            [JsiiProperty(name: "bank", typeJson: "{\"primitive\":\"string\"}")]
            public string Bank
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Account holder type, if provided. Can be one of `individual` or `company`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#account_holder_type PaymentMethod#account_holder_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountHolderType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountHolderType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
