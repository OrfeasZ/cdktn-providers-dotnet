using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiInterface(nativeType: typeof(IPagesProjectDeploymentConfigsPreviewLimits), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewLimits")]
    public interface IPagesProjectDeploymentConfigsPreviewLimits
    {
        /// <summary>CPU time limit in milliseconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#cpu_ms PagesProject#cpu_ms}
        /// </remarks>
        [JsiiProperty(name: "cpuMs", typeJson: "{\"primitive\":\"number\"}")]
        double CpuMs
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPagesProjectDeploymentConfigsPreviewLimits), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewLimits")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewLimits
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>CPU time limit in milliseconds.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#cpu_ms PagesProject#cpu_ms}
            /// </remarks>
            [JsiiProperty(name: "cpuMs", typeJson: "{\"primitive\":\"number\"}")]
            public double CpuMs
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
