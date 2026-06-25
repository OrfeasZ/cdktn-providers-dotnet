using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FileStorageOutboundConnector
{
    [JsiiInterface(nativeType: typeof(IFileStorageOutboundConnectorConfig), fullyQualifiedName: "oci.fileStorageOutboundConnector.FileStorageOutboundConnectorConfig")]
    public interface IFileStorageOutboundConnectorConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#availability_domain FileStorageOutboundConnector#availability_domain}.</summary>
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        string AvailabilityDomain
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#bind_distinguished_name FileStorageOutboundConnector#bind_distinguished_name}.</summary>
        [JsiiProperty(name: "bindDistinguishedName", typeJson: "{\"primitive\":\"string\"}")]
        string BindDistinguishedName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#compartment_id FileStorageOutboundConnector#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#connector_type FileStorageOutboundConnector#connector_type}.</summary>
        [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectorType
        {
            get;
        }

        /// <summary>endpoints block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#endpoints FileStorageOutboundConnector#endpoints}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.FileStorageOutboundConnector.IFileStorageOutboundConnectorEndpoints" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "endpoints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fileStorageOutboundConnector.FileStorageOutboundConnectorEndpoints\"},\"kind\":\"array\"}}]}}")]
        object Endpoints
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#defined_tags FileStorageOutboundConnector#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#display_name FileStorageOutboundConnector#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#freeform_tags FileStorageOutboundConnector#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#id FileStorageOutboundConnector#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#is_lock_override FileStorageOutboundConnector#is_lock_override}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isLockOverride", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsLockOverride
        {
            get
            {
                return null;
            }
        }

        /// <summary>locks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#locks FileStorageOutboundConnector#locks}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.FileStorageOutboundConnector.IFileStorageOutboundConnectorLocks" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "locks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fileStorageOutboundConnector.FileStorageOutboundConnectorLocks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Locks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#password_secret_id FileStorageOutboundConnector#password_secret_id}.</summary>
        [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PasswordSecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#password_secret_version FileStorageOutboundConnector#password_secret_version}.</summary>
        [JsiiProperty(name: "passwordSecretVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PasswordSecretVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#timeouts FileStorageOutboundConnector#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.fileStorageOutboundConnector.FileStorageOutboundConnectorTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.FileStorageOutboundConnector.IFileStorageOutboundConnectorTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#trusted_certificate_secret_id FileStorageOutboundConnector#trusted_certificate_secret_id}.</summary>
        [JsiiProperty(name: "trustedCertificateSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrustedCertificateSecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#trusted_certificate_secret_version FileStorageOutboundConnector#trusted_certificate_secret_version}.</summary>
        [JsiiProperty(name: "trustedCertificateSecretVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TrustedCertificateSecretVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFileStorageOutboundConnectorConfig), fullyQualifiedName: "oci.fileStorageOutboundConnector.FileStorageOutboundConnectorConfig")]
        internal sealed class _Proxy : DeputyBase, oci.FileStorageOutboundConnector.IFileStorageOutboundConnectorConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#availability_domain FileStorageOutboundConnector#availability_domain}.</summary>
            [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
            public string AvailabilityDomain
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#bind_distinguished_name FileStorageOutboundConnector#bind_distinguished_name}.</summary>
            [JsiiProperty(name: "bindDistinguishedName", typeJson: "{\"primitive\":\"string\"}")]
            public string BindDistinguishedName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#compartment_id FileStorageOutboundConnector#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#connector_type FileStorageOutboundConnector#connector_type}.</summary>
            [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}")]
            public string ConnectorType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>endpoints block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#endpoints FileStorageOutboundConnector#endpoints}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.FileStorageOutboundConnector.IFileStorageOutboundConnectorEndpoints" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "endpoints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fileStorageOutboundConnector.FileStorageOutboundConnectorEndpoints\"},\"kind\":\"array\"}}]}}")]
            public object Endpoints
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#defined_tags FileStorageOutboundConnector#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#display_name FileStorageOutboundConnector#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#freeform_tags FileStorageOutboundConnector#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#id FileStorageOutboundConnector#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#is_lock_override FileStorageOutboundConnector#is_lock_override}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isLockOverride", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsLockOverride
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>locks block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#locks FileStorageOutboundConnector#locks}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.FileStorageOutboundConnector.IFileStorageOutboundConnectorLocks" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "locks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fileStorageOutboundConnector.FileStorageOutboundConnectorLocks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Locks
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#password_secret_id FileStorageOutboundConnector#password_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PasswordSecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#password_secret_version FileStorageOutboundConnector#password_secret_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passwordSecretVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PasswordSecretVersion
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#timeouts FileStorageOutboundConnector#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.fileStorageOutboundConnector.FileStorageOutboundConnectorTimeouts\"}", isOptional: true)]
            public oci.FileStorageOutboundConnector.IFileStorageOutboundConnectorTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.FileStorageOutboundConnector.IFileStorageOutboundConnectorTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#trusted_certificate_secret_id FileStorageOutboundConnector#trusted_certificate_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trustedCertificateSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrustedCertificateSecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/file_storage_outbound_connector#trusted_certificate_secret_version FileStorageOutboundConnector#trusted_certificate_secret_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trustedCertificateSecretVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TrustedCertificateSecretVersion
            {
                get => GetInstanceProperty<double?>();
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
