using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Charge
{
    [JsiiInterface(nativeType: typeof(IChargeFraudDetails), fullyQualifiedName: "stripe.charge.ChargeFraudDetails")]
    public interface IChargeFraudDetails
    {
        /// <summary>Assessments reported by you. If set, possible values of are `safe` and `fraudulent`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#user_report Charge#user_report}
        /// </remarks>
        [JsiiProperty(name: "userReport", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserReport
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IChargeFraudDetails), fullyQualifiedName: "stripe.charge.ChargeFraudDetails")]
        internal sealed class _Proxy : DeputyBase, stripe.Charge.IChargeFraudDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Assessments reported by you. If set, possible values of are `safe` and `fraudulent`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#user_report Charge#user_report}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userReport", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserReport
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
