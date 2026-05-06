using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityTag
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityTag.IdentityTagValidator")]
    public class IdentityTagValidator : oci.IdentityTag.IIdentityTagValidator
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_tag#validator_type IdentityTag#validator_type}.</summary>
        [JsiiProperty(name: "validatorType", typeJson: "{\"primitive\":\"string\"}")]
        public string ValidatorType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_tag#values IdentityTag#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
