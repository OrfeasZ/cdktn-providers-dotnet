using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRegistration
{
    [JsiiInterface(nativeType: typeof(IDomainRegistrationConfig), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationConfig")]
    public interface IDomainRegistrationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>List of domain names to be managed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#domain_names DomainRegistration#domain_names}
        /// </remarks>
        [JsiiProperty(name: "domainNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] DomainNames
        {
            get;
        }

        /// <summary>Enable or disable auto-renewal of the domain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#auto_renew DomainRegistration#auto_renew}
        /// </remarks>
        [JsiiProperty(name: "autoRenew", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoRenew
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enable or disable dnssec for the domain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#dnssec DomainRegistration#dnssec}
        /// </remarks>
        [JsiiProperty(name: "dnssec", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Dnssec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Duration of the registration period in years.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#duration_in_years DomainRegistration#duration_in_years}
        /// </remarks>
        [JsiiProperty(name: "durationInYears", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DurationInYears
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#id DomainRegistration#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>owner_contact block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#owner_contact DomainRegistration#owner_contact}
        /// </remarks>
        [JsiiProperty(name: "ownerContact", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContact\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.DomainRegistration.IDomainRegistrationOwnerContact? OwnerContact
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the owner contact. Either `owner_contact_id` or `owner_contact` must be provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#owner_contact_id DomainRegistration#owner_contact_id}
        /// </remarks>
        [JsiiProperty(name: "ownerContactId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OwnerContactId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The project_id you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#project_id DomainRegistration#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProjectId
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#timeouts DomainRegistration#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.DomainRegistration.IDomainRegistrationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainRegistrationConfig), fullyQualifiedName: "scaleway.domainRegistration.DomainRegistrationConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.DomainRegistration.IDomainRegistrationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of domain names to be managed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#domain_names DomainRegistration#domain_names}
            /// </remarks>
            [JsiiProperty(name: "domainNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] DomainNames
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Enable or disable auto-renewal of the domain.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#auto_renew DomainRegistration#auto_renew}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoRenew", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AutoRenew
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Enable or disable dnssec for the domain.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#dnssec DomainRegistration#dnssec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dnssec", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Dnssec
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Duration of the registration period in years.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#duration_in_years DomainRegistration#duration_in_years}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "durationInYears", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DurationInYears
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#id DomainRegistration#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>owner_contact block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#owner_contact DomainRegistration#owner_contact}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ownerContact", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationOwnerContact\"}", isOptional: true)]
            public scaleway.DomainRegistration.IDomainRegistrationOwnerContact? OwnerContact
            {
                get => GetInstanceProperty<scaleway.DomainRegistration.IDomainRegistrationOwnerContact?>();
            }

            /// <summary>ID of the owner contact. Either `owner_contact_id` or `owner_contact` must be provided.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#owner_contact_id DomainRegistration#owner_contact_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ownerContactId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OwnerContactId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The project_id you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#project_id DomainRegistration#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_registration#timeouts DomainRegistration#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.domainRegistration.DomainRegistrationTimeouts\"}", isOptional: true)]
            public scaleway.DomainRegistration.IDomainRegistrationTimeouts? Timeouts
            {
                get => GetInstanceProperty<scaleway.DomainRegistration.IDomainRegistrationTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
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
