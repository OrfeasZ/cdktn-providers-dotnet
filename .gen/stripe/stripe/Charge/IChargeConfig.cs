using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Charge
{
    [JsiiInterface(nativeType: typeof(IChargeConfig), fullyQualifiedName: "stripe.charge.ChargeConfig")]
    public interface IChargeConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Amount intended to be collected by this payment.</summary>
        /// <remarks>
        /// A positive integer representing how much to charge in the <a href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a> (e.g., 100 cents to charge $1.00 or 100 to charge ¥100, a zero-decimal currency). The minimum amount is $0.50 US or <a href="https://docs.stripe.com/currencies#minimum-and-maximum-charge-amounts">equivalent in charge currency</a>. The amount value supports up to eight digits (e.g., a value of 99999999 for a USD charge of $999,999.99).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#amount Charge#amount}
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

        /// <summary>The application fee (if any) for the charge. [See the Connect documentation](https://docs.stripe.com/connect/direct-charges#collect-fees) for details.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#application_fee Charge#application_fee}
        /// </remarks>
        [JsiiProperty(name: "applicationFee", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ApplicationFee
        {
            get
            {
                return null;
            }
        }

        /// <summary>The amount of the application fee (if any) requested for the charge. [See the Connect documentation](https://docs.stripe.com/connect/direct-charges#collect-fees) for details.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#application_fee_amount Charge#application_fee_amount}
        /// </remarks>
        [JsiiProperty(name: "applicationFeeAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ApplicationFeeAmount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to immediately capture the charge.</summary>
        /// <remarks>
        /// Defaults to <c>true</c>. When <c>false</c>, the charge issues an authorization (or pre-authorization), and will need to be <a href="https://api.stripe.com#capture_charge">captured</a> later. Uncaptured charges expire after a set number of days (7 by default). For more information, see the <a href="https://docs.stripe.com/charges/placing-a-hold">authorizing charges and settling later</a> documentation.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#capture Charge#capture}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "capture", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Capture
        {
            get
            {
                return null;
            }
        }

        /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Must be a [supported currency](https://stripe.com/docs/currencies).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#currency Charge#currency}
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

        /// <summary>ID of the customer this charge is for if one exists.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#customer Charge#customer}
        /// </remarks>
        [JsiiProperty(name: "customer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Customer
        {
            get
            {
                return null;
            }
        }

        /// <summary>An arbitrary string attached to the object. Often useful for displaying to users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#description Charge#description}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#destination Charge#destination}.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"stripe.charge.ChargeDestination\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Charge.IChargeDestination? Destination
        {
            get
            {
                return null;
            }
        }

        /// <summary>Information on fraud assessments for the charge.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#fraud_details Charge#fraud_details}
        /// </remarks>
        [JsiiProperty(name: "fraudDetails", typeJson: "{\"fqn\":\"stripe.charge.ChargeFraudDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Charge.IChargeFraudDetails? FraudDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#metadata Charge#metadata}
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>The account (if any) the charge was made on behalf of without triggering an automatic transfer.</summary>
        /// <remarks>
        /// See the <a href="https://docs.stripe.com/connect/separate-charges-and-transfers">Connect documentation</a> for details.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#on_behalf_of Charge#on_behalf_of}
        /// </remarks>
        [JsiiProperty(name: "onBehalfOf", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OnBehalfOf
        {
            get
            {
                return null;
            }
        }

        /// <summary>Options to configure Radar. See [Radar Session](https://docs.stripe.com/radar/radar-session) for more information.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#radar_options Charge#radar_options}
        /// </remarks>
        [JsiiProperty(name: "radarOptions", typeJson: "{\"fqn\":\"stripe.charge.ChargeRadarOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Charge.IChargeRadarOptions? RadarOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>This is the email address that the receipt for this charge was sent to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#receipt_email Charge#receipt_email}
        /// </remarks>
        [JsiiProperty(name: "receiptEmail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReceiptEmail
        {
            get
            {
                return null;
            }
        }

        /// <summary>Shipping information for the charge.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#shipping Charge#shipping}
        /// </remarks>
        [JsiiProperty(name: "shipping", typeJson: "{\"fqn\":\"stripe.charge.ChargeShipping\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Charge.IChargeShipping? Shipping
        {
            get
            {
                return null;
            }
        }

        /// <summary>This is a legacy field that will be removed in the future.</summary>
        /// <remarks>
        /// It contains the Source, Card, or BankAccount object used for the charge. For details about the payment method used for this charge, refer to <c>payment_method</c> or <c>payment_method_details</c> instead.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#source Charge#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Source
        {
            get
            {
                return null;
            }
        }

        /// <summary>For a non-card charge, text that appears on the customer's statement as the statement descriptor.</summary>
        /// <remarks>
        /// This value overrides the account's default statement descriptor. For information about requirements, including the 22-character limit, see <a href="https://docs.stripe.com/get-started/account/statement-descriptors">the Statement Descriptor docs</a>.
        ///
        /// For a card charge, this value is ignored unless you don't specify a <c>statement_descriptor_suffix</c>, in which case this value is used as the suffix.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#statement_descriptor Charge#statement_descriptor}
        /// </remarks>
        [JsiiProperty(name: "statementDescriptor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StatementDescriptor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Provides information about a card charge.</summary>
        /// <remarks>
        /// Concatenated to the account's <a href="https://docs.stripe.com/get-started/account/statement-descriptors#static">statement descriptor prefix</a> to form the complete statement descriptor that appears on the customer's statement. If the account has no prefix value, the suffix is concatenated to the account's statement descriptor.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#statement_descriptor_suffix Charge#statement_descriptor_suffix}
        /// </remarks>
        [JsiiProperty(name: "statementDescriptorSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StatementDescriptorSuffix
        {
            get
            {
                return null;
            }
        }

        /// <summary>An optional dictionary including the account to automatically transfer to as part of a destination charge.</summary>
        /// <remarks>
        /// <a href="https://docs.stripe.com/connect/destination-charges">See the Connect documentation</a> for details.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#transfer_data Charge#transfer_data}
        /// </remarks>
        [JsiiProperty(name: "transferData", typeJson: "{\"fqn\":\"stripe.charge.ChargeTransferData\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Charge.IChargeTransferData? TransferData
        {
            get
            {
                return null;
            }
        }

        /// <summary>A string that identifies this transaction as part of a group. See the [Connect documentation](https://docs.stripe.com/connect/separate-charges-and-transfers#transfer-options) for details.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#transfer_group Charge#transfer_group}
        /// </remarks>
        [JsiiProperty(name: "transferGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TransferGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IChargeConfig), fullyQualifiedName: "stripe.charge.ChargeConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.Charge.IChargeConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Amount intended to be collected by this payment.</summary>
            /// <remarks>
            /// A positive integer representing how much to charge in the <a href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a> (e.g., 100 cents to charge $1.00 or 100 to charge ¥100, a zero-decimal currency). The minimum amount is $0.50 US or <a href="https://docs.stripe.com/currencies#minimum-and-maximum-charge-amounts">equivalent in charge currency</a>. The amount value supports up to eight digits (e.g., a value of 99999999 for a USD charge of $999,999.99).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#amount Charge#amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Amount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The application fee (if any) for the charge. [See the Connect documentation](https://docs.stripe.com/connect/direct-charges#collect-fees) for details.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#application_fee Charge#application_fee}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applicationFee", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ApplicationFee
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The amount of the application fee (if any) requested for the charge. [See the Connect documentation](https://docs.stripe.com/connect/direct-charges#collect-fees) for details.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#application_fee_amount Charge#application_fee_amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applicationFeeAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ApplicationFeeAmount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Whether to immediately capture the charge.</summary>
            /// <remarks>
            /// Defaults to <c>true</c>. When <c>false</c>, the charge issues an authorization (or pre-authorization), and will need to be <a href="https://api.stripe.com#capture_charge">captured</a> later. Uncaptured charges expire after a set number of days (7 by default). For more information, see the <a href="https://docs.stripe.com/charges/placing-a-hold">authorizing charges and settling later</a> documentation.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#capture Charge#capture}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "capture", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Capture
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Must be a [supported currency](https://stripe.com/docs/currencies).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#currency Charge#currency}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Currency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ID of the customer this charge is for if one exists.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#customer Charge#customer}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Customer
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>An arbitrary string attached to the object. Often useful for displaying to users.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#description Charge#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#destination Charge#destination}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"stripe.charge.ChargeDestination\"}", isOptional: true)]
            public stripe.Charge.IChargeDestination? Destination
            {
                get => GetInstanceProperty<stripe.Charge.IChargeDestination?>();
            }

            /// <summary>Information on fraud assessments for the charge.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#fraud_details Charge#fraud_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fraudDetails", typeJson: "{\"fqn\":\"stripe.charge.ChargeFraudDetails\"}", isOptional: true)]
            public stripe.Charge.IChargeFraudDetails? FraudDetails
            {
                get => GetInstanceProperty<stripe.Charge.IChargeFraudDetails?>();
            }

            /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#metadata Charge#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>The account (if any) the charge was made on behalf of without triggering an automatic transfer.</summary>
            /// <remarks>
            /// See the <a href="https://docs.stripe.com/connect/separate-charges-and-transfers">Connect documentation</a> for details.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#on_behalf_of Charge#on_behalf_of}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onBehalfOf", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OnBehalfOf
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Options to configure Radar. See [Radar Session](https://docs.stripe.com/radar/radar-session) for more information.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#radar_options Charge#radar_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "radarOptions", typeJson: "{\"fqn\":\"stripe.charge.ChargeRadarOptions\"}", isOptional: true)]
            public stripe.Charge.IChargeRadarOptions? RadarOptions
            {
                get => GetInstanceProperty<stripe.Charge.IChargeRadarOptions?>();
            }

            /// <summary>This is the email address that the receipt for this charge was sent to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#receipt_email Charge#receipt_email}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "receiptEmail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReceiptEmail
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Shipping information for the charge.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#shipping Charge#shipping}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shipping", typeJson: "{\"fqn\":\"stripe.charge.ChargeShipping\"}", isOptional: true)]
            public stripe.Charge.IChargeShipping? Shipping
            {
                get => GetInstanceProperty<stripe.Charge.IChargeShipping?>();
            }

            /// <summary>This is a legacy field that will be removed in the future.</summary>
            /// <remarks>
            /// It contains the Source, Card, or BankAccount object used for the charge. For details about the payment method used for this charge, refer to <c>payment_method</c> or <c>payment_method_details</c> instead.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#source Charge#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Source
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>For a non-card charge, text that appears on the customer's statement as the statement descriptor.</summary>
            /// <remarks>
            /// This value overrides the account's default statement descriptor. For information about requirements, including the 22-character limit, see <a href="https://docs.stripe.com/get-started/account/statement-descriptors">the Statement Descriptor docs</a>.
            ///
            /// For a card charge, this value is ignored unless you don't specify a <c>statement_descriptor_suffix</c>, in which case this value is used as the suffix.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#statement_descriptor Charge#statement_descriptor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statementDescriptor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StatementDescriptor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Provides information about a card charge.</summary>
            /// <remarks>
            /// Concatenated to the account's <a href="https://docs.stripe.com/get-started/account/statement-descriptors#static">statement descriptor prefix</a> to form the complete statement descriptor that appears on the customer's statement. If the account has no prefix value, the suffix is concatenated to the account's statement descriptor.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#statement_descriptor_suffix Charge#statement_descriptor_suffix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statementDescriptorSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StatementDescriptorSuffix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>An optional dictionary including the account to automatically transfer to as part of a destination charge.</summary>
            /// <remarks>
            /// <a href="https://docs.stripe.com/connect/destination-charges">See the Connect documentation</a> for details.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#transfer_data Charge#transfer_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transferData", typeJson: "{\"fqn\":\"stripe.charge.ChargeTransferData\"}", isOptional: true)]
            public stripe.Charge.IChargeTransferData? TransferData
            {
                get => GetInstanceProperty<stripe.Charge.IChargeTransferData?>();
            }

            /// <summary>A string that identifies this transaction as part of a group. See the [Connect documentation](https://docs.stripe.com/connect/separate-charges-and-transfers#transfer-options) for details.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#transfer_group Charge#transfer_group}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transferGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TransferGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
