using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ClimateOrder
{
    [JsiiInterface(nativeType: typeof(IClimateOrderBeneficiary), fullyQualifiedName: "stripe.climateOrder.ClimateOrderBeneficiary")]
    public interface IClimateOrderBeneficiary
    {
        /// <summary>Publicly displayable name for the end beneficiary of carbon removal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/climate_order#public_name ClimateOrder#public_name}
        /// </remarks>
        [JsiiProperty(name: "publicName", typeJson: "{\"primitive\":\"string\"}")]
        string PublicName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IClimateOrderBeneficiary), fullyQualifiedName: "stripe.climateOrder.ClimateOrderBeneficiary")]
        internal sealed class _Proxy : DeputyBase, stripe.ClimateOrder.IClimateOrderBeneficiary
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Publicly displayable name for the end beneficiary of carbon removal.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/climate_order#public_name ClimateOrder#public_name}
            /// </remarks>
            [JsiiProperty(name: "publicName", typeJson: "{\"primitive\":\"string\"}")]
            public string PublicName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
