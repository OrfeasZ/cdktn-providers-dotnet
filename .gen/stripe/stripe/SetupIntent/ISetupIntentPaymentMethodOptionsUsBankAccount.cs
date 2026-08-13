using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodOptionsUsBankAccount), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccount")]
    public interface ISetupIntentPaymentMethodOptionsUsBankAccount
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#financial_connections SetupIntent#financial_connections}.</summary>
        [JsiiProperty(name: "financialConnections", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnections\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountFinancialConnections? FinancialConnections
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#mandate_options SetupIntent#mandate_options}.</summary>
        [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountMandateOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountMandateOptions? MandateOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Additional fields for network related functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#networks SetupIntent#networks}
        /// </remarks>
        [JsiiProperty(name: "networks", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountNetworks\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountNetworks? Networks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Bank account verification method. The default value is `automatic`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#verification_method SetupIntent#verification_method}
        /// </remarks>
        [JsiiProperty(name: "verificationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VerificationMethod
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodOptionsUsBankAccount), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccount")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#financial_connections SetupIntent#financial_connections}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "financialConnections", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnections\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountFinancialConnections? FinancialConnections
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountFinancialConnections?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#mandate_options SetupIntent#mandate_options}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountMandateOptions\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountMandateOptions? MandateOptions
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountMandateOptions?>();
            }

            /// <summary>Additional fields for network related functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#networks SetupIntent#networks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networks", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountNetworks\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountNetworks? Networks
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountNetworks?>();
            }

            /// <summary>Bank account verification method. The default value is `automatic`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#verification_method SetupIntent#verification_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "verificationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VerificationMethod
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
