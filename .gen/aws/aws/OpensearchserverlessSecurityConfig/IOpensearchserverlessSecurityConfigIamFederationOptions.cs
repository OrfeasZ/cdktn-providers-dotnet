using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchserverlessSecurityConfig
{
    [JsiiInterface(nativeType: typeof(IOpensearchserverlessSecurityConfigIamFederationOptions), fullyQualifiedName: "aws.opensearchserverlessSecurityConfig.OpensearchserverlessSecurityConfigIamFederationOptions")]
    public interface IOpensearchserverlessSecurityConfigIamFederationOptions
    {
        /// <summary>Group attribute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/opensearchserverless_security_config#group_attribute OpensearchserverlessSecurityConfig#group_attribute}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/opensearchserverless_security_config#user_attribute OpensearchserverlessSecurityConfig#user_attribute}
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

        [JsiiTypeProxy(nativeType: typeof(IOpensearchserverlessSecurityConfigIamFederationOptions), fullyQualifiedName: "aws.opensearchserverlessSecurityConfig.OpensearchserverlessSecurityConfigIamFederationOptions")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchserverlessSecurityConfig.IOpensearchserverlessSecurityConfigIamFederationOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Group attribute.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/opensearchserverless_security_config#group_attribute OpensearchserverlessSecurityConfig#group_attribute}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "groupAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GroupAttribute
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>User attribute.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/opensearchserverless_security_config#user_attribute OpensearchserverlessSecurityConfig#user_attribute}
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
