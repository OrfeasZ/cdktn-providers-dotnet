using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdamicrovmsImage
{
    [JsiiInterface(nativeType: typeof(ILambdamicrovmsImageCpuConfiguration), fullyQualifiedName: "aws.lambdamicrovmsImage.LambdamicrovmsImageCpuConfiguration")]
    public interface ILambdamicrovmsImageCpuConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_image#architecture LambdamicrovmsImage#architecture}.</summary>
        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}")]
        string Architecture
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdamicrovmsImageCpuConfiguration), fullyQualifiedName: "aws.lambdamicrovmsImage.LambdamicrovmsImageCpuConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.LambdamicrovmsImage.ILambdamicrovmsImageCpuConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_image#architecture LambdamicrovmsImage#architecture}.</summary>
            [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}")]
            public string Architecture
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
