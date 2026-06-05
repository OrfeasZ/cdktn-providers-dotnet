using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace tailscale.Contacts
{
    [JsiiInterface(nativeType: typeof(IContactsAccount), fullyQualifiedName: "tailscale.contacts.ContactsAccount")]
    public interface IContactsAccount
    {
        /// <summary>Email address to send communications to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/contacts#email Contacts#email}
        /// </remarks>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        string Email
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IContactsAccount), fullyQualifiedName: "tailscale.contacts.ContactsAccount")]
        internal sealed class _Proxy : DeputyBase, tailscale.Contacts.IContactsAccount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Email address to send communications to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/contacts#email Contacts#email}
            /// </remarks>
            [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
            public string Email
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
