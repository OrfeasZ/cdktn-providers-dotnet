using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedDeployment
{
    [JsiiByValue(fqn: "oci.generativeAiHostedDeployment.GenerativeAiHostedDeploymentActiveArtifact")]
    public class GenerativeAiHostedDeploymentActiveArtifact : oci.GenerativeAiHostedDeployment.IGenerativeAiHostedDeploymentActiveArtifact
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/generative_ai_hosted_deployment#artifact_type GenerativeAiHostedDeployment#artifact_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "artifactType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ArtifactType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/generative_ai_hosted_deployment#container_uri GenerativeAiHostedDeployment#container_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containerUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContainerUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/generative_ai_hosted_deployment#hosted_deployment_id GenerativeAiHostedDeployment#hosted_deployment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostedDeploymentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostedDeploymentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/generative_ai_hosted_deployment#id GenerativeAiHostedDeployment#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/generative_ai_hosted_deployment#status GenerativeAiHostedDeployment#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/generative_ai_hosted_deployment#tag GenerativeAiHostedDeployment#tag}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Tag
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/generative_ai_hosted_deployment#time_created GenerativeAiHostedDeployment#time_created}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeCreated
        {
            get;
            set;
        }
    }
}
