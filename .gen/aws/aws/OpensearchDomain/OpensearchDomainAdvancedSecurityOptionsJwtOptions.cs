using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiByValue(fqn: "aws.opensearchDomain.OpensearchDomainAdvancedSecurityOptionsJwtOptions")]
    public class OpensearchDomainAdvancedSecurityOptionsJwtOptions : aws.OpensearchDomain.IOpensearchDomainAdvancedSecurityOptionsJwtOptions
    {
        private object? _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/opensearch_domain#enabled OpensearchDomain#enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/opensearch_domain#public_key OpensearchDomain#public_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PublicKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/opensearch_domain#roles_key OpensearchDomain#roles_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rolesKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RolesKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/opensearch_domain#subject_key OpensearchDomain#subject_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subjectKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubjectKey
        {
            get;
            set;
        }
    }
}
