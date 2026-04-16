using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.GradientaiAgent
{
    [JsiiInterface(nativeType: typeof(IGradientaiAgentModelVersions), fullyQualifiedName: "digitalocean.gradientaiAgent.GradientaiAgentModelVersions")]
    public interface IGradientaiAgentModelVersions
    {
        /// <summary>Major version of the model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#major GradientaiAgent#major}
        /// </remarks>
        [JsiiProperty(name: "major", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Major
        {
            get
            {
                return null;
            }
        }

        /// <summary>Minor version of the model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#minor GradientaiAgent#minor}
        /// </remarks>
        [JsiiProperty(name: "minor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Minor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Patch version of the model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#patch GradientaiAgent#patch}
        /// </remarks>
        [JsiiProperty(name: "patch", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Patch
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGradientaiAgentModelVersions), fullyQualifiedName: "digitalocean.gradientaiAgent.GradientaiAgentModelVersions")]
        internal sealed class _Proxy : DeputyBase, digitalocean.GradientaiAgent.IGradientaiAgentModelVersions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Major version of the model.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#major GradientaiAgent#major}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "major", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Major
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Minor version of the model.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#minor GradientaiAgent#minor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Minor
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Patch version of the model.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#patch GradientaiAgent#patch}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "patch", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Patch
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
