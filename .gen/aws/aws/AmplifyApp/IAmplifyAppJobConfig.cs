using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AmplifyApp
{
    [JsiiInterface(nativeType: typeof(IAmplifyAppJobConfig), fullyQualifiedName: "aws.amplifyApp.AmplifyAppJobConfig")]
    public interface IAmplifyAppJobConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/amplify_app#build_compute_type AmplifyApp#build_compute_type}.</summary>
        [JsiiProperty(name: "buildComputeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BuildComputeType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAmplifyAppJobConfig), fullyQualifiedName: "aws.amplifyApp.AmplifyAppJobConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AmplifyApp.IAmplifyAppJobConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/amplify_app#build_compute_type AmplifyApp#build_compute_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "buildComputeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BuildComputeType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
