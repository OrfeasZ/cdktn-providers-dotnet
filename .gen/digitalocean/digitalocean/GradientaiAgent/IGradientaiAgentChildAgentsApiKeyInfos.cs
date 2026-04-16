using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.GradientaiAgent
{
    [JsiiInterface(nativeType: typeof(IGradientaiAgentChildAgentsApiKeyInfos), fullyQualifiedName: "digitalocean.gradientaiAgent.GradientaiAgentChildAgentsApiKeyInfos")]
    public interface IGradientaiAgentChildAgentsApiKeyInfos
    {
        /// <summary>Created By user ID for the API Key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#created_by GradientaiAgent#created_by}
        /// </remarks>
        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CreatedBy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the API Key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#name GradientaiAgent#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Updated At timestamp for the API Key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#secret_key GradientaiAgent#secret_key}
        /// </remarks>
        [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>API Key value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#uuid GradientaiAgent#uuid}
        /// </remarks>
        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Uuid
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGradientaiAgentChildAgentsApiKeyInfos), fullyQualifiedName: "digitalocean.gradientaiAgent.GradientaiAgentChildAgentsApiKeyInfos")]
        internal sealed class _Proxy : DeputyBase, digitalocean.GradientaiAgent.IGradientaiAgentChildAgentsApiKeyInfos
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Created By user ID for the API Key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#created_by GradientaiAgent#created_by}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CreatedBy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of the API Key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#name GradientaiAgent#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Updated At timestamp for the API Key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#secret_key GradientaiAgent#secret_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>API Key value.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#uuid GradientaiAgent#uuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Uuid
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
