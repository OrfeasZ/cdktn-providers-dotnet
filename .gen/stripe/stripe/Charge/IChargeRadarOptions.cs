using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Charge
{
    [JsiiInterface(nativeType: typeof(IChargeRadarOptions), fullyQualifiedName: "stripe.charge.ChargeRadarOptions")]
    public interface IChargeRadarOptions
    {
        /// <summary>A [Radar Session](https://docs.stripe.com/radar/radar-session) is a snapshot of the browser metadata and device details that help Radar make more accurate predictions on your payments.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#session Charge#session}
        /// </remarks>
        [JsiiProperty(name: "session", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Session
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IChargeRadarOptions), fullyQualifiedName: "stripe.charge.ChargeRadarOptions")]
        internal sealed class _Proxy : DeputyBase, stripe.Charge.IChargeRadarOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A [Radar Session](https://docs.stripe.com/radar/radar-session) is a snapshot of the browser metadata and device details that help Radar make more accurate predictions on your payments.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#session Charge#session}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "session", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Session
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
