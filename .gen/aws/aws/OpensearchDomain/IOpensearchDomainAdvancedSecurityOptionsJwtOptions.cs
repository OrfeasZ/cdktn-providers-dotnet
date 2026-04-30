using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiInterface(nativeType: typeof(IOpensearchDomainAdvancedSecurityOptionsJwtOptions), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainAdvancedSecurityOptionsJwtOptions")]
    public interface IOpensearchDomainAdvancedSecurityOptionsJwtOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/opensearch_domain#enabled OpensearchDomain#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/opensearch_domain#public_key OpensearchDomain#public_key}.</summary>
        [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PublicKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/opensearch_domain#roles_key OpensearchDomain#roles_key}.</summary>
        [JsiiProperty(name: "rolesKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RolesKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/opensearch_domain#subject_key OpensearchDomain#subject_key}.</summary>
        [JsiiProperty(name: "subjectKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubjectKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchDomainAdvancedSecurityOptionsJwtOptions), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainAdvancedSecurityOptionsJwtOptions")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchDomain.IOpensearchDomainAdvancedSecurityOptionsJwtOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/opensearch_domain#enabled OpensearchDomain#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/opensearch_domain#public_key OpensearchDomain#public_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PublicKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/opensearch_domain#roles_key OpensearchDomain#roles_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rolesKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RolesKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/opensearch_domain#subject_key OpensearchDomain#subject_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subjectKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubjectKey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
