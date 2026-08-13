using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentMandateDataCustomerAcceptance), fullyQualifiedName: "stripe.setupIntent.SetupIntentMandateDataCustomerAcceptance")]
    public interface ISetupIntentMandateDataCustomerAcceptance
    {
        /// <summary>The type of customer acceptance information included with the Mandate. One of `online` or `offline`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#type SetupIntent#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>The time at which the customer accepted the Mandate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#accepted_at SetupIntent#accepted_at}
        /// </remarks>
        [JsiiProperty(name: "acceptedAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AcceptedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is a Mandate accepted online, this hash contains details about the online acceptance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#online SetupIntent#online}
        /// </remarks>
        [JsiiProperty(name: "online", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentMandateDataCustomerAcceptanceOnline\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentMandateDataCustomerAcceptanceOnline? Online
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentMandateDataCustomerAcceptance), fullyQualifiedName: "stripe.setupIntent.SetupIntentMandateDataCustomerAcceptance")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentMandateDataCustomerAcceptance
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The type of customer acceptance information included with the Mandate. One of `online` or `offline`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#type SetupIntent#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The time at which the customer accepted the Mandate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#accepted_at SetupIntent#accepted_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acceptedAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AcceptedAt
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>If this is a Mandate accepted online, this hash contains details about the online acceptance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#online SetupIntent#online}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "online", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentMandateDataCustomerAcceptanceOnline\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentMandateDataCustomerAcceptanceOnline? Online
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentMandateDataCustomerAcceptanceOnline?>();
            }
        }
    }
}
