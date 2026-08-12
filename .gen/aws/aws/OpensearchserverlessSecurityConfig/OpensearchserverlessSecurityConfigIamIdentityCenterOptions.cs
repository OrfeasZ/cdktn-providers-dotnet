using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchserverlessSecurityConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.opensearchserverlessSecurityConfig.OpensearchserverlessSecurityConfigIamIdentityCenterOptions")]
    public class OpensearchserverlessSecurityConfigIamIdentityCenterOptions : aws.OpensearchserverlessSecurityConfig.IOpensearchserverlessSecurityConfigIamIdentityCenterOptions
    {
        /// <summary>Instance ARN.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/opensearchserverless_security_config#instance_arn OpensearchserverlessSecurityConfig#instance_arn}
        /// </remarks>
        [JsiiProperty(name: "instanceArn", typeJson: "{\"primitive\":\"string\"}")]
        public string InstanceArn
        {
            get;
            set;
        }

        /// <summary>Group attribute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/opensearchserverless_security_config#group_attribute OpensearchserverlessSecurityConfig#group_attribute}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "groupAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GroupAttribute
        {
            get;
            set;
        }

        /// <summary>User attribute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/opensearchserverless_security_config#user_attribute OpensearchserverlessSecurityConfig#user_attribute}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserAttribute
        {
            get;
            set;
        }
    }
}
