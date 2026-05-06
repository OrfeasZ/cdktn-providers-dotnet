using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiInterface(nativeType: typeof(IWorkersScriptAssets), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptAssets")]
    public interface IWorkersScriptAssets
    {
        /// <summary>Configuration for assets within a Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#config WorkersScript#config}
        /// </remarks>
        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptAssetsConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.WorkersScript.IWorkersScriptAssetsConfig? Config
        {
            get
            {
                return null;
            }
        }

        /// <summary>Token provided upon successful upload of all files from a registered manifest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#jwt WorkersScript#jwt}
        /// </remarks>
        [JsiiProperty(name: "jwt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Jwt
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkersScriptAssets), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptAssets")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkersScript.IWorkersScriptAssets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configuration for assets within a Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#config WorkersScript#config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptAssetsConfig\"}", isOptional: true)]
            public cloudflare.WorkersScript.IWorkersScriptAssetsConfig? Config
            {
                get => GetInstanceProperty<cloudflare.WorkersScript.IWorkersScriptAssetsConfig?>();
            }

            /// <summary>Token provided upon successful upload of all files from a registered manifest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/workers_script#jwt WorkersScript#jwt}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jwt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Jwt
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
