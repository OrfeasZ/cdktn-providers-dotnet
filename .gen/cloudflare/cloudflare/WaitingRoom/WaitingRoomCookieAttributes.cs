using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WaitingRoom
{
    [JsiiByValue(fqn: "cloudflare.waitingRoom.WaitingRoomCookieAttributes")]
    public class WaitingRoomCookieAttributes : cloudflare.WaitingRoom.IWaitingRoomCookieAttributes
    {
        /// <summary>Configures the SameSite attribute on the waiting room cookie.</summary>
        /// <remarks>
        /// Value <c>auto</c> will be translated to <c>lax</c> or <c>none</c> depending if <strong>Always Use HTTPS</strong> is enabled. Note that when using value <c>none</c>, the secure attribute cannot be set to <c>never</c>.
        /// Available values: "auto", "lax", "none", "strict".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#samesite WaitingRoom#samesite}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "samesite", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Samesite
        {
            get;
            set;
        }

        /// <summary>Configures the Secure attribute on the waiting room cookie.</summary>
        /// <remarks>
        /// Value <c>always</c> indicates that the Secure attribute will be set in the Set-Cookie header, <c>never</c> indicates that the Secure attribute will not be set, and <c>auto</c> will set the Secure attribute depending if <strong>Always Use HTTPS</strong> is enabled.
        /// Available values: "auto", "always", "never".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/waiting_room#secure WaitingRoom#secure}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Secure
        {
            get;
            set;
        }
    }
}
