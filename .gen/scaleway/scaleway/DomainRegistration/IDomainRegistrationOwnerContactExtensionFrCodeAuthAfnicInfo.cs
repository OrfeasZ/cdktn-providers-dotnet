using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiInterface(nativeType: typeof(IDomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo")]
    public interface IDomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo
    {
        /// <summary>AFNIC authorization code for the contact (specific to French domains).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/domain_registration#code_auth_afnic DomainRegistration#code_auth_afnic}
        /// </remarks>
        [JsiiProperty(name: "codeAuthAfnic", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CodeAuthAfnic
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo")]
        internal sealed class _Proxy : DeputyBase, scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>AFNIC authorization code for the contact (specific to French domains).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/domain_registration#code_auth_afnic DomainRegistration#code_auth_afnic}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codeAuthAfnic", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CodeAuthAfnic
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
