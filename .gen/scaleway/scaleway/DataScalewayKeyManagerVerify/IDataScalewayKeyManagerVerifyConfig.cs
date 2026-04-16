using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayKeyManagerVerify
{
    [JsiiInterface(nativeType: typeof(IDataScalewayKeyManagerVerifyConfig), fullyQualifiedName: "scaleway.dataScalewayKeyManagerVerify.DataScalewayKeyManagerVerifyConfig")]
    public interface IDataScalewayKeyManagerVerifyConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Digest of the original signed message.</summary>
        /// <remarks>
        /// Must be generated using the same algorithm specified in the key’s configuration, and encoded as a base64 string.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/key_manager_verify#digest DataScalewayKeyManagerVerify#digest}
        /// </remarks>
        [JsiiProperty(name: "digest", typeJson: "{\"primitive\":\"string\"}")]
        string Digest
        {
            get;
        }

        /// <summary>ID of the key to use for signature verification. Can be a plain UUID or a regional ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/key_manager_verify#key_id DataScalewayKeyManagerVerify#key_id}
        /// </remarks>
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyId
        {
            get;
        }

        /// <summary>The message signature to verify, encoded as a base64 string.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/key_manager_verify#signature DataScalewayKeyManagerVerify#signature}
        /// </remarks>
        [JsiiProperty(name: "signature", typeJson: "{\"primitive\":\"string\"}")]
        string Signature
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/key_manager_verify#id DataScalewayKeyManagerVerify#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region of the key.</summary>
        /// <remarks>
        /// If not set, the region is derived from the key_id when possible or from the provider configuration.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/key_manager_verify#region DataScalewayKeyManagerVerify#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataScalewayKeyManagerVerifyConfig), fullyQualifiedName: "scaleway.dataScalewayKeyManagerVerify.DataScalewayKeyManagerVerifyConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.DataScalewayKeyManagerVerify.IDataScalewayKeyManagerVerifyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Digest of the original signed message.</summary>
            /// <remarks>
            /// Must be generated using the same algorithm specified in the key’s configuration, and encoded as a base64 string.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/key_manager_verify#digest DataScalewayKeyManagerVerify#digest}
            /// </remarks>
            [JsiiProperty(name: "digest", typeJson: "{\"primitive\":\"string\"}")]
            public string Digest
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ID of the key to use for signature verification. Can be a plain UUID or a regional ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/key_manager_verify#key_id DataScalewayKeyManagerVerify#key_id}
            /// </remarks>
            [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The message signature to verify, encoded as a base64 string.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/key_manager_verify#signature DataScalewayKeyManagerVerify#signature}
            /// </remarks>
            [JsiiProperty(name: "signature", typeJson: "{\"primitive\":\"string\"}")]
            public string Signature
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/key_manager_verify#id DataScalewayKeyManagerVerify#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region of the key.</summary>
            /// <remarks>
            /// If not set, the region is derived from the key_id when possible or from the provider configuration.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/key_manager_verify#region DataScalewayKeyManagerVerify#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
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
