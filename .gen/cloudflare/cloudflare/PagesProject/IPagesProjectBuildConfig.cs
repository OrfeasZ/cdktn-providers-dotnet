using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiInterface(nativeType: typeof(IPagesProjectBuildConfig), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectBuildConfig")]
    public interface IPagesProjectBuildConfig
    {
        /// <summary>Enable build caching for the project.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#build_caching PagesProject#build_caching}
        /// </remarks>
        [JsiiProperty(name: "buildCaching", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BuildCaching
        {
            get
            {
                return null;
            }
        }

        /// <summary>Command used to build project.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#build_command PagesProject#build_command}
        /// </remarks>
        [JsiiProperty(name: "buildCommand", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BuildCommand
        {
            get
            {
                return null;
            }
        }

        /// <summary>Output directory of the build.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#destination_dir PagesProject#destination_dir}
        /// </remarks>
        [JsiiProperty(name: "destinationDir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationDir
        {
            get
            {
                return null;
            }
        }

        /// <summary>Directory to run the command.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#root_dir PagesProject#root_dir}
        /// </remarks>
        [JsiiProperty(name: "rootDir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RootDir
        {
            get
            {
                return null;
            }
        }

        /// <summary>The classifying tag for analytics.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#web_analytics_tag PagesProject#web_analytics_tag}
        /// </remarks>
        [JsiiProperty(name: "webAnalyticsTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WebAnalyticsTag
        {
            get
            {
                return null;
            }
        }

        /// <summary>The auth token for analytics.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#web_analytics_token PagesProject#web_analytics_token}
        /// </remarks>
        [JsiiProperty(name: "webAnalyticsToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WebAnalyticsToken
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPagesProjectBuildConfig), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectBuildConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PagesProject.IPagesProjectBuildConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Enable build caching for the project.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#build_caching PagesProject#build_caching}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "buildCaching", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? BuildCaching
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Command used to build project.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#build_command PagesProject#build_command}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "buildCommand", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BuildCommand
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Output directory of the build.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#destination_dir PagesProject#destination_dir}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "destinationDir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationDir
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Directory to run the command.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#root_dir PagesProject#root_dir}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rootDir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RootDir
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The classifying tag for analytics.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#web_analytics_tag PagesProject#web_analytics_tag}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webAnalyticsTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WebAnalyticsTag
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The auth token for analytics.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#web_analytics_token PagesProject#web_analytics_token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webAnalyticsToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WebAnalyticsToken
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
