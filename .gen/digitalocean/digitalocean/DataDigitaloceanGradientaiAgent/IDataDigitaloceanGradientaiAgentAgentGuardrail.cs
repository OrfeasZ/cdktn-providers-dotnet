using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiAgent
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanGradientaiAgentAgentGuardrail), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiAgent.DataDigitaloceanGradientaiAgentAgentGuardrail")]
    public interface IDataDigitaloceanGradientaiAgentAgentGuardrail
    {
        /// <summary>Agent UUID for the Guardrail.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#agent_uuid DataDigitaloceanGradientaiAgent#agent_uuid}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#default_response DataDigitaloceanGradientaiAgent#default_response}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#description DataDigitaloceanGradientaiAgent#description}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#guardrail_uuid DataDigitaloceanGradientaiAgent#guardrail_uuid}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#is_default DataDigitaloceanGradientaiAgent#is_default}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#name DataDigitaloceanGradientaiAgent#name}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#priority DataDigitaloceanGradientaiAgent#priority}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#type DataDigitaloceanGradientaiAgent#type}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#uuid DataDigitaloceanGradientaiAgent#uuid}
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

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanGradientaiAgentAgentGuardrail), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiAgent.DataDigitaloceanGradientaiAgentAgentGuardrail")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanGradientaiAgent.IDataDigitaloceanGradientaiAgentAgentGuardrail
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Agent UUID for the Guardrail.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#agent_uuid DataDigitaloceanGradientaiAgent#agent_uuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "agentUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AgentUuid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Default response for the Guardrail.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#default_response DataDigitaloceanGradientaiAgent#default_response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultResponse", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultResponse
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Description of the Guardrail.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#description DataDigitaloceanGradientaiAgent#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Guardrail UUID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#guardrail_uuid DataDigitaloceanGradientaiAgent#guardrail_uuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "guardrailUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GuardrailUuid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Indicates if the Guardrail is default.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#is_default DataDigitaloceanGradientaiAgent#is_default}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isDefault", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsDefault
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Name of Guardrail.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#name DataDigitaloceanGradientaiAgent#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Priority of the Guardrail.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#priority DataDigitaloceanGradientaiAgent#priority}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Type of the Guardrail.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#type DataDigitaloceanGradientaiAgent#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Guardrail UUID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#uuid DataDigitaloceanGradientaiAgent#uuid}
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
