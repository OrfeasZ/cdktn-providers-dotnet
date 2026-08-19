using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplicationIam
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiHostedApplicationIamStorageConfigs), fullyQualifiedName: "oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamStorageConfigs")]
    public interface IGenerativeAiHostedApplicationIamStorageConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/generative_ai_hosted_application_iam#environment_variable_key GenerativeAiHostedApplicationIam#environment_variable_key}.</summary>
        [JsiiProperty(name: "environmentVariableKey", typeJson: "{\"primitive\":\"string\"}")]
        string EnvironmentVariableKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/generative_ai_hosted_application_iam#storage_id GenerativeAiHostedApplicationIam#storage_id}.</summary>
        [JsiiProperty(name: "storageId", typeJson: "{\"primitive\":\"string\"}")]
        string StorageId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiHostedApplicationIamStorageConfigs), fullyQualifiedName: "oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamStorageConfigs")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamStorageConfigs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/generative_ai_hosted_application_iam#environment_variable_key GenerativeAiHostedApplicationIam#environment_variable_key}.</summary>
            [JsiiProperty(name: "environmentVariableKey", typeJson: "{\"primitive\":\"string\"}")]
            public string EnvironmentVariableKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/generative_ai_hosted_application_iam#storage_id GenerativeAiHostedApplicationIam#storage_id}.</summary>
            [JsiiProperty(name: "storageId", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
