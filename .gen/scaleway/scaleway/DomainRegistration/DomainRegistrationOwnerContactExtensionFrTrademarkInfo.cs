using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiByValue(fqn: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrTrademarkInfo")]
    public class DomainRegistrationOwnerContactExtensionFrTrademarkInfo : scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrTrademarkInfo
    {
        /// <summary>Trademark information from INPI (French extension).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#trademark_inpi DomainRegistration#trademark_inpi}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trademarkInpi", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrademarkInpi
        {
            get;
            set;
        }
    }
}
