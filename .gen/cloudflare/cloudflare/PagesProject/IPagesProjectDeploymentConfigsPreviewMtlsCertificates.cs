using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiInterface(nativeType: typeof(IPagesProjectDeploymentConfigsPreviewMtlsCertificates), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewMtlsCertificates")]
    public interface IPagesProjectDeploymentConfigsPreviewMtlsCertificates
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#certificate_id PagesProject#certificate_id}.</summary>
        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPagesProjectDeploymentConfigsPreviewMtlsCertificates), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewMtlsCertificates")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewMtlsCertificates
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#certificate_id PagesProject#certificate_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
