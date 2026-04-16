using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiInterface(nativeType: typeof(IOpensearchDomainIdentityCenterOptions), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainIdentityCenterOptions")]
    public interface IOpensearchDomainIdentityCenterOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearch_domain#enabled_api_access OpensearchDomain#enabled_api_access}.</summary>
        [JsiiProperty(name: "enabledApiAccess", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnabledApiAccess
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearch_domain#identity_center_instance_arn OpensearchDomain#identity_center_instance_arn}.</summary>
        [JsiiProperty(name: "identityCenterInstanceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdentityCenterInstanceArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearch_domain#roles_key OpensearchDomain#roles_key}.</summary>
        [JsiiProperty(name: "rolesKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RolesKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearch_domain#subject_key OpensearchDomain#subject_key}.</summary>
        [JsiiProperty(name: "subjectKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubjectKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchDomainIdentityCenterOptions), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainIdentityCenterOptions")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchDomain.IOpensearchDomainIdentityCenterOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearch_domain#enabled_api_access OpensearchDomain#enabled_api_access}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabledApiAccess", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnabledApiAccess
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearch_domain#identity_center_instance_arn OpensearchDomain#identity_center_instance_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "identityCenterInstanceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdentityCenterInstanceArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearch_domain#roles_key OpensearchDomain#roles_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rolesKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RolesKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearch_domain#subject_key OpensearchDomain#subject_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subjectKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubjectKey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
