using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TreasuryFinancialAccount
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPaymentsAch")]
    public class TreasuryFinancialAccountFeaturesOutboundPaymentsAch : stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPaymentsAch
    {
        private object _requested;

        /// <summary>Whether the FinancialAccount should have the Feature.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#requested TreasuryFinancialAccount#requested}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "requested", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object Requested
        {
            get => _requested;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requested = value;
            }
        }

        /// <summary>Whether the Feature is operational.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#status TreasuryFinancialAccount#status}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }

        private object? _statusDetails;

        /// <summary>Additional details; includes at least one entry when the status is not `active`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/treasury_financial_account#status_details TreasuryFinancialAccount#status_details}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPaymentsAchStatusDetails" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statusDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPaymentsAchStatusDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StatusDetails
        {
            get => _statusDetails;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPaymentsAchStatusDetails[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPaymentsAchStatusDetails).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _statusDetails = value;
            }
        }
    }
}
