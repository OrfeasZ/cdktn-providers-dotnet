using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiByValue(fqn: "cloudflare.pagesProject.PagesProjectBuildConfig")]
    public class PagesProjectBuildConfig : cloudflare.PagesProject.IPagesProjectBuildConfig
    {
        private object? _buildCaching;

        /// <summary>Enable build caching for the project.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#build_caching PagesProject#build_caching}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "buildCaching", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? BuildCaching
        {
            get => _buildCaching;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _buildCaching = value;
            }
        }

        /// <summary>Command used to build project.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#build_command PagesProject#build_command}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "buildCommand", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BuildCommand
        {
            get;
            set;
        }

        /// <summary>Output directory of the build.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#destination_dir PagesProject#destination_dir}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "destinationDir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationDir
        {
            get;
            set;
        }

        /// <summary>Directory to run the command.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#root_dir PagesProject#root_dir}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rootDir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RootDir
        {
            get;
            set;
        }

        /// <summary>The classifying tag for analytics.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#web_analytics_tag PagesProject#web_analytics_tag}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "webAnalyticsTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WebAnalyticsTag
        {
            get;
            set;
        }

        /// <summary>The auth token for analytics.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#web_analytics_token PagesProject#web_analytics_token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "webAnalyticsToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WebAnalyticsToken
        {
            get;
            set;
        }
    }
}
