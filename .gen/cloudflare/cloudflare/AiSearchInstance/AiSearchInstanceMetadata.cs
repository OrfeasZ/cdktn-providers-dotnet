using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiByValue(fqn: "cloudflare.aiSearchInstance.AiSearchInstanceMetadata")]
    public class AiSearchInstanceMetadata : cloudflare.AiSearchInstance.IAiSearchInstanceMetadata
    {
        private object? _createdFromAisearchWizard;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#created_from_aisearch_wizard AiSearchInstance#created_from_aisearch_wizard}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "createdFromAisearchWizard", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? CreatedFromAisearchWizard
        {
            get => _createdFromAisearchWizard;
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
                _createdFromAisearchWizard = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#search_for_agents AiSearchInstance#search_for_agents}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "searchForAgents", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceMetadataSearchForAgents\"}", isOptional: true)]
        public cloudflare.AiSearchInstance.IAiSearchInstanceMetadataSearchForAgents? SearchForAgents
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_search_instance#worker_domain AiSearchInstance#worker_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "workerDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WorkerDomain
        {
            get;
            set;
        }
    }
}
