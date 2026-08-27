using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplicationIam
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamStorageConfigs")]
    public class GenerativeAiHostedApplicationIamStorageConfigs : oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamStorageConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_hosted_application_iam#environment_variable_key GenerativeAiHostedApplicationIam#environment_variable_key}.</summary>
        [JsiiProperty(name: "environmentVariableKey", typeJson: "{\"primitive\":\"string\"}")]
        public string EnvironmentVariableKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_hosted_application_iam#storage_id GenerativeAiHostedApplicationIam#storage_id}.</summary>
        [JsiiProperty(name: "storageId", typeJson: "{\"primitive\":\"string\"}")]
        public string StorageId
        {
            get;
            set;
        }
    }
}
