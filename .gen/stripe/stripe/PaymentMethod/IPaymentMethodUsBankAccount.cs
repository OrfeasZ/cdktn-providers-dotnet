using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodUsBankAccount), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodUsBankAccount")]
    public interface IPaymentMethodUsBankAccount
    {
        /// <summary>Account holder type: individual or company.</summary>
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

        /// <summary>Account number of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#account_number PaymentMethod#account_number}
        /// </remarks>
        [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountNumber
        {
            get
            {
                return null;
            }
        }

        /// <summary>Account type: checkings or savings. Defaults to checking if omitted.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#account_type PaymentMethod#account_type}
        /// </remarks>
        [JsiiProperty(name: "accountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountType
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the Financial Connections Account used to create the payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#financial_connections_account PaymentMethod#financial_connections_account}
        /// </remarks>
        [JsiiProperty(name: "financialConnectionsAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FinancialConnectionsAccount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Routing number of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#routing_number PaymentMethod#routing_number}
        /// </remarks>
        [JsiiProperty(name: "routingNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoutingNumber
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodUsBankAccount), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodUsBankAccount")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodUsBankAccount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Account holder type: individual or company.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#account_holder_type PaymentMethod#account_holder_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountHolderType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountHolderType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Account number of the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#account_number PaymentMethod#account_number}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountNumber
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Account type: checkings or savings. Defaults to checking if omitted.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#account_type PaymentMethod#account_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The ID of the Financial Connections Account used to create the payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#financial_connections_account PaymentMethod#financial_connections_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "financialConnectionsAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FinancialConnectionsAccount
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Routing number of the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#routing_number PaymentMethod#routing_number}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routingNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoutingNumber
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
