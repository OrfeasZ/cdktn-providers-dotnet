using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiGenerativeAiPrivateEndpoint
{
    [JsiiByValue(fqn: "oci.generativeAiGenerativeAiPrivateEndpoint.GenerativeAiGenerativeAiPrivateEndpointTimeouts")]
    public class GenerativeAiGenerativeAiPrivateEndpointTimeouts : oci.GenerativeAiGenerativeAiPrivateEndpoint.IGenerativeAiGenerativeAiPrivateEndpointTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_generative_ai_private_endpoint#create GenerativeAiGenerativeAiPrivateEndpoint#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_generative_ai_private_endpoint#delete GenerativeAiGenerativeAiPrivateEndpoint#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_generative_ai_private_endpoint#update GenerativeAiGenerativeAiPrivateEndpoint#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
