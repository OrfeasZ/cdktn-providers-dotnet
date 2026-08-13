using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnections), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnections")]
    public interface IPaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnections
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#filters PaymentIntent#filters}.</summary>
        [JsiiProperty(name: "filters", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters? Filters
        {
            get
            {
                return null;
            }
        }

        /// <summary>The list of permissions to request. The `payment_method` permission must be included.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#permissions PaymentIntent#permissions}
        /// </remarks>
        [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Permissions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Data features requested to be retrieved upon account creation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#prefetch PaymentIntent#prefetch}
        /// </remarks>
        [JsiiProperty(name: "prefetch", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Prefetch
        {
            get
            {
                return null;
            }
        }

        /// <summary>For webview integrations only.</summary>
        /// <remarks>
        /// Upon completing OAuth login in the native browser, the user will be redirected to this URL to return to your app.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#return_url PaymentIntent#return_url}
        /// </remarks>
        [JsiiProperty(name: "returnUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReturnUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnections), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnections")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnections
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#filters PaymentIntent#filters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filters", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters? Filters
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters?>();
            }

            /// <summary>The list of permissions to request. The `payment_method` permission must be included.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#permissions PaymentIntent#permissions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Permissions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Data features requested to be retrieved upon account creation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#prefetch PaymentIntent#prefetch}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "prefetch", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Prefetch
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>For webview integrations only.</summary>
            /// <remarks>
            /// Upon completing OAuth login in the native browser, the user will be redirected to this URL to return to your app.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#return_url PaymentIntent#return_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "returnUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReturnUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
