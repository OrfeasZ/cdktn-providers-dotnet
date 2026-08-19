using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdamicrovmsImage
{
    [JsiiInterface(nativeType: typeof(ILambdamicrovmsImageCodeArtifact), fullyQualifiedName: "aws.lambdamicrovmsImage.LambdamicrovmsImageCodeArtifact")]
    public interface ILambdamicrovmsImageCodeArtifact
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/lambdamicrovms_image#uri LambdamicrovmsImage#uri}.</summary>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        string Uri
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdamicrovmsImageCodeArtifact), fullyQualifiedName: "aws.lambdamicrovmsImage.LambdamicrovmsImageCodeArtifact")]
        internal sealed class _Proxy : DeputyBase, aws.LambdamicrovmsImage.ILambdamicrovmsImageCodeArtifact
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/lambdamicrovms_image#uri LambdamicrovmsImage#uri}.</summary>
            [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
            public string Uri
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
