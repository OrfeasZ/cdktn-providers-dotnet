using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiInterface(nativeType: typeof(IDomainRegistrationOwnerContactExtensionFr), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFr")]
    public interface IDomainRegistrationOwnerContactExtensionFr
    {
        /// <summary>association_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#association_info DomainRegistration#association_info}
        /// </remarks>
        [JsiiProperty(name: "associationInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrAssociationInfo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrAssociationInfo? AssociationInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>code_auth_afnic_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#code_auth_afnic_info DomainRegistration#code_auth_afnic_info}
        /// </remarks>
        [JsiiProperty(name: "codeAuthAfnicInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo? CodeAuthAfnicInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>duns_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#duns_info DomainRegistration#duns_info}
        /// </remarks>
        [JsiiProperty(name: "dunsInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrDunsInfo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrDunsInfo? DunsInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>individual_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#individual_info DomainRegistration#individual_info}
        /// </remarks>
        [JsiiProperty(name: "individualInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrIndividualInfo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrIndividualInfo? IndividualInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Mode of the French extension (e.g., 'individual', 'duns', 'association', etc.).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#mode DomainRegistration#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        /// <summary>trademark_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#trademark_info DomainRegistration#trademark_info}
        /// </remarks>
        [JsiiProperty(name: "trademarkInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrTrademarkInfo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrTrademarkInfo? TrademarkInfo
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainRegistrationOwnerContactExtensionFr), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFr")]
        internal sealed class _Proxy : DeputyBase, scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFr
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>association_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#association_info DomainRegistration#association_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "associationInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrAssociationInfo\"}", isOptional: true)]
            public scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrAssociationInfo? AssociationInfo
            {
                get => GetInstanceProperty<scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrAssociationInfo?>();
            }

            /// <summary>code_auth_afnic_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#code_auth_afnic_info DomainRegistration#code_auth_afnic_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codeAuthAfnicInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo\"}", isOptional: true)]
            public scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo? CodeAuthAfnicInfo
            {
                get => GetInstanceProperty<scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrCodeAuthAfnicInfo?>();
            }

            /// <summary>duns_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#duns_info DomainRegistration#duns_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dunsInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrDunsInfo\"}", isOptional: true)]
            public scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrDunsInfo? DunsInfo
            {
                get => GetInstanceProperty<scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrDunsInfo?>();
            }

            /// <summary>individual_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#individual_info DomainRegistration#individual_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "individualInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrIndividualInfo\"}", isOptional: true)]
            public scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrIndividualInfo? IndividualInfo
            {
                get => GetInstanceProperty<scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrIndividualInfo?>();
            }

            /// <summary>Mode of the French extension (e.g., 'individual', 'duns', 'association', etc.).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#mode DomainRegistration#mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>trademark_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#trademark_info DomainRegistration#trademark_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trademarkInfo", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContactExtensionFrTrademarkInfo\"}", isOptional: true)]
            public scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrTrademarkInfo? TrademarkInfo
            {
                get => GetInstanceProperty<scaleway.DomainRegistration.IDomainRegistrationOwnerContactExtensionFrTrademarkInfo?>();
            }
        }
    }
}
