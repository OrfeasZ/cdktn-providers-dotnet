using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiInterface(nativeType: typeof(IPagesProjectDeploymentConfigsPreviewR2Buckets), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewR2Buckets")]
    public interface IPagesProjectDeploymentConfigsPreviewR2Buckets
    {
        /// <summary>Jurisdiction of the R2 bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#jurisdiction PagesProject#jurisdiction}
        /// </remarks>
        [JsiiProperty(name: "jurisdiction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Jurisdiction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the R2 bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#name PagesProject#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPagesProjectDeploymentConfigsPreviewR2Buckets), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewR2Buckets")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewR2Buckets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Jurisdiction of the R2 bucket.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#jurisdiction PagesProject#jurisdiction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jurisdiction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Jurisdiction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of the R2 bucket.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#name PagesProject#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
