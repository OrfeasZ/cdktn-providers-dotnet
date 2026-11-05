using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelArtifactSignature
{
    [JsiiInterface(nativeType: typeof(IDatascienceModelArtifactSignatureTimeouts), fullyQualifiedName: "oci.datascienceModelArtifactSignature.DatascienceModelArtifactSignatureTimeouts")]
    public interface IDatascienceModelArtifactSignatureTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.12.1/docs/resources/datascience_model_artifact_signature#create DatascienceModelArtifactSignature#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.12.1/docs/resources/datascience_model_artifact_signature#delete DatascienceModelArtifactSignature#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.12.1/docs/resources/datascience_model_artifact_signature#update DatascienceModelArtifactSignature#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceModelArtifactSignatureTimeouts), fullyQualifiedName: "oci.datascienceModelArtifactSignature.DatascienceModelArtifactSignatureTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceModelArtifactSignature.IDatascienceModelArtifactSignatureTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.12.1/docs/resources/datascience_model_artifact_signature#create DatascienceModelArtifactSignature#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.12.1/docs/resources/datascience_model_artifact_signature#delete DatascienceModelArtifactSignature#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.12.1/docs/resources/datascience_model_artifact_signature#update DatascienceModelArtifactSignature#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
