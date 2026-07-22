using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    [JsiiInterface(nativeType: typeof(IDifStackOkeSecrets), fullyQualifiedName: "oci.difStack.DifStackOkeSecrets")]
    public interface IDifStackOkeSecrets
    {
        /// <summary>secret_data block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/dif_stack#secret_data DifStack#secret_data}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackOkeSecretsSecretData" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "secretData", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackOkeSecretsSecretData\"},\"kind\":\"array\"}}]}}")]
        object SecretData
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/dif_stack#secret_name DifStack#secret_name}.</summary>
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
        string SecretName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/dif_stack#template_object_storage_path DifStack#template_object_storage_path}.</summary>
        [JsiiProperty(name: "templateObjectStoragePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TemplateObjectStoragePath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDifStackOkeSecrets), fullyQualifiedName: "oci.difStack.DifStackOkeSecrets")]
        internal sealed class _Proxy : DeputyBase, oci.DifStack.IDifStackOkeSecrets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>secret_data block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/dif_stack#secret_data DifStack#secret_data}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackOkeSecretsSecretData" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "secretData", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackOkeSecretsSecretData\"},\"kind\":\"array\"}}]}}")]
            public object SecretData
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/dif_stack#secret_name DifStack#secret_name}.</summary>
            [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/dif_stack#template_object_storage_path DifStack#template_object_storage_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "templateObjectStoragePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TemplateObjectStoragePath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
