using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenericArtifactsContentArtifactByPath
{
    [JsiiInterface(nativeType: typeof(IGenericArtifactsContentArtifactByPathTimeouts), fullyQualifiedName: "oci.genericArtifactsContentArtifactByPath.GenericArtifactsContentArtifactByPathTimeouts")]
    public interface IGenericArtifactsContentArtifactByPathTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generic_artifacts_content_artifact_by_path#create GenericArtifactsContentArtifactByPath#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generic_artifacts_content_artifact_by_path#delete GenericArtifactsContentArtifactByPath#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generic_artifacts_content_artifact_by_path#update GenericArtifactsContentArtifactByPath#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenericArtifactsContentArtifactByPathTimeouts), fullyQualifiedName: "oci.genericArtifactsContentArtifactByPath.GenericArtifactsContentArtifactByPathTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.GenericArtifactsContentArtifactByPath.IGenericArtifactsContentArtifactByPathTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generic_artifacts_content_artifact_by_path#create GenericArtifactsContentArtifactByPath#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generic_artifacts_content_artifact_by_path#delete GenericArtifactsContentArtifactByPath#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generic_artifacts_content_artifact_by_path#update GenericArtifactsContentArtifactByPath#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
