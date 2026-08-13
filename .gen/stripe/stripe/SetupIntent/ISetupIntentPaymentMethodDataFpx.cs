using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodDataFpx), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodDataFpx")]
    public interface ISetupIntentPaymentMethodDataFpx
    {
        /// <summary>The customer's bank.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#bank SetupIntent#bank}
        /// </remarks>
        [JsiiProperty(name: "bank", typeJson: "{\"primitive\":\"string\"}")]
        string Bank
        {
            get;
        }

        /// <summary>Account holder type for FPX transaction.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#account_holder_type SetupIntent#account_holder_type}
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

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodDataFpx), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodDataFpx")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodDataFpx
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The customer's bank.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#bank SetupIntent#bank}
            /// </remarks>
            [JsiiProperty(name: "bank", typeJson: "{\"primitive\":\"string\"}")]
            public string Bank
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Account holder type for FPX transaction.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#account_holder_type SetupIntent#account_holder_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountHolderType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountHolderType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
