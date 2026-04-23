using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53DomainsDelegationSignerRecord
{
    [JsiiInterface(nativeType: typeof(IRoute53DomainsDelegationSignerRecordConfig), fullyQualifiedName: "aws.route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecordConfig")]
    public interface IRoute53DomainsDelegationSignerRecordConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/route53domains_delegation_signer_record#domain_name Route53DomainsDelegationSignerRecord#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        string DomainName
        {
            get;
        }

        /// <summary>signing_attributes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/route53domains_delegation_signer_record#signing_attributes Route53DomainsDelegationSignerRecord#signing_attributes}
        /// </remarks>
        [JsiiProperty(name: "signingAttributes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecordSigningAttributes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SigningAttributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/route53domains_delegation_signer_record#timeouts Route53DomainsDelegationSignerRecord#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecordTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Route53DomainsDelegationSignerRecord.IRoute53DomainsDelegationSignerRecordTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53DomainsDelegationSignerRecordConfig), fullyQualifiedName: "aws.route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecordConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Route53DomainsDelegationSignerRecord.IRoute53DomainsDelegationSignerRecordConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/route53domains_delegation_signer_record#domain_name Route53DomainsDelegationSignerRecord#domain_name}.</summary>
            [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>signing_attributes block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/route53domains_delegation_signer_record#signing_attributes Route53DomainsDelegationSignerRecord#signing_attributes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "signingAttributes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecordSigningAttributes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SigningAttributes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/route53domains_delegation_signer_record#timeouts Route53DomainsDelegationSignerRecord#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecordTimeouts\"}", isOptional: true)]
            public aws.Route53DomainsDelegationSignerRecord.IRoute53DomainsDelegationSignerRecordTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Route53DomainsDelegationSignerRecord.IRoute53DomainsDelegationSignerRecordTimeouts?>();
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
