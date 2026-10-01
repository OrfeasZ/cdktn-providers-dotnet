using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanAgentPlatformAgent
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanAgentPlatformAgentFunctions), fullyQualifiedName: "digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentFunctions")]
    public interface IDataDigitaloceanAgentPlatformAgentFunctions
    {
        /// <summary>API Key value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#api_key DataDigitaloceanAgentPlatformAgent#api_key}
        /// </remarks>
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApiKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Description of the Function.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#description DataDigitaloceanAgentPlatformAgent#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of function.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#faasname DataDigitaloceanAgentPlatformAgent#faasname}
        /// </remarks>
        [JsiiProperty(name: "faasname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Faasname
        {
            get
            {
                return null;
            }
        }

        /// <summary>Namespace of function.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#faasnamespace DataDigitaloceanAgentPlatformAgent#faasnamespace}
        /// </remarks>
        [JsiiProperty(name: "faasnamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Faasnamespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Guardrail UUID for the Function.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#guardrail_uuid DataDigitaloceanAgentPlatformAgent#guardrail_uuid}
        /// </remarks>
        [JsiiProperty(name: "guardrailUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GuardrailUuid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of function.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#name DataDigitaloceanAgentPlatformAgent#name}
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

        /// <summary>Url of the Deployment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#url DataDigitaloceanAgentPlatformAgent#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Url
        {
            get
            {
                return null;
            }
        }

        /// <summary>API Key value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#uuid DataDigitaloceanAgentPlatformAgent#uuid}
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

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanAgentPlatformAgentFunctions), fullyQualifiedName: "digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentFunctions")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanAgentPlatformAgent.IDataDigitaloceanAgentPlatformAgentFunctions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>API Key value.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#api_key DataDigitaloceanAgentPlatformAgent#api_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Description of the Function.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#description DataDigitaloceanAgentPlatformAgent#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of function.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#faasname DataDigitaloceanAgentPlatformAgent#faasname}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "faasname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Faasname
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Namespace of function.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#faasnamespace DataDigitaloceanAgentPlatformAgent#faasnamespace}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "faasnamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Faasnamespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Guardrail UUID for the Function.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#guardrail_uuid DataDigitaloceanAgentPlatformAgent#guardrail_uuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "guardrailUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GuardrailUuid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of function.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#name DataDigitaloceanAgentPlatformAgent#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Url of the Deployment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#url DataDigitaloceanAgentPlatformAgent#url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Url
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>API Key value.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_agent#uuid DataDigitaloceanAgentPlatformAgent#uuid}
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
