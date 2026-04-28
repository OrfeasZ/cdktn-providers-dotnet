using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiInterface(nativeType: typeof(IDomainRegistrationOwnerContactExtensionFrDunsInfo), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrDunsInfo")]
    public interface IDomainRegistrationOwnerContactExtensionFrDunsInfo
    {
        /// <summary>DUNS ID associated with the domain owner (for French domains).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/domain_registration#duns_id DomainRegistration#duns_id}
        /// </remarks>
        [JsiiProperty(name: "dunsId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DunsId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Local identifier of the domain owner (for French domains).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/domain_registration#local_id DomainRegistration#local_id}
        /// </remarks>
        [JsiiProperty(name: "localId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LocalId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainRegistrationOwnerContactExtensionFrDunsInfo), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrDunsInfo")]
        internal sealed class _Proxy : DeputyBase, scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrDunsInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>DUNS ID associated with the domain owner (for French domains).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/domain_registration#duns_id DomainRegistration#duns_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dunsId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DunsId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Local identifier of the domain owner (for French domains).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/domain_registration#local_id DomainRegistration#local_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "localId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LocalId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
