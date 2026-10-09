using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanAgentPlatformAgent
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanAgentPlatformAgentAgentGuardrail), fullyQualifiedName: "digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentAgentGuardrail")]
    public interface IDataDigitaloceanAgentPlatformAgentAgentGuardrail
    {
        /// <summary>Agent UUID for the Guardrail.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_agent#agent_uuid DataDigitaloceanAgentPlatformAgent#agent_uuid}
        /// </remarks>
        [JsiiProperty(name: "agentUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AgentUuid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Default response for the Guardrail.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_agent#default_response DataDigitaloceanAgentPlatformAgent#default_response}
        /// </remarks>
        [JsiiProperty(name: "defaultResponse", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>Description of the Guardrail.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_agent#description DataDigitaloceanAgentPlatformAgent#description}
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

        /// <summary>Guardrail UUID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_agent#guardrail_uuid DataDigitaloceanAgentPlatformAgent#guardrail_uuid}
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

        /// <summary>Indicates if the Guardrail is default.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_agent#is_default DataDigitaloceanAgentPlatformAgent#is_default}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isDefault", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsDefault
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of Guardrail.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_agent#name DataDigitaloceanAgentPlatformAgent#name}
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

        /// <summary>Priority of the Guardrail.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_agent#priority DataDigitaloceanAgentPlatformAgent#priority}
        /// </remarks>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>Type of the Guardrail.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_agent#type DataDigitaloceanAgentPlatformAgent#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>Guardrail UUID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_agent#uuid DataDigitaloceanAgentPlatformAgent#uuid}
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

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanAgentPlatformAgentAgentGuardrail), fullyQualifiedName: "digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentAgentGuardrail")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanAgentPlatformAgent.IDataDigitaloceanAgentPlatformAgentAgentGuardrail
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Agent UUID for the Guardrail.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_agent#agent_uuid DataDigitaloceanAgentPlatformAgent#agent_uuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "agentUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AgentUuid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Default response for the Guardrail.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_agent#default_response DataDigitaloceanAgentPlatformAgent#default_response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultResponse", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultResponse
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Description of the Guardrail.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_agent#description DataDigitaloceanAgentPlatformAgent#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Guardrail UUID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_agent#guardrail_uuid DataDigitaloceanAgentPlatformAgent#guardrail_uuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "guardrailUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GuardrailUuid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Indicates if the Guardrail is default.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_agent#is_default DataDigitaloceanAgentPlatformAgent#is_default}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isDefault", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsDefault
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Name of Guardrail.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_agent#name DataDigitaloceanAgentPlatformAgent#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Priority of the Guardrail.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_agent#priority DataDigitaloceanAgentPlatformAgent#priority}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Type of the Guardrail.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_agent#type DataDigitaloceanAgentPlatformAgent#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Guardrail UUID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_agent#uuid DataDigitaloceanAgentPlatformAgent#uuid}
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
