using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelEncoderSettingsThumbnailConfiguration), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsThumbnailConfiguration")]
    public interface IMedialiveChannelEncoderSettingsThumbnailConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/medialive_channel#state MedialiveChannel#state}.</summary>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        string State
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelEncoderSettingsThumbnailConfiguration), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsThumbnailConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelEncoderSettingsThumbnailConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/medialive_channel#state MedialiveChannel#state}.</summary>
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
            public string State
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
