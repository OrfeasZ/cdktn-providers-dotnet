using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiInterface(nativeType: typeof(IOpensearchDomainDeploymentStrategyOptions), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainDeploymentStrategyOptions")]
    public interface IOpensearchDomainDeploymentStrategyOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/opensearch_domain#deployment_strategy OpensearchDomain#deployment_strategy}.</summary>
        [JsiiProperty(name: "deploymentStrategy", typeJson: "{\"primitive\":\"string\"}")]
        string DeploymentStrategy
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchDomainDeploymentStrategyOptions), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainDeploymentStrategyOptions")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchDomain.IOpensearchDomainDeploymentStrategyOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/opensearch_domain#deployment_strategy OpensearchDomain#deployment_strategy}.</summary>
            [JsiiProperty(name: "deploymentStrategy", typeJson: "{\"primitive\":\"string\"}")]
            public string DeploymentStrategy
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
