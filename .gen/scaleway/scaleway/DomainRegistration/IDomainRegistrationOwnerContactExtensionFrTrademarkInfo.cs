using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiInterface(nativeType: typeof(IDomainRegistrationOwnerContactExtensionFrTrademarkInfo), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrTrademarkInfo")]
    public interface IDomainRegistrationOwnerContactExtensionFrTrademarkInfo
    {
        /// <summary>Trademark information from INPI (French extension).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/domain_registration#trademark_inpi DomainRegistration#trademark_inpi}
        /// </remarks>
        [JsiiProperty(name: "trademarkInpi", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrademarkInpi
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainRegistrationOwnerContactExtensionFrTrademarkInfo), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrTrademarkInfo")]
        internal sealed class _Proxy : DeputyBase, scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrTrademarkInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Trademark information from INPI (French extension).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/domain_registration#trademark_inpi DomainRegistration#trademark_inpi}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trademarkInpi", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrademarkInpi
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
