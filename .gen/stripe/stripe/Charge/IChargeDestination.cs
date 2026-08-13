using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Charge
{
    [JsiiInterface(nativeType: typeof(IChargeDestination), fullyQualifiedName: "stripe.charge.ChargeDestination")]
    public interface IChargeDestination
    {
        /// <summary>ID of an existing, connected Stripe account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#account Charge#account}
        /// </remarks>
        [JsiiProperty(name: "account", typeJson: "{\"primitive\":\"string\"}")]
        string Account
        {
            get;
        }

        /// <summary>The amount to transfer to the destination account without creating an `Application Fee` object.</summary>
        /// <remarks>
        /// Cannot be combined with the <c>application_fee</c> parameter. Must be less than or equal to the charge amount.
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

        [JsiiTypeProxy(nativeType: typeof(IChargeDestination), fullyQualifiedName: "stripe.charge.ChargeDestination")]
        internal sealed class _Proxy : DeputyBase, stripe.Charge.IChargeDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID of an existing, connected Stripe account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#account Charge#account}
            /// </remarks>
            [JsiiProperty(name: "account", typeJson: "{\"primitive\":\"string\"}")]
            public string Account
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The amount to transfer to the destination account without creating an `Application Fee` object.</summary>
            /// <remarks>
            /// Cannot be combined with the <c>application_fee</c> parameter. Must be less than or equal to the charge amount.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#amount Charge#amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Amount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
