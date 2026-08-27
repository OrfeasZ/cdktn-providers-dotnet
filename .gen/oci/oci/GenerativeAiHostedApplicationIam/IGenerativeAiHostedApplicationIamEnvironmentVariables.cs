using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplicationIam
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiHostedApplicationIamEnvironmentVariables), fullyQualifiedName: "oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamEnvironmentVariables")]
    public interface IGenerativeAiHostedApplicationIamEnvironmentVariables
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_hosted_application_iam#name GenerativeAiHostedApplicationIam#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_hosted_application_iam#type GenerativeAiHostedApplicationIam#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_hosted_application_iam#value GenerativeAiHostedApplicationIam#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiHostedApplicationIamEnvironmentVariables), fullyQualifiedName: "oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamEnvironmentVariables")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamEnvironmentVariables
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_hosted_application_iam#name GenerativeAiHostedApplicationIam#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_hosted_application_iam#type GenerativeAiHostedApplicationIam#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_hosted_application_iam#value GenerativeAiHostedApplicationIam#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
