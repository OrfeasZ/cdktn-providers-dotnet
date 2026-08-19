using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodedeployDeploymentGroup
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupEc2TagSet), fullyQualifiedName: "aws.codedeployDeploymentGroup.CodedeployDeploymentGroupEc2TagSet")]
    public interface ICodedeployDeploymentGroupEc2TagSet
    {
        /// <summary>ec2_tag_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/codedeploy_deployment_group#ec2_tag_filter CodedeployDeploymentGroup#ec2_tag_filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupEc2TagSetEc2TagFilter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ec2TagFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupEc2TagSetEc2TagFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ec2TagFilter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupEc2TagSet), fullyQualifiedName: "aws.codedeployDeploymentGroup.CodedeployDeploymentGroupEc2TagSet")]
        internal sealed class _Proxy : DeputyBase, aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupEc2TagSet
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ec2_tag_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/codedeploy_deployment_group#ec2_tag_filter CodedeployDeploymentGroup#ec2_tag_filter}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupEc2TagSetEc2TagFilter" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ec2TagFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupEc2TagSetEc2TagFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ec2TagFilter
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
