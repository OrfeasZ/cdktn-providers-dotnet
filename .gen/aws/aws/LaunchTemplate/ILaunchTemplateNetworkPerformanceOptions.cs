using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateNetworkPerformanceOptions), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateNetworkPerformanceOptions")]
    public interface ILaunchTemplateNetworkPerformanceOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/launch_template#bandwidth_weighting LaunchTemplate#bandwidth_weighting}.</summary>
        [JsiiProperty(name: "bandwidthWeighting", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BandwidthWeighting
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateNetworkPerformanceOptions), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateNetworkPerformanceOptions")]
        internal sealed class _Proxy : DeputyBase, aws.LaunchTemplate.ILaunchTemplateNetworkPerformanceOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/launch_template#bandwidth_weighting LaunchTemplate#bandwidth_weighting}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bandwidthWeighting", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BandwidthWeighting
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
