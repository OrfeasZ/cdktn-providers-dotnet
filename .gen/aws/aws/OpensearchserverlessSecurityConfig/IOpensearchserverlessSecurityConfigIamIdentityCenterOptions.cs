using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchserverlessSecurityConfig
{
    [JsiiInterface(nativeType: typeof(IOpensearchserverlessSecurityConfigIamIdentityCenterOptions), fullyQualifiedName: "aws.opensearchserverlessSecurityConfig.OpensearchserverlessSecurityConfigIamIdentityCenterOptions")]
    public interface IOpensearchserverlessSecurityConfigIamIdentityCenterOptions
    {
        /// <summary>Instance ARN.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/opensearchserverless_security_config#instance_arn OpensearchserverlessSecurityConfig#instance_arn}
        /// </remarks>
        [JsiiProperty(name: "instanceArn", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceArn
        {
            get;
        }

        /// <summary>Group attribute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/opensearchserverless_security_config#group_attribute OpensearchserverlessSecurityConfig#group_attribute}
        /// </remarks>
        [JsiiProperty(name: "groupAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GroupAttribute
        {
            get
            {
                return null;
            }
        }

        /// <summary>User attribute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/opensearchserverless_security_config#user_attribute OpensearchserverlessSecurityConfig#user_attribute}
        /// </remarks>
        [JsiiProperty(name: "userAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserAttribute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchserverlessSecurityConfigIamIdentityCenterOptions), fullyQualifiedName: "aws.opensearchserverlessSecurityConfig.OpensearchserverlessSecurityConfigIamIdentityCenterOptions")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchserverlessSecurityConfig.IOpensearchserverlessSecurityConfigIamIdentityCenterOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Instance ARN.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/opensearchserverless_security_config#instance_arn OpensearchserverlessSecurityConfig#instance_arn}
            /// </remarks>
            [JsiiProperty(name: "instanceArn", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Group attribute.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/opensearchserverless_security_config#group_attribute OpensearchserverlessSecurityConfig#group_attribute}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "groupAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GroupAttribute
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>User attribute.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/opensearchserverless_security_config#user_attribute OpensearchserverlessSecurityConfig#user_attribute}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserAttribute
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
