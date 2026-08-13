using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentConfig")]
    public class PaymentIntentConfig : stripe.PaymentIntent.IPaymentIntentConfig
    {
        /// <summary>Amount intended to be collected by this PaymentIntent.</summary>
        /// <remarks>
        /// A positive integer representing how much to charge in the <a href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a> (e.g., 100 cents to charge $1.00 or 100 to charge ¥100, a zero-decimal currency). The minimum amount is $0.50 US or <a href="https://docs.stripe.com/currencies#minimum-and-maximum-charge-amounts">equivalent in charge currency</a>. The amount value supports up to eight digits (e.g., a value of 99999999 for a USD charge of $999,999.99).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#amount PaymentIntent#amount}
        /// </remarks>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
        public double Amount
        {
            get;
            set;
        }

        /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Must be a [supported currency](https://stripe.com/docs/currencies).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#currency PaymentIntent#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public string Currency
        {
            get;
            set;
        }

        /// <summary>The amount of the application fee (if any) that will be requested to be applied to the payment and transferred to the application owner's Stripe account.</summary>
        /// <remarks>
        /// The amount of the application fee collected will be capped at the total amount captured. For more information, see the PaymentIntents <a href="https://docs.stripe.com/payments/connected-accounts">use case for connected accounts</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#application_fee_amount PaymentIntent#application_fee_amount}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "applicationFeeAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ApplicationFeeAmount
        {
            get;
            set;
        }

        /// <summary>Settings to configure compatible payment methods from the [Stripe Dashboard](https://dashboard.stripe.com/settings/payment_methods).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#automatic_payment_methods PaymentIntent#automatic_payment_methods}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "automaticPaymentMethods", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentAutomaticPaymentMethods\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentAutomaticPaymentMethods? AutomaticPaymentMethods
        {
            get;
            set;
        }

        /// <summary>Controls when the funds will be captured from the customer's account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#capture_method PaymentIntent#capture_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "captureMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CaptureMethod
        {
            get;
            set;
        }

        private object? _confirm;

        /// <summary>Set to `true` to attempt to [confirm this PaymentIntent](https://docs.stripe.com/api/payment_intents/confirm) immediately. This parameter defaults to `false`. When creating and confirming a PaymentIntent at the same time, you can also provide the parameters available in the [Confirm API](https://docs.stripe.com/api/payment_intents/confirm).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#confirm PaymentIntent#confirm}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "confirm", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Confirm
        {
            get => _confirm;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _confirm = value;
            }
        }

        /// <summary>Describes whether we can confirm this PaymentIntent automatically, or if it requires customer action to confirm the payment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#confirmation_method PaymentIntent#confirmation_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "confirmationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConfirmationMethod
        {
            get;
            set;
        }

        /// <summary>ID of the ConfirmationToken used to confirm this PaymentIntent.</summary>
        /// <remarks>
        /// If the provided ConfirmationToken contains properties that are also being provided in this request, such as <c>payment_method</c>, then the values in this request will take precedence.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#confirmation_token PaymentIntent#confirmation_token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "confirmationToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConfirmationToken
        {
            get;
            set;
        }

        /// <summary>ID of the Customer this PaymentIntent belongs to, if one exists.</summary>
        /// <remarks>
        /// Payment methods attached to other Customers cannot be used with this PaymentIntent.
        ///
        /// If <a href="https://api.stripe.com#payment_intent_object-setup_future_usage">setup_future_usage</a> is set and this PaymentIntent's payment method is not <c>card_present</c>, then the payment method attaches to the Customer after the PaymentIntent has been confirmed and any required actions from the user are complete. If the payment method is <c>card_present</c> and isn't a digital wallet, then a <a href="https://docs.stripe.com/api/charges/object#charge_object-payment_method_details-card_present-generated_card">generated_card</a> payment method representing the card is created and attached to the Customer instead.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#customer PaymentIntent#customer}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Customer
        {
            get;
            set;
        }

        /// <summary>An arbitrary string attached to the object. Often useful for displaying to users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#description PaymentIntent#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        private object? _errorOnRequiresAction;

        /// <summary>Set to `true` to fail the payment attempt if the PaymentIntent transitions into `requires_action`.</summary>
        /// <remarks>
        /// Use this parameter for simpler integrations that don't handle customer actions, such as <a href="https://docs.stripe.com/payments/save-card-without-authentication">saving cards without authentication</a>. This parameter can only be used with <a href="https://docs.stripe.com/api/payment_intents/create#create_payment_intent-confirm"><c>confirm=true</c></a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#error_on_requires_action PaymentIntent#error_on_requires_action}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "errorOnRequiresAction", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ErrorOnRequiresAction
        {
            get => _errorOnRequiresAction;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _errorOnRequiresAction = value;
            }
        }

        /// <summary>The list of payment method types to exclude from use with this payment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#excluded_payment_method_types PaymentIntent#excluded_payment_method_types}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "excludedPaymentMethodTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludedPaymentMethodTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#hooks PaymentIntent#hooks}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hooks", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentHooks\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentHooks? Hooks
        {
            get;
            set;
        }

        /// <summary>ID of the mandate that's used for this payment. This parameter can only be used with [`confirm=true`](https://docs.stripe.com/api/payment_intents/create#create_payment_intent-confirm).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#mandate PaymentIntent#mandate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mandate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mandate
        {
            get;
            set;
        }

        /// <summary>This hash contains details about the Mandate to create. This parameter can only be used with [`confirm=true`](https://docs.stripe.com/api/payment_intents/create#create_payment_intent-confirm).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#mandate_data PaymentIntent#mandate_data}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mandateData", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentMandateData\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentMandateData? MandateData
        {
            get;
            set;
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Learn more about [storing information in metadata](https://docs.stripe.com/payments/payment-intents/creating-payment-intents#storing-information-in-metadata).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#metadata PaymentIntent#metadata}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get;
            set;
        }

        /// <summary>You can specify the settlement merchant as the connected account using the `on_behalf_of` attribute on the charge.</summary>
        /// <remarks>
        /// See the PaymentIntents <a href="/payments/connected-accounts">use case for connected accounts</a> for details.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#on_behalf_of PaymentIntent#on_behalf_of}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onBehalfOf", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OnBehalfOf
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#payment_details PaymentIntent#payment_details}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "paymentDetails", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentDetails\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentDetails? PaymentDetails
        {
            get;
            set;
        }

        /// <summary>ID of the payment method used in this PaymentIntent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#payment_method PaymentIntent#payment_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PaymentMethod
        {
            get;
            set;
        }

        /// <summary>The ID of the [payment method configuration](https://docs.stripe.com/api/payment_method_configurations) to use with this PaymentIntent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#payment_method_configuration PaymentIntent#payment_method_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentMethodConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PaymentMethodConfiguration
        {
            get;
            set;
        }

        /// <summary>If provided, this hash will be used to create a PaymentMethod.</summary>
        /// <remarks>
        /// The new PaymentMethod will appear
        /// in the <a href="https://docs.stripe.com/api/payment_intents/object#payment_intent_object-payment_method">payment_method</a>
        /// property on the PaymentIntent.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#payment_method_data PaymentIntent#payment_method_data}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentMethodData", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodData\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodData? PaymentMethodData
        {
            get;
            set;
        }

        /// <summary>Payment-method-specific configuration for this PaymentIntent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#payment_method_options PaymentIntent#payment_method_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentMethodOptions", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptions\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodOptions? PaymentMethodOptions
        {
            get;
            set;
        }

        /// <summary>Options to configure Radar. Learn more about [Radar Sessions](https://docs.stripe.com/radar/radar-session).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#radar_options PaymentIntent#radar_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "radarOptions", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentRadarOptions\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentRadarOptions? RadarOptions
        {
            get;
            set;
        }

        /// <summary>Email address that the receipt for the resulting payment will be sent to.</summary>
        /// <remarks>
        /// If <c>receipt_email</c> is specified for a payment in live mode, a receipt will be sent regardless of your <a href="https://dashboard.stripe.com/account/emails">email settings</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#receipt_email PaymentIntent#receipt_email}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "receiptEmail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReceiptEmail
        {
            get;
            set;
        }

        /// <summary>The URL to redirect your customer back to after they authenticate or cancel their payment on the payment method's app or site.</summary>
        /// <remarks>
        /// If you'd prefer to redirect to a mobile application, you can alternatively supply an application URI scheme. This parameter can only be used with <a href="https://docs.stripe.com/api/payment_intents/create#create_payment_intent-confirm"><c>confirm=true</c></a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#return_url PaymentIntent#return_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "returnUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReturnUrl
        {
            get;
            set;
        }

        /// <summary>Indicates that you intend to make future payments with this PaymentIntent's payment method.</summary>
        /// <remarks>
        /// If you provide a Customer with the PaymentIntent, you can use this parameter to <a href="/payments/save-during-payment">attach the payment method</a> to the Customer after the PaymentIntent is confirmed and the customer completes any required actions. If you don't provide a Customer, you can still <a href="/api/payment_methods/attach">attach</a> the payment method to a Customer after the transaction completes.
        ///
        /// If the payment method is <c>card_present</c> and isn't a digital wallet, Stripe creates and attaches a <a href="/api/charges/object#charge_object-payment_method_details-card_present-generated_card">generated_card</a> payment method representing the card to the Customer instead.
        ///
        /// When processing card payments, Stripe uses <c>setup_future_usage</c> to help you comply with regional legislation and network rules, such as <a href="/strong-customer-authentication">SCA</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#setup_future_usage PaymentIntent#setup_future_usage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "setupFutureUsage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SetupFutureUsage
        {
            get;
            set;
        }

        /// <summary>Shipping information for this PaymentIntent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#shipping PaymentIntent#shipping}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shipping", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentShipping\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentShipping? Shipping
        {
            get;
            set;
        }

        /// <summary>Text that appears on the customer's statement as the statement descriptor for a non-card charge.</summary>
        /// <remarks>
        /// This value overrides the account's default statement descriptor. For information about requirements, including the 22-character limit, see <a href="https://docs.stripe.com/get-started/account/statement-descriptors">the Statement Descriptor docs</a>.
        ///
        /// Setting this value for a card charge returns an error. For card charges, set the <a href="https://docs.stripe.com/get-started/account/statement-descriptors#dynamic">statement_descriptor_suffix</a> instead.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#statement_descriptor PaymentIntent#statement_descriptor}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statementDescriptor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StatementDescriptor
        {
            get;
            set;
        }

        /// <summary>Provides information about a card charge.</summary>
        /// <remarks>
        /// Concatenated to the account's <a href="https://docs.stripe.com/get-started/account/statement-descriptors#static">statement descriptor prefix</a> to form the complete statement descriptor that appears on the customer's statement.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#statement_descriptor_suffix PaymentIntent#statement_descriptor_suffix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statementDescriptorSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StatementDescriptorSuffix
        {
            get;
            set;
        }

        /// <summary>The data that automatically creates a Transfer after the payment finalizes.</summary>
        /// <remarks>
        /// Learn more about the <a href="https://docs.stripe.com/payments/connected-accounts">use case for connected accounts</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#transfer_data PaymentIntent#transfer_data}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transferData", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentTransferData\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentTransferData? TransferData
        {
            get;
            set;
        }

        /// <summary>A string that identifies the resulting payment as part of a group.</summary>
        /// <remarks>
        /// Learn more about the <a href="https://docs.stripe.com/connect/separate-charges-and-transfers">use case for connected accounts</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#transfer_group PaymentIntent#transfer_group}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transferGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransferGroup
        {
            get;
            set;
        }

        private object? _useStripeSdk;

        /// <summary>Set to `true` when confirming server-side and using Stripe.js, iOS, or Android client-side SDKs to handle the next actions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#use_stripe_sdk PaymentIntent#use_stripe_sdk}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "useStripeSdk", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? UseStripeSdk
        {
            get => _useStripeSdk;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _useStripeSdk = value;
            }
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
