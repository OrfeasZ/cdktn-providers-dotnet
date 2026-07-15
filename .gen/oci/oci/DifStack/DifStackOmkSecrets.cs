using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.difStack.DifStackOmkSecrets")]
    public class DifStackOmkSecrets : oci.DifStack.IDifStackOmkSecrets
    {
        private object _secretData;

        /// <summary>secret_data block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#secret_data DifStack#secret_data}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackOmkSecretsSecretData" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "secretData", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackOmkSecretsSecretData\"},\"kind\":\"array\"}}]}}")]
        public object SecretData
        {
            get => _secretData;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DifStack.IDifStackOmkSecretsSecretData[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DifStack.IDifStackOmkSecretsSecretData).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DifStack.IDifStackOmkSecretsSecretData).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _secretData = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#secret_name DifStack#secret_name}.</summary>
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#template_object_storage_path DifStack#template_object_storage_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "templateObjectStoragePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TemplateObjectStoragePath
        {
            get;
            set;
        }
    }
}
