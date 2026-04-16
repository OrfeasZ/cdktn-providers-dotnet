using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiInterface(nativeType: typeof(IDomainRegistrationOwnerContactExtensionFrIndividualInfo), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrIndividualInfo")]
    public interface IDomainRegistrationOwnerContactExtensionFrIndividualInfo
    {
        /// <summary>Whether the individual contact has opted into WHOIS publishing.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#whois_opt_in DomainRegistration#whois_opt_in}
        /// </remarks>
        [JsiiProperty(name: "whoisOptIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WhoisOptIn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainRegistrationOwnerContactExtensionFrIndividualInfo), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrIndividualInfo")]
        internal sealed class _Proxy : DeputyBase, scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrIndividualInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether the individual contact has opted into WHOIS publishing.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#whois_opt_in DomainRegistration#whois_opt_in}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "whoisOptIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? WhoisOptIn
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
