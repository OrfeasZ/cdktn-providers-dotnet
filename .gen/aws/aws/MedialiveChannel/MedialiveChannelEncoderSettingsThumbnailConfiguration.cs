using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsThumbnailConfiguration")]
    public class MedialiveChannelEncoderSettingsThumbnailConfiguration : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsThumbnailConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/medialive_channel#state MedialiveChannel#state}.</summary>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public string State
        {
            get;
            set;
        }
    }
}
