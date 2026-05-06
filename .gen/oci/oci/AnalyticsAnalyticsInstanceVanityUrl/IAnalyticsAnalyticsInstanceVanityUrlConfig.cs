using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AnalyticsAnalyticsInstanceVanityUrl
{
    [JsiiInterface(nativeType: typeof(IAnalyticsAnalyticsInstanceVanityUrlConfig), fullyQualifiedName: "oci.analyticsAnalyticsInstanceVanityUrl.AnalyticsAnalyticsInstanceVanityUrlConfig")]
    public interface IAnalyticsAnalyticsInstanceVanityUrlConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_vanity_url#analytics_instance_id AnalyticsAnalyticsInstanceVanityUrl#analytics_instance_id}.</summary>
        [JsiiProperty(name: "analyticsInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        string AnalyticsInstanceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_vanity_url#ca_certificate AnalyticsAnalyticsInstanceVanityUrl#ca_certificate}.</summary>
        [JsiiProperty(name: "caCertificate", typeJson: "{\"primitive\":\"string\"}")]
        string CaCertificate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_vanity_url#hosts AnalyticsAnalyticsInstanceVanityUrl#hosts}.</summary>
        [JsiiProperty(name: "hosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Hosts
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_vanity_url#private_key AnalyticsAnalyticsInstanceVanityUrl#private_key}.</summary>
        [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}")]
        string PrivateKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_vanity_url#public_certificate AnalyticsAnalyticsInstanceVanityUrl#public_certificate}.</summary>
        [JsiiProperty(name: "publicCertificate", typeJson: "{\"primitive\":\"string\"}")]
        string PublicCertificate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_vanity_url#description AnalyticsAnalyticsInstanceVanityUrl#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_vanity_url#id AnalyticsAnalyticsInstanceVanityUrl#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_vanity_url#passphrase AnalyticsAnalyticsInstanceVanityUrl#passphrase}.</summary>
        [JsiiProperty(name: "passphrase", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Passphrase
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_vanity_url#timeouts AnalyticsAnalyticsInstanceVanityUrl#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.analyticsAnalyticsInstanceVanityUrl.AnalyticsAnalyticsInstanceVanityUrlTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.AnalyticsAnalyticsInstanceVanityUrl.IAnalyticsAnalyticsInstanceVanityUrlTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAnalyticsAnalyticsInstanceVanityUrlConfig), fullyQualifiedName: "oci.analyticsAnalyticsInstanceVanityUrl.AnalyticsAnalyticsInstanceVanityUrlConfig")]
        internal sealed class _Proxy : DeputyBase, oci.AnalyticsAnalyticsInstanceVanityUrl.IAnalyticsAnalyticsInstanceVanityUrlConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_vanity_url#analytics_instance_id AnalyticsAnalyticsInstanceVanityUrl#analytics_instance_id}.</summary>
            [JsiiProperty(name: "analyticsInstanceId", typeJson: "{\"primitive\":\"string\"}")]
            public string AnalyticsInstanceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_vanity_url#ca_certificate AnalyticsAnalyticsInstanceVanityUrl#ca_certificate}.</summary>
            [JsiiProperty(name: "caCertificate", typeJson: "{\"primitive\":\"string\"}")]
            public string CaCertificate
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_vanity_url#hosts AnalyticsAnalyticsInstanceVanityUrl#hosts}.</summary>
            [JsiiProperty(name: "hosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Hosts
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_vanity_url#private_key AnalyticsAnalyticsInstanceVanityUrl#private_key}.</summary>
            [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}")]
            public string PrivateKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_vanity_url#public_certificate AnalyticsAnalyticsInstanceVanityUrl#public_certificate}.</summary>
            [JsiiProperty(name: "publicCertificate", typeJson: "{\"primitive\":\"string\"}")]
            public string PublicCertificate
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_vanity_url#description AnalyticsAnalyticsInstanceVanityUrl#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_vanity_url#id AnalyticsAnalyticsInstanceVanityUrl#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_vanity_url#passphrase AnalyticsAnalyticsInstanceVanityUrl#passphrase}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passphrase", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Passphrase
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/analytics_analytics_instance_vanity_url#timeouts AnalyticsAnalyticsInstanceVanityUrl#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.analyticsAnalyticsInstanceVanityUrl.AnalyticsAnalyticsInstanceVanityUrlTimeouts\"}", isOptional: true)]
            public oci.AnalyticsAnalyticsInstanceVanityUrl.IAnalyticsAnalyticsInstanceVanityUrlTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.AnalyticsAnalyticsInstanceVanityUrl.IAnalyticsAnalyticsInstanceVanityUrlTimeouts?>();
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
