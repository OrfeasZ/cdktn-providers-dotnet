using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.opensearchDomain.OpensearchDomainDeploymentStrategyOptions")]
    public class OpensearchDomainDeploymentStrategyOptions : aws.OpensearchDomain.IOpensearchDomainDeploymentStrategyOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearch_domain#deployment_strategy OpensearchDomain#deployment_strategy}.</summary>
        [JsiiProperty(name: "deploymentStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public string DeploymentStrategy
        {
            get;
            set;
        }
    }
}
