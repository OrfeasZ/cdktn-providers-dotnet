using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace acme.Registration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "acme.registration.RegistrationExternalAccountBinding")]
    public class RegistrationExternalAccountBinding : acme.Registration.IRegistrationExternalAccountBinding
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/registration#hmac_base64 Registration#hmac_base64}.</summary>
        [JsiiProperty(name: "hmacBase64", typeJson: "{\"primitive\":\"string\"}")]
        public string HmacBase64
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.47.0/docs/resources/registration#key_id Registration#key_id}.</summary>
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyId
        {
            get;
            set;
        }
    }
}
