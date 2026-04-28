using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace acme.Registration
{
    [JsiiInterface(nativeType: typeof(IRegistrationExternalAccountBinding), fullyQualifiedName: "acme.registration.RegistrationExternalAccountBinding")]
    public interface IRegistrationExternalAccountBinding
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.1/docs/resources/registration#hmac_base64 Registration#hmac_base64}.</summary>
        [JsiiProperty(name: "hmacBase64", typeJson: "{\"primitive\":\"string\"}")]
        string HmacBase64
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.1/docs/resources/registration#key_id Registration#key_id}.</summary>
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRegistrationExternalAccountBinding), fullyQualifiedName: "acme.registration.RegistrationExternalAccountBinding")]
        internal sealed class _Proxy : DeputyBase, acme.Registration.IRegistrationExternalAccountBinding
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.1/docs/resources/registration#hmac_base64 Registration#hmac_base64}.</summary>
            [JsiiProperty(name: "hmacBase64", typeJson: "{\"primitive\":\"string\"}")]
            public string HmacBase64
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.1/docs/resources/registration#key_id Registration#key_id}.</summary>
            [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
