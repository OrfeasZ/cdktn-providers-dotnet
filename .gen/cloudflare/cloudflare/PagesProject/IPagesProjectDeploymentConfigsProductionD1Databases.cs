using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiInterface(nativeType: typeof(IPagesProjectDeploymentConfigsProductionD1Databases), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionD1Databases")]
    public interface IPagesProjectDeploymentConfigsProductionD1Databases
    {
        /// <summary>UUID of the D1 database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#id PagesProject#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPagesProjectDeploymentConfigsProductionD1Databases), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionD1Databases")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionD1Databases
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>UUID of the D1 database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#id PagesProject#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
