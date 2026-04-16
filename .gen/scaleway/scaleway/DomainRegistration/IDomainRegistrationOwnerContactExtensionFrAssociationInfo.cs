using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiInterface(nativeType: typeof(IDomainRegistrationOwnerContactExtensionFrAssociationInfo), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrAssociationInfo")]
    public interface IDomainRegistrationOwnerContactExtensionFrAssociationInfo
    {
        /// <summary>Publication date in the Official Journal (RFC3339 format) for association information.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#publication_jo DomainRegistration#publication_jo}
        /// </remarks>
        [JsiiProperty(name: "publicationJo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PublicationJo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Page number of the publication in the Official Journal for association information.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#publication_jo_page DomainRegistration#publication_jo_page}
        /// </remarks>
        [JsiiProperty(name: "publicationJoPage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PublicationJoPage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainRegistrationOwnerContactExtensionFrAssociationInfo), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrAssociationInfo")]
        internal sealed class _Proxy : DeputyBase, scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrAssociationInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Publication date in the Official Journal (RFC3339 format) for association information.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#publication_jo DomainRegistration#publication_jo}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicationJo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PublicationJo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Page number of the publication in the Official Journal for association information.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#publication_jo_page DomainRegistration#publication_jo_page}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicationJoPage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PublicationJoPage
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
