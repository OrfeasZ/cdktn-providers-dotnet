using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace acme.Registration
{
    [JsiiInterface(nativeType: typeof(IRegistrationConfig), fullyQualifiedName: "acme.registration.RegistrationConfig")]
    public interface IRegistrationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/registration#account_key_algorithm Registration#account_key_algorithm}.</summary>
        [JsiiProperty(name: "accountKeyAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountKeyAlgorithm
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/registration#account_key_ecdsa_curve Registration#account_key_ecdsa_curve}.</summary>
        [JsiiProperty(name: "accountKeyEcdsaCurve", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountKeyEcdsaCurve
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/registration#account_key_pem Registration#account_key_pem}.</summary>
        [JsiiProperty(name: "accountKeyPem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountKeyPem
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/registration#account_key_rsa_bits Registration#account_key_rsa_bits}.</summary>
        [JsiiProperty(name: "accountKeyRsaBits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AccountKeyRsaBits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/registration#email_address Registration#email_address}.</summary>
        [JsiiProperty(name: "emailAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmailAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>external_account_binding block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/registration#external_account_binding Registration#external_account_binding}
        /// </remarks>
        [JsiiProperty(name: "externalAccountBinding", typeJson: "{\"fqn\":\"acme.registration.RegistrationExternalAccountBinding\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        acme.Registration.IRegistrationExternalAccountBinding? ExternalAccountBinding
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/registration#id Registration#id}.</summary>
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

        [JsiiTypeProxy(nativeType: typeof(IRegistrationConfig), fullyQualifiedName: "acme.registration.RegistrationConfig")]
        internal sealed class _Proxy : DeputyBase, acme.Registration.IRegistrationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/registration#account_key_algorithm Registration#account_key_algorithm}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accountKeyAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountKeyAlgorithm
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/registration#account_key_ecdsa_curve Registration#account_key_ecdsa_curve}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accountKeyEcdsaCurve", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountKeyEcdsaCurve
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/registration#account_key_pem Registration#account_key_pem}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accountKeyPem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountKeyPem
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/registration#account_key_rsa_bits Registration#account_key_rsa_bits}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accountKeyRsaBits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AccountKeyRsaBits
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/registration#email_address Registration#email_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmailAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>external_account_binding block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/registration#external_account_binding Registration#external_account_binding}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "externalAccountBinding", typeJson: "{\"fqn\":\"acme.registration.RegistrationExternalAccountBinding\"}", isOptional: true)]
            public acme.Registration.IRegistrationExternalAccountBinding? ExternalAccountBinding
            {
                get => GetInstanceProperty<acme.Registration.IRegistrationExternalAccountBinding?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/registration#id Registration#id}.</summary>
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
