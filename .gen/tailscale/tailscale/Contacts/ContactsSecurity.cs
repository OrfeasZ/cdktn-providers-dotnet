using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace tailscale.Contacts
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "tailscale.contacts.ContactsSecurity")]
    public class ContactsSecurity : tailscale.Contacts.IContactsSecurity
    {
        /// <summary>Email address to send communications to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/contacts#email Contacts#email}
        /// </remarks>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        public string Email
        {
            get;
            set;
        }
    }
}
