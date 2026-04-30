using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderImage
{
    [JsiiInterface(nativeType: typeof(IImagebuilderImageLoggingConfiguration), fullyQualifiedName: "aws.imagebuilderImage.ImagebuilderImageLoggingConfiguration")]
    public interface IImagebuilderImageLoggingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/imagebuilder_image#log_group_name ImagebuilderImage#log_group_name}.</summary>
        [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string LogGroupName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IImagebuilderImageLoggingConfiguration), fullyQualifiedName: "aws.imagebuilderImage.ImagebuilderImageLoggingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ImagebuilderImage.IImagebuilderImageLoggingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/imagebuilder_image#log_group_name ImagebuilderImage#log_group_name}.</summary>
            [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string LogGroupName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
