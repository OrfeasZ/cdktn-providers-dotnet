using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DirectoryServiceTrust
{
    [JsiiInterface(nativeType: typeof(IDirectoryServiceTrustConfig), fullyQualifiedName: "aws.directoryServiceTrust.DirectoryServiceTrustConfig")]
    public interface IDirectoryServiceTrustConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/directory_service_trust#directory_id DirectoryServiceTrust#directory_id}.</summary>
        [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}")]
        string DirectoryId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/directory_service_trust#remote_domain_name DirectoryServiceTrust#remote_domain_name}.</summary>
        [JsiiProperty(name: "remoteDomainName", typeJson: "{\"primitive\":\"string\"}")]
        string RemoteDomainName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/directory_service_trust#trust_direction DirectoryServiceTrust#trust_direction}.</summary>
        [JsiiProperty(name: "trustDirection", typeJson: "{\"primitive\":\"string\"}")]
        string TrustDirection
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/directory_service_trust#trust_password DirectoryServiceTrust#trust_password}.</summary>
        [JsiiProperty(name: "trustPassword", typeJson: "{\"primitive\":\"string\"}")]
        string TrustPassword
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/directory_service_trust#conditional_forwarder_ip_addrs DirectoryServiceTrust#conditional_forwarder_ip_addrs}.</summary>
        [JsiiProperty(name: "conditionalForwarderIpAddrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ConditionalForwarderIpAddrs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/directory_service_trust#delete_associated_conditional_forwarder DirectoryServiceTrust#delete_associated_conditional_forwarder}.</summary>
        [JsiiProperty(name: "deleteAssociatedConditionalForwarder", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeleteAssociatedConditionalForwarder
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/directory_service_trust#region DirectoryServiceTrust#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/directory_service_trust#selective_auth DirectoryServiceTrust#selective_auth}.</summary>
        [JsiiProperty(name: "selectiveAuth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SelectiveAuth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/directory_service_trust#trust_type DirectoryServiceTrust#trust_type}.</summary>
        [JsiiProperty(name: "trustType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrustType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDirectoryServiceTrustConfig), fullyQualifiedName: "aws.directoryServiceTrust.DirectoryServiceTrustConfig")]
        internal sealed class _Proxy : DeputyBase, aws.DirectoryServiceTrust.IDirectoryServiceTrustConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/directory_service_trust#directory_id DirectoryServiceTrust#directory_id}.</summary>
            [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}")]
            public string DirectoryId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/directory_service_trust#remote_domain_name DirectoryServiceTrust#remote_domain_name}.</summary>
            [JsiiProperty(name: "remoteDomainName", typeJson: "{\"primitive\":\"string\"}")]
            public string RemoteDomainName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/directory_service_trust#trust_direction DirectoryServiceTrust#trust_direction}.</summary>
            [JsiiProperty(name: "trustDirection", typeJson: "{\"primitive\":\"string\"}")]
            public string TrustDirection
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/directory_service_trust#trust_password DirectoryServiceTrust#trust_password}.</summary>
            [JsiiProperty(name: "trustPassword", typeJson: "{\"primitive\":\"string\"}")]
            public string TrustPassword
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/directory_service_trust#conditional_forwarder_ip_addrs DirectoryServiceTrust#conditional_forwarder_ip_addrs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "conditionalForwarderIpAddrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ConditionalForwarderIpAddrs
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/directory_service_trust#delete_associated_conditional_forwarder DirectoryServiceTrust#delete_associated_conditional_forwarder}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deleteAssociatedConditionalForwarder", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DeleteAssociatedConditionalForwarder
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/directory_service_trust#region DirectoryServiceTrust#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/directory_service_trust#selective_auth DirectoryServiceTrust#selective_auth}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "selectiveAuth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SelectiveAuth
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/directory_service_trust#trust_type DirectoryServiceTrust#trust_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trustType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrustType
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
