using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplication
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiHostedApplicationStorageConfigs), fullyQualifiedName: "oci.generativeAiHostedApplication.GenerativeAiHostedApplicationStorageConfigs")]
    public interface IGenerativeAiHostedApplicationStorageConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#environment_variable_key GenerativeAiHostedApplication#environment_variable_key}.</summary>
        [JsiiProperty(name: "environmentVariableKey", typeJson: "{\"primitive\":\"string\"}")]
        string EnvironmentVariableKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#storage_id GenerativeAiHostedApplication#storage_id}.</summary>
        [JsiiProperty(name: "storageId", typeJson: "{\"primitive\":\"string\"}")]
        string StorageId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiHostedApplicationStorageConfigs), fullyQualifiedName: "oci.generativeAiHostedApplication.GenerativeAiHostedApplicationStorageConfigs")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiHostedApplication.IGenerativeAiHostedApplicationStorageConfigs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#environment_variable_key GenerativeAiHostedApplication#environment_variable_key}.</summary>
            [JsiiProperty(name: "environmentVariableKey", typeJson: "{\"primitive\":\"string\"}")]
            public string EnvironmentVariableKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_hosted_application#storage_id GenerativeAiHostedApplication#storage_id}.</summary>
            [JsiiProperty(name: "storageId", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
