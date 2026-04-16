using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ManagedTransforms
{
    [JsiiInterface(nativeType: typeof(IManagedTransformsConfig), fullyQualifiedName: "cloudflare.managedTransforms.ManagedTransformsConfig")]
    public interface IManagedTransformsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The list of Managed Request Transforms.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/managed_transforms#managed_request_headers ManagedTransforms#managed_request_headers}
        /// </remarks>
        [JsiiProperty(name: "managedRequestHeaders", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.managedTransforms.ManagedTransformsManagedRequestHeaders\"},\"kind\":\"array\"}}]}}")]
        object ManagedRequestHeaders
        {
            get;
        }

        /// <summary>The list of Managed Response Transforms.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/managed_transforms#managed_response_headers ManagedTransforms#managed_response_headers}
        /// </remarks>
        [JsiiProperty(name: "managedResponseHeaders", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.managedTransforms.ManagedTransformsManagedResponseHeaders\"},\"kind\":\"array\"}}]}}")]
        object ManagedResponseHeaders
        {
            get;
        }

        /// <summary>The unique ID of the zone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/managed_transforms#zone_id ManagedTransforms#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        string ZoneId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedTransformsConfig), fullyQualifiedName: "cloudflare.managedTransforms.ManagedTransformsConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ManagedTransforms.IManagedTransformsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The list of Managed Request Transforms.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/managed_transforms#managed_request_headers ManagedTransforms#managed_request_headers}
            /// </remarks>
            [JsiiProperty(name: "managedRequestHeaders", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.managedTransforms.ManagedTransformsManagedRequestHeaders\"},\"kind\":\"array\"}}]}}")]
            public object ManagedRequestHeaders
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>The list of Managed Response Transforms.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/managed_transforms#managed_response_headers ManagedTransforms#managed_response_headers}
            /// </remarks>
            [JsiiProperty(name: "managedResponseHeaders", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.managedTransforms.ManagedTransformsManagedResponseHeaders\"},\"kind\":\"array\"}}]}}")]
            public object ManagedResponseHeaders
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>The unique ID of the zone.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/managed_transforms#zone_id ManagedTransforms#zone_id}
            /// </remarks>
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string ZoneId
            {
                get => GetInstanceProperty<string>()!;
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
