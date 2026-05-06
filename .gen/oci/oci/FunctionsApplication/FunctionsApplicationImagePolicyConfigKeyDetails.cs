using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FunctionsApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.functionsApplication.FunctionsApplicationImagePolicyConfigKeyDetails")]
    public class FunctionsApplicationImagePolicyConfigKeyDetails : oci.FunctionsApplication.IFunctionsApplicationImagePolicyConfigKeyDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_application#kms_key_id FunctionsApplication#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public string KmsKeyId
        {
            get;
            set;
        }
    }
}
