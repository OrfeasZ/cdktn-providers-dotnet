using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2NetworkInsightsAccessScope
{
    [JsiiInterface(nativeType: typeof(IEc2NetworkInsightsAccessScopeExcludePathsThroughResources), fullyQualifiedName: "aws.ec2NetworkInsightsAccessScope.Ec2NetworkInsightsAccessScopeExcludePathsThroughResources")]
    public interface IEc2NetworkInsightsAccessScopeExcludePathsThroughResources
    {
        /// <summary>resource_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/ec2_network_insights_access_scope#resource_statement Ec2NetworkInsightsAccessScope#resource_statement}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Ec2NetworkInsightsAccessScope.IEc2NetworkInsightsAccessScopeExcludePathsThroughResourcesResourceStatement" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "resourceStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2NetworkInsightsAccessScope.Ec2NetworkInsightsAccessScopeExcludePathsThroughResourcesResourceStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceStatement
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2NetworkInsightsAccessScopeExcludePathsThroughResources), fullyQualifiedName: "aws.ec2NetworkInsightsAccessScope.Ec2NetworkInsightsAccessScopeExcludePathsThroughResources")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2NetworkInsightsAccessScope.IEc2NetworkInsightsAccessScopeExcludePathsThroughResources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>resource_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/ec2_network_insights_access_scope#resource_statement Ec2NetworkInsightsAccessScope#resource_statement}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Ec2NetworkInsightsAccessScope.IEc2NetworkInsightsAccessScopeExcludePathsThroughResourcesResourceStatement" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2NetworkInsightsAccessScope.Ec2NetworkInsightsAccessScopeExcludePathsThroughResourcesResourceStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceStatement
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
