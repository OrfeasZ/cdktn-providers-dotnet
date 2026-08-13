using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Source
{
    [JsiiInterface(nativeType: typeof(ISourceMandate), fullyQualifiedName: "stripe.source.SourceMandate")]
    public interface ISourceMandate
    {
        /// <summary>The parameters required to notify Stripe of a mandate acceptance or refusal by the customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#acceptance Source#acceptance}
        /// </remarks>
        [JsiiProperty(name: "acceptance", typeJson: "{\"fqn\":\"stripe.source.SourceMandateAcceptance\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Source.ISourceMandateAcceptance? Acceptance
        {
            get
            {
                return null;
            }
        }

        /// <summary>The amount specified by the mandate. (Leave null for a mandate covering all amounts).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#amount Source#amount}
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

        /// <summary>The currency specified by the mandate. (Must match `currency` of the source).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#currency Source#currency}
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

        /// <summary>The interval of debits permitted by the mandate.</summary>
        /// <remarks>
        /// Either <c>one_time</c> (just permitting a single debit), <c>scheduled</c> (with debits on an agreed schedule or for clearly-defined events), or <c>variable</c>(for debits with any frequency)
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#interval Source#interval}
        /// </remarks>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Interval
        {
            get
            {
                return null;
            }
        }

        /// <summary>The method Stripe should use to notify the customer of upcoming debit instructions and/or mandate confirmation as required by the underlying debit network.</summary>
        /// <remarks>
        /// Either <c>email</c> (an email is sent directly to the customer), <c>manual</c> (a <c>source.mandate_notification</c> event is sent to your webhooks endpoint and you should handle the notification) or <c>none</c> (the underlying debit network does not require any notification).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#notification_method Source#notification_method}
        /// </remarks>
        [JsiiProperty(name: "notificationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NotificationMethod
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISourceMandate), fullyQualifiedName: "stripe.source.SourceMandate")]
        internal sealed class _Proxy : DeputyBase, stripe.Source.ISourceMandate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The parameters required to notify Stripe of a mandate acceptance or refusal by the customer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#acceptance Source#acceptance}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acceptance", typeJson: "{\"fqn\":\"stripe.source.SourceMandateAcceptance\"}", isOptional: true)]
            public stripe.Source.ISourceMandateAcceptance? Acceptance
            {
                get => GetInstanceProperty<stripe.Source.ISourceMandateAcceptance?>();
            }

            /// <summary>The amount specified by the mandate. (Leave null for a mandate covering all amounts).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#amount Source#amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Amount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The currency specified by the mandate. (Must match `currency` of the source).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#currency Source#currency}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Currency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The interval of debits permitted by the mandate.</summary>
            /// <remarks>
            /// Either <c>one_time</c> (just permitting a single debit), <c>scheduled</c> (with debits on an agreed schedule or for clearly-defined events), or <c>variable</c>(for debits with any frequency)
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#interval Source#interval}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Interval
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The method Stripe should use to notify the customer of upcoming debit instructions and/or mandate confirmation as required by the underlying debit network.</summary>
            /// <remarks>
            /// Either <c>email</c> (an email is sent directly to the customer), <c>manual</c> (a <c>source.mandate_notification</c> event is sent to your webhooks endpoint and you should handle the notification) or <c>none</c> (the underlying debit network does not require any notification).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#notification_method Source#notification_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notificationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NotificationMethod
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
