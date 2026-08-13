using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentConfig")]
    public class SetupIntentConfig : stripe.SetupIntent.ISetupIntentConfig
    {
        private object? _attachToSelf;

        /// <summary>If present, the SetupIntent's payment method will be attached to the in-context Stripe Account.</summary>
        /// <remarks>
        /// It can only be used for this Stripe Account’s own money movement flows like InboundTransfer and OutboundTransfers. It cannot be set to true when setting up a PaymentMethod for a Customer, and defaults to false when attaching a PaymentMethod to a Customer.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#attach_to_self SetupIntent#attach_to_self}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "attachToSelf", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AttachToSelf
        {
            get => _attachToSelf;
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
                _attachToSelf = value;
            }
        }

        /// <summary>Settings for dynamic payment methods compatible with this Setup Intent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#automatic_payment_methods SetupIntent#automatic_payment_methods}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "automaticPaymentMethods", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentAutomaticPaymentMethods\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentAutomaticPaymentMethods? AutomaticPaymentMethods
        {
            get;
            set;
        }

        private object? _confirm;

        /// <summary>Set to `true` to attempt to confirm this SetupIntent immediately.</summary>
        /// <remarks>
        /// This parameter defaults to <c>false</c>. If a card is the attached payment method, you can provide a <c>return_url</c> in case further authentication is necessary.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#confirm SetupIntent#confirm}
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

        /// <summary>ID of the ConfirmationToken used to confirm this SetupIntent.</summary>
        /// <remarks>
        /// If the provided ConfirmationToken contains properties that are also being provided in this request, such as <c>payment_method</c>, then the values in this request will take precedence.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#confirmation_token SetupIntent#confirmation_token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "confirmationToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConfirmationToken
        {
            get;
            set;
        }

        /// <summary>ID of the Customer this SetupIntent belongs to, if one exists.</summary>
        /// <remarks>
        /// If present, the SetupIntent's payment method will be attached to the Customer on successful setup. Payment methods attached to other Customers cannot be used with this SetupIntent.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#customer SetupIntent#customer}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Customer
        {
            get;
            set;
        }

        /// <summary>ID of the Account this SetupIntent belongs to, if one exists.</summary>
        /// <remarks>
        /// If present, the SetupIntent's payment method will be attached to the Account on successful setup. Payment methods attached to other Accounts cannot be used with this SetupIntent.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#customer_account SetupIntent#customer_account}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customerAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomerAccount
        {
            get;
            set;
        }

        /// <summary>An arbitrary string attached to the object. Often useful for displaying to users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#description SetupIntent#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Payment method types that are excluded from this SetupIntent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#excluded_payment_method_types SetupIntent#excluded_payment_method_types}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "excludedPaymentMethodTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludedPaymentMethodTypes
        {
            get;
            set;
        }

        /// <summary>Indicates the directions of money movement for which this payment method is intended to be used.</summary>
        /// <remarks>
        /// Include <c>inbound</c> if you intend to use the payment method as the origin to pull funds from. Include <c>outbound</c> if you intend to use the payment method as the destination to send funds to. You can include both if you intend to use the payment method for both purposes.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#flow_directions SetupIntent#flow_directions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "flowDirections", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? FlowDirections
        {
            get;
            set;
        }

        /// <summary>This hash contains details about the mandate to create. This parameter can only be used with [`confirm=true`](https://docs.stripe.com/api/setup_intents/create#create_setup_intent-confirm).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#mandate_data SetupIntent#mandate_data}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mandateData", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentMandateData\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentMandateData? MandateData
        {
            get;
            set;
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#metadata SetupIntent#metadata}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get;
            set;
        }

        /// <summary>The account (if any) for which the setup is intended.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#on_behalf_of SetupIntent#on_behalf_of}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onBehalfOf", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OnBehalfOf
        {
            get;
            set;
        }

        /// <summary>ID of the payment method used with this SetupIntent.</summary>
        /// <remarks>
        /// If the payment method is <c>card_present</c> and isn't a digital wallet, then the <a href="https://docs.stripe.com/api/setup_attempts/object#setup_attempt_object-payment_method_details-card_present-generated_card">generated_card</a> associated with the <c>latest_attempt</c> is attached to the Customer instead.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#payment_method SetupIntent#payment_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PaymentMethod
        {
            get;
            set;
        }

        /// <summary>The ID of the [payment method configuration](https://docs.stripe.com/api/payment_method_configurations) to use with this SetupIntent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#payment_method_configuration SetupIntent#payment_method_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentMethodConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PaymentMethodConfiguration
        {
            get;
            set;
        }

        /// <summary>When included, this hash creates a PaymentMethod that is set as the [`payment_method`](https://docs.stripe.com/api/setup_intents/object#setup_intent_object-payment_method) value in the SetupIntent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#payment_method_data SetupIntent#payment_method_data}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentMethodData", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodData\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodData? PaymentMethodData
        {
            get;
            set;
        }

        /// <summary>Payment method-specific configuration for this SetupIntent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#payment_method_options SetupIntent#payment_method_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentMethodOptions", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptions\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodOptions? PaymentMethodOptions
        {
            get;
            set;
        }

        /// <summary>The list of payment method types (e.g. card) that this SetupIntent is allowed to set up. A list of valid payment method types can be found [here](https://docs.stripe.com/api/payment_methods/object#payment_method_object-type).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#payment_method_types SetupIntent#payment_method_types}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentMethodTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PaymentMethodTypes
        {
            get;
            set;
        }

        /// <summary>The URL to redirect your customer back to after they authenticate or cancel their payment on the payment method's app or site.</summary>
        /// <remarks>
        /// To redirect to a mobile application, you can alternatively supply an application URI scheme. This parameter can only be used with <a href="https://docs.stripe.com/api/setup_intents/create#create_setup_intent-confirm"><c>confirm=true</c></a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#return_url SetupIntent#return_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "returnUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReturnUrl
        {
            get;
            set;
        }

        /// <summary>If you populate this hash, this SetupIntent generates a `single_use` mandate after successful completion.</summary>
        /// <remarks>
        /// Single-use mandates are only valid for the following payment methods: <c>acss_debit</c>, <c>alipay</c>, <c>au_becs_debit</c>, <c>bacs_debit</c>, <c>bancontact</c>, <c>boleto</c>, <c>ideal</c>, <c>link</c>, <c>sepa_debit</c>, and <c>us_bank_account</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#single_use SetupIntent#single_use}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "singleUse", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentSingleUse\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentSingleUse? SingleUse
        {
            get;
            set;
        }

        /// <summary>Indicates how the payment method is intended to be used in the future.</summary>
        /// <remarks>
        /// Use <c>on_session</c> if you intend to only reuse the payment method when the customer is in your checkout flow. Use <c>off_session</c> if your customer may or may not be in your checkout flow. If not provided, this value defaults to <c>off_session</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#usage SetupIntent#usage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Usage
        {
            get;
            set;
        }

        private object? _useStripeSdk;

        /// <summary>Set to `true` when confirming server-side and using Stripe.js, iOS, or Android client-side SDKs to handle the next actions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#use_stripe_sdk SetupIntent#use_stripe_sdk}
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
