using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchserverlessSecurityConfig
{
    [JsiiByValue(fqn: "aws.opensearchserverlessSecurityConfig.OpensearchserverlessSecurityConfigIamFederationOptions")]
    public class OpensearchserverlessSecurityConfigIamFederationOptions : aws.OpensearchserverlessSecurityConfig.IOpensearchserverlessSecurityConfigIamFederationOptions
    {
        /// <summary>Group attribute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/opensearchserverless_security_config#group_attribute OpensearchserverlessSecurityConfig#group_attribute}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/opensearchserverless_security_config#user_attribute OpensearchserverlessSecurityConfig#user_attribute}
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
