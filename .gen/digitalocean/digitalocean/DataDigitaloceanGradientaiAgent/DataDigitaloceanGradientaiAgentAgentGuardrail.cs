using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiAgent
{
    [JsiiByValue(fqn: "digitalocean.dataDigitaloceanGradientaiAgent.DataDigitaloceanGradientaiAgentAgentGuardrail")]
    public class DataDigitaloceanGradientaiAgentAgentGuardrail : digitalocean.DataDigitaloceanGradientaiAgent.IDataDigitaloceanGradientaiAgentAgentGuardrail
    {
        /// <summary>Agent UUID for the Guardrail.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#agent_uuid DataDigitaloceanGradientaiAgent#agent_uuid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "agentUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AgentUuid
        {
            get;
            set;
        }

        /// <summary>Default response for the Guardrail.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#default_response DataDigitaloceanGradientaiAgent#default_response}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultResponse", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultResponse
        {
            get;
            set;
        }

        /// <summary>Description of the Guardrail.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#description DataDigitaloceanGradientaiAgent#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Guardrail UUID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#guardrail_uuid DataDigitaloceanGradientaiAgent#guardrail_uuid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "guardrailUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GuardrailUuid
        {
            get;
            set;
        }

        private object? _isDefault;

        /// <summary>Indicates if the Guardrail is default.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#is_default DataDigitaloceanGradientaiAgent#is_default}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isDefault", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsDefault
        {
            get => _isDefault;
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
                _isDefault = value;
            }
        }

        /// <summary>Name of Guardrail.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#name DataDigitaloceanGradientaiAgent#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Priority of the Guardrail.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#priority DataDigitaloceanGradientaiAgent#priority}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Priority
        {
            get;
            set;
        }

        /// <summary>Type of the Guardrail.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#type DataDigitaloceanGradientaiAgent#type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }

        /// <summary>Guardrail UUID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#uuid DataDigitaloceanGradientaiAgent#uuid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Uuid
        {
            get;
            set;
        }
    }
}
