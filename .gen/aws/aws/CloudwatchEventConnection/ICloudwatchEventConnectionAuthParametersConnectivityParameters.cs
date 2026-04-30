using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventConnection
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventConnectionAuthParametersConnectivityParameters), fullyQualifiedName: "aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersConnectivityParameters")]
    public interface ICloudwatchEventConnectionAuthParametersConnectivityParameters
    {
        /// <summary>resource_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_connection#resource_parameters CloudwatchEventConnection#resource_parameters}
        /// </remarks>
        [JsiiProperty(name: "resourceParameters", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersConnectivityParametersResourceParameters\"}")]
        aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersConnectivityParametersResourceParameters ResourceParameters
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventConnectionAuthParametersConnectivityParameters), fullyQualifiedName: "aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersConnectivityParameters")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersConnectivityParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>resource_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_connection#resource_parameters CloudwatchEventConnection#resource_parameters}
            /// </remarks>
            [JsiiProperty(name: "resourceParameters", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersConnectivityParametersResourceParameters\"}")]
            public aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersConnectivityParametersResourceParameters ResourceParameters
            {
                get => GetInstanceProperty<aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersConnectivityParametersResourceParameters>()!;
            }
        }
    }
}
