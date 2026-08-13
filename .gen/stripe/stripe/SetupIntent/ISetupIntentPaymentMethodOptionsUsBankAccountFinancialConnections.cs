using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodOptionsUsBankAccountFinancialConnections), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnections")]
    public interface ISetupIntentPaymentMethodOptionsUsBankAccountFinancialConnections
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#filters SetupIntent#filters}.</summary>
        [JsiiProperty(name: "filters", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters? Filters
        {
            get
            {
                return null;
            }
        }

        /// <summary>The list of permissions to request. The `payment_method` permission must be included.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#permissions SetupIntent#permissions}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#prefetch SetupIntent#prefetch}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#return_url SetupIntent#return_url}
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

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodOptionsUsBankAccountFinancialConnections), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnections")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountFinancialConnections
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#filters SetupIntent#filters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filters", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters? Filters
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters?>();
            }

            /// <summary>The list of permissions to request. The `payment_method` permission must be included.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#permissions SetupIntent#permissions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Permissions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Data features requested to be retrieved upon account creation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#prefetch SetupIntent#prefetch}
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#return_url SetupIntent#return_url}
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
