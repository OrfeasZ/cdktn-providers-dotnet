using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiHostedApplication.GenerativeAiHostedApplicationStorageConfigs")]
    public class GenerativeAiHostedApplicationStorageConfigs : oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationStorageConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/generative_ai_hosted_application#environment_variable_key GenerativeAiHostedApplication#environment_variable_key}.</summary>
        [JsiiProperty(name: "environmentVariableKey", typeJson: "{\"primitive\":\"string\"}")]
        public string EnvironmentVariableKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/generative_ai_hosted_application#storage_id GenerativeAiHostedApplication#storage_id}.</summary>
        [JsiiProperty(name: "storageId", typeJson: "{\"primitive\":\"string\"}")]
        public string StorageId
        {
            get;
            set;
        }
    }
}
