using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Stream
{
    [JsiiByValue(fqn: "cloudflare.stream.StreamPublicDetails")]
    public class StreamPublicDetails : cloudflare.Stream.IStreamPublicDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#channel_link Stream#channel_link}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "channelLink", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ChannelLink
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#logo Stream#logo}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Logo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#share_link Stream#share_link}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shareLink", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ShareLink
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/stream#title Stream#title}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Title
        {
            get;
            set;
        }
    }
}
