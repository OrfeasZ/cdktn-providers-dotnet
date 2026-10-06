using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.PartnerOrganization
{
    [JsiiInterface(nativeType: typeof(IPartnerOrganizationConfig), fullyQualifiedName: "scaleway.partnerOrganization.PartnerOrganizationConfig")]
    public interface IPartnerOrganizationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>A custom ID for the customer in your own infrastructure.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.85.0/docs/resources/partner_organization#customer_id PartnerOrganization#customer_id}
        /// </remarks>
        [JsiiProperty(name: "customerId", typeJson: "{\"primitive\":\"string\"}")]
        string CustomerId
        {
            get;
        }

        /// <summary>The email of the new organization owner.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.85.0/docs/resources/partner_organization#email PartnerOrganization#email}
        /// </remarks>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        string Email
        {
            get;
        }

        /// <summary>The name of the organization you want to create. Usually the company name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.85.0/docs/resources/partner_organization#organization_name PartnerOrganization#organization_name}
        /// </remarks>
        [JsiiProperty(name: "organizationName", typeJson: "{\"primitive\":\"string\"}")]
        string OrganizationName
        {
            get;
        }

        /// <summary>The first name of the new organization owner.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.85.0/docs/resources/partner_organization#owner_firstname PartnerOrganization#owner_firstname}
        /// </remarks>
        [JsiiProperty(name: "ownerFirstname", typeJson: "{\"primitive\":\"string\"}")]
        string OwnerFirstname
        {
            get;
        }

        /// <summary>The last name of the new organization owner.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.85.0/docs/resources/partner_organization#owner_lastname PartnerOrganization#owner_lastname}
        /// </remarks>
        [JsiiProperty(name: "ownerLastname", typeJson: "{\"primitive\":\"string\"}")]
        string OwnerLastname
        {
            get;
        }

        /// <summary>Your personal partner_id. This is the same as your Organization ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.85.0/docs/resources/partner_organization#partner_id PartnerOrganization#partner_id}
        /// </remarks>
        [JsiiProperty(name: "partnerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PartnerId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The phone number of the new organization owner.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.85.0/docs/resources/partner_organization#phone_number PartnerOrganization#phone_number}
        /// </remarks>
        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PhoneNumber
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPartnerOrganizationConfig), fullyQualifiedName: "scaleway.partnerOrganization.PartnerOrganizationConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.PartnerOrganization.IPartnerOrganizationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A custom ID for the customer in your own infrastructure.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.85.0/docs/resources/partner_organization#customer_id PartnerOrganization#customer_id}
            /// </remarks>
            [JsiiProperty(name: "customerId", typeJson: "{\"primitive\":\"string\"}")]
            public string CustomerId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The email of the new organization owner.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.85.0/docs/resources/partner_organization#email PartnerOrganization#email}
            /// </remarks>
            [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
            public string Email
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the organization you want to create. Usually the company name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.85.0/docs/resources/partner_organization#organization_name PartnerOrganization#organization_name}
            /// </remarks>
            [JsiiProperty(name: "organizationName", typeJson: "{\"primitive\":\"string\"}")]
            public string OrganizationName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The first name of the new organization owner.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.85.0/docs/resources/partner_organization#owner_firstname PartnerOrganization#owner_firstname}
            /// </remarks>
            [JsiiProperty(name: "ownerFirstname", typeJson: "{\"primitive\":\"string\"}")]
            public string OwnerFirstname
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The last name of the new organization owner.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.85.0/docs/resources/partner_organization#owner_lastname PartnerOrganization#owner_lastname}
            /// </remarks>
            [JsiiProperty(name: "ownerLastname", typeJson: "{\"primitive\":\"string\"}")]
            public string OwnerLastname
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Your personal partner_id. This is the same as your Organization ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.85.0/docs/resources/partner_organization#partner_id PartnerOrganization#partner_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "partnerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PartnerId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The phone number of the new organization owner.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.85.0/docs/resources/partner_organization#phone_number PartnerOrganization#phone_number}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PhoneNumber
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
