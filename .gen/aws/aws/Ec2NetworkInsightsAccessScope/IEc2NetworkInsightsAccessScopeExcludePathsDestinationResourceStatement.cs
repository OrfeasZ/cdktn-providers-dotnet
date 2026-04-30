using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2NetworkInsightsAccessScope
{
    [JsiiInterface(nativeType: typeof(IEc2NetworkInsightsAccessScopeExcludePathsDestinationResourceStatement), fullyQualifiedName: "aws.ec2NetworkInsightsAccessScope.Ec2NetworkInsightsAccessScopeExcludePathsDestinationResourceStatement")]
    public interface IEc2NetworkInsightsAccessScopeExcludePathsDestinationResourceStatement
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#resources Ec2NetworkInsightsAccessScope#resources}.</summary>
        [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Resources
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#resource_types Ec2NetworkInsightsAccessScope#resource_types}.</summary>
        [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ResourceTypes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2NetworkInsightsAccessScopeExcludePathsDestinationResourceStatement), fullyQualifiedName: "aws.ec2NetworkInsightsAccessScope.Ec2NetworkInsightsAccessScopeExcludePathsDestinationResourceStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2NetworkInsightsAccessScope.IEc2NetworkInsightsAccessScopeExcludePathsDestinationResourceStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#resources Ec2NetworkInsightsAccessScope#resources}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Resources
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#resource_types Ec2NetworkInsightsAccessScope#resource_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ResourceTypes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
