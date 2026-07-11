using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ServicePrincipalCertificate
{
    [JsiiInterface(nativeType: typeof(IServicePrincipalCertificateConfig), fullyQualifiedName: "azuread.servicePrincipalCertificate.ServicePrincipalCertificateConfig")]
    public interface IServicePrincipalCertificateConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The object ID of the service principal for which this certificate should be created.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_certificate#service_principal_id ServicePrincipalCertificate#service_principal_id}
        /// </remarks>
        [JsiiProperty(name: "servicePrincipalId", typeJson: "{\"primitive\":\"string\"}")]
        string ServicePrincipalId
        {
            get;
        }

        /// <summary>The certificate data, which can be PEM encoded, base64 encoded DER or hexadecimal encoded DER.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_certificate#value ServicePrincipalCertificate#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>Specifies the encoding used for the supplied certificate data.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_certificate#encoding ServicePrincipalCertificate#encoding}
        /// </remarks>
        [JsiiProperty(name: "encoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Encoding
        {
            get
            {
                return null;
            }
        }

        /// <summary>The end date until which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_certificate#end_date ServicePrincipalCertificate#end_date}
        /// </remarks>
        [JsiiProperty(name: "endDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndDate
        {
            get
            {
                return null;
            }
        }

        /// <summary>A relative duration for which the certificate is valid until, for example `240h` (10 days) or `2400h30m`.</summary>
        /// <remarks>
        /// Valid time units are "ns", "us" (or "µs"), "ms", "s", "m", "h"
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_certificate#end_date_relative ServicePrincipalCertificate#end_date_relative}
        /// </remarks>
        [JsiiProperty(name: "endDateRelative", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndDateRelative
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_certificate#id ServicePrincipalCertificate#id}.</summary>
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

        /// <summary>A UUID used to uniquely identify this certificate. If not specified a UUID will be automatically generated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_certificate#key_id ServicePrincipalCertificate#key_id}
        /// </remarks>
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The start date from which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). If this isn't specified, the current date is used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_certificate#start_date ServicePrincipalCertificate#start_date}
        /// </remarks>
        [JsiiProperty(name: "startDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartDate
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_certificate#timeouts ServicePrincipalCertificate#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.servicePrincipalCertificate.ServicePrincipalCertificateTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.ServicePrincipalCertificate.IServicePrincipalCertificateTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>The type of key/certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_certificate#type ServicePrincipalCertificate#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServicePrincipalCertificateConfig), fullyQualifiedName: "azuread.servicePrincipalCertificate.ServicePrincipalCertificateConfig")]
        internal sealed class _Proxy : DeputyBase, azuread.ServicePrincipalCertificate.IServicePrincipalCertificateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The object ID of the service principal for which this certificate should be created.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_certificate#service_principal_id ServicePrincipalCertificate#service_principal_id}
            /// </remarks>
            [JsiiProperty(name: "servicePrincipalId", typeJson: "{\"primitive\":\"string\"}")]
            public string ServicePrincipalId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The certificate data, which can be PEM encoded, base64 encoded DER or hexadecimal encoded DER.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_certificate#value ServicePrincipalCertificate#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Specifies the encoding used for the supplied certificate data.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_certificate#encoding ServicePrincipalCertificate#encoding}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Encoding
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The end date until which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_certificate#end_date ServicePrincipalCertificate#end_date}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndDate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A relative duration for which the certificate is valid until, for example `240h` (10 days) or `2400h30m`.</summary>
            /// <remarks>
            /// Valid time units are "ns", "us" (or "µs"), "ms", "s", "m", "h"
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_certificate#end_date_relative ServicePrincipalCertificate#end_date_relative}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endDateRelative", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndDateRelative
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_certificate#id ServicePrincipalCertificate#id}.</summary>
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

            /// <summary>A UUID used to uniquely identify this certificate. If not specified a UUID will be automatically generated.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_certificate#key_id ServicePrincipalCertificate#key_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The start date from which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). If this isn't specified, the current date is used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_certificate#start_date ServicePrincipalCertificate#start_date}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "startDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartDate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_certificate#timeouts ServicePrincipalCertificate#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.servicePrincipalCertificate.ServicePrincipalCertificateTimeouts\"}", isOptional: true)]
            public azuread.ServicePrincipalCertificate.IServicePrincipalCertificateTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuread.ServicePrincipalCertificate.IServicePrincipalCertificateTimeouts?>();
            }

            /// <summary>The type of key/certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/service_principal_certificate#type ServicePrincipalCertificate#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
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
