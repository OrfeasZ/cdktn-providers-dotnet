using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiByValue(fqn: "aws.opensearchDomain.OpensearchDomainIdentityCenterOptions")]
    public class OpensearchDomainIdentityCenterOptions : aws.OpensearchDomain.IOpensearchDomainIdentityCenterOptions
    {
        private object? _enabledApiAccess;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/opensearch_domain#enabled_api_access OpensearchDomain#enabled_api_access}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabledApiAccess", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnabledApiAccess
        {
            get => _enabledApiAccess;
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
                _enabledApiAccess = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/opensearch_domain#identity_center_instance_arn OpensearchDomain#identity_center_instance_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identityCenterInstanceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdentityCenterInstanceArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/opensearch_domain#roles_key OpensearchDomain#roles_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rolesKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RolesKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/opensearch_domain#subject_key OpensearchDomain#subject_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subjectKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubjectKey
        {
            get;
            set;
        }
    }
}
