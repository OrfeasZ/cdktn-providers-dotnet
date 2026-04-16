using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiInterface(nativeType: typeof(IDomainRegistrationOwnerContactExtensionEu), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionEu")]
    public interface IDomainRegistrationOwnerContactExtensionEu
    {
        /// <summary>Indicates the European citizenship of the contact.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#european_citizenship DomainRegistration#european_citizenship}
        /// </remarks>
        [JsiiProperty(name: "europeanCitizenship", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EuropeanCitizenship
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainRegistrationOwnerContactExtensionEu), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionEu")]
        internal sealed class _Proxy : DeputyBase, scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionEu
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Indicates the European citizenship of the contact.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#european_citizenship DomainRegistration#european_citizenship}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "europeanCitizenship", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EuropeanCitizenship
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
