using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.SpacesKey
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.spacesKey.SpacesKeyGrant")]
    public class SpacesKeyGrant : digitalocean.SpacesKey.ISpacesKeyGrant
    {
        /// <summary>The name of the bucket to grant the key access to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_key#bucket SpacesKey#bucket}
        /// </remarks>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>The permission to grant the key. Valid values are `read`, `readwrite`, or `fullaccess`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_key#permission SpacesKey#permission}
        /// </remarks>
        [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
        public string Permission
        {
            get;
            set;
        }
    }
}
