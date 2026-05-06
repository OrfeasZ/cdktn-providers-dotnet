using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ArtifactsContainerRepository
{
    [JsiiInterface(nativeType: typeof(IArtifactsContainerRepositoryReadme), fullyQualifiedName: "oci.artifactsContainerRepository.ArtifactsContainerRepositoryReadme")]
    public interface IArtifactsContainerRepositoryReadme
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/artifacts_container_repository#content ArtifactsContainerRepository#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        string Content
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/artifacts_container_repository#format ArtifactsContainerRepository#format}.</summary>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        string Format
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IArtifactsContainerRepositoryReadme), fullyQualifiedName: "oci.artifactsContainerRepository.ArtifactsContainerRepositoryReadme")]
        internal sealed class _Proxy : DeputyBase, oci.ArtifactsContainerRepository.IArtifactsContainerRepositoryReadme
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/artifacts_container_repository#content ArtifactsContainerRepository#content}.</summary>
            [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
            public string Content
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/artifacts_container_repository#format ArtifactsContainerRepository#format}.</summary>
            [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
            public string Format
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
