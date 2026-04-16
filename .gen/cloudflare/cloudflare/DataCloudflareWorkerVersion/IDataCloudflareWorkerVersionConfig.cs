using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkerVersion
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareWorkerVersionConfig), fullyQualifiedName: "cloudflare.dataCloudflareWorkerVersion.DataCloudflareWorkerVersionConfig")]
    public interface IDataCloudflareWorkerVersionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/worker_version#account_id DataCloudflareWorkerVersion#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>Identifier for the version, which can be ID or the literal "latest" to operate on the most recently created version.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/worker_version#version_id DataCloudflareWorkerVersion#version_id}
        /// </remarks>
        [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}")]
        string VersionId
        {
            get;
        }

        /// <summary>Identifier for the Worker, which can be ID or name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/worker_version#worker_id DataCloudflareWorkerVersion#worker_id}
        /// </remarks>
        [JsiiProperty(name: "workerId", typeJson: "{\"primitive\":\"string\"}")]
        string WorkerId
        {
            get;
        }

        /// <summary>Whether to include the `modules` property of the version in the response, which contains code and sourcemap content and may add several megabytes to the response size.</summary>
        /// <remarks>
        /// Available values: "modules".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/worker_version#include DataCloudflareWorkerVersion#include}
        /// </remarks>
        [JsiiProperty(name: "include", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Include
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareWorkerVersionConfig), fullyQualifiedName: "cloudflare.dataCloudflareWorkerVersion.DataCloudflareWorkerVersionConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareWorkerVersion.IDataCloudflareWorkerVersionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/worker_version#account_id DataCloudflareWorkerVersion#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Identifier for the version, which can be ID or the literal "latest" to operate on the most recently created version.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/worker_version#version_id DataCloudflareWorkerVersion#version_id}
            /// </remarks>
            [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}")]
            public string VersionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Identifier for the Worker, which can be ID or name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/worker_version#worker_id DataCloudflareWorkerVersion#worker_id}
            /// </remarks>
            [JsiiProperty(name: "workerId", typeJson: "{\"primitive\":\"string\"}")]
            public string WorkerId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Whether to include the `modules` property of the version in the response, which contains code and sourcemap content and may add several megabytes to the response size.</summary>
            /// <remarks>
            /// Available values: "modules".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/worker_version#include DataCloudflareWorkerVersion#include}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "include", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Include
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
